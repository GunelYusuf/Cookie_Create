using System;
using Basket_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Basket_MVC.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<PRODUCTS1> PRODUCTS1s { get; set; }
        public DbSet<CATEGORY1> cATEGORY1s { get; set; }
    }
}
