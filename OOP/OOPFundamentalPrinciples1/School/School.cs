using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private List<StudentsClass> classesInSchool;
        
        public School(StudentsClass[] studentsClasses)
        {
            this.classesInSchool = new List<StudentsClass>(studentsClasses);
        }
        public StudentsClass[] Class
        {
            get { return this.classesInSchool.ToArray(); }
            
        }
        public int Length
        {
            get { return this.classesInSchool.Count; }
        }

        public StudentsClass StudentsClass
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public void AddClass(StudentsClass studentsClass)
        {
            this.classesInSchool.Add(studentsClass);
        }
        
    }
}
