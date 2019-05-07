using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lab3.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult New()
        {
            return View("CustomerForm");
        }

        public IEnumerable<ApplicationUser> GetApplicationUsers()
        {
            var allUsers = _context.Users.ToList();

            for (int i = 0; i < allUsers.Count; i++)
            {
                if(Roles.GetRolesForUser(allUsers[i].UserName).Contains(RoleName.CanManageToursAndUsers))
                {
                    allUsers.Remove(allUsers[i]);
                }
            }

            return allUsers;
        }

        // GET: Users
        [Authorize(Roles = RoleName.CanManageToursAndUsers)]
        public ActionResult Index()
        {            
            return View(_context.Users.ToList());
        }
    }
}