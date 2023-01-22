using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Infinite.DogStore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("MyConn")
        {
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }
    }
}