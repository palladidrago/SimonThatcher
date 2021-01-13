using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimonThatcher.Properties;
using System.Drawing.Drawing2D;

namespace SimonThatcher
{
    public partial class StartSimon : Form
    {
        public StartSimon()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            gRL_play.Location = new Point(0, 0);
            gRL_difficulty.Location = new Point(0, 0);
            gRL_howto.Location = new Point(0, 0);
            pic_circle.Location = new Point(gRL_play.Width-pic_circle.Width-30,0);
            b_play.FlatAppearance.MouseOverBackColor = Color.Salmon;

            b_play.FlatAppearance.BorderSize = 0;
            b_difficulty.FlatAppearance.BorderSize = 0;
            b_play.FlatAppearance.BorderSize = 0;
            b_howto.FlatAppearance.BorderSize = 0;



            pic_circle.Controls.Add(red);
            pic_circle.Controls.Add(blue);
            pic_circle.Controls.Add(green);
            pic_circle.Controls.Add(yellow);

            int h = pic_circle.Height;
            int w = pic_circle.Width;

            red.Left = w / 2;
            blue.Left = w / 2;
            green.Left = w / 2 - red.Width -4 ;
            yellow.Left = green.Left;


            blue.Top = h / 2;
            yellow.Top = h / 2;
            red.Top = h / 2 - blue.Height +4;
            green.Top = red.Top;
        }
        Form gameForm;
        int howManyTurns = 5;
        Button curDiff;
        string[] colorArr = { "red", "green", "blue", "yellow" };
        Random rnd = new Random();
        private void Start() { gameForm = new SimonMiranMeir(howManyTurns); }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
            
        }

        private void easyB_Click(object sender, EventArgs e) 
        { Button b = sender as Button; howManyTurns = 5; b.Enabled = false; curDiff.Enabled = true; curDiff = b; }
        private void ohNoB_Click(object sender, EventArgs e) 
        { Button b = sender as Button; howManyTurns = 50; b.Enabled = false; curDiff.Enabled = true; curDiff = b; }
        private void UCryB_Click(object sender, EventArgs e) 
        { Button b = sender as Button; howManyTurns = 500; b.Enabled = false; curDiff.Enabled = true; curDiff = b; }

        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private async void t_on_off_Tick(object sender, EventArgs e)
        {
            PictureBox curPictureBox;
            string curPicText;
            curPictureBox = pic_circle.Controls[colorArr[rnd.Next(4)]] as PictureBox;

            curPicText = curPictureBox.Name;

            curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
            await Task.Delay(500);
            curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;

        }

        private void Play_Click(object sender, EventArgs e)
        {
            b_play.BackColor = Color.Salmon;
            b_difficulty.BackColor = Color.FromArgb(64, 64, 64);
            b_howto.BackColor = Color.FromArgb(64, 64, 64);

            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_play.FlatAppearance.MouseOverBackColor = Color.Salmon;
            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = false;
            gRL_difficulty.Visible = false;
            gRL_play.Visible = true;

            t_on_off.Start();
        }
        private void Difficulty_Click(object sender, EventArgs e)
        {
            b_play.BackColor = Color.FromArgb(64, 64, 64);
            b_difficulty.BackColor = Color.FromArgb(0, 192, 192);
            b_howto.BackColor = Color.FromArgb(64, 64, 64);

            b_play.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = false;
            gRL_difficulty.Visible =true;
            gRL_play.Visible = false;

            t_on_off.Stop();
        }
        private void How_To_Click(object sender, EventArgs e)
        {
            b_howto.BackColor = Color.FromArgb(220, 214, 95);
            b_play.BackColor = Color.FromArgb(64, 64, 64);
            b_difficulty.BackColor = Color.FromArgb(64, 64, 64);

            b_howto.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 214, 95);
            b_difficulty.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            b_play.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);

            gRL_howto.Visible = true;
            gRL_difficulty.Visible = false;
            gRL_play.Visible = false;

            t_on_off.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            pbar.Value++;
        }

    }
}
