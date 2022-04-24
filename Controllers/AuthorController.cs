using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVC_Web_Application.Models;

namespace MVC_Web_Application.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult AuthorList()
        {
            List<Author> list = new List<Author>()
            {
            new Author { authorId = 22, authorName = "ShivajiSawant", authorBookName = "Mrityunjay" },
            new Author { authorId = 33, authorName = "IravatiKarwe", authorBookName = "Mahabharat" },
            new Author { authorId = 44, authorName = "Achyut Godbole", authorBookName = "Poetry" },
            new Author { authorId = 77, authorName = "Salim Ali", authorBookName = "BirdView" },
            };
            ViewBag.Author = list;
            return View();
        }
    }
}
