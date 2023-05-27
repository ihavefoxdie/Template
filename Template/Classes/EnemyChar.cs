using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Classes
{
    public class EnemyChar : Character
    {
        public EnemyChar(string name) : base(name)
        {

        }

        public override void UseItem(string item)
        {
            Console.WriteLine(this.Name + " threw " + item + " away.");
        }

        public override void OnDestReached()
        {
            Console.WriteLine(this.Name + " sabotaged something.");
        }
    }
}
