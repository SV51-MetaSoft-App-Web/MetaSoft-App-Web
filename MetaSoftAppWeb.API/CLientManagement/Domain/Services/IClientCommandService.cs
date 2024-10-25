using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;

namespace MetaSoftAppWeb.API.ClientManagement.Domain.Services;

/// <summary>
/// Client command service interface
/// </summary>
public interface IClientCommandService
{
    /// <summary>
    /// Handle create client command
    /// </summary>
    /// <param name="command">The CreateClientsSourceCommand</param>
    /// <returns>
    /// The created client if successful otherwise null
    /// </returns>
    /// <see cref="CreateClientsSourceCommand"/>
    Task<Clients?> Handle(CreateClientsSourceCommand command);
}   