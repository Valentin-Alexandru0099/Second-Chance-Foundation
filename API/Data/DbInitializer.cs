using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Extensions;
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

            var jobs = new List<Job>
            {
                new Job
                {
                    Name="Cashier",
                    Description="We are looking for a cashier!",
                    SubmissionTime=DateTime.Now.SetKindUtc(),
                    Available=true,
                    Organization=new Organization{Name="Cora", Description="The best supermarket in town  !", Website="https://www.cora.ro/"},
                },
                new Job
                {
                    Name="Cashier",
                    Description="We need experienced and fast man or women for a cashier job!",
                    SubmissionTime=DateTime.Now.SetKindUtc(),
                    Available=true,
                    Organization=new Organization{Name="Bogard", Description="The best at everything there is !", Website="https://www.bogardconstruction.com/"},
                },
                new Job
                {
                    Name="Carpenter",
                    Description="Looking for new personal for a small business!",
                    SubmissionTime=DateTime.Now.SetKindUtc(),
                    Available=true,
                    Organization=new Organization{Name="Mega Image", Description="A very fruitfull place to be !", Website="https://www.mega-image.ro/"},
                }
            };

            foreach (var job in jobs) 
                {
                    context.Jobs.Add(job);
                }

            var meets = new List<Meet>
            {
                new Meet
                {
                    Name="Meet Marti",
                    Description="Meeting saptamanal!",
                    Date=DateTime.Now.SetKindUtc(),
                    Status=Status.Upcoming,
                 },
                new Meet
                {
                    Name="Meet Miercuri",
                    Description="Meeting saptamanal!",
                    Date=DateTime.Now.SetKindUtc(),
                    Status=Status.Upcoming,
                 },

            };

            foreach (var meet in meets)
            {
                context.Meets.Add(meet);
            }
            context.SaveChanges();

            }
        }
    }
