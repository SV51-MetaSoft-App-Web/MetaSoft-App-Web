using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Queries;

namespace MetaSoftAppWeb.API.ClientManagement.Domain.Services;

/// <summary>
/// Client query service interface
/// </summary>
public interface IClientQueryService
{
    /// <summary>
    /// Handle get client by id query
    /// </summary>
    /// <param name="query">GetClientsByIdQuery query</param>
    /// <returns>
    /// The client if successful otherwise null
    /// </returns>
    /// <see cref="GetClientByIdQuery"/>
    Task<Clients?> Handle(GetClientByIdQuery query);
}