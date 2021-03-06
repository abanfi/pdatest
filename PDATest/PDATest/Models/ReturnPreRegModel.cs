﻿using PDATestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReturnPreRegModel : DefaultModel 
    {
        public ReturnPreRegModel()
        {
            data = new List<ParcelCompositeReturnModel>();
        }

        public string packageCode { get; set; }
        public bool damaged { get; set; }
        public string partnerId { get; set; }
        public string customerName { get; set; }
        public int refuseReason { get; set; }
        public bool returnDamaged { get; set; }
        public bool noLabel { get; set; }

        public DateTime eventCreated { get; set; }

        public List<ParcelCompositeReturnModel> data { get; set; }
        
        public override string ToString()
        {
            string stringValue = base.ToString();
            stringValue += "eventCreated:" + eventCreated + Environment.NewLine;
            stringValue += "packageCode:" + packageCode + Environment.NewLine;
            stringValue += "damaged:" + damaged + Environment.NewLine;
            stringValue += "partnerId:" + partnerId + Environment.NewLine;
            stringValue += "customerName:" + customerName + Environment.NewLine;
            stringValue += "refuseReason:" + refuseReason + Environment.NewLine;
            stringValue += "bagBarcode:" + returnDamaged + Environment.NewLine;
            stringValue += "bagBarcode:" + noLabel + Environment.NewLine;
            foreach (ParcelCompositeReturnModel parcelComposite in data)
            {
                stringValue += "parcelcomposite:" + parcelComposite.Barcode;
            }
            return stringValue;
        }        
    }
}
