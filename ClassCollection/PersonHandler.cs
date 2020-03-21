using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class PersonHandler
    {
        public static void SetAge(Person press, int age)
        {
            press.Age = age;
        }
        public static Person CreatPerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age; p.FName = fname; p.LNname = lname; p.Height = height; p.Weight = weight;
            return p;
        }
        public static Person CreatPerson(string fname, string lname)
        {
            Person p = new Person();
            p.FName = fname; p.LNname = lname;
            return p;
        }
        public static Person CreatPerson(int age, string fname, string lname)
        {
            Person p = new Person();
            p.Age = age; p.FName = fname; p.LNname = lname;
            return p;
        }
        public static Person CreatPerson(string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            p.FName = fname; p.LNname = lname; p.Height = height; p.Weight = weight;
            return p;
        }
    }
   
}
