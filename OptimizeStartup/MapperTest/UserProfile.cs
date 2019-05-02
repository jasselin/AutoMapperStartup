using AutoMapper;

namespace OptimizeStartup.MapperTest
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
