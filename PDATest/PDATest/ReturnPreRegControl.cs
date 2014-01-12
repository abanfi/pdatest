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
    public partial class ReturnPreRegControl : UserControl
    {
        private ReturnPreRegData returnPreRegData;
        
        public ReturnPreRegControl()
        {
            InitializeComponent();
            initBinding(new ReturnPreRegData());
        }

        private void initBinding(ReturnPreRegData data)
        {
            this.returnPreRegData = data;
            defaultParametersControl1.bind(data);
            returnPreRegDataBindingSource.DataSource = data;
        }

        private void findParcelForDeliveryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
