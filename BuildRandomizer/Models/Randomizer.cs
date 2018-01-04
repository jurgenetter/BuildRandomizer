using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildRandomizer.Models
{
	public static class Randomizer
	{
		public static Build RandomizeBuild()
		{
			Build build = new Build();

			using (var db = new BuildContext())
			{
				string s = db.Database.Connection.ConnectionString;

				build.Ascendancy = db.Ascendancies.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
				build.Defense = db.Defenses.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();
				do
				{
					build.Keystones = db.Keystones.OrderBy(r => Guid.NewGuid()).Take(2).ToList(); //All the build problems come from Chaos Innoculation, so just get new Keystones if there's an issue.
				} while (!checkBuildValidity(build));

				build.WeaponType = db.WeaponTypes.OrderBy(r => Guid.NewGuid()).Take(1).FirstOrDefault();

				Random random = new Random();
				List<SkillGem> skillList = new List<SkillGem>();
				skillList.Add(db.SkillGems.OrderBy(g => Guid.NewGuid()).Where(r => r.Type == "Attack" || r.Type == "Spell").Take(1).FirstOrDefault());
				skillList.AddRange(db.SkillGems.OrderBy(g => Guid.NewGuid()).Where(r => r.Type != "Aura" && r.Type != "Curse").Take(2).ToList());
				int numSupport = random.Next(1, 4);
				skillList.AddRange(db.SkillGems.OrderBy(g => Guid.NewGuid()).Where(r => r.Type == "Aura" || r.Type == "Curse").Take(numSupport).ToList());

				build.SkillList = skillList;


			}

			return build;
		}

		public static bool checkBuildValidity(Build b)
		{
			if(b.Keystones.Any(e => e.Name.Contains("Chaos")) && !b.Defense.Name.Contains("Energy")) //Chaos Innoculation requires Energy Shield
			{
				return false;
			}

			if (b.Defense.Name.Contains("Battery") && b.Keystones.Any(e => e.Name.Contains("Chaos"))) //Chaos Innoculation and Eldritch Battery are mutually exclusive
			{
				return false;
			}

			return true;
		}
	}
}