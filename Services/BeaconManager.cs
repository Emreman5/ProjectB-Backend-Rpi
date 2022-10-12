using RpiServerAPI.DataAccess.Abstract;

namespace RpiServerAPI.Services;

public class BeaconManager
{
    private IBeaconDal _beaconDal;

    public BeaconManager(IBeaconDal beaconDal)
    {
        _beaconDal = beaconDal;
    }
}