using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_district")]
    public class District
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Province")]
        public int Province_Id { get; set; }
        public virtual Province Province { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
