using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsGame
{
    public partial class FormAddPlayer : Form
    {
        public string PlayerNickname { get; set; }
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            PlayerNickname = textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
            {
                buttonAddPlayer.Enabled = true;
            }
            else
            {
                buttonAddPlayer.Enabled = false;
            }
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    buttonAddPlayer.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
