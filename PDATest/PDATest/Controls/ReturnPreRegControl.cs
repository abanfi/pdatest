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
    public partial class ReturnPreRegControl : PDATestProject.Controls.DefaultControl
    {
        private ReturnPreRegModel returnPreRegModel;
        
        public ReturnPreRegControl()
        {
            InitializeComponent();
            initBinding(new ReturnPreRegModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return returnPreRegModel;
        }

        private void initBinding(ReturnPreRegModel data)
        {
            this.returnPreRegModel = data;
            defaultParametersControl1.bind(data);
            returnPreRegDataBindingSource.DataSource = data;
            parcelMinimalReturnDataBindingSource.DataSource = data.data;
        }

        private void findParcelForCustRetPreRegButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForCustRetPreReg(returnPreRegModel));
        }

        private void postRefuseCustRetPreregButton_Click(object sender, EventArgs e)
        {
            returnPreRegModel.data = (List<ParcelCompositeReturnModel>)parcelMinimalReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postRefuseCustRetPrereg(returnPreRegModel));
        }

        private void postCustRetPreregButton_Click(object sender, EventArgs e)
        {
            returnPreRegModel.data = (List<ParcelCompositeReturnModel>)parcelMinimalReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postCustRetPrereg(returnPreRegModel));
        }

        private void postCustRetUnexpectedButton_Click(object sender, EventArgs e)
        {
            returnPreRegModel.data = (List<ParcelCompositeReturnModel>)parcelMinimalReturnDataBindingSource.DataSource;
            actualize(PudoServiceExecutor.postCustRetUnexpected(returnPreRegModel));
        }

        private void actualize(ReturnPreRegReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            parcelMinimalReturnDataBindingSource.Clear();
            foreach (ParcelCompositeReturnModel parcelComposite in data.data)
            {
                parcelMinimalReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();            
        }
    }
}
