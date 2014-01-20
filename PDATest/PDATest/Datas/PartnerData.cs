using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class PartnerData : DefaultData 
    {
        public string partnerId { get; set; }
        public string partnerNamePart { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "partnerNamePart:" + partnerNamePart + Environment.NewLine;
            stringValue += "partnerId:" + partnerId + Environment.NewLine;
            return stringValue;
        }
    }
}
