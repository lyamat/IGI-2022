using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IGI.Entities;

namespace IGI.Data
{
	public class DbInitializer
	{
		public static async Task Seed(ApplicationDbContext context,
								UserManager<ApplicationUser> userManager,
								RoleManager<IdentityRole> roleManager)
		{
			string adminEmail = "admin@gmail.com";
			string adminRoleName = "admin";

			context.Database.EnsureCreated();
			if(!context.Roles.Any())
			{
				var roleAdmin = new IdentityRole
				{
					Name = adminRoleName,
					NormalizedName = adminRoleName
				};
				await roleManager.CreateAsync(roleAdmin);
			}
			if(!context.Users.Any())
			{
				var user = new ApplicationUser
				{
					Email = "user@gmail.com",
					UserName = "user@gmail.com"
				};
				await userManager.CreateAsync(user, "1234567890");

				var admin = new ApplicationUser
				{
					Email = adminEmail,
					UserName = "admin@gmail.com"
				};
				await userManager.CreateAsync(admin, "1234567890");

				admin = await userManager.FindByEmailAsync(adminEmail);
				await userManager.AddToRoleAsync(admin, adminRoleName);
			}
			if (!context.Parts.Any())
			{
				context.Parts.AddRange(
					new List<PCPart>
					{
                        new PCPart {
                            Name="Mikasa V200W", Description="Volleyball professional Mikasa", Price=299.0,
                            Image="Mikasa-V200W.jpg", CategoryId=1},
                        new PCPart {
							Name="Mikasa MV5PC", Description="Training volleyball ball Mikasa", Price=299.0,
							Image="Mikasa-MV5PC.jpg", CategoryId=1},
						new PCPart {
							Name="Fora FV 8001", Description="Training volleyball ball Fora", Price=386.66,
							Image="Fora-FV-8001.jpg", CategoryId=1},
						new PCPart {
							Name="Molten V5B1502 L", Description="Volleyball professional Molten", Price=324.0,
							Image="Molten-V5B1502-L.jpg", CategoryId=1},
						new PCPart {
							Name="Molten V5B1502 O", Description="Volleyball professional Molten", Price=109.95,
							Image="Molten-V5B1502-O.jpg", CategoryId=1},
						new PCPart {
							Name="Asics Sky Elite FF2 M1", Description="Height 158 mm", Price=109.9,
							Image="Asics-Sky-Elite-FF2-M1.jpg", CategoryId=2},
						new PCPart {
							Name="Asics Sky Elite FF MT", Description="Height 125 mm", Price=69.95,
							Image="Asics-Sky-Elite-FF-MT.jpg", CategoryId=2},
						new PCPart {
							Name="Asics Volley Set", Description="Asics professional set", Price=194.99,
							Image="Asics-Volley-Set.jpg", CategoryId=3},
						new PCPart {
							Name="Givota Kit Volley Piper", Description="Givota professional set", Price=195.05,
							Image="Givota-Kit-Volley-Piper.jpg", CategoryId=3},
						new PCPart {
							Name="Antenna 9922", Description="Antenna 25 mm 2m", Price=139.99,
							Image="Antenna-9922.jpg", CategoryId=4},
						new PCPart {
							Name="Antenna Pocket S1610", Description="Pocket 22 mm 3.4 m", Price=86.99,
							Image="Antenna-Pocket-S1610.jpg", CategoryId=4},
						new PCPart {
							Name="Protection For Posts MD4", Description="Pocket for 3-4m and 3.9/2mm", Price=139.99,
							Image="Protection-For-Posts-MD4.jpg", CategoryId=4},
						
					});
				await context.SaveChangesAsync();
			}
			if (!context.PartCategories.Any())
			{
				context.PartCategories.AddRange(
					new List<PCPartCategory>
					{
                        new PCPartCategory {Name="Accessories"},
                        new PCPartCategory {Name="Uniform"},
                        new PCPartCategory {Name="Shoes"},
                        new PCPartCategory {Name="Balls"},
                    });
				await context.SaveChangesAsync();
			}
		}
	}
}
