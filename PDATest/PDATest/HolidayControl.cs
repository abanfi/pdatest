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
    public partial class HolidayControl : UserControl
    {

        private HolidayData holidayData;
              
        public HolidayControl()
        {
            InitializeComponent();
            initBinding(new HolidayData());
        }

        private void initBinding(HolidayData data)
        {
            this.holidayData = data;
            defaultParametersControl1.bind(data);
            holidayDataBindingSource.DataSource = data;
        }

    }
}
