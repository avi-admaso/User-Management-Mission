using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.לכל משתמש יש שדות של שם פרטי, שם משפחה, שנת לידה ואימייל, השדות פרטיים, כמו כן לכל משתמש יש פונקציה שמדפיסה את הנתונים בצורה יפה.
namespace User
{
    internal class TheUser : IComparable
    {
       private string firstName;
        private string lastName;
        private int birthYear;
        private string mail;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int BirthYear { get { return birthYear; } set { birthYear = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public TheUser (string firstName , string lastName, int birthYear , string mail, string? theGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.mail = mail;   
        }
        public int CompareTo(object? obj)
        {
            TheUser compareAge = (TheUser)obj;
            if (this.birthYear < compareAge.birthYear) return 1;
            if(this.birthYear > compareAge.birthYear) return -1;
            return 0;
        }
        public virtual string printUser()
        {
            return $"{this.firstName},{this.lastName},{this.birthYear},{this.mail}";
        }
    }
}
