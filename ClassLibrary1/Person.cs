using System;

namespace ClassLibrary1
{
    public enum Gender
    {
        Male,
        Female
    };
    public class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set
            {
                if (CheckName(value))
                    name = value;
            }
        }

        private String address = "default";

        public String Address
        {
            get { return address; }
            set
            {
                if (CheckAddress(value))
                address = value;
            }
        }

        /// <summary>
        /// Checker om addresen er null eller empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckAddress(string value)
        {
            if (String.IsNullOrEmpty(value)) return false;
            return true;
        }

        /// <summary>
        /// Checker om navnet er mindre end 1 char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckName(string value)
        {
            if (value.Length < 2) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }

        protected bool Equals(Person other)
        {
            return string.Equals(name, other.name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            return (name != null ? name.GetHashCode() : 0);
        }
    }
}