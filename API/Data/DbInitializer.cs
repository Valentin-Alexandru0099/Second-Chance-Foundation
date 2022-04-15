using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
    {
        public static class DbInitializer
        {
            public static void Initialize(StoreContext context)
            {
            if (context.Meets.Any()) return;
            if (context.Jobs.Any()) return;
            var jobs = new List<Job>
            {
                new Job
                {
                    Name="Cashier",
                    Description="We are looking for a cashier!",
                    SubmissionTime=System.DateTime.Now,
                    Available=true,
                    Organization=null,
                },
                new Job
                {
                    Name="Cashier",
                    Description="We need experienced and fast man or women for a cashier job!",
                    SubmissionTime=System.DateTime.Now,
                    Available=true,
                    Organization=null,
                },
                new Job
                {
                    Name="Carpenter",
                    Description="Looking for new personal for a small business!",
                    SubmissionTime=System.DateTime.Now,
                    Available=true,
                    Organization=null,
                }
            };
            var meets = new List<Meet> {
            };
            foreach (var job in jobs)
                {
                    context.Jobs.Add(job);
                }
            foreach (var meet in meets)
            {
                context.Meets.Add(meet);
            }
            context.SaveChanges();
            }
        }
    }
