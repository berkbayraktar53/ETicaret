using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.Message
{
    public class iModels
    {
        public List<System.Web.Mvc.SelectListItem> Users { get; set; }
        public List<ETicaret.MvcWebUI.DB.Messages> Messages { get; set; }
    }
}