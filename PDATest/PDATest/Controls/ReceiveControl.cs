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
    public partial class ReceiveControl : PDATestProject.Controls.DefaultControl
    {
        private ReceiveModel receiveModel;
        
        public ReceiveControl()
        {
            InitializeComponent();
            initBinding(new ReceiveModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return receiveModel;
        }

        private void initBinding(ReceiveModel data)
        {
            this.receiveModel = data;
            defaultParametersControl1.bind(data);
            receiveDataBindingSource.DataSource = data;
            parcelCompositeSelectableReturnDataBindingSource.DataSource = data.gridModel;
        }

        private void findParcelForReceiveButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForReceive(receiveModel));
        }

        private void postReceiveButton_Click(object sender, EventArgs e)
        {
            receiveModel.gridModel = (List<ParcelCompositeSelectableReturnModel>) 
                parcelCompositeSelectableReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postReceive(receiveModel));
        }

        private void actualize(ReceiveReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + resultMessageTextBox.Text;
            parcelCompositeSelectableReturnDataBindingSource.Clear();
            foreach (ParcelCompositeReturnModel parcelComposite in data.datas)
            {
                parcelCompositeSelectableReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
