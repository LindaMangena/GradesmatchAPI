using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GradesmatchAPI.Models.Data
{
    public class GradesmatchContext : DbContext
    {

        public GradesmatchContext(DbContextOptions<GradesmatchContext> options) : base(options)
        {

        }

        public DbSet<Student>? Students { get; set; }



    }
}