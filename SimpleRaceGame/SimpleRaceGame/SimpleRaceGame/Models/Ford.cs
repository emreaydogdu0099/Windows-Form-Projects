using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRaceGame.Models
{
    internal class Ford : Car
    {
        Random random = new Random();
        public override int speed()
        {
            return random.Next(5, 15);          
        }
    }
}
