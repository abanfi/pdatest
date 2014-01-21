using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReturnPreRegReturnModel : DefaultReturnModel 
    {
        public List<ParcelCompositeReturnModel> data = new List<ParcelCompositeReturnModel>();
    }
}
