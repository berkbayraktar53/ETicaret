using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models.Account
{
    public class RegisterModels
    {
        public ETicaret.MvcWebUI.DB.Members Member { get; set; }
        public string rePassword { get; set; }
    }
}