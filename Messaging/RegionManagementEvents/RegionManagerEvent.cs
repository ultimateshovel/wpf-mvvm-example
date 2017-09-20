namespace Messaging.Common.RegionManagementEvents
{
    using Core.Interfaces.RegionManagement;
    using Prism.Events;

    public class RegionManagerEvent<TValue> : PubSubEvent<IRegionManagerBaseClass<TValue>> where TValue : IRegionRequest
    { }
}