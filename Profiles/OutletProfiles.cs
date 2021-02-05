using AutoMapper;
using WebsiteAPI.Dtos;
using WebsiteAPI.Models;

namespace WebsiteAPI.Profiles
{
    public class OutletProfiles : Profile
    {
       public OutletProfiles()
       {
           //source -> target
           CreateMap<Outlet, OutletReadDtos>();
           CreateMap<OutletCreateDtos, Outlet>();
            CreateMap<OutletUpdateDtos, Outlet>();

       }
    }
}