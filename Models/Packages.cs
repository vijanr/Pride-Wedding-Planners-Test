using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Packages
    {
		public int ID { get; set; }
		public int price { get; set; }
		public string detail { get; set; }
		public int start_date { get; set; }
		public string image { get; set; }
		public string email { get; set; }
		public string end_date { get; set; }
		public int package_no { get; set; }
	}
}
