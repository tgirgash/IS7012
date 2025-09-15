using System.Collections.Generic;

namespace RecruitCatGirgastj.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public string ExperienceNeeded { get; set; }
        public string RemoteEligible { get; set; }
        public int OpenPositions { get; set; }

        public List<Candidate> Candidates { get; set; }
    }
}
