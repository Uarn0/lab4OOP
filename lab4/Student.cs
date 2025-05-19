using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EnrollmentYear { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, int enrollmentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            EnrollmentYear = enrollmentYear;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({EnrollmentYear})";
        }
    }
}
