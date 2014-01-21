using PDATestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReturnModel: DefaultModel
    {
        public string barcode { get; set; }
        public string bagBarcode { get; set; }

        public List<ReturnParcelReturnModel> data = new List<ReturnParcelReturnModel>();


        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "barcode:" + barcode + Environment.NewLine;
            stringValue += "bagBarcode:" + bagBarcode + Environment.NewLine;
            foreach (ReturnParcelReturnModel parcelComposite in data)
            {
                stringValue += "parcelcomposite:" + parcelComposite.Barcode + "->selected:" + parcelComposite.Selected;
            }
            return stringValue;
        }
    }
}
