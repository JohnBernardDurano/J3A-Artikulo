using ENTJAVA_Week3.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using ENTJAVA_Week3.Models.EntityManager;

namespace ENTJAVA_Week3.Controllers
{
    public class GenreController : Controller
    {
        public ActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGenre(GenreModel user)
        {
            if (ModelState.IsValid)
            {
                GenreManager um = new GenreManager();
                if (um.IsLoginNameExist(user.LoginName))
                {
                    um.AddUserGenre(user);
                    // FormsAuthentication.SetAuthCookie(user.FirstName, false);
                    return RedirectToAction("", "Home");
                }
                else
                    ModelState.AddModelError("", "User Not Found.");
            }
            return View();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UserModel userData)
        {
            UserManager um = new UserManager();
            if (um.IsLoginNameExist(userData.LoginName))
            {
                um.UpdateUserAccount(userData);
                return RedirectToAction("Index"); // Redirect to a relevant action after successful update.
            }
            // Handle the case when the login name doesn't exist, e.g., return a relevant error view.
            return RedirectToAction("LoginNameNotFound");
        }


    }
}
