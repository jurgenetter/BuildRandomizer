namespace BuildRandomizer.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class BuildContext : DbContext
	{
		// Your context has been configured to use a 'BuildContext' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'BuildRandomizer.Models.BuildContext' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'BuildContext' 
		// connection string in the application configuration file.
		public BuildContext()
			: base("name=BuildContext")
		{
		}

		public DbSet<Ascendancy> Ascendancies { get; set; }
		public DbSet<Defense> Defenses { get; set; }
		public DbSet<Keystone> Keystones { get; set; }
		public DbSet<SkillGem> SkillGems { get; set; }
		public DbSet<WeaponType> WeaponTypes { get; set; }

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}
}