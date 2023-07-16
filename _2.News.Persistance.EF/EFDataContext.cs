using Microsoft.EntityFrameworkCore;

namespace _2.NewsBlog.Persistanse.Ef;

public class EFDataContext : DbContext
{
    public EFDataContext(DbContextOptions<EFDataContext> option) : base(option)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder model)
    {
        base.OnModelCreating(model);
        model.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
    }
}