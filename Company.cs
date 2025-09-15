using System;
using System.Collections.Generic;

namespace RecruitCatGirgastj.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }  
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public decimal CompanyRevenue { get; set; }
        public bool IsHiring { get; set; }
        
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
