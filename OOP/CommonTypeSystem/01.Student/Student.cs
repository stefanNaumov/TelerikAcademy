using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 01 - Define a class Student, which contains data about a student – first, 
//middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
//Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//02 - Add implementations of the ICloneable interface. 
//The Clone() method should deeply copy all object's fields into a new object of type Student.

//03 - Implement the  IComparable<Student> interface to compare students by names 
//(as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace Student
{
    public class Student: ICloneable,IComparable<Student>
    {
        private string firstName;
        private string sirName;
        private string lastName;
        private string ssn;
        private string address;
        private string email;
        private string phone;
        private string course;
        private Speciality speciality;
        private Faculty faculty;
        private University university;
        //constructors
        public Student()
        {

        }
        public Student(string firstName, string sirName, string lastName, string ssn, string address, string email, string phone, string course,
                        Speciality speciality, Faculty faculty, University university)
        {
            this.firstName = firstName;
            this.sirName = sirName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.course = course;
            this.speciality = speciality;
            this.faculty = faculty;
            this.university = university;
        }
        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.firstName = value;
            }
        }
        public string SirName
        {
            get { return this.sirName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.sirName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                this.lastName = value;
            }
        }
        public string SSN
        {
            get { return this.ssn; }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Not a valid SSN! SSN consist of 11 numbers!");
                }
                this.ssn = value;
            }
        }
        public string Address
        {
            get { return this.address; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.address = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (ValidateMail(value) == true)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid e-mail!");
                }
            }
        }
        public string Phone
        {
            get { return this.phone; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid phone!");
                }
                this.phone = value;
            }
        }
        public string Course
        {
            get { return this.course; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid course!");
                }
                this.course = value;
            }
        }
        public Speciality Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }
        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        //overriding System.Object methods
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (Object.Equals(this.ssn,student.ssn))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.ssn.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Student Name: " + this.firstName + " " + this.lastName + "SSN: " + this.ssn);

            if (!(String.IsNullOrWhiteSpace(this.course)))
            {
                info.AppendLine("Student Course: " + this.course); 
            }
            if (!(String.IsNullOrWhiteSpace(this.speciality.ToString())))
            {
                info.AppendLine("Speciality: " + this.speciality); 
            }
            if (!(String.IsNullOrWhiteSpace(this.faculty.ToString())))
            {
                info.AppendLine("Faculty: " + this.faculty); 
            }
            if (!(String.IsNullOrWhiteSpace(this.university.ToString())))
            {
                info.AppendLine("University: " + this.university); 
            }
            if (!(String.IsNullOrWhiteSpace(this.address)))
            {
                info.AppendLine("Student Adress: " + this.address); 
            }
            if (!(String.IsNullOrWhiteSpace(this.phone)))
            {
                info.AppendLine("Student Phone: " + this.phone); 
            }
            if (!(String.IsNullOrWhiteSpace(this.email)))
            {
                info.AppendLine("Student E-mail: " + this.email); 
            }
            return info.ToString();
        }
        //override operators == and !=
        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(Student first, Student second)
        {
            return !(first.Equals(second));
        }
        //Task 02 - implement the IClonable interface
        public Student Clone()
        {
            Student newStudent = new Student(this.firstName, this.sirName, this.lastName, this.ssn, this.address, this.email, this.phone, this.course,
                                this.speciality, this.faculty, this.university);
            return newStudent;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }
        //Task 03 - Implement the IComparable interface
        public int CompareTo(Student student)
        {
            if (this.firstName != student.firstName)
            {
                return this.firstName.CompareTo(student.firstName);
            }
            else
            {
                if (this.ssn != student.ssn)
                {
                    return this.ssn.CompareTo(student.ssn);
                }
            }
            return 0;
        }
        //method for validating e-mail
        static bool ValidateMail(string value)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
