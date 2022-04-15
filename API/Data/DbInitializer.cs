using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
    {
        public static class DbInitializer
        {
            public static async Task Initialize(StoreContext context, UserManager<User> userManager)
            {
                if (!userManager.Users.Any())
                {
                    var user = new User
                    {
                        UserName = "bob",
                        Email = "bob@test.com"
                    };

                    await userManager.CreateAsync(user, "Pa$$w0rd");
                    await userManager.AddToRoleAsync(user, "Member");

                    var admin = new User
                    {
                        UserName = "admin",
                        Email = "admin@test.com"
                    };
                    
                    await userManager.CreateAsync(admin, "Pa$$w0rd");
                    await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
                }


                if (context.Meets.Any()) return;
                if (context.Jobs.Any()) return;

                var jobs = new List<Job> {

                };

                foreach (var job in jobs) 
                {
                    context.Jobs.Add(job);
                }

                var meets = new List<Meet> {
                    
                };

                foreach (var meet in meets)
                {
                    context.Meets.Add(meet);
                }
                context.SaveChanges();
            }
        }
    }
