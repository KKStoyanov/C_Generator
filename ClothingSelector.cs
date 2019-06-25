using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Generator
{
    class ClothingSelector
    {
        private int range;

        public ClothingSelector(int temperature)
        {
            //this.range = determineType(temperature);
        }

        public int getRange()
        {
            return this.range;
        }

        public int determineType(int temperature)
        {
            if(temperature < 40)
            {
                return 0;
            }else if(temperature >= 40 && temperature < 50)
            {
                return 1;
            }else if(temperature >= 50 && temperature < 75)
            {
                return 2;
            }else if(temperature >= 75)
            {
                return 3;
            }
            return 2;
        }
    }
}
