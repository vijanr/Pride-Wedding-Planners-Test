using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Packages
    {
		[Key]
		public int ID { get; set; }
		public string price { get; set; }
		public string detail { get; set; }
		public string start_date { get; set; }
		public string image { get; set; }
		public string email { get; set; }
		public string end_date { get; set; }
		public int package_no { get; set; }
	}
}
