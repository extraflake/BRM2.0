using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_batch_class")]
    public class BatchClass : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
        public int Plan { get; set; }

        [ForeignKey("Employee")]
        public string trainer { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Batches")]
        public string batch { get; set; }
        public virtual Batch Batches { get; set; }

        [ForeignKey("Rooms")]
        public string room { get; set; }
        public virtual Room Rooms { get; set; }
    }
}
