﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DEV.Learn.Tutorials.RazorPages.Data;
using DEV.Learn.Tutorials.RazorPages.Models;

namespace DEV.Learn.Tutorials.RazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly DEV.Learn.Tutorials.RazorPages.Data.DEVLearnTutorialsRazorPagesContext _context;

        public IndexModel(DEV.Learn.Tutorials.RazorPages.Data.DEVLearnTutorialsRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
