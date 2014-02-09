using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDATestProject.PDAPudoService;
using PDATestProject.Models;

namespace PDATestProject
{
    public partial class PackageControl : PDATestProject.Controls.DefaultControl
    {

        private PackageModel packageModel;

        public PackageControl()
        {
            InitializeComponent();
            initBinding(new PackageModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return packageModel;
        }

        private void initBinding(PackageModel data)
        {
            this.packageModel = data;
            defaultParametersControl1.bind(data);
            packageDataBindingSource.DataSource = data;
        }

        private void findParcelByBarCodeButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelByBarCode(packageModel));
            
        }

        private void findParcelByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelByFilter(packageModel));
        }

        private void actualize(PackageReturnModel data)
        {
            resultMessageTextBox.Text = data.SummaryMessage + Environment.NewLine + resultMessageTextBox.Text;
            parcelCompositeReturnDataBindingSource.Clear();
            foreach (ParcelCompositeReturnModel parcelComposite in data.datas)
            {
                parcelCompositeReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }

    }
}
