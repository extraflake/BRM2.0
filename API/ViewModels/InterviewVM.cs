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
        public string Created_By { get; set; }
        public DateTimeOffset? Create_Datetime { get; set; }
        public string Updated_By { get; set; }
        public DateTimeOffset? Update_Datetime { get; set; }
    }
}
