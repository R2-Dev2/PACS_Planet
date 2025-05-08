using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public int spaceShipPortL { get; private set; }
        private string spaceShipId;
        private string spaceShipCode;
        private ValidationResult status;
        private int step = 0;

        public bool CheckAccess(EntryMessage msg, string ip)
        {
            LoadSpaceShipInfo(msg.shipCode);
            string deliveryCode = msg.deliveryCode;
            if(DatabaseHelper.DeliveryInfo(deliveryCode, planetId, spaceShipId) is null)
            {
                status = ValidationResult.AD;
                return false;
            }
            if (string.IsNullOrEmpty(spaceShipIp) || spaceShipIp != ip || spaceShipPortL == 0)
            {
                status = ValidationResult.AD;
                return false;
            }
            status = ValidationResult.VP;
            return true;
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
            string listenPort =  row["PortSpaceShipL"].ToString();
            if (int.TryParse(listenPort, out int listenPortInt)) this.spaceShipPortL = listenPortInt;
            else this.spaceShipPortL = 0;
        }
    }
}
