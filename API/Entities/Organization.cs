using System.Collections.Generic;

namespace API.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }

        public List<Job> Jobs { get; set; } = new List<Job>();
    }
}
