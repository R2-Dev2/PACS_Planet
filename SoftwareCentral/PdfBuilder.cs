using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace SoftwareCentral
{
    class PdfBuilder
    {
        static XFont titleFont = new XFont("Times New Roman", 20, XFontStyleEx.Bold);
        static XFont labelFont = new XFont("Times New Roman", 12, XFontStyleEx.Bold);
        static XFont regularFont = new XFont("Times New Roman", 12, XFontStyleEx.Regular);
        static XFont signNameFont = new XFont("Times New Roman", 16, XFontStyleEx.Regular);

        static string logoPath = @"./img/logoTitle.png";
        static string bgLogoPath = @"./img/bgLogo.png";
        static string r2dev2Path = @"./img/r2dev2.png";

        private List<DeliveryItem> delivery;

        public List<DeliveryItem> Delivery
        {
            set { delivery = value; }
        }

        private PdfDocument document;
        public PdfDocument Document
        {
            get { return document;  }
        }

        private PdfPage page;
        private XGraphics gfx;

        public PdfBuilder() { }

        public void CreatePdf()
        {
            this.document = new PdfDocument();

            string deliveryNumber = delivery.Find(i => i.ColumnName.Equals("deliveryNumber")).ItemValue;
            string title = $"Delivery #{deliveryNumber}";
            this.document.Info.Title = $"{deliveryNumber}";

            this.page = document.AddPage();
            this.gfx = XGraphics.FromPdfPage(page);

            DrawPage(title);
            AddMetadata();

            string filename = $"{deliveryNumber}.pdf";

            document.Save(filename);

            Process.Start(filename);
        }

        private void AddMetadata()
        {
            var pdfProperties = document.Info.Elements;
            foreach (DeliveryItem item in delivery)
            {
                pdfProperties.Add(new KeyValuePair<string, PdfItem>($"/{item.ColumnName}", new PdfString(item.ItemValue)));
            }
        }

        private void DrawPage(string title)
        {
            double leftMargin = 50, rightMargin = 30, topMargin = 30, bottomMargin = 30;
            double pageWidth = gfx.PageSize.Width - leftMargin - rightMargin;
            double pageHeight = gfx.PageSize.Height - topMargin - bottomMargin;
            XSize pageSize = new XSize(pageWidth, pageHeight);

            double headerHeight = 70;
            XSize headerSize = new XSize(pageWidth, headerHeight);
            XPoint headerPoint = new XPoint(leftMargin, topMargin);

            XSize infoSize = new XSize(pageWidth, 0);
            XPoint infoPoint = new XPoint(leftMargin, topMargin + headerHeight + 10);

            DrawHeader(title, headerSize, headerPoint);
            double endY = DrawDeliveryInfo(infoSize, infoPoint);

            double signWidth = 180;
            double signHeight = 60;
            XSize signSize = new XSize(signWidth, signHeight);
            XPoint signPoint = new XPoint((pageWidth - signWidth) / 2 + leftMargin, endY + 20);

            DrawSignature(signSize, signPoint);
        }

        private void DrawHeader(string title, XSize size, XPoint point)
        {
            double imgSize = 40;
            DrawLogo(size, point, imgSize);

            XRect rect = new XRect(point, size);

            rect.Width = size.Width - imgSize - 20;
            rect.Offset(imgSize + 20, 0);

            gfx.DrawString(title, titleFont, XBrushes.Blue, rect, XStringFormats.CenterLeft);
        }

        private void DrawLogo(XSize headerSize, XPoint headerPoint, double size)
        {
            double imgY = (headerSize.Height - size) / 2 + headerPoint.Y;
            XPoint imgPoint = new XPoint(headerPoint.X, imgY);

            DrawImage(gfx, logoPath, imgPoint, size, size);
        }

        private double DrawDeliveryInfo(XSize size, XPoint point)
        {
            double lineHeight = labelFont.GetHeight();
            double cyAscent = lineHeight * labelFont.CellAscent / labelFont.CellSpace + 5;

            XRect rectLabel = new XRect(point, size);
            XRect rectData = new XRect(point, size);

            Dictionary<string, string> infoLabel = getLabelInfo();

            foreach (KeyValuePair<string, string> pair in infoLabel)
            {

                XSize fontSize = gfx.MeasureString(pair.Key, labelFont);

                gfx.DrawString(pair.Key, labelFont, XBrushes.Black, rectLabel);

                rectData.X = point.X + fontSize.Width;
                gfx.DrawString(pair.Value, regularFont, XBrushes.Black, rectData);

                rectLabel.Y += cyAscent;
                rectData.Y += cyAscent;
            }

            return rectLabel.Y;
        }

        private Dictionary<string, string> getLabelInfo()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            string deliveryCode = delivery.Find(i => i.ColumnName.Equals("deliveryCode")).ItemValue;
            string origin = delivery.Find(i => i.ColumnName.Equals("origin")).ItemValue;
            string destination = delivery.Find(i => i.ColumnName.Equals("destination")).ItemValue;
            string shipCode = delivery.Find(i => i.ColumnName.Equals("shipCode")).ItemValue;
            string deliveryDate = delivery.Find(i => i.ColumnName.Equals("deliveryDate")).ItemValue;

            values.Add("Delivery code: ", deliveryCode);
            values.Add("Origin: ", origin);
            values.Add("Destination: ", destination);
            values.Add("Ship code: ", shipCode);
            values.Add("Delivery date: ", deliveryDate);

            return values;
        }

        private void DrawSignature(XSize size, XPoint point)
        {
            XRect rect = new XRect(point, size);

            double imgSize = 35;
            XPoint bgPoint = new XPoint((size.Width - size.Height) / 2 + point.X, point.Y);
            XPoint imgPoint = new XPoint(point.X, (size.Height - imgSize) + point.Y);
            DrawImage(gfx, bgLogoPath, bgPoint, size.Height, size.Height);
            DrawImage(gfx, r2dev2Path, imgPoint, imgSize, imgSize);

            double halfWidth = size.Width / 2;
            XSize halfSize = new XSize(halfWidth - 5, size.Height);
            XRect leftRect = new XRect(point, halfSize);
            XRect rightRect = new XRect(new XPoint(point.X + halfWidth + 5, point.Y), halfSize);

            XTextFormatter tf = new XTextFormatter(gfx);
            tf.DrawString("R2-Dev2", signNameFont, XBrushes.Black, leftRect);
            tf.DrawString($"Digitally signed by R2-Dev2\nDate: {DateTime.Now}", regularFont, XBrushes.Black, rightRect);

        }

        public void DrawImage(XGraphics gfx, string path, XPoint point, double width, double height)
        {
            XImage image = XImage.FromFile(path);
            gfx.DrawImage(image, point.X, point.Y, width, height);
        }

    }
}
