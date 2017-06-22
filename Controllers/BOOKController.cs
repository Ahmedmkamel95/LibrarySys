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
    public class BOOKController : Controller
    {
        BOOKBusiness book = new BOOKBusiness();
        ReservationBusiness resv = new ReservationBusiness();

        //

        // GET: /BOOK/
        public ActionResult Index(int id=0)
        {
            int x = id;
            
            var model = book.RetrivealBooks();
             return View(model);

        }



        //
        // GET: /BOOK/Create
        public ActionResult SaveBook(int id = -1)
        {
            if (id == -1)
            {
                return View(new BOOKVM());
            }
            
            var model = book.GetBookById(id);

            return View(model);
        }

        //
        // POST: /BOOK/Create
        [HttpPost]
        public ActionResult SaveBook(BOOKVM model)
        {
            book.SaveBook(model);
            return RedirectToAction("Index");


        }

        //
        // GET: /BOOK/Delete/5
        public ActionResult Delete(int id)
        {
            book.DeleteBook(id);
            return RedirectToAction("Index");
        }


        public ActionResult Search(string ah)
        {
            var b = book.Search(ah);
            return View("Search", b);
        }
    }

}
