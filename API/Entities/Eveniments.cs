namespace API.Entities
{
    public class Eveniments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime SubbmissionTime { get; set; }
        public Status Status { get; set; }

        public int OrganizationId { get; set; }
        

    }
}
