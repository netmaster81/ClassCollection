using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Dog:Animal
    {
        public string DogKind { get; set; }
        public Dog()
        {
            base.Name = "Dog";
        }
        public Dog(double age, double weight, string gender, string dogkind) : base ("Dog", age, weight, gender)
        {
            this.DogKind = dogkind;
        }
        public override string Stats()
        {
            return base.Stats() + $" DogKind: {DogKind}";
            //return $"DogKind: {DogKind}";
        }
        public string PrintHelloImSon()
        {
            return "Helloooo Father";
        }
    }
}
