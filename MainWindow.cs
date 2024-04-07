using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_Ex5
{
    public partial class MainWindow : Form
    {
        private Maze maze; 
        private Player player; 
        public MainWindow()
        {
            InitializeComponent();
            this.maze = new Maze();
            this.player = new Player(maze.getStartRoom());
            this.updateRoom();
        }

        private void updateRoom()
        {
            this.roomLabel.Text = this.player.getCurrentRoom().getName();
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

        private void buttonN_Click(object sender, EventArgs e)
        {
            this.movePlayer('N');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            this.movePlayer('W');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            this.movePlayer('E');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            this.movePlayer('S');
        }
    }
}
