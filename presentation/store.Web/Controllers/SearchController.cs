﻿using Microsoft.AspNetCore.Mvc;
using Store;

namespace store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;

        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);

            return View(books);
        }
    }
}
