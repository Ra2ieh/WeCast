

namespace WeCast.Infrastructure.SeedOfWork;

public class UnitOfWork : IUnitOfWork
{

    private readonly WeCastDbContext _context;
    //private readonly Lazy<ITripRepository> _tripRepository;

    public UnitOfWork(WeCastDbContext context)
    {
        _context = context;
      //  _tripRepository = new Lazy<ITripRepository>(() => new TripRepository(_context));
    }

   // public ITripRepository TripRepository => _tripRepository.Value;
}
