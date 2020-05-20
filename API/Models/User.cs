using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_account")]
    public class User 
    {
        [Key]
        public string Id { get; set; }
        public string Password { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
