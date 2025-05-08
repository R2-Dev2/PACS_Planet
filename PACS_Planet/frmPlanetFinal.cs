using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workflow;

namespace PACS_Planet
{
    public partial class frmPlanetFinal : Form
    {
        bool isListening = false;
        private Planet planet;

        public frmPlanetFinal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void MakeButtonCircular(Button btn)
        {
            int diameter = Math.Min(btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);
            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;

            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold);

            btn.AutoSize = false;
            btn.Size = new Size(diameter, diameter);
            btn.Padding = new Padding(0);
        }

        private void frmPlanetFinal_Load(object sender, EventArgs e)
        {
            loadPlanetData();
            OcultarEncabezados(tabControl1);
            MakeButtonCircular(btn1);
            MakeButtonCircular(btn2);
            MakeButtonCircular(btn3);
            MakeButtonCircular(btn4);
            Image img = GetImageFromUrl(planet.PlanetPicture);
            if (img is null)
            {
                img = pbPlanet.ErrorImage;
            }
            pbPlanet.Image = img;
        }


        private void loadPlanetData()
        {
            planet = new Planet();
            if (!planet.loadConfig())
            {
                MessageBox.Show("Error loading configuration data. The program cannot start");
                this.Close();
            }

            DataRow planetRow = DatabaseHelper.PlanetInfo(planet.CodePlanet);

            planet.IdPlanet = planetRow["idPlanet"].ToString();
            planet.DescPlanet = planetRow["DescPlanet"].ToString();
            planet.PlanetPicture = planetRow["PlanetPicture"].ToString();
            Console.WriteLine(planet.PlanetPicture);

            string portListenStr = planetRow["PortPlanetL"].ToString();
            if (int.TryParse(portListenStr, out int portListen))
            {
                planet.PortListen = portListen;
            }
            else
            {
                MessageBox.Show("Error loading configuration data. The program cannot start");
                this.Close();
            }
        }

        public static Image GetImageFromUrl(string url)
        {
            Image img = null;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (Stream stream = webClient.OpenRead(url))
                    {
                        img = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return img;
        }

        private void OcultarEncabezados(TabControl tabControl1)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;

                btnStartListening.Text = null;

                btnStartListening.BackgroundImage = Properties.Resources.listen;

                btnStartListening.BackgroundImageLayout = ImageLayout.Stretch;


                // Iniciar escolta...
            }
            else
            {
                isListening = false;

                btnStartListening.Text = null;

                btnStartListening.BackgroundImage = Properties.Resources.stop_listen;

                btnStartListening.BackgroundImageLayout = ImageLayout.Stretch;

                // Aturar escolta...
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
