using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string customer_no { get; set; }
        public string vendor_no { get; set; }
    }
}
