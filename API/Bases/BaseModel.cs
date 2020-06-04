using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Bases
{
    public class BaseModel
    {
        public DateTimeOffset Create_Datetime { get; set; }
        public DateTimeOffset Update_Datetime { get; set; }
        //public DateTimeOffset Create_Date { get; set; }
        //public DateTimeOffset Update_Date { get; set; }

        public string Created_By { get; set; }
        public string Updated_By { get; set; }
    }
}
