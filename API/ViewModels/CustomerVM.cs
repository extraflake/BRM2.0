using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class CustomerVM
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string rm { get; set; }
        public string empid { get; set; }
        public string district { get; set; }
        public string phone_relation_manager { get; set; }
    }
}
