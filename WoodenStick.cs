using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class WoodenStick : Item
    {

        public WoodenStick(string name, bool pickable): base(name, pickable)
        {

        }

        public override void use(Player user)
        {
            WoodenStick anotherStick = new WoodenStick("WoodenStick", true);
            user.addItem(anotherStick);
        }
    }
}
