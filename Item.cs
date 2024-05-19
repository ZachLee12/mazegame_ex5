using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_Ex5
{
    internal class Item
    {
        protected string name;
        private bool pickable;
        public Item(string name, bool pickable)
        {
            this.name = name;
            this.pickable = pickable;
        }

        public override string ToString()
        {
            return this.name;
        }

        public bool isPickable()
        {
            return this.pickable;
        }

        public virtual void use(Player user)
        {
            Console.WriteLine("Use method in Item Class");
        }
    }
}
