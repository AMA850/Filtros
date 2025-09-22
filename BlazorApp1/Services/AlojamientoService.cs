using BlazorApp1.Components.Pages;
using BlazorApp1.DATA;
using BlazorApp1.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorApp1.Services
{
    public class AlojamientoService : IAlojamientoService
    {
        private readonly IAlojamRepository _alojamRepository;

        public AlojamientoService(IAlojamRepository alojamRepository)
        {
            _alojamRepository = alojamRepository;
        }

        public async Task<List<Alojam>> getAllAsync()
        {
            try
            {
                var response = await _alojamRepository.GetAllAsync();

                if (response == null || !response.Any())
                {
                    return new List<Alojam>();
                }
                else
                {
                    return response;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en getAllAsync: {ex.Message}");
                return new List<Alojam>();
            }
        }

        public async Task<List<Alojam>> getAlojProv(int thCod)
        {
            try
            {
                var response = await _alojamRepository.GetByProvinciaAsync(thCod);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en getAlojProv: {ex.Message}");
                return new List<Alojam>();
            }
        }
        public async Task<List<Alojam>> getAlojComarca(int comCod)
        {
            try
            {
                var response = await _alojamRepository.GetByComarca(comCod);
                return response ?? new List<Alojam>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en getAlojComarca: {ex.Message}");
                return new List<Alojam>();
            }
        }

        public async Task<List<Alojam>> getAlojByAnimals(bool dog)
        {
            try
            {
                var response = await _alojamRepository.GetByAnimals(dog);
                return response ?? new List<Alojam>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en getAlojByAnimals: {ex.Message}");
                return new List<Alojam>();
            }
        }
    }
}