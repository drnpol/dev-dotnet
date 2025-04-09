using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEV.Learn.Tutorials.MVC.Models;

namespace DEV.Learn.Tutorials.MVC.Data
{
    public class DEVLearnTutorialsMVCContext : DbContext
    {
        public DEVLearnTutorialsMVCContext (DbContextOptions<DEVLearnTutorialsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DEV.Learn.Tutorials.MVC.Models.Movie> Movie { get; set; } = default!;
    }
}
