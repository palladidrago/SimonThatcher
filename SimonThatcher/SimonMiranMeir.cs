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
using ColorSlider;

namespace SimonThatcher
{
    public partial class SimonMiranMeir : Form
    {
        string[] colorArr = { "red", "green", "blue", "yellow" };
        string[] sequenceArr;
        int curClick = 0;
        int howManyTurns;
        string name;
        bool isSimonTurn = true;
        int turn = 0;
        Random rnd = new Random();

        public SimonMiranMeir(int howManyTurns, string name)
        {
            InitializeComponent();
            //sButton.FlatAppearance.BorderSize = 0;

            //Make the form unresizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            turnLabel.Text = "Turn: " + "Simon";
            //Define the turns as per the parameter
            this.howManyTurns = howManyTurns;
            this.name = name;
            sequenceArr = new string[howManyTurns];
            //Create random predetermined game array.
            for (int i = 0; i < howManyTurns; i++)
                sequenceArr[i] = colorArr[rnd.Next(4)];

            DisableButtons();

            pic_circle.Controls.Add(red);
            pic_circle.Controls.Add(blue);
            pic_circle.Controls.Add(green);
            pic_circle.Controls.Add(yellow);

            int h = pic_circle.Height;
            int w = pic_circle.Width;

            red.Left = w / 2;
            blue.Left = w / 2;
            green.Left = w / 2 - red.Width - 4;
            yellow.Left = green.Left;


            blue.Top = h / 2;
            yellow.Top = h / 2;
            red.Top = h / 2 - blue.Height - 4;
            green.Top = red.Top;

            panel_progress.Width = 0;
        }
        private void sButClick(object sender, EventArgs e)
        {
            timer1.Start();
            sButton.Click -= sButClick;
            sButton.Click += Exit;
            sButton.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (turn == howManyTurns) { timer1.Stop(); UWin(); }
            if (isSimonTurn)
            {
                timer1.Stop();
                Simon_Flash();

            }
            //Task.Delay(1000).ContinueWith(t => bar());
            //Console.WriteLine("SEDCOND");
            
        }

        private async void Simon_Flash()
        {
            
            //Flashes the simon according to given string array.
            PictureBox curPictureBox;
            string curPicText;
            for (int i = 0; i <= turn; i++)
            {
                curPictureBox = pic_circle.Controls[sequenceArr[i]] as PictureBox;

                curPicText = curPictureBox.Name;

                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
                await Task.Delay(750);
                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;
                if (i != turn - 1)
                    await Task.Delay(250);
                else
                    await Task.Delay(750);
            }

            turn++;
            isSimonTurn = false;
            turnLabel.Text = "Turn: " + name;
            EnableButtons();
        }


        private async void simonBClick(object sender, EventArgs e)
        {
            
            //Deal with clicks.
            PictureBox p = sender as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;
            await Task.Delay(300);  
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_off") as Image;
            await Task.Delay(300);

            if (sequenceArr[curClick] == p.Name){
                //If right button is pressed.
                curClick++;
                if (curClick == turn)
                {
                    //If all the right buttons have been clicked start simon.
                    panel_progress.Width += (int)(800.0 / howManyTurns); 
                    turnLabel.Text = "Turn: " + "Simon";
                    DisableButtons();
                    isSimonTurn = true;
                    curClick = 0;
                    await Task.Delay(900);
                    timer1.Start();
                }
            }
            else //If the loser loses.  
            { timer1.Stop(); ULose(curClick); }
        }

        private void DisableButtons()
        {
            //Disables all the buttons
            red.Enabled = false;
            green.Enabled = false;
            blue.Enabled = false;
            yellow.Enabled = false;
        }

        private void EnableButtons()
        {
            //Enable all the buttons
            red.Enabled = true;
            green.Enabled = true;
            blue.Enabled = true;
            yellow.Enabled = true;
        }

        private void ULose(int curClick)
        {
            PictureBox p= pic_circle.Controls[sequenceArr[curClick]] as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;

            sButton.Visible = true;
            sButton.Text = $"Simon won the game click here to return to main menu";

            timer1.Stop();
        }
        private void UWin()
        {
            sButton.Visible = true;
            sButton.Text = $"{name} won the game click here to return to main menu";
            //new StartSimon();
        }
        private void Exit(object sender, EventArgs e)
        {
            this.Hide(); Form newStart = new StartSimon(); this.Close();
            newStart.ShowDialog();
        }
    }

}
