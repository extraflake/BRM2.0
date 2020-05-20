using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_tr_employee_role")]
    public class EmployeeRole
    {
        [Key]
        public int Id { get; set; }
        public bool Is_Delete { get; set; }

        [ForeignKey("Employee")]
        public string Employee_Id { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Role")]
        public int Role_Id { get; set; }
        public virtual Role Role { get; set; }
    }
}
