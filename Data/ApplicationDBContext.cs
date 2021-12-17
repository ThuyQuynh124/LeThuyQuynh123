using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeThuyQuynh123.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<LeThuyQuynh123.Models.Company> Company { get; set; }

        public DbSet<LeThuyQuynh123.Models.LTQ> LTQ { get; set; }
    }
