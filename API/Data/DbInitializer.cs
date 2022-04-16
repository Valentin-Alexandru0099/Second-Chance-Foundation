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
                    Name="Tuesday Meeting",
                    Description="Weekly meeting to discuss best interview practices!",
                    Date=DateTime.Now.SetKindUtc(),
                    Status=Status.Upcoming,
                 },
                new Meet
                {
                    Name="Wednesday Meeting",
                    Description="The monthly meeting to discuss CV updating!",
                    Date=DateTime.Now.SetKindUtc(),
                    Status=Status.Upcoming,
                 },
                new Meet
                {
                    Name="Friday Meeting",
                    Description="Scheduling courses to take for specific companies that want to hire.",
                    Date=DateTime.Now.SetKindUtc(),
                    Status=Status.Upcoming,
                 },

            };

            foreach (var meet in meets)
            {
                context.Meets.Add(meet);
            }

            var articles = new List<Article>
            {
                new Article
                {
                    Title="7 interview skills that will get you hired in 2022",
                    Content="Overview of skills for an interview Let’s start with the basics. Here are the most important interview skills to focus on and how to make sure you project professionalism and expertise in your field.Interview preparationKnow the companySpeaking skills (clear, cohesive, calm)Think first, speak secondListeningPart of having a successful interview comes from taking the time to prepare . Winging it rarely turns out well, and an interviewer can sense ill preparation from a mile away. So, what should your preparation entail? We suggest you re-read the job description several times so that you are capable of discussing the position and the requirements associated with it comfortably. Think about how you can illustrate the desired skills with the experience you have. "
                 },
                new Article
                {
                    Title="Tips for before the interview",
                    Content="1. Start by researching the company and your interviewers. Understanding key information about the company you’re interviewing with can help you go into your interview with confidence. Using the company’s website, social media posts and recent press releases will provide a solid understanding of the company’s goals and how your background makes you a great fit. Review our Complete Guide to Researching a Company."

                 },
                new Article
                {
                    Title="How to Integrate Back Into Society",
                    Content="Start Early One of the most important tips for successful reintegration is starting early. Plan as early as possible for what you can do to have a successful life after prison. This means that as vital as it is to follow release programs, it’s even more important to follow pre - release programs.Yes, finding a job post-release is imperative, but so is taking the time to help offenders change their attitudes and beliefs about crime.These programs may also address mental health issues, offer job training, and more.",

                 },

            };

            foreach (var article in articles)
            {
                context.Articles.Add(article);
            }
            context.SaveChanges();

            }
        }
    }
