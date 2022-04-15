using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
    {
        public static class DbInitializer
        {
            public static void Initialize(StoreContext context)
            {
            if (context.Events.Any()) return;
            var events = new List<Events> {
                
            };


            foreach (var ev in events)
                {
                    context.Events.Add(ev);
                }

                context.SaveChanges();
            }
        }
    }
