﻿namespace Drawing
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.draw_area = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // draw_area
            // 
            this.draw_area.Location = new System.Drawing.Point(12, 12);
            this.draw_area.Name = "draw_area";
            this.draw_area.Size = new System.Drawing.Size(776, 426);
            this.draw_area.TabIndex = 0;
            this.draw_area.TabStop = false;
            this.draw_area.Paint += new System.Windows.Forms.PaintEventHandler(this.draw_area_Paint);
            this.draw_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseDown);
            this.draw_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.draw_area);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox draw_area;
    }
}

