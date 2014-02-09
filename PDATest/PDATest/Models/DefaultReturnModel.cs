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
            SummaryMessage = "";
            ResultPart = "";
            ParametersPart = "";
            watch = System.Diagnostics.Stopwatch.StartNew();
        }

        public string SummaryMessage { get; set; }

        public string ResultPart { get; set; }

        public string ParametersPart { get; set; }

        public System.Diagnostics.Stopwatch watch { get; set; }

    }
}
