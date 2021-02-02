namespace SimonThatcher
{
    partial class SimonMiranMeir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimonMiranMeir));
            this.sButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.turnLabel = new System.Windows.Forms.Label();
            this.pic_circle = new System.Windows.Forms.PictureBox();
            this.gradient1 = new SimonThatcher.Gradient();
            this.panel_progress = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).BeginInit();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sButton
            // 
            this.sButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sButton.FlatAppearance.BorderSize = 0;
            this.sButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sButton.ForeColor = System.Drawing.Color.Black;
            this.sButton.Location = new System.Drawing.Point(0, 340);
            this.sButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(800, 115);
            this.sButton.TabIndex = 1;
            this.sButton.TabStop = false;
            this.sButton.Text = "START";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.sButClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.Image = global::SimonThatcher.Properties.Resources.green_off;
            this.green.Location = new System.Drawing.Point(281, 56);
            this.green.Margin = new System.Windows.Forms.Padding(4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(117, 106);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green.TabIndex = 3;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.simonBClick);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.White;
            this.blue.Image = global::SimonThatcher.Properties.Resources.blue_off;
            this.blue.Location = new System.Drawing.Point(401, 168);
            this.blue.Margin = new System.Windows.Forms.Padding(4);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(117, 106);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blue.TabIndex = 3;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.simonBClick);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Transparent;
            this.yellow.Image = global::SimonThatcher.Properties.Resources.yellow_off;
            this.yellow.Location = new System.Drawing.Point(281, 168);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(117, 106);
            this.yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellow.TabIndex = 2;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.simonBClick);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Image = global::SimonThatcher.Properties.Resources.red_off;
            this.red.Location = new System.Drawing.Point(401, 56);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(117, 106);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 2;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.simonBClick);
            // 
            // turnLabel
            // 
            this.turnLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnLabel.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.Location = new System.Drawing.Point(3, 33);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(744, 77);
            this.turnLabel.TabIndex = 4;
            this.turnLabel.Text = "Turn: ";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_circle
            // 
            this.pic_circle.Image = global::SimonThatcher.Properties.Resources.white_circle;
            this.pic_circle.Location = new System.Drawing.Point(236, -1);
            this.pic_circle.Name = "pic_circle";
            this.pic_circle.Size = new System.Drawing.Size(335, 340);
            this.pic_circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_circle.TabIndex = 6;
            this.pic_circle.TabStop = false;
            // 
            // gradient1
            // 
            this.gradient1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradient1.ColorBottom = System.Drawing.Color.Teal;
            this.gradient1.ColorTop = System.Drawing.Color.LightSeaGreen;
            this.gradient1.Controls.Add(this.panel_progress);
            this.gradient1.Controls.Add(this.turnLabel);
            this.gradient1.Location = new System.Drawing.Point(0, 340);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(799, 110);
            this.gradient1.TabIndex = 7;
            // 
            // panel_progress
            // 
            this.panel_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(32)))));
            this.panel_progress.Location = new System.Drawing.Point(0, 0);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(800, 30);
            this.panel_progress.TabIndex = 5;
            // 
            // SimonMiranMeir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.red);
            this.Controls.Add(this.pic_circle);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.gradient1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimonMiranMeir";
            this.Text = " Simon Says";
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_circle)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.PictureBox pic_circle;
        private Gradient gradient1;
        private System.Windows.Forms.Panel panel_progress;
    }
}

