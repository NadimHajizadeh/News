using _2.NewsBlog.Persistanse.Ef;
using _3.NewsBlog.EntityMap.Contracts;
namespace _2.News.Persistance.EF;




public class EFUnitOfWork : UnitOfWork
{
    private readonly EFDataContext _context;

    public EFUnitOfWork(EFDataContext context)
    {
        _context = context;
    }
    public void Complete()
    {
        _context.SaveChanges();
    }
}