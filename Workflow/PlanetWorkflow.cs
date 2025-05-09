using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Encrypting;
using Model;
using static Workflow.PACSMessage;

namespace Workflow
{
    public class PlanetWorkflow
    {
        private string planetId;
        public string PlanetId
        {
            get { return planetId; }
            set { planetId = value; }

        }
        private EncodingConfig config;
        public EncodingConfig Config
        {
            get { return config; }
            set { config = value; }

        }
        public string spaceShipIp { get; private set; }
        public int shipMsgPort { get; private set; }
        public int shipFilePort { get; private set; }
        private string spaceShipId;
        private string spaceShipCode;
        private ValidationResult status;
        public int step = 0;
        public string KeyEncripted;
        public string IVEncrypted;
        public string PdfEncrypted;
        public int encryptedKeyCount = 0;
        public string deliveryCode;
        public byte[] KeyDecripted;
        public byte[] IVDecrypted;
        public byte[] PdfDecrypted;

        public bool CheckAccess(EntryMessage msg, string ip)
        {
            LoadSpaceShipInfo(msg.shipCode);
            this.deliveryCode = msg.deliveryCode;
            if(DatabaseHelper.DeliveryInfo(deliveryCode, planetId, spaceShipId) is null)
            {
                status = ValidationResult.AD;
                return false;
            }
            if (string.IsNullOrEmpty(spaceShipIp) || spaceShipIp != ip || shipMsgPort == 0)
            {
                status = ValidationResult.AD;
                return false;
            }
            status = ValidationResult.VP;
            return true;
        }
        
        public bool CheckPdf()
        {
            byte[] dbPdf = DatabaseHelper.GetDeliveryDataPdf(deliveryCode);
            string dbPdfStr = Convert.ToBase64String(dbPdf);
            string pdfStr = Convert.ToBase64String(PdfDecrypted);

            byte[] hashBBDD = HashUser.GenerateHashedString(dbPdfStr);
            byte[] hashShip = HashUser.GenerateHashedString(pdfStr);

            bool isValid = Convert.ToBase64String(hashBBDD).Equals(Convert.ToBase64String(hashShip));
            if (!isValid)
            {
                this.status = ValidationResult.AD;
            }
            else
            {
                this.status = ValidationResult.VP;
            }
            return isValid;
        }

        public bool CheckSums(string sumPlanet, string sumShip)
        {
            bool isValid = sumPlanet == sumShip;
            if (isValid)
            {
                this.status = ValidationResult.AG;
            }
            else
            {
                this.status = ValidationResult.AD;
            }
            return isValid;
        }

        public string GetValidationMessage()
        {
            step++;
            return new ValidationMessage(spaceShipCode, step, status).ToString();    
        }

        private void LoadSpaceShipInfo(string shipCode)
        {
            DataRow row = DatabaseHelper.SpaceShipInfo(shipCode);
            this.spaceShipCode = shipCode;
            this.spaceShipId = row["idSpaceShip"].ToString();
            this.spaceShipIp = row["IPSpaceShip"].ToString();
            string msgPort =  row["PortSpaceShipL"].ToString();
            string filePort =  row["PortSpaceShipS"].ToString();
            if (int.TryParse(msgPort, out int msgPortInt)) this.shipMsgPort = msgPortInt;
            else this.shipMsgPort = 0;
            if (int.TryParse(filePort, out int filePortInt)) this.shipFilePort = filePortInt;
            else this.shipFilePort = 0;
        }

        public void validateEncrypted(string message)
        {
            encryptedKeyCount++;

            if (encryptedKeyCount == 1)
            {
                KeyEncripted = message;
            }
            else if (encryptedKeyCount == 2)
            {
                IVEncrypted = message;
            }
            else if (encryptedKeyCount == 3)
            {
                PdfEncrypted = message;
            }
        }

        public void DecryptCredentials(string codePlanet)
        {
            byte[] keyEncrypted = Convert.FromBase64String(KeyEncripted);
            byte[] ivEncrypted = Convert.FromBase64String(IVEncrypted);

            KeyDecripted = AES.DecryptAesCredentials(keyEncrypted, codePlanet);
            IVDecrypted = AES.DecryptAesCredentials(ivEncrypted, codePlanet);
        }

        public void DecryptDeliveryPdf()
        {
            byte[] pdfEncrypted = Convert.FromBase64String(PdfEncrypted);
            PdfDecrypted = AES.DescryptAesPdf(KeyDecripted, IVDecrypted, pdfEncrypted);
        }
    }
}
    