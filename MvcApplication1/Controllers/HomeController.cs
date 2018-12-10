using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using Newtonsoft.Json;
using Trirand.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            BookGrid bookGrid = new BookGrid();

            return View(bookGrid);
        }

        [HttpGet]
        public string GetData(string jqGridID, bool _search, string nd, int rows, int page, string sidx, string sord)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Id = 1, Author = "sd", Name = "sdsd", Price = 130, Year = 1222 });
            books.Add(new Book { Id = 2, Author = "sd1", Name = "sdsd1", Price = 1301, Year = 12221 });
            books.Add(new Book { Id = 3, Author = "sd2", Name = "sdsd2", Price = 1302, Year = 12222 });
            books.Add(new Book { Id = 4, Author = "sd3", Name = "sdsd3", Price = 1303, Year = 12232 });
            books.Add(new Book { Id = 5, Author = "sd4", Name = "sdsd4", Price = 1304, Year = 12224 });

            return JsonConvert.SerializeObject(books);
        }


    }
}
