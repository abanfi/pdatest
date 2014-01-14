﻿using System;
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

        private void getHolidayButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.getHoliday(holidayData));

        }

        private void setHolidaysButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.setHoliday(holidayData));
        }

        private void actualize(DefaultReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage;
        }

    }
}