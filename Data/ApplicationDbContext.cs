using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTest.Models;

namespace MvcTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTest.Models.NguyenQuocAnh> NguyenQuocAnh { get; set; } = default!;
    }
}
