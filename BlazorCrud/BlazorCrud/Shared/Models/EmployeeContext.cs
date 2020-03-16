﻿using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class TrayContext : DbContext
    {
        public virtual DbSet<Tray> tblTray { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseMySql("server=localhost;database=growing;user=admin;password=;persistsecurityinfo = True");
            }
        }
    }
}
