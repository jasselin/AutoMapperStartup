using AutoMapper;
using System.Threading;
using System.Threading.Tasks;

namespace OptimizeStartup.MapperTest
{
    public class MapperFactory : IMapperFactory
    {
        private IConfigurationProvider _config;

        public MapperFactory()
        {
            _config = GetTempConfiguration();

            Task.Factory.StartNew(() => _config = GetPermanentConfiguration());
        }

        public IMapper GetMapper()
        {
            return new Mapper(_config);
        }

        private IConfigurationProvider GetTempConfiguration()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile<UserProfile>();
            });
        }

        private IConfigurationProvider GetPermanentConfiguration()
        {
            Thread.Sleep(5000);
            return new MapperConfiguration(config =>
            {
                config.AddProfile<UserProfile>();
                config.AddProfile<OtherProfile>();
            });
        }
    }
}
