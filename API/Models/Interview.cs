using API.Bases;
using API.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_tr_interview_history")]
    public class Interview : BaseModel
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

        public Interview()
        {

        }

        public Interview(InterviewVM interviewVM)
        {
            this.Id = interviewVM.Id;
            this.interview_datetime = interviewVM.interview_datetime;
            this.PIC = interviewVM.PIC;
            this.Note = interviewVM.Note;
            this.Department = interviewVM.Department;
            this.Employee = interviewVM.Employee;
            this.Customer = interviewVM.Customer;
            this.Created_By = "13144";
            this.Create_Datetime = DateTimeOffset.Now;
        }

        public void Update(InterviewVM interviewVM)
        {
            this.Id = interviewVM.Id;
            this.interview_datetime = interviewVM.interview_datetime;
            this.PIC = interviewVM.PIC;
            this.Note = interviewVM.Note;
            this.Department = interviewVM.Department;
            this.Employee = interviewVM.Employee;
            this.Customer = interviewVM.Customer;
            this.Updated_By = "13144";
            this.Update_Datetime = DateTimeOffset.Now;
        }
    }
}
