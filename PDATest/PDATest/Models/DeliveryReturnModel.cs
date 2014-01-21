
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class DeliveryReturnModel : DefaultReturnModel
    {
        public List<DeliveryParcelMinimumReturnModel> datas = new List<DeliveryParcelMinimumReturnModel>();
    }

    public class DeliveryParcelMinimumReturnModel 
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
