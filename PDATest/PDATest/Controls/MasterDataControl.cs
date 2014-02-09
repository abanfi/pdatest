using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDATestProject.Models;
using PDATestProject.Controls;

namespace PDATestProject
{

    public partial class MasterDataControl : PDATestProject.Controls.DefaultControl
    {

        private MasterDataModel masterDataModel;
       
        public MasterDataControl()
        {
            InitializeComponent();
            initBinding(new MasterDataModel());
        }

        public override DefaultModel getDefaultParams()
        {
            return masterDataModel;
        }

        private void initBinding(MasterDataModel data)
        {
            this.masterDataModel = data;
            defaultParametersControl1.bind(data);
            masterDataDataBindingSource.DataSource = data;
        }

        private void findInsertedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findInsertedDictionarySince(masterDataModel);
            actialize(result, dictionaryTabPage);
           
            foreach (DictionaryReturnModel value in result.dictionaries)
            {
                dictionaryReturnDataBindingSource.Add(value);
            } 
        }


        private void findInsertedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findInsertedPartnerSince(masterDataModel);
            actialize(result, partnerTabPage);
          
            foreach (PartnerReturnModel value in result.partners)
            {
                partnerReturnDataBindingSource.Add(value);
            }
        }

        private void findInsertedParcelSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findInsertedParcelSince(masterDataModel);
            actialize(result, parcelTabPage);

            foreach (ParcelReturnModel value in result.parcels)
            {
                parcelReturnDataBindingSource.Add(value);
            }
        }

        private void findDeletedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findDeletedDictionarySince(masterDataModel);
            actialize(result, dictionaryTabPage);

            foreach (DictionaryReturnModel value in result.dictionaries)
            {
                dictionaryReturnDataBindingSource.Add(value);
            } 

        }

        private void findDeletedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findDeletedPartnerSince(masterDataModel);
            actialize(result, partnerTabPage);

            foreach (PartnerReturnModel value in result.partners)
            {
                partnerReturnDataBindingSource.Add(value);
            }
        }

        private void findDeletedParcelSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnModel result = PudoServiceExecutor.findDeletedParcelSince(masterDataModel);
            actialize(result, parcelTabPage);

            foreach (ParcelReturnModel value in result.parcels)
            {
                parcelReturnDataBindingSource.Add(value);
            }
        }

        private void actialize(MasterDataReturnModel result, TabPage page)
        {
            clearAll();
            resultMessageTextBox.Text = result.SummaryMessage + resultMessageTextBox.Text;
            resultTabControl.SelectedTab = page;
            defaultParametersControl1.generateNewTransactionId();
        }

        private void clearAll()
        {
            parcelReturnDataBindingSource.Clear();
            partnerReturnDataBindingSource.Clear();
            dictionaryReturnDataBindingSource.Clear();
        }

      
    }
}
