using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Resources;

namespace MetaSoftAppWeb.API.ClientManagement.Interfaces.REST.Transform;

/// <summary>
/// Assembler to create a client resource from an entity
/// </summary>
public static class ClientResourceFromEntityAssembler
{
    /// <summary>
    /// Converts a <see cref="Clients"/> entity to a <see cref="ClientResource"/>
    /// </summary>
    /// <param name="entity">The <see cref="Clients"/> entity</param>
    /// <returns>
    /// A <see cref="ClientResource"/> resource
    /// </returns>
    public static ClientResource ToResourceFromEntity(Clients entity)
    {
        return new ClientResource(entity.Id,entity.PersonName, entity.Dni, entity.Email, entity.BusinessName, entity.Phone, entity.Address, entity.Country, entity.City, entity.Ruc);
    }
}       