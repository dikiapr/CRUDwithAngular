using CRUDwithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwithAngular.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
