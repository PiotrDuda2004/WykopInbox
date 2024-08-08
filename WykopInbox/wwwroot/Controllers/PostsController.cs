using Microsoft.AspNetCore.Mvc;

namespace WykopInbox.wwwroot.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
