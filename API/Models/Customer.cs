using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_customer")]
    public class Customer : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [ForeignKey("Employee")]
        public string RelationManager { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("District")]
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}
