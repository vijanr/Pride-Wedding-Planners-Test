using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Payments
    {
        [Key]
        public int ID { get; set; }
        public string card_no { get; set; }
        public string cardholder_name { get; set; }
        public string exp_date { get; set; }
        public string CVV { get; set; }
    }
}
