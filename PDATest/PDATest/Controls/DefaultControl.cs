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

        public void setDefaultParams(DefaultData parameters)
        {
            cloneValues(parameters, getDefaultParams());
        }

        public virtual DefaultData getDefaultParams()
        {
            return null;
        }

        protected void cloneValues(DefaultData from, DefaultData to)
        {
            to.languageCode = from.languageCode;
            to.offline = from.offline;
            to.terminalId = from.terminalId;
            to.transactionId = from.transactionId;

            inited = true;
        }
        
    }
}
