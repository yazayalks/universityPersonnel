using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universityPersonnel.Models
{
    public class EmploymentBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string JobTitle { get; set; }
        public string ReasonDismissal { get; set; }
        public List<Staff?> EmploymentBooks { get; set; }
    }
    
}
