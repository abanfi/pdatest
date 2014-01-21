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
    public partial class OpeningHoursControl : PDATestProject.Controls.DefaultControl
    {
        private OpeningHoursModel openingHoursModel;
        
        public OpeningHoursControl()
        {
            InitializeComponent();
            initBinding(new OpeningHoursModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return openingHoursModel;
        }

        private void initBinding(OpeningHoursModel data)
        {
            this.openingHoursModel = data;
            defaultParametersControl1.bind(data);
            openingHoursDataBindingSource.DataSource = data;
        }

        private void getOpeningHoursButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.getOpeningHours(openingHoursModel));
        }

        private void setOpeningHoursButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.setOpeningHours(openingHoursModel));
        }

        private void actualize(DefaultReturnModel data)
        {
            resultMessageTextBox.Text = data.summaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            defaultParametersControl1.generateNewTransactionId();
        }
    }
}
