using AutoMapper;
using CarSite.Models.ViewModels;
using ProductSIte.Models;

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
