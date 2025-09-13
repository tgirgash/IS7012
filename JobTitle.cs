using System.Collections.Generic;

namespace Exercise1.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Candidate> Candidates { get; set; }
    }
}
