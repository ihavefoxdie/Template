using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    abstract public class RoutineAI
    {
        public void StartRoutine(string item, string destination)
        {
            UseItem(item);
            if (!GoTo(destination))
                Idle();
            else
                OnDestReached();
        }

        virtual public void Idle()
        {
            Console.WriteLine("Looking around.");
        }

        abstract public void UseItem(string item);

        abstract public bool GoTo(string destination);

        virtual public void OnDestReached()
        {
            Console.WriteLine("Do nothing.");
        }
    }
}
