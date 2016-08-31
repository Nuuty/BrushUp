using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class Student : Person
    {   
        private int semester;

        public int Semester
        {
            get { return semester; }
            set
            {
                if (CheckSemester(value))
                semester = value;
            }
        }
        
        private Gender gender;

        public Student(string name, string address, int semester, Gender gender)
        {
            if (CheckName(name))
            {
                Name = name;
            }
            if (CheckAddress(address))
            {
                Address = address;
            }
            if (CheckSemester(semester))
            {
                Semester = semester;
            }
            this.gender = gender;
        }

        /// <summary>
        /// Checker om semester værdien er mellem 1 og 8
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckSemester(int value)
        {
            if (value < 1 || value > 8) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Gender: {gender}, Semester: {Semester}";
        }

        protected bool Equals(Student other)
        {
            return semester == other.semester;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Student) obj);
        }

        public override int GetHashCode()
        {
            return semester;
        }
    }
}
