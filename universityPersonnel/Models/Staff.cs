using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universityPersonnel.Models
{
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }

        public string Floor { get; set; }
       
        public string PlaceBirth { get; set; }
        public string HomeAddress { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string Education { get; set; }
        public string PassportIssuedBy { get; set; }
        public int PassportId { get; set; }
      
        public DateTime DateIssuePassport { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime YearGraduation { get; set; }
        public AcademicDegree? AcademicDegree { get; set; }










    }
}
