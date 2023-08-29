using AutoMapper;
using CarSite.Application.ViewModels;
using CarSite.Domain.Entities;

namespace CarSite.Application.Services
{
    public class MapperService:Profile
    {
        public MapperService()
        {
            CreateMap<AddCarVM, Car>();
        }
    }
}
