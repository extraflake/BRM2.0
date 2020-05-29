using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class EmployeeRoleVM
    {
        public int Id { get;set; }
        public int Role { get;set; }
        public string Name { get;set; }
        public string NIK { get;set; }
        public string role_name { get;set; }
    }
}
