using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUnivesity.Models;

    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUnivesity.Models.Student> Student { get; set; } = default!;

        public DbSet<ContosoUnivesity.Models.Enrollment> Enrollment { get; set; } = default!;

        public DbSet<ContosoUnivesity.Models.Course> Course { get; set; } = default!;
    }
