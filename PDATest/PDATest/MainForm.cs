using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDATestProject
{ 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void activate(ToolStripButton button, UserControl control)
        {
            //add selected control
            contentPanel.Controls.Clear();
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Controls.Add(control);

            //clear checked state
            packageButton.Checked = false;
            masterDataButton.Checked = false;
            partnerButton.Checked = false;
            holidayButton.Checked = false;
            openingHoursButton.Checked = false;
            deliveryButton.Checked = false;
            returnButton.Checked = false;
            receiveButton.Checked = false;
            preRegButton.Checked = false;

            // check current selection
            button.Checked = true;
        }

        private void packageButton_Click(object sender, EventArgs e)
        {
            activate(packageButton, new PackageControl());
        }

        private void masterDataButton_Click(object sender, EventArgs e)
        {
            activate(masterDataButton, new MasterDataControl());
        }

        private void partnerButton_Click(object sender, EventArgs e)
        {
            activate(partnerButton, new PartnerControl());
        }

        private void holidayButton_Click(object sender, EventArgs e)
        {
            activate(holidayButton, new HolidayControl());
        }

        private void openingHoursButton_Click(object sender, EventArgs e)
        {
            activate(openingHoursButton, new OpeningHoursControl());
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            activate(deliveryButton, new DeliveryControl());
        }

        private void preRegButton_Click(object sender, EventArgs e)
        {
            activate(preRegButton, new ReturnPreRegControl());
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            activate(returnButton, new ReturnControl());
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            activate(receiveButton, new ReceiveControl());
        }

    }
}
