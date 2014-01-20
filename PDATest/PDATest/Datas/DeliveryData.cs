using PDATestProject.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class DeliveryData : DefaultData 
    {
        public string packageCode { get; set; }
        public bool damaged { get; set; }
        public int reason { get; set; }
        public int payment { get; set; }
        public int refuseIdType { get; set; }
        public string refuseDocNo { get; set; }
        public int postIdType { get; set; }
        public string postDocNo { get; set; }

        public List<DeliveryParleccMinimumReturnData> datas = new List<DeliveryParleccMinimumReturnData>();

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "packageCode:" + packageCode + Environment.NewLine;
            stringValue += "damaged:" + damaged + Environment.NewLine;
            stringValue += "reason:" + reason + Environment.NewLine;
            stringValue += "payment:" + payment + Environment.NewLine;
            stringValue += "refuseIdType:" + refuseIdType + Environment.NewLine;
            stringValue += "refuseDocNo:" + refuseDocNo + Environment.NewLine;
            stringValue += "postIdType:" + postIdType + Environment.NewLine;
            stringValue += "postDocNo:" + postDocNo + Environment.NewLine;
            foreach (DeliveryParleccMinimumReturnData parcelComposite in datas)
            {
                stringValue += "parcelcomposite:" + parcelComposite.Barcode + "->selected:" + parcelComposite.Selected;
            }
            return stringValue;
        }
    }
}
