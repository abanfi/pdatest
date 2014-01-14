using System;
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
    public partial class ReturnControl : PDATestProject.Controls.DefaultControl
    {
        private ReturnData returnData;
        
        public ReturnControl()
        {
            InitializeComponent();
            initBinding(new ReturnData());
        }
        public override DefaultData getDefaultParams()
        {
            return returnData;
        }


        private void initBinding(ReturnData data)
        {
            this.returnData = data;
            defaultParametersControl1.bind(data);
            returnDataBindingSource.DataSource = data;
        }

        private void findParcelForReturnButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForReturn(returnData));
        }

        private void postReturnButton_Click(object sender, EventArgs e)
        {
            returnData.data = (List<ReturnParcelReturnData>)returnParcelReturnDataBindingSource.List;
           actualize( PudoServiceExecutor.postReturn(returnData));
        }

        private void actualize(ReturnReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage;
            returnParcelReturnDataBindingSource.Clear();
            foreach (ReturnParcelReturnData parcelComposite in data.data)
            {
                returnParcelReturnDataBindingSource.Add(parcelComposite);
            }
        }
    }
}
