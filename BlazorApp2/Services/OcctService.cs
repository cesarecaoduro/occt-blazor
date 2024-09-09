using Occt;
using System.Runtime.CompilerServices;

namespace BlazorApp2.Services
{
    public class OcctService : IOcctService
    {
        private readonly ILogger<OcctService> _logger;

        public OcctService(ILogger<OcctService> logger)
        {
            _logger = logger;  
            Initialize();
        }

        [ModuleInitializer]
        public static void Initialize()
        {
            OcctConfiguration.Configure();
        }

        public string Version => $"{Occt.Version.Major}.{Occt.Version.Minor}.{Occt.Version.Maintenance}";
    }
}
