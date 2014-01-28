using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class DefaultReturnModel
    {
        public DefaultReturnModel()
        {
            summaryMessage = "";
            watch = System.Diagnostics.Stopwatch.StartNew();
        }

        public string summaryMessage { get; set; }

        public System.Diagnostics.Stopwatch watch { get; set; }

    }
}
