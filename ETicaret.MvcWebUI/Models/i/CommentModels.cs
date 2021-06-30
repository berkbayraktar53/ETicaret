using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.i
{
    public class CommentModels
    {
        public List<ETicaret.MvcWebUI.DB.Comments> Comments { get; set; }
        public ETicaret.MvcWebUI.DB.Products Product { get; set; }
    }
}