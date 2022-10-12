using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Review_Project.Models;

namespace Review_Project.Data
{
    public class Review_ProjectContext : DbContext
    {
        public Review_ProjectContext (DbContextOptions<Review_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Review_Project.Models.ReviewModel> ReviewModel { get; set; } = default!;
    }
}
