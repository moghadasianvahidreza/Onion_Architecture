﻿using Onion.Data;

namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			// فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>());

			// فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

			// به درد مشتری می خورد
			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{

			//System.Data.Entity.Database.SetInitializer(new DatabaseContextInitializer());
		}

		public System.Data.Entity.DbSet<User> Users { get; set; }

		public System.Data.Entity.DbSet<Role> Roles { get; set; }

		public System.Data.Entity.DbSet<UserRole> UserRoles { get; set; }
	} 
}