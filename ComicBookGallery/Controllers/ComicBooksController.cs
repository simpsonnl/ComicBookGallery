using System;
using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        //? means that a null could be passed as an argument
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);

            if (comicBook == null)
            {
                return NotFound();
            }

            return View(comicBook);
        }
    }
}
