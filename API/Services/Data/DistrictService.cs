using API.Models;
using API.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class DistrictService : GeneralService<District, DistrictRepository>
    {
        private readonly DistrictRepository _districtRepository;

        public DistrictService(DistrictRepository districtRepository) : base(districtRepository)
        {
            _districtRepository = districtRepository;
        }
    }
}
