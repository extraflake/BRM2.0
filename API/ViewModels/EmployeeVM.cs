using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class EmployeeVM
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string phone { get; set; }
        public bool is_deleted { get; set; }
        public DateTime create_date { get; set; }
    }
}
