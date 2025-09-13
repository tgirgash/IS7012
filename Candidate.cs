namespace Exercise1.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
