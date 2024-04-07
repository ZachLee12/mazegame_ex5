using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Item
    {
        private string name;
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

        public void use(Player user)
        {
            // in exercise 7
        }
    }
}
