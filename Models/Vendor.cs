using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Vendor
    {
        [Key]
        public int ID { get; set; }
        public string company_name { get; set; }
        public string tele_no { get; set; }
        public string company_catogary { get; set; }
        public string email { get; set; }
    }
}
