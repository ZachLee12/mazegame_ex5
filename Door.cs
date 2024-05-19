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

        private string saveOriginalName;
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
            this.direction1 = direction1;
            this.direction2 = direction2;
            this.saveOriginalName = this.name;

            // Lock the rooms to each other via this Door
            this.lockDoor();
            this.updateName();
        }

        public void updateName()
        {   
            this.name = this.locked ? $"Locked {this.saveOriginalName}" : $"Opened {this.saveOriginalName}";
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

        public void lockDoor()
        {
            this.room1.setOneConnectedRoom(null, this.direction1);
            this.room2.setOneConnectedRoom(null, this.direction2);
        }

        public void unlockDoor()
        {
            this.room1.setOneConnectedRoom(this.room2, this.direction1);
            this.room2.setOneConnectedRoom(this.room1, this.direction2);
        }

        public void toggleLock()
        {
            if(this.locked)
            {
                this.unlockDoor();
            }
            else
            {
                this.lockDoor();
            }
            this.locked = !this.locked;

            this.updateName();
        }
    }
}
