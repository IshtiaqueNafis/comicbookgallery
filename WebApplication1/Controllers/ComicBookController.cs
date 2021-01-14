using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ComicBookController:Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            { Id=1,
              SeriesTitle = "The Amazing Spider-Man",
              IssueNumber = 700,
              DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
              Artists = new Artists[]
              { 
                  new Artists() {Role = "Script",Name = "Dan Slott"},
                  new Artists() {Role = "Pencils",Name = "Humberto Ramos"},
                  new Artists() {Role = "Inks",Name = "Victor Olazaba"},
                  new Artists() {Role = "Colors",Name = "Edgar Delgado"},
                  new Artists() {Role = "Letters",Name = "Chris Eliopoulos"},
              }
              
            };
            
            
            return View(comicBook); // view will alwways return a comicbook here 
        }
    }
}