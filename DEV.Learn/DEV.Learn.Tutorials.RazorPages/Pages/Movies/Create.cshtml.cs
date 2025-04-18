﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DEV.Learn.Tutorials.RazorPages.Data;
using DEV.Learn.Tutorials.RazorPages.Models;

namespace DEV.Learn.Tutorials.RazorPages.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly DEV.Learn.Tutorials.RazorPages.Data.DEVLearnTutorialsRazorPagesContext _context;

        public CreateModel(DEV.Learn.Tutorials.RazorPages.Data.DEVLearnTutorialsRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movie == null || Movie == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
