using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    abstract public class Character : RoutineAI
    {
        public string Name { get; private set; }

        public Character(string name)
        {
            Name = name;
        }

        public override bool GoTo(string destination)
        {
            Console.WriteLine(this.Name + " goes to " + destination + ".");
            return ReachDestination(destination);
        }

        virtual protected bool ReachDestination(string destination)
        {
            bool success = Convert.ToBoolean(new Random().Next(2));
            return success;
        }
    }
}
