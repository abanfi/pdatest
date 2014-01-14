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
    }
}
