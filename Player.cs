using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Player
    {
        Room currentRoom;
        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }

        public bool move(char direction)
        {
            Room moveToRoom = this.currentRoom.getConnectedRoom(direction);
            if (moveToRoom == null)
            {
                return false;
            }
            else
            {
                this.currentRoom = moveToRoom;
                return true;
            }
        }
    }
}
