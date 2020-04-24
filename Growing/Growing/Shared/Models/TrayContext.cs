﻿using Growing.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Growing.Server.DataAccess
{
    public class TrayContext : DbContext
    {
        public virtual DbSet<Tray> tblTray { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseMySql("server=localhost;database=growing;user=root;password=\"#F3tw01pl3z*\";persistsecurityinfo = True");
            }
        }
    }
}
