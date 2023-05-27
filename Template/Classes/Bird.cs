using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    public class Bird : RoutineAI
    {
        public override bool GoTo(string destination)
        {
            Console.WriteLine("A bird flew to " + destination + ".");
            return true;
        }

        public override void UseItem(string item)
        {
        }
    }
}
