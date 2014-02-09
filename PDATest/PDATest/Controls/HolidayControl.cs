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
    public partial class HolidayControl : PDATestProject.Controls.DefaultControl
    {

        private HolidayModel holidayModel;
              
        public HolidayControl()
        {
            InitializeComponent();
            initBinding(new HolidayModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return holidayModel;
        }

        private void initBinding(HolidayModel data)
        {
            this.holidayModel = data;
            defaultParametersControl1.bind(data);
            holidayDataBindingSource.DataSource = data;
        }

        private void getHolidayButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.getHoliday(holidayModel));

        }

        private void setHolidaysButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.setHoliday(holidayModel));
        }

        private void actualize(DefaultReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + resultMessageTextBox.Text;
            defaultParametersControl1.generateNewTransactionId();
        }

    }
}
