using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_Ex5
{
    public partial class MainWindow : Form
    {
        private Maze maze; 
        private Player player;

        // For highscore feature
        private HighScoreService highScoreService;

        // Stopwatch for highscore counter
        private Stopwatch stopwatch;
        public MainWindow()
        {
            InitializeComponent();
            this.maze = new Maze();
            this.player = new Player(maze.getStartRoom());
            this.updateRoom();

            // For highscore feature
            this.highScoreService = new HighScoreService();

            // Stopwatch for highscore counter
            stopwatch = new Stopwatch();
            stopwatch.Start();

            // Subscribe to the Load event
            this.Load += new EventHandler(MainForm_Load);

            // Handle the FormClosing event to stop the Stopwatch and log the time
            this.FormClosing += MainForm_FormClosing;
        }

        private async Task<string> getHighScore()
        {
            // For highscore feature
            string currentHighScore = await this.highScoreService.getHighScore("http://localhost:3000/highscore");
            this.actualHighScore.Text = currentHighScore;
            return currentHighScore;
        }

        // Event handler for the Load event
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await this.getHighScore();
        }

        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the Stopwatch when the form is closing
            stopwatch.Stop();

            // Log the elapsed time
            TimeSpan elapsed = stopwatch.Elapsed;
            string formatElapsedString = $"Elapsed time: {elapsed.TotalSeconds} seconds";

            await this.updateHighScore(elapsed);
            Console.WriteLine(formatElapsedString);
        }

        private async Task<string> updateHighScore(TimeSpan elapsed)
        {
            return await this.highScoreService.updateHighScore("http://localhost:3000/highscore", elapsed.TotalSeconds);
        }

        private void updateRoom()
        {
            Room currentRoom = this.player.getCurrentRoom();
            this.roomLabel.Text = currentRoom.getName();
            
            // Update Room Items
            this.roomItemsListBox.Items.Clear();
            for(int i = 0;i < currentRoom.getContent().Count; i++)
            {
                this.roomItemsListBox.Items.Add(currentRoom.getContent()[i]);
            }

            //Update Player Items
            this.playerItemsListBox.Items.Clear();
            for (int i = 0; i < this.player.getBag().Count; i++)
            {
                this.playerItemsListBox.Items.Add(this.player.getBag()[i]);
            }
        }

        private void pickUpItem()
        {
            Item targetItem = (Item)this.roomItemsListBox.SelectedItem;
            
            // Shows dialog to inform that no item has been selected.
            if(targetItem == null)
            {
                MessageBox.Show("No item is selected.");
            }
            else
            {
                if(targetItem.isPickable())
                {
                    this.player.addItem(targetItem);
                    
                    // Remove item from current room
                    this.player.getCurrentRoom().removeItem(targetItem);
                    this.updateRoom();
                }
                else
                {
                    MessageBox.Show($"{targetItem.ToString()} is not pickable because it is too heavy!");
                }
            }
        }

        private void dropItem()
        {
            Item targetItem = (Item) this.playerItemsListBox.SelectedItem;
            // Shows dialog to inform that no item has been selected.
            if (targetItem == null)
            {
                MessageBox.Show("No item is selected.");
            }
            else
            {
                if (targetItem.isPickable())
                {
                    this.player.getCurrentRoom().addItem(targetItem);

                    // Remove item from player's bag
                    this.player.removeItem(targetItem);
                    this.updateRoom();
                }
                else
                {
                    MessageBox.Show($"{targetItem.ToString()} is not pickable because it is too heavy!");
                }
            }
        }
            
        private void movePlayer(char direction)
        {
            bool isPlayerMoved = this.player.move(direction);
            if (isPlayerMoved)
            {
                this.updateRoom();
                if(this.player.getCurrentRoom() == this.maze.getWinningRoom())
                {
                    MessageBox.Show("Congratulations, you win!");
                    Close();
                }
                else if(this.player.getCurrentRoom() == this.maze.getLosingRoom())
                {
                    MessageBox.Show("You Lose! You are dead!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("You hit a wall!");
            }
        }

        private bool canGoThrough(char direction)
        {
            Room currentRoom = this.player.getCurrentRoom();
            Door targetDoor = null;
            bool canGoThrough = true;
            foreach(Item item in this.player.getCurrentRoom().getContent())
            {
                if(item is Door door)
                {
                    targetDoor = door;
                }
            }

            return canGoThrough;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (this.canGoThrough('N'))
            {
                this.movePlayer('N');
            }
            else
            {
                MessageBox.Show("Door is locked!");
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (this.canGoThrough('W'))
            {
                this.movePlayer('W');
            }
            else
            {
                MessageBox.Show("Door is locked!");
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (this.canGoThrough('E'))
            {
                this.movePlayer('E');
            }
            else
            {
                MessageBox.Show("Door is locked!");
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (this.canGoThrough('S'))
            {
                this.movePlayer('S');
            }
            else
            {
                MessageBox.Show("Door is locked!");
            }
        }

        private void pickUpButton_Click(object sender, EventArgs e)
        {
            this.pickUpItem();
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            this.dropItem();
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            Item targetItem = (Item)this.playerItemsListBox.SelectedItem;
            if(targetItem == null)
            {
                MessageBox.Show("Select an item from your bag to use it!");
                return;
            }
            targetItem.use(this.player);
            this.updateRoom();
        }

        private void highScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
