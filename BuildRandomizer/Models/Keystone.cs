using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BuildRandomizer.Models
{
	[Table("Keystones")]
	public class Keystone
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}