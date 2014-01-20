using PDATestProject.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class ReturnData : DefaultData 
    {
        public string barcode { get; set; }
        public string bagBarcode { get; set; }

        public List<ReturnParcelReturnData> data = new List<ReturnParcelReturnData>();


        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "barcode:" + barcode + Environment.NewLine;
            stringValue += "bagBarcode:" + bagBarcode + Environment.NewLine;
            foreach (ReturnParcelReturnData parcelComposite in data)
            {
                stringValue += "parcelcomposite:" + parcelComposite.Barcode + "->selected:" + parcelComposite.Selected;
            }
            return stringValue;
        }
    }
}
