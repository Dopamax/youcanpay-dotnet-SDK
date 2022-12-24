using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoucanPay.Models
{
    internal class YoucanPayCardInformation
    {
        public String cardHolderName { get; set; }
        public String cardNumber { get; set; }
        public String expireDateYear { get; set; }
        public String expireDateMonth { get; set; }
        public String cvv { get; set; }

        public YoucanPayCardInformation(string cardHolderName, string cardNumber, string expireDateMonth, string expireDateYear, string cvv)
        {
            this.cardHolderName = cardHolderName;
            this.cardNumber = cardNumber;
            this.expireDateYear = expireDateYear;
            this.expireDateMonth = expireDateMonth;
            this.cvv = cvv;
        }


    }
}
