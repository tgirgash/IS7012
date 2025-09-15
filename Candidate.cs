using System;

namespace RecruitCatGirgastj.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; } 

        public string Email { get; set; }
        public int YearsExperience { get; set; }
        public bool HasCurrentPosition { get; set; }

        public int? CompanyId { get; set; }   
        public Company Company { get; set; }

        public int JobTitleId { get; set; }   
        public JobTitle JobTitle { get; set; }

        public int IndustryId { get; set; }   
        public Industry Industry { get; set; }
    }
}
