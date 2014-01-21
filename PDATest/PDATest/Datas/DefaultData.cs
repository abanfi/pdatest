using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class DefaultData
    {

        public DefaultData()
        {
            terminalId = "BEQ75";
            offline = "Nem";
            languageCode = "EN";
            transactionId = "PDAUI" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
            createDate = DateTime.Now;
        }

        public string terminalId { get; set; }
        public string transactionId { get; set; }
        public string offline { get; set; }
        public string languageCode { get; set; }
        public DateTime createDate { get; set; }

        public override string ToString()
        {
            string stringValue = "Parameters:" + Environment.NewLine;
            stringValue += "terminalId:" + terminalId + Environment.NewLine;
            stringValue += "transactionId:" + transactionId + Environment.NewLine;
            stringValue += "offline:" + offline + Environment.NewLine;
            stringValue += "languageCode:" + languageCode + Environment.NewLine;
            stringValue += "createDate:" + createDate + Environment.NewLine;
            return stringValue;
        }
    }
}
