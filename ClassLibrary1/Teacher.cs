using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary1
{
    class Teacher : Person
    {
        private Gender gender;

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Teacher(string name, string address, Gender gender, int salary)
        {

            if (!CheckName(name))
            {
                Name = name;
            }

            if (!CheckAddress(address))
            {
                Address = address;
            }
            this.gender = gender;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Gender: {gender}, Salary: {Salary}";
        }

        protected bool Equals(Teacher other)
        {
            return salary == other.salary;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Teacher) obj);
        }

        public override int GetHashCode()
        {
            return salary;
        }
    }
}
