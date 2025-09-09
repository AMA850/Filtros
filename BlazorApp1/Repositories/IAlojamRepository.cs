using BlazorApp1.DATA;

namespace BlazorApp1.Repositories
{
    public interface IAlojamRepository
    {
        Task<List<Alojam>> GetAllAsync();
        Task<List<Alojam>> GetByProvinciaAsync(int thCod);
    }
}
