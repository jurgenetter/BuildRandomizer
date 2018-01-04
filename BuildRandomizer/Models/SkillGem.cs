using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BuildRandomizer.Models
{
	[Table("SkillGems")]
	public class SkillGem
	{
		[Key]
		public int Id { get; set; }
		public enum GemColor { Red, Green, Blue, White }

		public string Name { get; set; }
		public GemColor Color { get; set; }

		public string Type { get; set; } //Attack, Spell, Aura, Curse
	}
}