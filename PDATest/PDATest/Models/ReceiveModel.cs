using PDATestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReceiveModel : DefaultModel
    {
        public ReceiveModel()
        {
            gridModel = new List<ParcelCompositeSelectableReturnModel>();
        }

        public string barcode { get; set; }

        public List<ParcelCompositeSelectableReturnModel> gridModel { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "barcode:" + barcode + Environment.NewLine;
            foreach (ParcelCompositeSelectableReturnModel data in gridModel)
            {
                stringValue += "parcelcomposite:" + data.Barcode + "," + data.ShipmentID + "->selected:" + data.Selected;
            }
            return stringValue;
        }
    }
}
