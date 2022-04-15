using System;

namespace API.Entities
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionTime { get; set; }
        public Status Status { get; set; }
        public int OrganizationId { get; set; }
        

    }
}
