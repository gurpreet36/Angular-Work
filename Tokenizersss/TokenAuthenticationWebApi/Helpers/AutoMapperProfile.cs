using TokenAuthenticationWebApi.Entities;
using AutoMapper;
using TokenAuthenticationWebApi.DTOs;
using System.Text;


namespace TokenAuthenticationWebApi.Helpers
{
    public class AutoMapperProfile:Profile
    {
         public AutoMapperProfile()
        {
            //CreateMap<TblBook, BookListDto>();
            CreateMap<LoginDto, TblUser>();
            CreateMap<RegisterDto, TblUser>()
           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => Encoding.Unicode.GetBytes( src.Password)));

        }

    
    }
}