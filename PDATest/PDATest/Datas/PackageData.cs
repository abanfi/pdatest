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
    }
}
