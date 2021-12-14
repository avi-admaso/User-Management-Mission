using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    internal class Student : TheUser
    {
        public string grade;
        public Student(string firstName, string lastName, int birthYear, string mail, string grade) : base(firstName, lastName, birthYear, mail,grade)
        {
            this.grade = grade;
        }
        public override string printUser()
        {
            return $"{ base.printUser()},{this.grade}";
        }
    }
}
