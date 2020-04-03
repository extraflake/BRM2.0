using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_participant")]
    public class Participant : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Grade { get; set; }

        [ForeignKey("BatchClass")]
        public string batch_class { get; set; }
        public virtual BatchClass BatchClass { get; set; }
    }
}
