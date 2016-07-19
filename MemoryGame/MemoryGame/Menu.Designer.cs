namespace MemoryGame
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblMemoryGame = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMemoryGame
            // 
            this.lblMemoryGame.AutoSize = true;
            this.lblMemoryGame.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoryGame.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMemoryGame.ForeColor = System.Drawing.Color.Black;
            this.lblMemoryGame.Location = new System.Drawing.Point(831, 42);
            this.lblMemoryGame.Name = "lblMemoryGame";
            this.lblMemoryGame.Size = new System.Drawing.Size(300, 228);
            this.lblMemoryGame.TabIndex = 0;
            this.lblMemoryGame.Text = "Memory\r\nGame";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(850, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(201, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.Transparent;
            this.btnHighScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHighScore.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHighScore.Location = new System.Drawing.Point(850, 437);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(201, 50);
            this.btnHighScore.TabIndex = 2;
            this.btnHighScore.Text = "HIGHSCORE";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuit.Location = new System.Drawing.Point(850, 517);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(201, 50);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1259, 654);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.lblMemoryGame);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemoryGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnQuit;
    }
}