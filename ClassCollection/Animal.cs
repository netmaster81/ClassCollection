using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Animal
    {
        public string Name { get; set; }        
        public string Gender { get; set; }        
        public double Age { get; set; }
        public double Weight { get; set; }

        public Animal()
        {

        }
        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal(string name, double age, double weight, String gender)
        {
            this.Name = name; this.Age = age; this.Weight = weight; this.Gender = gender;
        }
        public virtual String Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Gender :{Gender}";
        }

        public string PrintHelloImFather()
        {
            return "My Son:) I am your Father ";
            //return PrintHelloImSon();
        }


    }
}
