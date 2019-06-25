using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Generator
{
    public class PieceOfClothing
    {
        public PieceOfClothing(string category, string circumstance, string name)
        {
            Category = category;
            Circumstance = circumstance;
            Name = name;
        }

        public string Name { get; set; }
        public string Circumstance { get; set; }
        public string Category { get; set; }
    }
}
