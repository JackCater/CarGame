namespace CarRacingGame
{
    partial class CarRacingGame
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timGameTimer = new System.Windows.Forms.Timer(this.components);
            this.leftRoadLine = new System.Windows.Forms.PictureBox();
            this.rightRoadLine = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pboxCoin1 = new System.Windows.Forms.PictureBox();
            this.pboxCoin4 = new System.Windows.Forms.PictureBox();
            this.pboxCoin6 = new System.Windows.Forms.PictureBox();
            this.pboxCoin5 = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRoadLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRoadLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(190, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(190, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 75);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(190, 400);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 75);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(190, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 75);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(190, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 75);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(190, 100);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 75);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timGameTimer
            // 
            this.timGameTimer.Interval = 25;
            this.timGameTimer.Tick += new System.EventHandler(this.OnGameTimerTick);
            // 
            // leftRoadLine
            // 
            this.leftRoadLine.BackColor = System.Drawing.Color.White;
            this.leftRoadLine.Location = new System.Drawing.Point(-1, 0);
            this.leftRoadLine.Name = "leftRoadLine";
            this.leftRoadLine.Size = new System.Drawing.Size(10, 475);
            this.leftRoadLine.TabIndex = 6;
            this.leftRoadLine.TabStop = false;
            // 
            // rightRoadLine
            // 
            this.rightRoadLine.BackColor = System.Drawing.Color.White;
            this.rightRoadLine.Location = new System.Drawing.Point(375, 0);
            this.rightRoadLine.Name = "rightRoadLine";
            this.rightRoadLine.Size = new System.Drawing.Size(10, 475);
            this.rightRoadLine.TabIndex = 7;
            this.rightRoadLine.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Red;
            this.enemy1.Location = new System.Drawing.Point(44, 30);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(20, 30);
            this.enemy1.TabIndex = 8;
            this.enemy1.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.Color.Red;
            this.enemy4.Location = new System.Drawing.Point(310, 33);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(20, 30);
            this.enemy4.TabIndex = 9;
            this.enemy4.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Red;
            this.enemy3.Location = new System.Drawing.Point(226, 33);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(20, 30);
            this.enemy3.TabIndex = 10;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Red;
            this.enemy2.Location = new System.Drawing.Point(135, 33);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(20, 30);
            this.enemy2.TabIndex = 11;
            this.enemy2.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Black;
            this.car.Location = new System.Drawing.Point(150, 350);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(20, 30);
            this.car.TabIndex = 16;
            this.car.TabStop = false;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(85, 147);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(234, 170);
            this.btnRestartGame.TabIndex = 17;
            this.btnRestartGame.Text = "RESTART GAME";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Visible = false;
            this.btnRestartGame.Click += new System.EventHandler(this.OnRestartGameClick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(85, 147);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(233, 169);
            this.btnStartGame.TabIndex = 18;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.OnStartGameClick);
            // 
            // pboxCoin1
            // 
            this.pboxCoin1.BackColor = System.Drawing.Color.Gold;
            this.pboxCoin1.Location = new System.Drawing.Point(44, 75);
            this.pboxCoin1.Name = "pboxCoin1";
            this.pboxCoin1.Size = new System.Drawing.Size(20, 20);
            this.pboxCoin1.TabIndex = 19;
            this.pboxCoin1.TabStop = false;
            // 
            // pboxCoin4
            // 
            this.pboxCoin4.BackColor = System.Drawing.Color.Gold;
            this.pboxCoin4.Location = new System.Drawing.Point(150, 75);
            this.pboxCoin4.Name = "pboxCoin4";
            this.pboxCoin4.Size = new System.Drawing.Size(20, 20);
            this.pboxCoin4.TabIndex = 20;
            this.pboxCoin4.TabStop = false;
            // 
            // pboxCoin6
            // 
            this.pboxCoin6.BackColor = System.Drawing.Color.Gold;
            this.pboxCoin6.Location = new System.Drawing.Point(310, 178);
            this.pboxCoin6.Name = "pboxCoin6";
            this.pboxCoin6.Size = new System.Drawing.Size(20, 20);
            this.pboxCoin6.TabIndex = 21;
            this.pboxCoin6.TabStop = false;
            // 
            // pboxCoin5
            // 
            this.pboxCoin5.BackColor = System.Drawing.Color.Gold;
            this.pboxCoin5.Location = new System.Drawing.Point(263, 86);
            this.pboxCoin5.Name = "pboxCoin5";
            this.pboxCoin5.Size = new System.Drawing.Size(20, 20);
            this.pboxCoin5.TabIndex = 22;
            this.pboxCoin5.TabStop = false;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Gold;
            this.lblCoins.Location = new System.Drawing.Point(16, 6);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(106, 26);
            this.lblCoins.TabIndex = 23;
            this.lblCoins.Text = "Score = 0";
            // 
            // CarRacingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pboxCoin5);
            this.Controls.Add(this.pboxCoin6);
            this.Controls.Add(this.pboxCoin4);
            this.Controls.Add(this.pboxCoin1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.car);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.rightRoadLine);
            this.Controls.Add(this.leftRoadLine);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "CarRacingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRoadLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRoadLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCoin5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timGameTimer;
        private System.Windows.Forms.PictureBox leftRoadLine;
        private System.Windows.Forms.PictureBox rightRoadLine;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pboxCoin1;
        private System.Windows.Forms.PictureBox pboxCoin4;
        private System.Windows.Forms.PictureBox pboxCoin6;
        private System.Windows.Forms.PictureBox pboxCoin5;
        private System.Windows.Forms.Label lblCoins;
    }
}

