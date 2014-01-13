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
    public partial class ReceiveControl : UserControl
    {
        private ReceiveData receiveData;
        
        public ReceiveControl()
        {
            InitializeComponent();
            initBinding(new ReceiveData());
        }

        private void initBinding(ReceiveData data)
        {
            this.receiveData = data;
            defaultParametersControl1.bind(data);
            receiveDataBindingSource.DataSource = data;
        }

        private void findParcelForReceiveButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findParcelForReceive(receiveData);
        }

        private void postReceiveButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.postReceive(receiveData);
        }
    }
}
