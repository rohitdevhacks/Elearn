using Microsoft.EntityFrameworkCore;
using onl.Models;
using System.Collections.Generic;

namespace onl.Data
{
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
     
             public DbSet<Course> Courses { get; set; }
            public DbSet<Upload> Uploads { get; set; }
    }
    }
