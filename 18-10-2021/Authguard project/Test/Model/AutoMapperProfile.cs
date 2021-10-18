using Test.Model;
using AutoMapper;

namespace Test.Model
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AccountDTO,Account>();
            //If there are more classes to automap then it will
            //be added here only.
        }
    }
}