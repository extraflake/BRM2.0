using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InterviewVM
    {
        public int Id { get; set; }
        public string NIK { get; set; }
        public string Employee { get; set; }
        public string PIC { get; set; }
        public DateTimeOffset interview_datetime { get; set; }
        public string Department { get; set; }
        public string Note { get; set; }
        public string Customer { get; set; }
        public DateTimeOffset Created_By { get; set; }
        public DateTimeOffset Created_Date { get; set; }
        public DateTimeOffset Update_By { get; set; }
        public DateTimeOffset Update_Date { get; set; }
    }
}
