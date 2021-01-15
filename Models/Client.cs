using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Client
    {
        public int ID { get; set; }
        public int client_NIC { get; set; }
        public string F_name { get; set; }
        public string L_name { get; set; }
        public int tele_no { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
    }
}
