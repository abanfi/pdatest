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
    public partial class PartnerControl : PDATestProject.Controls.DefaultControl
    {
        private PartnerModel partnerModel;
        
        public PartnerControl()
        {
            InitializeComponent();
            initBinding(new PartnerModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return partnerModel;
        }

        private void initBinding(PartnerModel data)
        {
            this.partnerModel = data;
            defaultParametersControl1.bind(data);
            partnerDataBindingSource.DataSource = data;
        }

        private void findPartnerByIdButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findPartnerById(partnerModel));
        }

        private void findPartnerByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findPartnerByFilter(partnerModel));
        }

        private void countPartnerByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.countPartnerByFilter(partnerModel));
        }

        private void actualize(PartnersReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            partnerReturnDataBindingSource.Clear();
            foreach (PartnerReturnModel partner in data.partners)
            {
                partnerReturnDataBindingSource.Add(partner);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
