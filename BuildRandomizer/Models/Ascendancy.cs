using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuildRandomizer.Models
{
	[Table("Ascendancies")]
	public class Ascendancy
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string BaseClass { get; set; }
	}
}