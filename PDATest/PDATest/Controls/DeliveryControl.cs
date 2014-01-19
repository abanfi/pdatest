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
    public partial class DeliveryControl : PDATestProject.Controls.DefaultControl
    {

        private DeliveryData deliveryData;
        
        public DeliveryControl()
        {
            InitializeComponent();
            initBinding(new DeliveryData());
        }

        public override DefaultData getDefaultParams()
        {
            return deliveryData;
        }

        private void initBinding(DeliveryData data)
        {
            this.deliveryData = data;
            defaultParametersControl1.bind(data);
            deliveryDataBindingSource.DataSource = data;
            deliveryParleccMinimumReturnDataBindingSource.DataSource = data.datas;
        }

        private void findParcelForDeliveryButton_Click(object sender, EventArgs e)
        {
           actualize(PudoServiceExecutor.findParcelForDelivery(deliveryData));
        }

        private void postCancelDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryData.datas = (List<DeliveryParleccMinimumReturnData>)
                deliveryParleccMinimumReturnDataBindingSource.DataSource;
            PudoServiceExecutor.postCancelDelivery(deliveryData);
        }

        private void postRefuseDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryData.datas = (List<DeliveryParleccMinimumReturnData>)
                deliveryParleccMinimumReturnDataBindingSource.List;
            PudoServiceExecutor.postRefuseDelivery(deliveryData);
        }

        private void postDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryData.datas = (List<DeliveryParleccMinimumReturnData>)
                deliveryParleccMinimumReturnDataBindingSource.List;
            PudoServiceExecutor.postDelivery(deliveryData);
        }

        private void actualize(DeliveryReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage + Environment.NewLine +
                "---------------------------------------------" +
                "--------------------------------------------------" + 
                Environment.NewLine + resultMessageTextBox.Text;
            deliveryParleccMinimumReturnDataBindingSource.Clear();
            foreach (DeliveryParleccMinimumReturnData parcelComposite in data.datas)
            {
                deliveryParleccMinimumReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
