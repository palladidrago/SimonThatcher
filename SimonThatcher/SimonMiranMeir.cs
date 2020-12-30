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
        public SimonMiranMeir(int howManyTurns)
        {
            InitializeComponent();
            //sButton.FlatAppearance.BorderSize = 0;

            //Make the form unresizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            turnLabel.Text = "Turn: " + turn + 1;
            //Define the turns as per the parameter
            this.howManyTurns = howManyTurns;
            sequenceArr = new string[howManyTurns];
            //Create random predetermined game array.
            for (int i = 0; i < howManyTurns; i++)
                sequenceArr[i] = colorArr[rnd.Next(4)];
            
            DisableButtons();

        }

        string[] colorArr = { "red", "green", "blue", "yellow" };
        string[] sequenceArr;
        int curClick = 0;
        int howManyTurns;
        bool isSimonTurn = true;
        int turn = 0;
        Random rnd = new Random();
        private void sButClick(object sender, EventArgs e)
        {
            timer1.Start();
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
                curPictureBox = Controls[sequenceArr[i]] as PictureBox;

                curPicText = curPictureBox.Name;

                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_on") as Image;
                await Task.Delay(1000);
                curPictureBox.Image = Resources.ResourceManager.GetObject(curPicText + "_off") as Image;
            }

            turn++;
            isSimonTurn = false;
            EnableButtons();
        }


        private async void simonBClick(object sender, EventArgs e)
        {

            //Deal with clicks.
            PictureBox p = sender as PictureBox;
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_on") as Image;
            await Task.Delay(300);  
            p.Image = Resources.ResourceManager.GetObject(p.Name + "_off") as Image;

            if (sequenceArr[curClick] == p.Name){
                //If right button is pressed.
                curClick++;
                if (curClick == turn)
                {
                    //If all the right buttons have been clicked start simon.
                    turnLabel.Text = "Turn: " + turn+1;
                    DisableButtons();
                    isSimonTurn = true;
                    curClick = 0;
                    await Task.Delay(900);
                    timer1.Start();
                }
            }
            else //If the loser loses.  
            { timer1.Stop(); ULose(); }
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

        private void ULose()
        {
            MessageBox.Show("You lose NIGGA");
            this.Hide(); Form newStart = new StartSimon(); this.Close();
            newStart.ShowDialog();
            timer1.Stop();
            new StartSimon();
        }
        private void UWin()
        {
            MessageBox.Show("You win PRO");
            this.Hide(); Form newStart = new StartSimon(); this.Close();
            newStart.ShowDialog();
            new StartSimon();
        }
    }

}
