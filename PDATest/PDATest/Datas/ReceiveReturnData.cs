using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Datas
{
    public class ReceiveReturnData : DefaultReturnData
    {
        public List<ParcelCompositeSelectableReturnData> datas = new List<ParcelCompositeSelectableReturnData>();
    }

    public class ParcelCompositeSelectableReturnData : ParcelCompositeReturnData
    {

        public bool Selected { get; set; }
        
    }
}
