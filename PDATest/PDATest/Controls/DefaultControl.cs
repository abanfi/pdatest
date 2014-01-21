using PDATestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDATestProject.Controls
{
    public class DefaultControl : UserControl
    {
        protected bool inited = false;

        public bool isInitialized(){
            return inited;
        }

        public void setDefaultParams(DefaultModel parameters)
        {
            cloneValues(parameters, getDefaultParams());
        }

        public virtual DefaultModel getDefaultParams()
        {
            return null;
        }

        protected void cloneValues(DefaultModel from, DefaultModel to)
        {
            to.languageCode = from.languageCode;
            to.offline = from.offline;
            to.terminalId = from.terminalId;
            to.transactionId = from.transactionId;

            inited = true;
        }
        
    }
}
