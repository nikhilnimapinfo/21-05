﻿using System.Data.Entity;

namespace ConsoleApp2
{
    partial class Program
    {
        public class PlutoContext : DbContext
        {
            public PlutoContext()
                : base("name=PlutoContext")
            {
            }

            public virtual DbSet<Author> Authors { get; set; }
            public virtual DbSet<Course> Courses { get; set; }
            public virtual DbSet<Tag> Tags { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new CourseConfiguration());
            }
        }
    }
}
