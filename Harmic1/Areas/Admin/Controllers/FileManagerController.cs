﻿using Microsoft.AspNetCore.Mvc;

namespace Harmic1.Areas.Admin.Controllers
{
    public class FileManagerController : Controller
    {
        [Area("Admin")]
        [Route ("/Admin/file-manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
