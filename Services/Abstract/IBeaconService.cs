using RpiServerAPI.Models;
using RpiServerAPI.Utilities.Results;
using IResult = RpiServerAPI.Utilities.Results.IResult;

namespace RpiServerAPI.Services.Abstract;

public interface IBeaconService
{
    public IResult AddBeacon(Beacon beacon);
    public IResult UpdateBeaconByUuid(string uuid, Beacon beacon);
    public IDataResult<List<Beacon>> GetAllBeacons();
    public IDataResult<Beacon> GetBeaconByUuid(string uuid);
    public IResult DeleteBeaconByUuid(string uuid);

}