using RpiServerAPI.DataAccess.Repository;
using RpiServerAPI.Models;

namespace RpiServerAPI.DataAccess.Abstract;

public interface IBeaconDal : IEntityRepo<Beacon>
{
}