using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildRandomizer.Models
{
	public class Build
	{
		public Ascendancy Ascendancy { get; set; }
		public List<SkillGem> SkillList { get; set; }
		public List<Keystone> Keystones { get; set; }
		public WeaponType WeaponType { get; set; }
		public Defense Defense { get; set; }

	}
}