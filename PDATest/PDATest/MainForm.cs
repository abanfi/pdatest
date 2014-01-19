using PDATestProject.Controls;
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
        private PackageControl packageControl;
        private MasterDataControl masterDataControl;
        private PartnerControl partnerControl;
        private HolidayControl holidayControl;
        private OpeningHoursControl openingHoursControl;
        private DeliveryControl deliveryControl;
        private ReturnPreRegControl returnPreRegControl;
        private ReturnControl returnControl;
        private ReceiveControl receiveControl;

        private DefaultControl currentControl;
        public MainForm()
        {
            InitializeComponent();
            endpointURLtoolStripLabel.Text = ConfigUtil.getEndpointAddress();
        }

        private void activate(ToolStripButton button, DefaultControl control)
        {

            if (!control.isInitialized() && currentControl != null)
            {
                control.setDefaultParams(currentControl.getDefaultParams());
            }
            currentControl = control;

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
            activate(packageButton, packageControl == null ? packageControl = new PackageControl() : packageControl);
        }

        private void masterDataButton_Click(object sender, EventArgs e)
        {
            activate(masterDataButton, masterDataControl == null ? masterDataControl = new MasterDataControl() : masterDataControl);
        }

        private void partnerButton_Click(object sender, EventArgs e)
        {
            activate(partnerButton, partnerControl == null ? partnerControl = new PartnerControl() : partnerControl);
        }

        private void holidayButton_Click(object sender, EventArgs e)
        {
            activate(holidayButton, holidayControl == null ? holidayControl = new HolidayControl() : holidayControl);
        }

        private void openingHoursButton_Click(object sender, EventArgs e)
        {
            activate(openingHoursButton, openingHoursControl == null ? openingHoursControl = new OpeningHoursControl() : openingHoursControl);
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            activate(deliveryButton, deliveryControl == null ? deliveryControl = new DeliveryControl() : deliveryControl);
        }

        private void preRegButton_Click(object sender, EventArgs e)
        {
            activate(preRegButton, returnPreRegControl == null ? returnPreRegControl = new ReturnPreRegControl() : returnPreRegControl);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            activate(returnButton, returnControl == null ? returnControl = new ReturnControl() : returnControl);
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            activate(receiveButton, receiveControl == null ? receiveControl = new ReceiveControl() : receiveControl);
        }

        //private void changeStripButton_Click(object sender, EventArgs e)
        //{
        //    string input = Microsoft.VisualBasic.Interaction.InputBox("Adja meg az új elérési útvonalat", 
        //        "Szolgáltatás beállítása", ConfigUtil.getEndpointAddress(), -1, -1);
            //PudoServiceExecutor.initEndpoint(input);
        //    ConfigUtil.setEndpointAddress(input);
        //    endpointURLtoolStripLabel.Text = input;
        //}

    }
}
