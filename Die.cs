using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franquies_Multiplication_Game
{
    internal class Die
    {
        private int faces = 0;
        public Die(int faces)
        {
            this.faces = faces;
        }

        public int Throw
        {
            get
            {
                return new Random().Next(faces) + 1;
            }
        }
    }
}
