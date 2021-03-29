using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class RegistrationDBContext : DbContext
    {
        public RegistrationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<PersonModel> Persons { get; set; }
    }
}
