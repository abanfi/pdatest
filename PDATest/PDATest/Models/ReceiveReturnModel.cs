using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReceiveReturnModel : DefaultReturnModel
    {
        public List<ParcelCompositeSelectableReturnModel> datas = new List<ParcelCompositeSelectableReturnModel>();
    }

    public class ParcelCompositeSelectableReturnModel : ParcelCompositeReturnModel
    {

        public bool Selected { get; set; }
        
    }
}
