using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;

        public DbSet<DemoMVC.Models.Person> Person { get; set; } = default!;
        public DbSet<DemoMVC.Models.DaiLy> DaiLy_1 { get; set; } = default!;
        public DbSet<DemoMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DemoMVC.Models.Student> Student { get; set; } = default!;
    }
