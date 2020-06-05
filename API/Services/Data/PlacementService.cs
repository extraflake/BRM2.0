using API.Models;
using API.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Data
{
    public class PlacementService : TransactionService<Placement, PlacementRepository>
    {
        private readonly PlacementRepository _placementRepository;

        public PlacementService(PlacementRepository placementRepository) : base(placementRepository)
        {
            _placementRepository = placementRepository;
        }
    }
}
