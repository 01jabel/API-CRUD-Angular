using BEAngularTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEAngularTest


{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Comentario>? Comentario { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

    }

}

