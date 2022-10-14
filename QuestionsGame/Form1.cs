using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuestionsGame
{
    public partial class Form1 : Form
    {
        private static readonly Color defaultBackColor = Color.FromArgb(255, 240, 240, 240);
        private static readonly Color currentBackColor = Color.Chartreuse;

        private List<Player> players = new List<Player>();
        private int currentPlayer;
        private int numberOfQuestions;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            players = new List<Player>()
            {
                new Player("Ionel"),
                new Player("Vaniusha"),
                new Player("Carl"),
                new Player("Lorik"),
                new Player("Mozambique")
            };

            UpdatePlayersSize();

            AddPlayersToGame();

            UpdateButtonsPositions();

        }

        private void groupBoxPlayers_SizeChanged(object sender, EventArgs e)
        {
            UpdateButtonsPositions();
        }

        private void UpdatePlayersSize()
        {
            groupBoxPlayers.Size = new Size(groupBoxPlayers.Size.Width, 25 * (players.Count + 1));
        }

        private void AddPlayersToGame()
        {
            int ct = 0;
            foreach (var player in players)
            {
                var label = new Label();
                label.Text = player.Nickname;
                label.Location = new Point(20, ++ct * 25);
                label.BackColor = Color.FromArgb(255, 240, 240, 240);
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.MouseClick += (sender, args) =>
                {
                    
                    if (args.Button == MouseButtons.Right)
                    {
                        players.Remove(players.Find(x => x.Nickname == ((Label)sender).Text));
                        RemovePlayersFromGame();
                        UpdatePlayersSize();
                        AddPlayersToGame();
                    }
                };

                groupBoxPlayers.Controls.Add(label);

            }
        }

        private void RemovePlayersFromGame()
        {
            while (groupBoxPlayers.Controls.Count > 0)
            {
                groupBoxPlayers.Controls.RemoveAt(0);
            }
        }

        private void UpdateButtonsPositions()
        {
            buttonAddPlayer.Location = new Point(groupBoxPlayers.Location.X,
                groupBoxPlayers.Location.Y + groupBoxPlayers.Size.Height + 6);

            buttonRandomizePlayers.Location = new Point(buttonAddPlayer.Location.X + buttonAddPlayer.Size.Width + 6,
                buttonAddPlayer.Location.Y);

            buttonStartGame.Location = new Point(buttonAddPlayer.Location.X,
                buttonAddPlayer.Location.Y + buttonAddPlayer.Size.Height + 6);

            buttonSkip.Location = new Point(buttonAddPlayer.Location.X + buttonAddPlayer.Size.Width + 6,
                buttonAddPlayer.Location.Y + buttonAddPlayer.Size.Height + 6);
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            using (var formInput = new FormAddPlayer())
            {
                while (formInput.ShowDialog() == DialogResult.OK)
                {
                    players.Add(new Player(formInput.PlayerNickname));
                    UpdatePlayersSize();
                    RemovePlayersFromGame();
                    AddPlayersToGame();
                }
            }

            if (buttonStartGame.Location.Y + buttonStartGame.Size.Height + 50 > this.Size.Height)
            {
                this.Size = new Size(this.Width, buttonStartGame.Location.Y + buttonStartGame.Size.Height + 51);
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (GameIsStarted())
            {
                buttonAddPlayer.Enabled = false;
                buttonSkip.Enabled = true;
                buttonRandomizePlayers.Enabled = false;
                buttonStartGame.Text = "End Game";
                StartGame();
            }
            else
            {
                buttonAddPlayer.Enabled = true;
                buttonSkip.Enabled = false;
                buttonRandomizePlayers.Enabled = true;
                buttonStartGame.Text = "Start Game";
                EndGame();
            }




        }

        private void StartGame()
        {

            currentPlayer = 0;
            groupBoxPlayers.Controls[currentPlayer].BackColor = currentBackColor;
            numberOfQuestions = Directory.GetFiles(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/images", "*").Length;

            AddAllButtons();

            // QUESTION
            
        }

        private void AddAllButtons()
        {
            int counter = 0;
            int oversize = 20;

            int numberOfColumns = (int)Math.Ceiling(Math.Sqrt((double)groupBoxQuestions.Size.Width /
                (groupBoxQuestions.Size.Height - oversize) * numberOfQuestions));

            int numberOfLines = (int)Math.Ceiling(Math.Sqrt((double)(groupBoxQuestions.Size.Height - oversize) /
                groupBoxQuestions.Size.Width * numberOfQuestions));


            int buttonHeight = (groupBoxQuestions.Size.Height - oversize - 2 * numberOfLines) / numberOfLines;

            int buttonWidth = (groupBoxQuestions.Size.Width - 10 * 5 / 3 - 2 * numberOfColumns) / numberOfColumns;

            for (int line = 0; line < numberOfLines; line++)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {

                    var button = new Button();
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point(10 + column * (buttonWidth + 2), 13 + 2 + line * (buttonHeight + 2));
                    button.Text = (++counter).ToString();
                    button.TabStop = false;

                    button.Click += (sender, args) =>
                    {
                        var btn = (Button)sender;

                        //MessageBox.Show("U cliked Question " + btn.Text);

                        var fullScreenImage = new FullScreenImage(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/images/image" + btn.Text + ".jpg");
                        
                        fullScreenImage.ShowDialog();

                        NextPlayer();
                        btn.Enabled = false;
                    };

                    groupBoxQuestions.Controls.Add(button);

                    if (counter >= numberOfQuestions)
                    {
                        column = numberOfColumns;
                        line = numberOfLines;
                    }
                }
            }
        }

        private void EndGame()
        {
            groupBoxPlayers.Controls[currentPlayer].BackColor = defaultBackColor;

            RemoveAllButtons();
        }

        private void RemoveAllButtons()
        {
            while (groupBoxQuestions.Controls.Count > 0)
            {
                groupBoxQuestions.Controls.RemoveAt(0);
            }
        }

        private void NextPlayer()
        {
            groupBoxPlayers.Controls[currentPlayer].BackColor = defaultBackColor;

            currentPlayer++;
            if (currentPlayer >= players.Count)
                currentPlayer = 0;

            groupBoxPlayers.Controls[currentPlayer].BackColor = currentBackColor;


        }

        private bool GameIsStarted()
        {
            return buttonStartGame.Text == "Start Game";
        }

        private void buttonRandomizePlayers_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            players = players.OrderBy(x => rnd.Next()).ToList();

            RemovePlayersFromGame();
            AddPlayersToGame();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            NextPlayer();
        }
    }
}
