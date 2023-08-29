using AutoMapper;
using CarSite.Domain.Entities;
using CarSite.Models.ViewModels;

namespace CarSite.Services
{
    public class MapperService:Profile
    {
       public MapperService() 
        {
            CreateMap<AddCarVM,Car>();
        }
    }
}
