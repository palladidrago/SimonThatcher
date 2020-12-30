using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            curDiff = easyB;
            curDiff.Enabled = false;
        }
        Form gameForm;
        int howManyTurns = 5;
        Button curDiff;
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


        }
}
