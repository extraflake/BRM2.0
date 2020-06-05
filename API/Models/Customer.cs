using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_customer")]
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [ForeignKey("RelationManager")]
        public string Relation_Manager { get; set; }
        public Employee RelationManager { get; set; }
        [ForeignKey("Districtx")]
        public int District { get; set; }
        public District Districtx { get; set; }

        public ICollection<Placement> Placements { get; set; }
    }
}
