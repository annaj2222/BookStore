using Books.Data.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Books.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class FriendStoreController : Controller
    {
        private readonly TheirDbContext _theirDbContext;

        public FriendStoreController(TheirDbContext theirDbContext)
        {
            _theirDbContext = theirDbContext;
        }

        public IActionResult Index()
        {
            var theirBooks = _theirDbContext.Books.ToList();

            return View(theirBooks);
        }
    }
}
