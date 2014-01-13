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
        public string reason { get; set; }
        public string payment { get; set; }
        public string refuseIdType { get; set; }
        public string refuseDocNo { get; set; }
        public string postIdType { get; set; }
        public string postDocNo { get; set; }
    }
}
