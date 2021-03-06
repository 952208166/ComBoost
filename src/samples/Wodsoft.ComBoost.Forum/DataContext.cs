﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wodsoft.ComBoost.Data.Entity;
using Wodsoft.ComBoost.Forum.Entity;

namespace Wodsoft.ComBoost.Forum
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=10.0.0.253;database=ComBoostForum;uid=sa;pwd=123@abc");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Board> Board { get; set; }

        public DbSet<Member> Member { get; set; }

        public DbSet<Entity.Forum> Forum { get; set; }

        public DbSet<Thread> Thread { get; set; }

        public DbSet<Post> Post { get; set; }
    }
}
