﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLocalDB.Models
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("MyDBConnectionString")
        {
            
        }

        public DbSet<Usuarios> usuariosDB { get; set; }
        public DbSet<AspNetRoles> AspNetRolesDB { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
