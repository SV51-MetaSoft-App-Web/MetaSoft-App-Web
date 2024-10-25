
using MetaSoftAppWeb.API.ClientManagement.Domain.Model.Commands;
using MetaSoftAppWeb.API.ClientManagement.Domain.Repositories;
using MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace MetaSoftAppWeb.API.ClientManagement.Infrastructure.Persistence.EFC.Repositories;

public class ClientRepository(AppDbContext context)
: BaseRepository<Clients>(context), IClientRepository
{
    
}