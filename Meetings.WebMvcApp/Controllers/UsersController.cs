using Meetings.WebMvcApp.Models;
using Meetings.WebMvcApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.WebMvcApp.Controllers
{
    public class UsersController : Controller
    {
        private UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        // GET: UsersController
        public async Task<ActionResult<List<UserView>>> Index()
        {
            List<UserView> users = await _userService.GetAll();

            if (users == null)
            {
                //Serilog.Log.Warning($"Trainer with Id {id} doesn't exist!");
                return RedirectToAction("EmptyList");
            }

            return View(users);
        }

        // GET: UsersController/Details/5
        public async Task<ActionResult<UserView>> Details(int id)
        {
            var model = await _userService.GetById(id);

            if (model == null)
                return RedirectToAction("EmptyList");

            return View(model);
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserView model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var user = await _userService.Create(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public async Task<ActionResult<UserView>> Edit(int id)
        {
            var model = await _userService.GetById(id);
            if (model == null)
            {
                return RedirectToAction("EmptyList");
            }
            return View(model);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserView  model)
        {
            try
            {
                
                if (model == null)
                    return RedirectToAction("EmptyList");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public async Task<ActionResult<UserView>> Delete(int id)
        {
            var model = await _userService.GetById(id);
            if (model == null)
            {
                return RedirectToAction("EmptyList");
            }
            return View(model);
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, UserView model)
        {
            try
            {
                var check = await _userService.Delete(id, model);

                if (check == false)
                {
                    return RedirectToAction("EmptyList");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EmptyList()
        {
            return View();
        }
    }
}
