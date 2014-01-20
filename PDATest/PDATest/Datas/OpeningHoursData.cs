using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class OpeningHoursData : DefaultData 
    {
        public String mondayFirts { get; set; }
        public String mondaySecond { get; set; }
        public String tuesdayFirts { get; set; }
        public String tuesdaySecond { get; set; }
        public String wednesdayFirts { get; set; }
        public String wednesdaySecond { get; set; }
        public String thursdayFirts { get; set; }
        public String thursdaySecond { get; set; }
        public String fridayFirts { get; set; }
        public String fridaySecond { get; set; }
        public String saturdayFirts { get; set; }
        public String saturdaySecond { get; set; }
        public String sundayFirts { get; set; }
        public String sundaySecond { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "mondayFirts:" + mondayFirts + Environment.NewLine;
            stringValue += "mondaySecond:" + mondaySecond + Environment.NewLine;
            stringValue += "tuesdayFirts:" + tuesdayFirts + Environment.NewLine;
            stringValue += "tuesdaySecond:" + tuesdaySecond + Environment.NewLine;
            stringValue += "wednesdayFirts:" + wednesdayFirts + Environment.NewLine;
            stringValue += "wednesdaySecond:" + wednesdaySecond + Environment.NewLine;
            stringValue += "thursdayFirts:" + thursdayFirts + Environment.NewLine;
            stringValue += "thursdaySecond:" + thursdaySecond + Environment.NewLine;
            stringValue += "fridayFirts:" + fridayFirts + Environment.NewLine;
            stringValue += "fridaySecond:" + fridaySecond + Environment.NewLine;
            stringValue += "saturdayFirts:" + saturdayFirts + Environment.NewLine;
            stringValue += "saturdaySecond:" + saturdaySecond + Environment.NewLine;
            stringValue += "sundayFirts:" + sundayFirts + Environment.NewLine;
            stringValue += "sundaySecond:" + sundaySecond + Environment.NewLine;
            return stringValue;
        }
    }
}
