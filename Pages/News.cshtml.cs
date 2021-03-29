using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Pages
{
    public class NewsModel : PageModel
    {
        private readonly ILogger<NewsModel> _logger;

        public NewsModel(ILogger<NewsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

