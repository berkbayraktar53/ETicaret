using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.i
{
    public class IndexModel
    {
        public List<ETicaret.MvcWebUI.DB.Products> Products { get; set; }
        public ETicaret.MvcWebUI.DB.Categories Category { get; set; }
    }
}