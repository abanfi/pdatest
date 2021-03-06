﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class MasterDataReturnModel : DefaultReturnModel
    {
        public List<DictionaryReturnModel> dictionaries = new List<DictionaryReturnModel>();

        public List<ParcelReturnModel> parcels = new List<ParcelReturnModel>();

        public List<PartnerReturnModel> partners = new List<PartnerReturnModel>();
    }

    public class DictionaryReturnModel
    {
        public string Description { get; set; }

        public string DictionaryClass { get; set; }

        public int KeyValue { get; set; }
    }

    public class ParcelReturnModel
    {
        public string LocationID { get; set; }

        public string BagBarcode { get; set; }

        public string Barcode { get; set; }

        public string Currency { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPostalCode { get; set; }

        public bool Damaged { get; set; }

        public string DestinationLocationID { get; set; }

        public int LinkedCount { get; set; }

        public string NextLinkedBarcode { get; set; }

        public string OldBarcode { get; set; }

        public int ParcelState { get; set; }

        public int ParcelWorkflow { get; set; }

        public string PartnerID { get; set; }

        public decimal PriceAtDelivery { get; set; }

        public System.DateTime ReturnDate { get; set; }

        public string ShipmentID { get; set; }

    }

    public class PartnerReturnModel
    {
        public string PartnerID { get; set; }

        public string PartnerName { get; set; }
    }
}
