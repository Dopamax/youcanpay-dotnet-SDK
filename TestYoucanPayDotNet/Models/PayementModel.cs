using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoucanPay.Models;

namespace TestYoucanPayDotNet.Models
{
    internal class PayementModel
    {
       
        public YoucanPayCardInformation youcanPayCardInformation { get; set; }
        public string token { get; set; }
        public string pub_key { get; set; }

        public PayementModel()
        {
        }

        public PayementModel(YoucanPayCardInformation youcanPayCardInformation, string token, string pub_key)
        {
            this.youcanPayCardInformation = youcanPayCardInformation;
            this.token = token;
            this.pub_key = pub_key;
        }
    }
}
