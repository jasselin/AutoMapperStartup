using AutoMapper;

namespace OptimizeStartup.MapperTest
{
    public class OtherProfile : Profile
    {
        public OtherProfile()
        {
            CreateMap<OtherClass, OtherViewModel>();
        }
    }
}
