using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame_Ex5
{
    internal class Maze
    {

        //Doors
        Door redDoor;
        Door blueDoor;

        //Keys
        Key redKey;
        Key blueKey;

        //Room items;
        Item coin;
        Item book;
        Item rock;

        //Usable items;
        WoodenStick woodenStick;

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
            this.woodenStick = new WoodenStick("Wooden Stick", true);


            this.kitchen = new Room("Kitchen");
            this.livingRoom = new Room("Living Room");
            this.exit = new Room("Exit");
            this.bathroom = new Room("Bathroom");
            this.bedroom = new Room("Bedroom");
            this.tortureChamber = new Room("Torture Chamber");

            // Set Room Items
            this.bathroom.addItem(this.coin);
            this.bathroom.addItem(this.book);
            this.bathroom.addItem(this.woodenStick);
            this.livingRoom.addItem(this.rock);

            // Set Rooms
            this.setSpecialRooms();
            this.setRoomConnections();

            // Red Door
            this.redDoor = new Door("Red Door", false, true, this.bedroom, this.livingRoom, 'N', 'S');
            this.bedroom.addItem(this.redDoor);
            this.livingRoom.addItem(this.redDoor);

            // Red Key
            this.redKey = new Key("Red Key", true, this.redDoor);
            this.bathroom.addItem(this.redKey);

            // Blue Door
            this.blueDoor = new Door("Blue Door", false, true, this.bathroom, this.bedroom, 'E', 'W');
            this.bathroom.addItem(this.blueDoor);
            this.bedroom.addItem(this.blueDoor);

            // Blue Key
            this.blueKey = new Key("Blue Key", true, this.blueDoor);
            this.bathroom.addItem(this.blueKey);
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
