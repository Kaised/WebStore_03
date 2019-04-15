using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebStore.DAL.Context
{
    public class WebStoreContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public WebStoreContext(DbContextOptions<WebStoreContext> options)
            :base(options)
        {

        }
    }
}
