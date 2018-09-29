namespace Core.Common.Core
{
    using System.Runtime.Serialization;

    [DataContract]
    public abstract class EntityBase : IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
