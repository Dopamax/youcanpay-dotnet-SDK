using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoucanPay.YoucanPayConfig;

namespace YoucanPay.Models
{
    internal class TokenizeModel
    {
        public string? amount { get; set; }

        public string? currency { get; set; }

        public string? order_id { get; set; }

        public string? pri_key { get; set; }

        public TokenizeModel(string? amount, string? currency, string? order_id, string? pri_key)
        {
            this.amount = amount;
            this.currency = currency;
            this.order_id = order_id;
            this.pri_key = pri_key;
        }

    }
}
