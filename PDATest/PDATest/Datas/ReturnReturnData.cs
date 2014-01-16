﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Datas
{
    public class ReturnReturnData : DefaultReturnData 
    {
        public List<ReturnParcelReturnData> data = new List<ReturnParcelReturnData>();
    }

    public class ReturnParcelReturnData
    {
        public bool Selected { get; set; }

        public string Barcode { get; set; }

        public bool Damaged { get; set; }

        public int LinkedCount { get; set; }

        public string NextLinkedBarcode { get; set; }

        public int ParcelState { get; set; }

        public decimal PriceAtDelivery { get; set; }

        public System.DateTime ReturnDate { get; set; }
    }

}