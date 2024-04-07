using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Room
    {
        public string name;
        public Dictionary<char, Room?> connectingRoomsDict;
        

        public Room(string name)
        {
            this.name = name;
            this.connectingRoomsDict = new Dictionary<char, Room>();
        }

        public void print()
        {
            Console.WriteLine(this.name);
        }

        public string getName() {  return name; }

        public void setConnectedRooms(
            Room? north,
            Room? east,
            Room? south,
            Room? west
            )
        {
            this.connectingRoomsDict.Add('N', value: north);
            this.connectingRoomsDict.Add('E', value: east);
            this.connectingRoomsDict.Add('S', value: south);
            this.connectingRoomsDict.Add('W', value: west);
        }

        public Room getConnectedRoom(char direction)
        {
            return this.connectingRoomsDict[direction];
        }
    }
}
