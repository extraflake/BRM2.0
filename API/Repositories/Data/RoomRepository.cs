using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class RoomRepository : GeneralRepository<Room, MyContext>
    {
        public RoomRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
