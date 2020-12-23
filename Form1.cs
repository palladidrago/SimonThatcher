using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SimonThatcher.Properties;
using System.Windows.Forms;

namespace SimonThatcher
{
    public partial class SimonMiranMeir : Form
    {
        public SimonMiranMeir()
        {
            InitializeComponent();
            //sButton.FlatAppearance.BorderSize = 0;
            Random rnd = new Random();
            for (int i = 0;i<sequenceArr.Length;i++)
            sequenceArr[i] = colorArr[rnd.Next(4)]; 
        }
        
        string[] colorArr = { "red", "green", "blue", "yellow" };
        string[] sequenceArr = new string[10];
        bool isSimonTurn = true;
        int turn = 0;
        private void sButClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSimonTurn) simon_Flash();
            turn++;
            if (turn == 10) timer1.Enabled = false;
        }
        private async void simon_Flash()
        {
            //Flashes the simon according to given string array.
            PictureBox curPictureBox;
            string curPicText;
            for (int i = 0; i < turn; i++)
            {
                curPictureBox = Controls[sequenceArr[i]] as PictureBox;
                curPicText = curPictureBox.Name ;
                curPictureBox.Image =  Resources.ResourceManager.GetObject(curPicText + "_off") as Image;

                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
            }
            await Task.Delay(2000);
            MessageBox.Show("Turn complete");
        }

        private void red_Click(object sender, EventArgs e)
        {

        }

        private void simonBClick(object sender, EventArgs e)
        {

        }
    }
}
