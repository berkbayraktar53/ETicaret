using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.i
{
    public class ProductModels
    {
        public ETicaret.MvcWebUI.DB.Products Product { get; set; }
        public List<ETicaret.MvcWebUI.DB.Comments> Comments { get; set; }
    }
}