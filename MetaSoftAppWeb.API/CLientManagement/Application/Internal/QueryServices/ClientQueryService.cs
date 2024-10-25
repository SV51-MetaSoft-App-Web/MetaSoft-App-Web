
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Queries;
using MetaSoftAppWeb.API.ClientManagement.Domain.Repositories;
using MetaSoftAppWeb.API.ClientManagement.Domain.Services;

/// <summary>
/// Query service for clients
/// </summary>
/// <param name="clientRepository">ClientRepository instance</param>
public class ClientQueryService(IClientRepository clientRepository) : IClientQueryService
{
    /// <inheritdoc cref="IClientQueryService.Handle(GetClientByIdQuery)"/>
    public async Task<Clients?> Handle(GetClientByIdQuery query)
    {
        return await clientRepository.FindByIdAsync(query.Id);
    }
}