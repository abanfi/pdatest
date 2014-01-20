using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject
{
    public class MasterDataData : DefaultData 
    {
        public DateTime date { get; set; }

        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "date:" + date + Environment.NewLine;
            return stringValue;
        }
    }
}
