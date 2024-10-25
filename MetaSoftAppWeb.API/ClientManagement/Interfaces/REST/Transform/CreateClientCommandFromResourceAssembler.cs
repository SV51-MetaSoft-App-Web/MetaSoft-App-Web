using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Resources;

namespace MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Transform;

/// <summary>
/// Assembler to create a client command from a resource
/// </summary>
public static class CreateClientCommandFromResourceAssembler
{
    /// <summary>
    /// Converts a <see cref="CreateClientResource"/> to a <see cref="CreateClientsSourceCommand"/>
    /// </summary>
    /// <param name="resource">The <see cref="CreateClientResource"/> resource</param>
    /// <returns>
    /// A <see cref="CreateClientsSourceCommand"/> command
    /// </returns>
    public static CreateClientsSourceCommand ToCommandFromResource(CreateClientResource resource)
    {
        return new CreateClientsSourceCommand(resource.PersonName, resource.Dni, resource.Email, resource.BusinessName, resource.Phone, resource.Address, resource.Country, resource.City, resource.Ruc);
    }
}