using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
    {
        public static class DbInitializer
        {
            public static void Initialize(StoreContext context)
            {
            if (context.Eveniments.Any()) return;
            var events = new List<Eveniments> {
                
            };


            foreach (var ev in events)
                {
                    context.Eveniments.Add(ev);
                }

                context.SaveChanges();
            }
        }
    }
