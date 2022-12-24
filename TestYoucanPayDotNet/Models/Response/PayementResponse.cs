using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYoucanPayDotNet.Models.Response
{
    internal class PayementResponse
    {
        public bool success { get; set; }
        public bool is_success { get; set; }
        public string code { get; set; }
        public string message { get; set; }
        public string transaction_id { get; set; }
        public string order_id { get; set; }
    }
}
