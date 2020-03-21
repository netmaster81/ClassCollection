using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Warm :Animal
    {
        public bool IsPoisonous { get; set; }
        public Warm()
        {
            base.Name = "Warm";
        }
        public override string Stats()
        {
            return base.Stats() + $"IsPoisonous: {IsPoisonous}";
        }

    }
}
