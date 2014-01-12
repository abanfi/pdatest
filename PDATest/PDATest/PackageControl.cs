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

namespace PDATestProject
{
    public partial class PackageControl : UserControl
    {

        private PackageData packageData;

        public PackageControl()
        {
            InitializeComponent();
            initBinding(new PackageData());
        }

        private void initBinding(PackageData data)
        {
            this.packageData = data;
            defaultParametersControl1.bind(data);
            packageDataBindingSource.DataSource = data;
        }

        private void findParcelByBarCodeButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findParcelByBarCode(packageData);
            
            PdaPudoServiceClient client = new PdaPudoServiceClient();
            FindParcelByBarcodeRequest request = new FindParcelByBarcodeRequest();
            request.Barcode = packageCodeTextBox.Text;
            request.EventCreated = new DateTime();

        }

        private void findParcelByFilterButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findParcelByFilter(packageData);
        }
            
    }
}
