using BlazorApp1.DATA;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class AlojamRepository : IAlojamRepository
    {
        private readonly ApplicationDbContext _context;

        public AlojamRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Alojam>> GetAllAsync()
        {
            return await _context.alojam.ToListAsync();
        }


        public async Task<List<Alojam>> GetByProvinciaAsync(int thCod)
        {
            return await _context.alojam
                                 .Where(a => a.THCod == thCod)
                                 .ToListAsync();
        }

    }
}
