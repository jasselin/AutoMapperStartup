using System.Diagnostics;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OptimizeStartup.MapperTest;
using OptimizeStartup.Models;

namespace OptimizeStartup.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = new User(1, "Carl", "Jackson", "carl@carljackson.io");
            var model = _mapper.Map<UserViewModel>(user);

            model.MapperName = _mapper.ConfigurationProvider.GetAllTypeMaps().Count().ToString();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
