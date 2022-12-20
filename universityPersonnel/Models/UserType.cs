using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universityPersonnel.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<User?> UserTypes { get; set; }

    }
}
