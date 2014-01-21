using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDATestProject.Models;

namespace PDATestProject
{
    public partial class DefaultParametersControl : UserControl
    {
        public DefaultParametersControl()
        {
            InitializeComponent();
        }

        public void bind(DefaultModel data)
        {
            defaultDataBindingSource.DataSource = data;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.generateNewTransactionId();
        }

        public void generateNewTransactionId()
        {
            string newTransactionId = "PDAUI" + (DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
            transactionTextBox.Text = newTransactionId;
            ((DefaultModel)defaultDataBindingSource.Current).transactionId = newTransactionId;
        }

    }
}
