using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class PartnersReturnModel : DefaultReturnModel 
    {
        public List<PartnerReturnModel> partners = new List<PartnerReturnModel>();
    }
}
