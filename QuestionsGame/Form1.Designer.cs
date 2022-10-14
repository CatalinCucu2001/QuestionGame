namespace QuestionsGame
{
    partial class Form1
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
            this.groupBoxQuestions = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRandomizePlayers = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxQuestions
            // 
            this.groupBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxQuestions.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQuestions.Name = "groupBoxQuestions";
            this.groupBoxQuestions.Size = new System.Drawing.Size(613, 426);
            this.groupBoxQuestions.TabIndex = 0;
            this.groupBoxQuestions.TabStop = false;
            this.groupBoxQuestions.Text = "Questions";
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlayers.Location = new System.Drawing.Point(631, 12);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Size = new System.Drawing.Size(157, 331);
            this.groupBoxPlayers.TabIndex = 1;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Players";
            this.groupBoxPlayers.SizeChanged += new System.EventHandler(this.groupBoxPlayers_SizeChanged);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPlayer.Location = new System.Drawing.Point(631, 349);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 2;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonRandomizePlayers
            // 
            this.buttonRandomizePlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandomizePlayers.Location = new System.Drawing.Point(713, 349);
            this.buttonRandomizePlayers.Name = "buttonRandomizePlayers";
            this.buttonRandomizePlayers.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomizePlayers.TabIndex = 3;
            this.buttonRandomizePlayers.Text = "Randomize";
            this.buttonRandomizePlayers.UseVisualStyleBackColor = true;
            this.buttonRandomizePlayers.Click += new System.EventHandler(this.buttonRandomizePlayers_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartGame.Location = new System.Drawing.Point(632, 379);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.Enabled = false;
            this.buttonSkip.Location = new System.Drawing.Point(714, 379);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(75, 23);
            this.buttonSkip.TabIndex = 5;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.buttonRandomizePlayers);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.groupBoxPlayers);
            this.Controls.Add(this.groupBoxQuestions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuestions;
        private System.Windows.Forms.GroupBox groupBoxPlayers;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonRandomizePlayers;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonSkip;
    }
}

