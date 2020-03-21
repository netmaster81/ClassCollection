using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Hedgehog : Animal
    {
        public int NoOfSpike { get; set; }
        public Hedgehog()
        {
            base.Name = "Hedgehog";
        }
        public override string Stats()
        {
            return base.Stats() + $"NoofSpike: {NoOfSpike}";
        }
    }
}
