﻿using BlazorApp1.DATA;

namespace BlazorApp1.Services
{
    public interface IAlojamientoService
    {
        
        Task<List<Alojam>> getAllAsync();
        Task<List<Alojam>> getAlojProv(int THCod);
    }
}
