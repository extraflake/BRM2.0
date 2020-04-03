using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_batch")]
    public class Batch : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTimeOffset Start_Date { get; set; }
        public DateTimeOffset End_Date { get; set; }
    }
}
