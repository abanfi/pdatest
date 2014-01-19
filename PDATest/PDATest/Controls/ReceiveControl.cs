using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDATestProject.Datas;

namespace PDATestProject
{
    public partial class ReceiveControl : PDATestProject.Controls.DefaultControl
    {
        private ReceiveData receiveData;
        
        public ReceiveControl()
        {
            InitializeComponent();
            initBinding(new ReceiveData());
        }

        public override DefaultData getDefaultParams()
        {
            return receiveData;
        }

        private void initBinding(ReceiveData data)
        {
            this.receiveData = data;
            defaultParametersControl1.bind(data);
            receiveDataBindingSource.DataSource = data;
            parcelCompositeSelectableReturnDataBindingSource.DataSource = data.gridData;
        }

        private void findParcelForReceiveButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForReceive(receiveData));
        }

        private void postReceiveButton_Click(object sender, EventArgs e)
        {
            receiveData.gridData = (List<ParcelCompositeSelectableReturnData>) 
                parcelCompositeSelectableReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postReceive(receiveData));
        }

        private void actualize(ReceiveReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            parcelCompositeSelectableReturnDataBindingSource.Clear();
            foreach (ParcelCompositeReturnData parcelComposite in data.datas)
            {
                parcelCompositeSelectableReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
