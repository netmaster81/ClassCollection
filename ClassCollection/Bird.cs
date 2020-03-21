using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Bird : Animal
    {
        public string BirdKind { get; set; }
        public Bird()
        {
            base.Name = "Bird";
        }
        public override string Stats()
        {
            return base.Stats() + $"BirdKind: {BirdKind}";
        }
    }
}
