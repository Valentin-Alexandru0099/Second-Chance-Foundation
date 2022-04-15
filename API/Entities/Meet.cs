using System;

namespace API.Entities
{
    public class Meet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }

    }
}
