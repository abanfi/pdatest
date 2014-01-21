using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDATestProject.Models
{
    public class ReturnReturnModel : DefaultReturnModel 
    {
        public List<ReturnParcelReturnModel> data = new List<ReturnParcelReturnModel>();
    }

    public class ReturnParcelReturnModel
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
