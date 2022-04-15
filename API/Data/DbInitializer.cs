using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
    {
        public static class DbInitializer
        {
            public static void Initialize(StoreContext context)
            {
            if (context.Event.Any()) return;
            var events = new List<Event> {
                
            };

            foreach (var ev in events)
                {
                    context.Event.Add(ev);
                }

                context.SaveChanges();
            }
        }
    }
