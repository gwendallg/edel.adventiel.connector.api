namespace Edel.Connector.Entities
{
    public interface IEntity : IMetadataeable
    {
       string Id { get; set; }
    }
}