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
