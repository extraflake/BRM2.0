using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class CustomerVM
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string relation_manager { get; set; }
        public string employee_id { get; set; }
        public int district_id { get; set; }

        public string district { get; set; }
        public string phone_relation_manager { get; set; }
    }
}
