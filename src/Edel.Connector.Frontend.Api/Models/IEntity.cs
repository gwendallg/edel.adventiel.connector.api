namespace Edel.Connector.Api.Models
{
    public interface IEntity : IMetadataeable
    {
       string Id { get; set; }
    }
}