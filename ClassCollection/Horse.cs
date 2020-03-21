using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class Horse:Animal
    {
        public string HoursKind { get; set; }
        public Horse()
        {
            base.Name = "Horse";
        }

        public override string Stats()
        {
            return base.Stats() + $"HoursKind: {HoursKind}";
        }
    }

}
