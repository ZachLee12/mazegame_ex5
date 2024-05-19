using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Player
    {
        private Room currentRoom;
        private List<Item> bag;
        private Key key;
        public Player(Room currentRoom)
        {
            this.bag = new List<Item>();
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
                Console.WriteLine("null Room");
                return false;
            }
            else
            {
                this.currentRoom = moveToRoom;
                return true;
            }
        }

        public List<Item> getBag()
        {
            return this.bag;
        }
        public void addItem(Item item)
        {
            Console.WriteLine($"Added {item.ToString()} to inventory");
            this.bag.Add(item);
        }

        public void removeItem(Item item)
        {
            this.bag.Remove(item);
        }
    }
}
