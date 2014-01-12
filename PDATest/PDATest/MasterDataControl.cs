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
    }
}
