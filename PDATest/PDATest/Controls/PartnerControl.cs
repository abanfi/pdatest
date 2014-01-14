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
    public partial class PartnerControl : UserControl
    {
        private PartnerData partnerData;
        
        public PartnerControl()
        {
            InitializeComponent();
            initBinding(new PartnerData());
        }

        private void initBinding(PartnerData data)
        {
            this.partnerData = data;
            defaultParametersControl1.bind(data);
            partnerDataBindingSource.DataSource = data;
        }

        private void findPartnerByIdButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findPartnerById(partnerData));
        }

        private void findPartnerByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findPartnerByFilter(partnerData));
        }

        private void countPartnerByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.countPartnerByFilter(partnerData));
        }

        private void actualize(PartnersReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage;
            partnerReturnDataBindingSource.Clear();
            foreach (PartnerReturnData partner in data.partners)
            {
                partnerReturnDataBindingSource.Add(partner);
            }
           
        }
    }
}
