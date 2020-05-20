using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_room")]
    public class Room : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
