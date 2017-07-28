using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    public class Pieces
    {
        public int value;
        public string color;
        public string name;

        public Pieces(string Color, int Value, string Name)
        {
            this.value = Value;
            this.color = Color;
            this.name = Name;
        }
    }
}
