using API.Entities;
using System;

namespace API.DTOs
{
    public class JobDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionTime { get; set; }

        public bool Available { get; set; }
        public Organization Organization { get; set; }
    }
}
