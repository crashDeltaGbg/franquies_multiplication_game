using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Franquies_Multiplication_Game
{
    internal class Player
    {
        public string Name { get; init; }

        public double Score { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
