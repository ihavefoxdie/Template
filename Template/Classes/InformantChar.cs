using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    public class InformantChar : Character
    {
        public InformantChar(string name) : base(name)
        {
        }

        public override void UseItem(string item)
        {
        }

        public override bool GoTo(string destination)
        {
            Console.WriteLine(this.Name + " doesn't go anywhere.");
            return false;
        }

        public override void Idle()
        {
            Console.WriteLine(this.Name + " asks: \"Do you need anything?\"");
        }
    }
}
