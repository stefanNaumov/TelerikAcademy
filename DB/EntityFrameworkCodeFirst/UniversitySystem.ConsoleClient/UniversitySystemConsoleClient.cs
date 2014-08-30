using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UniversitySystem.Data;
using UniversitySystem.Data.Migrations;
using UniversitySytem.Models;

namespace UniversitySystem.ConsoleClient
{
    class UniversitySystemConsoleClient
    {
        static void Main(string[] args)
        {
            var dbContext = new UniversitySystemDbContext();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UniversitySystemDbContext>());

            using (dbContext)
            {
                var student = new Student()
                   {
                       FirstName = "Eptar",
                       LastName = "Burov",
                       Age = 78
                   };

                dbContext.Students.Add(student);
                dbContext.SaveChanges();

                var selectStudent = dbContext.Students.First();

                Console.WriteLine(selectStudent.FirstName + " " + selectStudent.LastName);

                for (int i = 0; i < 5; i++)
                {
                    Student newStudent = new Student()
                    {
                        FirstName = "Pero the " + (i + 1) + " th"
                    };
                    dbContext.Students.Add(newStudent);
                }

                dbContext.SaveChanges(); 
            }
        }
    }
}
