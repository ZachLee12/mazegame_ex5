using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_Ex5
{
    internal class Key:Item
    {
        Door targetDoor;
        public Key(string name, bool pickable, Door targetDoor) : base(name, pickable)
        {
            this.targetDoor = targetDoor;
        }

        public override void use(Player user)
        {
            Room targetRoom = user.getCurrentRoom();
            if(targetRoom == this.targetDoor.getRoom1() || targetRoom == this.targetDoor.getRoom2())
            {
                this.targetDoor.toggleLock();
            }
            else
            {
                MessageBox.Show("I can see nothing to use the key with here!");
            }
        }
    }
}
