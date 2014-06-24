using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher: Human
    {
        private List<Discipline> disciplines;
        private string comment;
        public Teacher(string name, Discipline[] disciplines)
            : base(name)  //use constructor in base class Human
        {
            this.disciplines = new List<Discipline>(disciplines);
        }
        public string Comment
        {
            get { return this.comment; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid comment!");
                }
                this.comment = value;
            }
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
        }
    
        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }
        
    }
}
