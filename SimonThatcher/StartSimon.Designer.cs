﻿namespace SimonThatcher
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
            this.button1 = new System.Windows.Forms.Button();
            this.easyB = new System.Windows.Forms.Button();
            this.ohNoB = new System.Windows.Forms.Button();
            this.UCryB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(503, 331);
            this.button1.TabIndex = 0;
            this.button1.Text = "START THE GAME BROOO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // easyB
            // 
            this.easyB.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyB.Location = new System.Drawing.Point(650, 49);
            this.easyB.Name = "easyB";
            this.easyB.Size = new System.Drawing.Size(127, 86);
            this.easyB.TabIndex = 2;
            this.easyB.Text = "Easy";
            this.easyB.UseVisualStyleBackColor = true;
            this.easyB.Click += new System.EventHandler(this.easyB_Click);
            // 
            // ohNoB
            // 
            this.ohNoB.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohNoB.Location = new System.Drawing.Point(650, 176);
            this.ohNoB.Name = "ohNoB";
            this.ohNoB.Size = new System.Drawing.Size(127, 86);
            this.ohNoB.TabIndex = 2;
            this.ohNoB.Text = "Oh no";
            this.ohNoB.UseVisualStyleBackColor = true;
            this.ohNoB.Click += new System.EventHandler(this.ohNoB_Click);
            // 
            // UCryB
            // 
            this.UCryB.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCryB.Location = new System.Drawing.Point(650, 294);
            this.UCryB.Name = "UCryB";
            this.UCryB.Size = new System.Drawing.Size(127, 86);
            this.UCryB.TabIndex = 2;
            this.UCryB.Text = "U Cry";
            this.UCryB.UseVisualStyleBackColor = true;
            this.UCryB.Click += new System.EventHandler(this.UCryB_Click);
            // 
            // StartSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UCryB);
            this.Controls.Add(this.ohNoB);
            this.Controls.Add(this.easyB);
            this.Controls.Add(this.button1);
            this.Name = "StartSimon";
            this.Text = "StartSimon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button easyB;
        private System.Windows.Forms.Button ohNoB;
        private System.Windows.Forms.Button UCryB;
    }
}