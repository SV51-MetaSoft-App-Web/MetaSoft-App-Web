using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Domain.Repositories;
using MetaSoftAppWeb.API.ClientManagement.Domain.Services;
using MetaSoftAppWeb.API.Shared.Domain.Repositories;

namespace MetaSoftAppWeb.API.ClientManagement.Application.Internal.CommandServices;

/// <summary>
/// Client command service
/// </summary>
/// <param name="clientRepository">ClientRepository instance</param>
/// <param name="unitOfWork">Unit of Work instance</param>
/// 
public class ClientCommandService(IClientRepository clientRepository, IUnitOfWOrk unitOfWork) : IClientCommandService
{
    /// <inheritdoc cref="IClientCommandService.Handle"/>
    public async Task<Clients?> Handle(CreateClientsSourceCommand command)
    {
        var clients = new Clients(command);
        try
        {
            await clientRepository.AddAsync(clients);
            await unitOfWork.CompleteAsync();
        }
        catch (Exception e)
        {
            return null;
        }

        return clients;
    }
}