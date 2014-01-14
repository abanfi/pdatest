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

    public partial class MasterDataControl : PDATestProject.Controls.DefaultControl
    {

        private MasterDataData masterDataData;
       
        public MasterDataControl()
        {
            InitializeComponent();
            initBinding(new MasterDataData());
        }

        public override DefaultData getDefaultParams()
        {
            return masterDataData;
        }

        private void initBinding(MasterDataData data)
        {
            this.masterDataData = data;
            defaultParametersControl1.bind(data);
            masterDataDataBindingSource.DataSource = data;
        }

        private void findInsertedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findInsertedDictionarySince(masterDataData);
            resultMessageTextBox.Text =  result.summaryMessage;
            this.offlineDataGrid.DataSource = dictionaryReturnDataBindingSource;
            dictionaryReturnDataBindingSource.Clear();
            foreach (DictionaryReturnData value in result.dictionaries)
            {
                dictionaryReturnDataBindingSource.Add(value);
            } 
        }


        private void findInsertedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findInsertedPartnerSince(masterDataData);
            resultMessageTextBox.Text =  result.summaryMessage;
            this.offlineDataGrid.DataSource = partnerReturnDataBindingSource;
            partnerReturnDataBindingSource.Clear();
            foreach (PartnerReturnData value in result.partners)
            {
                partnerReturnDataBindingSource.Add(value);
            }
        }

        private void findInsertedParcelSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findInsertedParcelSince(masterDataData);

            resultMessageTextBox.Text = result.summaryMessage;
            this.offlineDataGrid.DataSource = parcelReturnDataBindingSource;
            parcelReturnDataBindingSource.Clear();
            foreach (ParcelReturnData value in result.parcels)
            {
                parcelReturnDataBindingSource.Add(value);
            } 
        }

        private void findDeletedDictionarySinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findDeletedDictionarySince(masterDataData);
           
            resultMessageTextBox.Text =  result.summaryMessage;
            this.offlineDataGrid.DataSource = dictionaryReturnDataBindingSource;
            dictionaryReturnDataBindingSource.Clear();
            foreach (DictionaryReturnData value in result.dictionaries)
            {
                dictionaryReturnDataBindingSource.Add(value);
            } 

        }

        private void findDeletedPartnerSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findDeletedPartnerSince(masterDataData);
           
            resultMessageTextBox.Text =  result.summaryMessage;
            this.offlineDataGrid.DataSource = partnerReturnDataBindingSource;
            partnerReturnDataBindingSource.Clear();
            foreach (PartnerReturnData value in result.partners)
            {
                partnerReturnDataBindingSource.Add(value);
            }
        }

        private void findDeletedParcelSinceButton_Click(object sender, EventArgs e)
        {
            MasterDataReturnData result = PudoServiceExecutor.findDeletedParcelSince(masterDataData);
            
            resultMessageTextBox.Text = result.summaryMessage;
            this.offlineDataGrid.DataSource = parcelReturnDataBindingSource;
            parcelReturnDataBindingSource.Clear();
            foreach (ParcelReturnData value in result.parcels)
            {
                parcelReturnDataBindingSource.Add(value);
            } 

        }

      
    }
}
