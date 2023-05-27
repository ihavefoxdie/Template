using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    public class FriendlyChar : Character
    {
        public FriendlyChar(string name) : base(name)
        {

        }

        public override void UseItem(string item)
        {
            Console.WriteLine(this.Name + " used " + item + ".");
        }
    }
}
