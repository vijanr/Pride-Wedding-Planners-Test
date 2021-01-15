using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Payments
    {
        public int ID { get; set; }
        public int card_no { get; set; }
        public string cardholder_name { get; set; }
        public int exp_date { get; set; }
        public int cvc { get; set; }
    }
}
