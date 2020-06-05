using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{ 
    [Table("tb_tr_placement")]
    public class Placement
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Notes { get; set; }

        [ForeignKey("Employeex")]
        public string Employee{ get; set; }
        public virtual Employee Employeex { get; set; }
        [ForeignKey("Customerx")]
        public string Customer { get; set; }
        public virtual Customer Customerx { get; set; }

        public DateTimeOffset Create_Date { get; set; }
        public DateTimeOffset Start_Date { get; set; }
        public DateTimeOffset Update_Date { get; set; }


    }
}
