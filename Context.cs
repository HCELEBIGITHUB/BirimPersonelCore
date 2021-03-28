﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirimPersonelCoreMVC.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HIDIRCELEBI; database=BirimCore_MVC;integrated security=true;");
        }

        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }

    }
}
