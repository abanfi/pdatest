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
    public partial class OpeningHoursControl : PDATestProject.Controls.DefaultControl
    {
        private OpeningHoursData openingHoursData;
        
        public OpeningHoursControl()
        {
            InitializeComponent();
            initBinding(new OpeningHoursData());
        }

        public override DefaultData getDefaultParams()
        {
            return openingHoursData;
        }

        private void initBinding(OpeningHoursData data)
        {
            this.openingHoursData = data;
            defaultParametersControl1.bind(data);
            openingHoursDataBindingSource.DataSource = data;
        }

        private void getOpeningHoursButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.getOpeningHours(openingHoursData));
        }

        private void setOpeningHoursButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.setOpeningHours(openingHoursData));
        }

        private void actualize(DefaultReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage;
        }
    }
}
