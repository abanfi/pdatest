using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class PackageData : DefaultData
    {
        public string packageCode { get; set; }
        public string filterPackageCode { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerZip { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "packageCode:" + packageCode + Environment.NewLine;
            stringValue += "filterPackageCode:" + filterPackageCode + Environment.NewLine;
            stringValue += "customerName:" + customerName + Environment.NewLine;
            stringValue += "customerAddress:" + customerAddress + Environment.NewLine;
            stringValue += "customerZip:" + customerZip + Environment.NewLine;
            return stringValue;
        }
    }
}
