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
    public partial class FullScreenImage : Form
    {
        public FullScreenImage(string pathToImage)
        {
            InitializeComponent();

            pictureBox1.ImageLocation = pathToImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            this.Size = new Size(pictureBox1.Size.Width + 40, pictureBox1.Size.Height + 70);

            
            pictureBox1.Location = new Point((this.Size.Width - pictureBox1.Size.Width ) / 2, (this.Size.Height - pictureBox1.Size.Height - 40) / 2); //40 e bara
        }


        private void FullScreenImage_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(Size.Width - 40, Size.Height - 70);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
