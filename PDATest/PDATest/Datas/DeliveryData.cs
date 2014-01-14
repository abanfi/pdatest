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
    }
}
