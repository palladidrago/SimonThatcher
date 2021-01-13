namespace SimonThatcher
{
    partial class StartSimon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSimon));
            this.t_on_off = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.p_menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b_howto = new System.Windows.Forms.Button();
            this.b_difficulty = new System.Windows.Forms.Button();
            this.b_play = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gRL_play = new SimonThatcher.Gradient_RL();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.pic_circle = new System.Windows.Forms.PictureBox();
            this.gRL_howto = new SimonThatcher.Gradient_RL();
            this.button1 = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.gRL_difficulty = new SimonThatcher.Gradient_RL();
            this.p_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gRL_play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).BeginInit();
            this.gRL_difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_on_off
            // 
            this.t_on_off.Enabled = true;
            this.t_on_off.Interval = 550;
            this.t_on_off.Tick += new System.EventHandler(this.t_on_off_Tick);
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_menu.Controls.Add(this.pictureBox2);
            this.p_menu.Controls.Add(this.b_howto);
            this.p_menu.Controls.Add(this.b_difficulty);
            this.p_menu.Controls.Add(this.b_play);
            this.p_menu.Controls.Add(this.pictureBox1);
            this.p_menu.Location = new System.Drawing.Point(548, 0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(258, 451);
            this.p_menu.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SimonThatcher.Properties.Resources.Exit;
            this.pictureBox2.Location = new System.Drawing.Point(0, 382);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // b_howto
            // 
            this.b_howto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_howto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_howto.FlatAppearance.BorderSize = 0;
            this.b_howto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_howto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_howto.Location = new System.Drawing.Point(-4, 234);
            this.b_howto.Name = "b_howto";
            this.b_howto.Size = new System.Drawing.Size(262, 68);
            this.b_howto.TabIndex = 3;
            this.b_howto.Text = "HOW TO PLAY";
            this.b_howto.UseVisualStyleBackColor = false;
            this.b_howto.Click += new System.EventHandler(this.How_To_Click);
            // 
            // b_difficulty
            // 
            this.b_difficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_difficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_difficulty.FlatAppearance.BorderSize = 0;
            this.b_difficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_difficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_difficulty.Location = new System.Drawing.Point(-4, 166);
            this.b_difficulty.Name = "b_difficulty";
            this.b_difficulty.Size = new System.Drawing.Size(265, 68);
            this.b_difficulty.TabIndex = 2;
            this.b_difficulty.Text = "Difficulty";
            this.b_difficulty.UseVisualStyleBackColor = false;
            this.b_difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            // 
            // b_play
            // 
            this.b_play.BackColor = System.Drawing.Color.Salmon;
            this.b_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_play.FlatAppearance.BorderSize = 0;
            this.b_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.b_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_play.Location = new System.Drawing.Point(0, 101);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(258, 68);
            this.b_play.TabIndex = 1;
            this.b_play.Text = "PLAY";
            this.b_play.UseVisualStyleBackColor = false;
            this.b_play.Click += new System.EventHandler(this.Play_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimonThatcher.Properties.Resources.סמל;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gRL_play
            // 
            this.gRL_play.ColorLeft = System.Drawing.Color.Salmon;
            this.gRL_play.ColorRight = System.Drawing.Color.Brown;
            this.gRL_play.Controls.Add(this.tx_name);
            this.gRL_play.Controls.Add(this.red);
            this.gRL_play.Controls.Add(this.blue);
            this.gRL_play.Controls.Add(this.yellow);
            this.gRL_play.Controls.Add(this.green);
            this.gRL_play.Controls.Add(this.pic_circle);
            this.gRL_play.Location = new System.Drawing.Point(12, 0);
            this.gRL_play.Name = "gRL_play";
            this.gRL_play.Size = new System.Drawing.Size(550, 452);
            this.gRL_play.TabIndex = 0;
            // 
            // tx_name
            // 
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tx_name.Location = new System.Drawing.Point(92, 137);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(367, 56);
            this.tx_name.TabIndex = 22;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Image = global::SimonThatcher.Properties.Resources.red_off;
            this.red.Location = new System.Drawing.Point(270, 85);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(153, 149);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 18;
            this.red.TabStop = false;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Transparent;
            this.blue.Image = global::SimonThatcher.Properties.Resources.blue_off;
            this.blue.Location = new System.Drawing.Point(270, 234);
            this.blue.Margin = new System.Windows.Forms.Padding(4);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(153, 149);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue.TabIndex = 20;
            this.blue.TabStop = false;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Transparent;
            this.yellow.Image = global::SimonThatcher.Properties.Resources.yellow_off;
            this.yellow.Location = new System.Drawing.Point(113, 234);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(153, 149);
            this.yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellow.TabIndex = 17;
            this.yellow.TabStop = false;
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Image = global::SimonThatcher.Properties.Resources.green_off;
            this.green.Location = new System.Drawing.Point(113, 85);
            this.green.Margin = new System.Windows.Forms.Padding(4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(153, 149);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green.TabIndex = 19;
            this.green.TabStop = false;
            // 
            // pic_circle
            // 
            this.pic_circle.BackColor = System.Drawing.Color.Transparent;
            this.pic_circle.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_circle.Location = new System.Drawing.Point(28, 3);
            this.pic_circle.Name = "pic_circle";
            this.pic_circle.Size = new System.Drawing.Size(478, 451);
            this.pic_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_circle.TabIndex = 21;
            this.pic_circle.TabStop = false;
            // 
            // gRL_howto
            // 
            this.gRL_howto.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.gRL_howto.ColorRight = System.Drawing.Color.Gold;
            this.gRL_howto.Location = new System.Drawing.Point(49, 72);
            this.gRL_howto.Name = "gRL_howto";
            this.gRL_howto.Size = new System.Drawing.Size(550, 452);
            this.gRL_howto.TabIndex = 23;
            this.gRL_howto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(61, 96);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(323, 23);
            this.pbar.TabIndex = 0;
            // 
            // gRL_difficulty
            // 
            this.gRL_difficulty.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gRL_difficulty.ColorRight = System.Drawing.Color.Teal;
            this.gRL_difficulty.Controls.Add(this.button1);
            this.gRL_difficulty.Controls.Add(this.pbar);
            this.gRL_difficulty.Location = new System.Drawing.Point(121, 12);
            this.gRL_difficulty.Name = "gRL_difficulty";
            this.gRL_difficulty.Size = new System.Drawing.Size(550, 452);
            this.gRL_difficulty.TabIndex = 22;
            this.gRL_difficulty.Visible = false;
            // 
            // StartSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_menu);
            this.Controls.Add(this.gRL_difficulty);
            this.Controls.Add(this.gRL_play);
            this.Controls.Add(this.gRL_howto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartSimon";
            this.Text = " Simon Says";
            this.p_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gRL_play.ResumeLayout(false);
            this.gRL_play.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).EndInit();
            this.gRL_difficulty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer t_on_off;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Gradient_RL gRL_play;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox pic_circle;
        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button b_howto;
        private System.Windows.Forms.Button b_difficulty;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Gradient_RL gRL_difficulty;
        private Gradient_RL gRL_howto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.TextBox tx_name;
    }
}