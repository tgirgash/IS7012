using System.Collections.Generic;

namespace Exercise1.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Company> Companies { get; set; }
    }
}
