using System;
using System.Collections.Generic;
using System.Linq;

using UniversitySystem.Data;
using UniversitySytem.Models;


namespace UniversitySystem.Client
{
    public class UniversitySystemConsoleClient
    {
        static void Main()
        {
            var dbContext = new UniversitySystemDbContext();

            var student = new Student()
            {
                FirstName = "Brigo",
                LastName = "Burov",
                Age = 78
            };

            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            var selectStudent = dbContext.Students.First();

            Console.WriteLine(selectStudent.FirstName + " " + selectStudent.LastName);
            
        }
    }
}
