using System;

using System.Data.Entity;

using UniversitySytem;

using UniversitySytem.Models;

namespace UniversitySystem.Data
{
    public class UniversitySystemDbContext: DbContext
    {
        public UniversitySystemDbContext()
            : base("UniversitySystem")
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
