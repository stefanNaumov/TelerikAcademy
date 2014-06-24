using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name!");
            }
            this.name = name;
        }
        public Discipline(string name,int numberOfLectures)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name!");
            }
            if (numberOfLectures < 0)
            {
                throw new ArgumentException("Lectures cannot be a negative number!");
            }
            this.name = name;
            this.numberOfLectures = numberOfLectures;
        }
        public Discipline(string name,int numberOfLectures,int numberOFExercises)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name!");
            }
            if (numberOfLectures < 0)
            {
                throw new ArgumentException("Lectures cannot be a negative number!");
            }
            if (numberOFExercises < 0)
            {
                throw new ArgumentException("Exercises cannot be a negative number!");
            }
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOFExercises;
        }
        public string Name
        {
            get { return this.name; }
        }
        public int Lectures
        {
            get { return this.numberOfLectures; }
        }
        public int Exercises
        {
            get { return this.numberOfExercises; }
        }
    }
}
