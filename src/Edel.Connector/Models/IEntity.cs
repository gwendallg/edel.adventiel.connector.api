namespace Edel.Connector.Models
{
    public interface IEntity : IMetadataeable
    {
       string Id { get; set; }
    }
}