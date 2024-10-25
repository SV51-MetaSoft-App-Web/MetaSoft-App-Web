
using MetaSoftAppWeb.API.Shared.Domain.Repositories;
using MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace MetaSoftAppWeb.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWOrk
{
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}