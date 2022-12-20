using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace universityPersonnel.Models
{
    public class Movement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Cause { get; set; }
        public DateTime Date { get; set; }
        public int Order { get; set; }
    }
}
