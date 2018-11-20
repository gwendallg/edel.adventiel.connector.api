namespace Edel.Connector.Api.Models
{
    /// <summary>
    /// scope of resource
    /// </summary>
    public enum ScopeType
    {
        /// <summary>
        /// read resource
        /// </summary>
        Read = 0,
        /// <summary>
        /// create resource
        /// </summary>
        Create = 2,
        /// <summary>
        /// update resource
        /// </summary>
        Update = 4,
        /// <summary>
        /// delete resource
        /// </summary>
        Delete = 8
    }
}