using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDATestProject
{
    public partial class ReturnControl : UserControl
    {
        private ReturnData returnData;
        
        public ReturnControl()
        {
            InitializeComponent();
            initBinding(new ReturnData());
        }

        private void initBinding(ReturnData data)
        {
            this.returnData = data;
            defaultParametersControl1.bind(data);
            returnDataBindingSource.DataSource = data;
        }
    }
}
