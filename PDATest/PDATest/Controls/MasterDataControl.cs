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
    
    public partial class MasterDataControl : UserControl
    {

        private MasterDataData masterDataData;
       
        public MasterDataControl()
        {
            InitializeComponent();
            initBinding(new MasterDataData());
        }

        private void initBinding(MasterDataData data)
        {
            this.masterDataData = data;
            defaultParametersControl1.bind(data);
            masterDataDataBindingSource.DataSource = data;
        }

        private void findInsertedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findInsertedDictionarySince(masterDataData);
        }

        private void findInsertedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findInsertedPartnerSince(masterDataData);
        }

        private void findInsertedParcelSinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findInsertedParcelSince(masterDataData);
        }

        private void findDeletedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findDeletedDictionarySince(masterDataData);
        }

        private void findDeletedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findDeletedPartnerSince(masterDataData);
        }

        private void findDeletedParcelSinceButton_Click(object sender, EventArgs e)
        {
            PudoServiceExecutor.findDeletedParcelSince(masterDataData);
        }
    }
}
