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
    public partial class DeliveryControl : PDATestProject.Controls.DefaultControl
    {

        private DeliveryModel deliveryModel;
        
        public DeliveryControl()
        {
            InitializeComponent();
            initBinding(new DeliveryModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return deliveryModel;
        }

        private void initBinding(DeliveryModel data)
        {
            this.deliveryModel = data;
            defaultParametersControl1.bind(data);
            deliveryDataBindingSource.DataSource = data;
            deliveryParleccMinimumReturnDataBindingSource.DataSource = data.datas;
        }

        private void findParcelForDeliveryButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForDelivery(deliveryModel));
        }

        private void postCancelDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryModel.datas = (List<DeliveryParcelMinimumReturnModel>)
                deliveryParleccMinimumReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postCancelDelivery(deliveryModel));
        }

        private void postRefuseDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryModel.datas = (List<DeliveryParcelMinimumReturnModel>)
                deliveryParleccMinimumReturnDataBindingSource.List;
            actualize(PudoServiceExecutor.postRefuseDelivery(deliveryModel));
        }

        private void postDeliveryButton_Click(object sender, EventArgs e)
        {
            deliveryModel.datas = (List<DeliveryParcelMinimumReturnModel>)
                deliveryParleccMinimumReturnDataBindingSource.List;
            actualize(PudoServiceExecutor.postDelivery(deliveryModel));
        }

        private void actualize(DeliveryReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + Environment.NewLine +
                "---------------------------------------------" +
                "--------------------------------------------------" + 
                Environment.NewLine + resultMessageTextBox.Text;
            deliveryParleccMinimumReturnDataBindingSource.Clear();
            foreach (DeliveryParcelMinimumReturnModel parcelComposite in data.datas)
            {
                deliveryParleccMinimumReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
