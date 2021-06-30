using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.Message
{
    public class RenderMessageModel
    {
        public List<ETicaret.MvcWebUI.DB.Messages> Messages { get; set; }
        public int Count { get; set; }
    }
}