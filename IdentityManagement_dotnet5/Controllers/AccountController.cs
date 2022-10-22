using IdentityManagement_dotnet5.Models;
using IdentityManagement_dotnet5.Repos;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManagement_dotnet5.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepos<User, int> _repos;

        public AccountController(IRepos<User, int> repos)
        {
            _repos = repos;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
