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
using PDATestProject.Datas;

namespace PDATestProject
{
    public partial class PackageControl : PDATestProject.Controls.DefaultControl
    {

        private PackageData packageData;

        public PackageControl()
        {
            InitializeComponent();
            initBinding(new PackageData());
        }

        public override DefaultData getDefaultParams()
        {
            return packageData;
        }

        private void initBinding(PackageData data)
        {
            this.packageData = data;
            defaultParametersControl1.bind(data);
            packageDataBindingSource.DataSource = data;
        }

        private void findParcelByBarCodeButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelByBarCode(packageData));
            
        }

        private void findParcelByFilterButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelByFilter(packageData));
        }

        private void actualize(PackageReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage + Environment.NewLine +
                "----------------------------------------------------------" +
                "--------------------------------------------------" +
                Environment.NewLine + resultMessageTextBox.Text;
            parcelCompositeReturnDataBindingSource.Clear();
            foreach (ParcelCompositeReturnData parcelComposite in data.datas){
                parcelCompositeReturnDataBindingSource.Add(parcelComposite);
            }
            defaultParametersControl1.generateNewTransactionId();
        }
            
    }
}
