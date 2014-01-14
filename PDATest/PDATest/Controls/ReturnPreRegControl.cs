﻿using System;
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
    public partial class ReturnPreRegControl : PDATestProject.Controls.DefaultControl
    {
        private ReturnPreRegData returnPreRegData;
        
        public ReturnPreRegControl()
        {
            InitializeComponent();
            initBinding(new ReturnPreRegData());
        }

        public override DefaultData getDefaultParams()
        {
            return returnPreRegData;
        }

        private void initBinding(ReturnPreRegData data)
        {
            this.returnPreRegData = data;
            defaultParametersControl1.bind(data);
            returnPreRegDataBindingSource.DataSource = data;
        }

        private void findParcelForDeliveryButton_Click(object sender, EventArgs e)
        {
            actualize(PudoServiceExecutor.findParcelForDelivery(returnPreRegData));
        }

        private void postRefuseCustRetPreregButton_Click(object sender, EventArgs e)
        {
            returnPreRegData.data = (List<ParcelMinimalReturnData>)parcelMinimalReturnDataBindingSource.List;
            actualize(PudoServiceExecutor.postRefuseCustRetPrereg(returnPreRegData));
        }

        private void postCustRetPreregButton_Click(object sender, EventArgs e)
        {
            returnPreRegData.data = (List<ParcelMinimalReturnData>)parcelMinimalReturnDataBindingSource.List;
            actualize(PudoServiceExecutor.postCustRetPrereg(returnPreRegData));
        }

        private void postCustRetUnexpectedButton_Click(object sender, EventArgs e)
        {
            returnPreRegData.data = (List<ParcelMinimalReturnData>)parcelMinimalReturnDataBindingSource.List;
            actualize(PudoServiceExecutor.postCustRetUnexpected(returnPreRegData));
        }

        private void actualize(ReturnPreRegReturnData data)
        {
            resultMessageTextBox.Text = data.summaryMessage;
            parcelMinimalReturnDataBindingSource.Clear();
            foreach (ParcelMinimalReturnData parcelComposite in data.data)
            {
                parcelMinimalReturnDataBindingSource.Add(parcelComposite);
            }
            
        }
    }
}
