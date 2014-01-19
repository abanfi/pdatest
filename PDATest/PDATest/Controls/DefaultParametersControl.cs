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
    public partial class DefaultParametersControl : UserControl
    {
        public DefaultParametersControl()
        {
            InitializeComponent();
        }

        public void bind(DefaultData data)
        {
            defaultDataBindingSource.DataSource = data;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.generateNewTransactionId();
        }

        public void generateNewTransactionId()
        {
            transactionTextBox.Text = "" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
            ((DefaultData)defaultDataBindingSource.Current).transactionId = "" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
        }

    }
}
