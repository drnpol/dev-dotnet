using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEV.Learn.Tutorials.RazorPages.Models;

namespace DEV.Learn.Tutorials.RazorPages.Data
{
    public class DEVLearnTutorialsRazorPagesContext : DbContext
    {
        public DEVLearnTutorialsRazorPagesContext (DbContextOptions<DEVLearnTutorialsRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<DEV.Learn.Tutorials.RazorPages.Models.Movie> Movie { get; set; } = default!;
    }
}
