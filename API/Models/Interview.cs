using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_tr_interview_history")]
    public class Interview
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset interview_datetime { get; set; }
        public string PIC { get; set; }
        public string Note { get; set; }
        public string Department { get; set; }
        [ForeignKey("EmployeeID")]
        public string Employee { get; set; }
        public Employee EmployeeID { get; set; }
        [ForeignKey("CustomerID")]
        public string Customer { get; set; }
        public Customer CustomerID { get; set; }
    }
}
