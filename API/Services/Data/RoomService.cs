using API.Context;
using API.Models;
using API.Repositories;
using API.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data 
{
    public class RoomService : GeneralService<Room, RoomRepository>
    {
        public RoomService(RoomRepository roomRepository) : base(roomRepository)
        {

        }
    }
}
