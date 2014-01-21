using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class MasterDataModel : DefaultModel 
    {
        public MasterDataModel()
        {
            date = DateTime.Now;
        }

        public DateTime date { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "date:" + date + Environment.NewLine;
            return stringValue;
        }
    }
}
