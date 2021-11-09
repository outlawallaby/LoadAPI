using AutoMapper;
using LoadAPI.Dtos;
using LoadAPI.Models;

namespace LoadAPI.Profiles
{
    public class LoadsProfile:Profile
    {
        public LoadsProfile()
        {
            //Sourse -> Target
            CreateMap<Load, LoadReadDto>();
            CreateMap<LoadCreateDto, Load>();
            CreateMap<LoadUpdateDto,Load>();
        }
    }
}