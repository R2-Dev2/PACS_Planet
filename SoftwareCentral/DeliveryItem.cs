using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCentral
{
    class DeliveryItem
    {
        private string columnName;
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        private string itemValue;
        public string ItemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }

        public DeliveryItem(string columnName, string itemValue)
        {
            this.columnName = columnName;
            this.itemValue = itemValue;
        }
    }
}
