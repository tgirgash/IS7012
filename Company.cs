using System.Collections.Generic;

namespace Exercise1.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<JobTitle> JobTitles { get; set; }
    }
}
