namespace Messaging.Common.RegionManagementEvents
{
    using Core.Interfaces.RegionManagement;

    public class RegionManagerBaseClass<T> : IRegionManagerBaseClass<T> where T : IRegionRequest
    { }
}