using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_asset")]
    public class Asset : BaseModel
    {
        public string Id { get; set; }
        public string Number { get; set; }

        [ForeignKey("Types")]
        public string type { get; set; }
        public virtual Type Types { get; set; }

        [ForeignKey("Participant")]
        public string employee { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
