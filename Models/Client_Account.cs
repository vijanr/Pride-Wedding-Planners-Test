using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Client_Account
    {
   
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
