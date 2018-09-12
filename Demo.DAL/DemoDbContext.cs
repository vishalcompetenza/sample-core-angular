using Demo.DomainModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL
{
    public class DemoDbContext : DbContext
    {
        #region Ctor
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {

        }
        #endregion

        #region Db Tables
        public DbSet<Book> Book { get; set; }
        #endregion
    }
}
