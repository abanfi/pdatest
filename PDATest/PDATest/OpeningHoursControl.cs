using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDATestProject
{
    public partial class OpeningHoursControl : UserControl
    {
        private OpeningHoursData openingHoursData;
        
        public OpeningHoursControl()
        {
            InitializeComponent();
            initBinding(new OpeningHoursData());
        }

        private void initBinding(OpeningHoursData data)
        {
            this.openingHoursData = data;
            defaultParametersControl1.bind(data);
            openingHoursDataBindingSource.DataSource = data;
        }

        private void getOpeningHoursButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.getOpeningHours(openingHoursData);
        }

        private void setOpeningHoursButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.setOpeningHours(openingHoursData);
        }
    }
}
