using PDATestProject.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class ReceiveData : DefaultData
    {
        public ReceiveData()
        {
            gridData = new List<ParcelCompositeSelectableReturnData>();
        }

        public string barcode { get; set; }

        public List<ParcelCompositeSelectableReturnData> gridData { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "barcode:" + barcode + Environment.NewLine;
            foreach (ParcelCompositeSelectableReturnData data in gridData)
            {
                stringValue += "parcelcomposite:" + data.Barcode + "," + data.ShipmentID + "->selected:" + data.Selected;
            }
            return stringValue;
        }
    }
}
