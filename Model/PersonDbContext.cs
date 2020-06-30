using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dockertraining_copose_jonatan_uscanga.Model
{
    public class PersonDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PersonDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql("Server=database_container;Port=3306;Database=Persons;Uid=admin;Pwd=test");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
