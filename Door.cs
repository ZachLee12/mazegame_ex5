using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Door : Item
    {
        private bool locked;
        private Room room1;
        private Room room2;
        private char direction1;
        private char direction2;
        public Door(
            string name,
            bool pickable,
            bool locked,
            Room room1,
            Room room2,
            char direction1,
            char direction2
            ) : base(name, pickable)
        {
            this.locked = locked;
            this.room1 = room1;
            this.room2 = room2;

            // Connect the rooms to each other via this Door
            this.room1.setOneConnectedRoom(room2, direction1);
            this.room2.setOneConnectedRoom(room1, direction2);
        }

        public bool isLocked()
        {
            return this.locked;
        }

        public Room getRoom1()
        {
            return this.room1;
        }

        public Room getRoom2()
        {
            return this.room2;
        }

        public void toggleLock()
        {
            this.locked = !this.locked;

            if(this.locked)
            {
                this.name = "Locked" + this.name;
                this.room1.setOneConnectedRoom(null,direction1);
                this.room2.setOneConnectedRoom(null, direction2);
            }
            else
            {
                this.name = "Open" + this.name;
                this.room1.setOneConnectedRoom(this.room2, direction1);
                this.room2.setOneConnectedRoom(this.room1, direction2);
            }
        }
    }
}
