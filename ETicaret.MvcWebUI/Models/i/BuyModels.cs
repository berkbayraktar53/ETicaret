using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.i
{
    public class BuyModels
    {
        public string OrderId { get; set; }
        public string OrderName { get; set; }
        public decimal TotelPrice { get; set; }
        public string OrderStatus { get; set; }
        public ETicaret.MvcWebUI.DB.Members Member { get; set; }
    }
}