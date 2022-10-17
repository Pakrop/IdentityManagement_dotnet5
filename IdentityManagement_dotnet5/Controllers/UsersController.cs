using IdentityManagement_dotnet5.Models;
using IdentityManagement_dotnet5.Repos;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManagement_dotnet5.Controllers
{
    public class UsersController : Controller
    {
        private readonly IRepos<User, int> repos;

        public IActionResult Index()
        {
            return View();
        }
    }
}
