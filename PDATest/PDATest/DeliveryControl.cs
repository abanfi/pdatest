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
    public partial class DeliveryControl : UserControl
    {

        private DeliveryData deliveryData;
        
        public DeliveryControl()
        {
            InitializeComponent();
            initBinding(new DeliveryData());
        }

        private void initBinding(DeliveryData data)
        {
            this.deliveryData = data;
            defaultParametersControl1.bind(data);
            deliveryDataBindingSource.DataSource = data;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
