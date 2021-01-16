using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Client_Account
    {
        [Key]
        public int ID { get; set; }
        
        public string username { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }
  
    }
}
