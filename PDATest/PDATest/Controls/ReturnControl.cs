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
    public partial class ReturnControl : PDATestProject.Controls.DefaultControl
    {
        private ReturnModel returnModel;
        
        public ReturnControl()
        {
            InitializeComponent();
            initBinding(new ReturnModel());
        }
        public override DefaultModel getDefaultParams()
        {
            return returnModel;
        }


        private void initBinding(ReturnModel data)
        {
            this.returnModel = data;
            defaultParametersControl1.bind(data);
            returnDataBindingSource.DataSource = data;
            returnParcelReturnDataBindingSource.DataSource = data.data;
        }

        private void findParcelForReturnButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForReturn(returnModel));
        }

        private void postReturnButton_Click(object sender, EventArgs e)
        {
            returnModel.data = (List<ReturnParcelReturnModel>)returnParcelReturnDataBindingSource.DataSource;
           actualize( PudoServiceExecutor.postReturn(returnModel));
        }

        private void actualize(ReturnReturnModel data)
        {
            resultMessageTextBox.Text = data.summaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            returnParcelReturnDataBindingSource.Clear();
            foreach (ReturnParcelReturnModel parcelComposite in data.data)
            {
                returnParcelReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
