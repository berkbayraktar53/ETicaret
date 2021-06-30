using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.Account
{
    public class ProfilModels
    {
        public ETicaret.MvcWebUI.DB.Members Members { get; set; }
        public List<ETicaret.MvcWebUI.DB.Addresses> Addresses { get; set; }
        public ETicaret.MvcWebUI.DB.Addresses CurrentAddress { get; set; }
    }
}