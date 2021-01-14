using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ComicBookController:Controller
    {
        private ComicBookRepisotory _comicBookRepisotory = null;

        public ComicBookController() // constrcutor this will get all the things for comicbookrepisotory
        {
            _comicBookRepisotory = new ComicBookRepisotory(); 
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepisotory.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id) // this exepcts a id now so link will be like comicbook/dettial/? ffollowed by any id ? means null 
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepisotory.GetComicBook((int) id);
            return View(comicBook); // view will alwways return a comicbook here 
        }
    }
}