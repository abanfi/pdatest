using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class HolidayData : DefaultData
    {
        public DateTime holiday1From { get; set; }
        public DateTime holiday1To { get; set; }
        public DateTime holiday2From { get; set; }
        public DateTime holiday2To { get; set; }
        public DateTime holiday3From { get; set; }
        public DateTime holiday3To { get; set; }
        public DateTime holiday4From { get; set; }
        public DateTime holiday4To { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "holiday1From:" + holiday1From + Environment.NewLine;
            stringValue += "holiday1To:" + holiday1To + Environment.NewLine;
            stringValue += "holiday2From:" + holiday2From + Environment.NewLine;
            stringValue += "holiday2To:" + holiday2To + Environment.NewLine;
            stringValue += "holiday3From:" + holiday3From + Environment.NewLine;
            stringValue += "holiday3To:" + holiday3To + Environment.NewLine;
            stringValue += "holiday4From:" + holiday4From + Environment.NewLine;
            stringValue += "holiday4To:" + holiday4To + Environment.NewLine;
            return stringValue;
        }
    }
}
