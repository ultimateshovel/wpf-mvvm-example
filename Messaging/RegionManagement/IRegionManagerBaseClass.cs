namespace Messaging.Core.Interfaces.RegionManagement
{
    public interface IRegionManagerBaseClass<out T> where T : IRegionRequest
    {}
}