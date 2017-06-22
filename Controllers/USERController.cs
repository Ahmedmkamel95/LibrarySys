using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibrarySystem.BL.LibrarySystem.ViewModel;
using LibrarySystem.DAL;
using LibrarySystem.BL.LibrarySystem.Business;
namespace LibrarySystem.Controllers
{
    public class USERController : Controller
    {
        UserBusiness user = new UserBusiness();
       
        // GET: /USER/Create
        public ActionResult Registration(int id=0)
        {
            if (id == 0)
            {
                return View(new USERVM());
            }
            else
            {
                USERVM model = user.GetUserById(id);
                return View(model);
            }
        }

        //
        // POST: /USER/Create
        [HttpPost]
        public ActionResult Registration(USERVM model)
        {
            user.registration(model);
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /USER/Edit/5
        public ActionResult login()
        {
            return View(new USERVM());
        }

        //
        // POST: /USER/Edit/5
        [HttpPost]
        public ActionResult login(USERVM model)
        {
           int check= user.login(model);
           if (check!=0)
           {
           //    TempData["id"] = model.user_id;
               return RedirectToAction("Index", "BOOK", new { id = check});
           }
           else
               return RedirectToAction("login");
 
        }

        //
       
    }
}
