using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universityPersonnel.Models
{
    public class Encouragement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Order { get; set; }
      
        public List<Staff?> Encouragements { get; set; }
        public EncouragementType? EncouragementType { get; set; }

    }
}
