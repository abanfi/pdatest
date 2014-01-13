using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class ReturnPreRegData : DefaultData 
    {
        public string packageCode { get; set; }
        public bool damaged { get; set; }
        public string partnerId { get; set; }
        public string customerName { get; set; }
        public bool returnDamaged { get; set; }
        public bool noLabel { get; set; }
      
    }
}
