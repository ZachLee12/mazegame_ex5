namespace MazeGame_Ex5
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.missionLabel = new System.Windows.Forms.Label();
            this.youAreCurrentlyInLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // missionLabel
            // 
            this.missionLabel.AutoSize = true;
            this.missionLabel.Location = new System.Drawing.Point(35, 27);
            this.missionLabel.Name = "missionLabel";
            this.missionLabel.Size = new System.Drawing.Size(560, 75);
            this.missionLabel.TabIndex = 0;
            this.missionLabel.Text = "Your Mission:\r\nNavigate through the rooms of the old mansion and find the exit.\r\n" +
    "Avoid the torture chamber, because you would die instantly!\r\n";
            // 
            // youAreCurrentlyInLabel
            // 
            this.youAreCurrentlyInLabel.AutoSize = true;
            this.youAreCurrentlyInLabel.Location = new System.Drawing.Point(35, 187);
            this.youAreCurrentlyInLabel.Name = "youAreCurrentlyInLabel";
            this.youAreCurrentlyInLabel.Size = new System.Drawing.Size(185, 25);
            this.youAreCurrentlyInLabel.TabIndex = 1;
            this.youAreCurrentlyInLabel.Text = "You are currently in:\r\n";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.BackColor = System.Drawing.SystemColors.Control;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.roomLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roomLabel.Location = new System.Drawing.Point(35, 282);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(292, 67);
            this.roomLabel.TabIndex = 2;
            this.roomLabel.Text = "BedRoom\r\n";
            // 
            // navigationLabel
            // 
            this.navigationLabel.AutoSize = true;
            this.navigationLabel.Location = new System.Drawing.Point(567, 227);
            this.navigationLabel.Name = "navigationLabel";
            this.navigationLabel.Size = new System.Drawing.Size(104, 25);
            this.navigationLabel.TabIndex = 3;
            this.navigationLabel.Text = "Navigation";
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(586, 266);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(63, 52);
            this.buttonN.TabIndex = 4;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(493, 321);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(63, 52);
            this.buttonW.TabIndex = 5;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(679, 321);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(63, 52);
            this.buttonE.TabIndex = 6;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(586, 375);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(63, 52);
            this.buttonS.TabIndex = 7;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.navigationLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.youAreCurrentlyInLabel);
            this.Controls.Add(this.missionLabel);
            this.Name = "MainWindow";
            this.Text = "Maze Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label missionLabel;
        private System.Windows.Forms.Label youAreCurrentlyInLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonS;
    }
}

