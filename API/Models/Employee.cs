using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_employee")]
    public class Employee : BaseModel
    {
        [Key]
        [ForeignKey("User")]
        public string NIK { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("District")]
        public int Hiring_Location { get; set; }
        public virtual District District { get; set; }

        public ICollection<Placement> Placements { get; set; }
    }
}
