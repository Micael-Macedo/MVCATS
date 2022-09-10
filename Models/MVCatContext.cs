using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCATS.Models
{
    public class MVCatContext : DbContext
    {
        public MVCatContext(DbContextOptions<MVCatContext> options) : base(options){}

        public DbSet<Cat> Cats { get; set; }
    }
}