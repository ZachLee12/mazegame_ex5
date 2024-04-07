using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Maze
    {

        //Door
        Door door;

        //Key
        Key key;

        //Room items;
        Item coin;
        Item book;
        Item rock;

        Room kitchen;
        Room livingRoom;
        Room exit;
        Room bathroom;
        Room bedroom;
        Room tortureChamber;

        // Special rooms
        Room startRoom;
        Room winningRoom;
        Room losingRoom;
   
        public Maze() {

            // Room items
            this.coin = new Item("Coin", true);
            this.book = new Item("Book", true);
            this.rock = new Item("Rock", false);


            this.kitchen = new Room("Kitchen");
            this.livingRoom = new Room("Living Room");
            this.exit = new Room("Exit");
            this.bathroom = new Room("Bathroom");
            this.bedroom = new Room("Bedroom");
            this.tortureChamber = new Room("Torture Chamber");

            // Set Room Items
            this.bathroom.addItem(this.coin);
            this.bathroom.addItem(this.book);
            this.livingRoom.addItem(this.rock);

            // Set Rooms
            this.setSpecialRooms();
            this.setRoomConnections();

            // Door
            this.door = new Door("Door", false, true, this.livingRoom, this.exit, 'E', 'W');
            this.livingRoom.addItem(this.door);
            this.exit.addItem(this.door);

        }

        private void setRoomConnections()
        {
            this.kitchen.setConnectedRooms(null, this.livingRoom, this.bathroom, null);
            this.livingRoom.setConnectedRooms(null, this.exit, this.bedroom, this.kitchen);
            this.exit.setConnectedRooms(null,null, null, this.livingRoom);
            this.bathroom.setConnectedRooms(this.kitchen, this.bedroom,null, null);
            this.bedroom.setConnectedRooms(this.livingRoom, null, this.tortureChamber, this.bathroom);
            this.tortureChamber.setConnectedRooms(this.bedroom, null, null, null);
        }

        private void setSpecialRooms()
        {
            this.winningRoom = this.exit;
            this.losingRoom = this.tortureChamber;
            this.startRoom = this.bathroom;
        }


        public Room getStartRoom()
        {
            return this.startRoom;
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }


    }
}
