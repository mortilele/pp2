namespace Calculator
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
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.editer = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndiv
            // 
            this.btndiv.AutoSize = true;
            this.btndiv.BackColor = System.Drawing.SystemColors.Window;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndiv.Location = new System.Drawing.Point(267, 10);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 34);
            this.btndiv.TabIndex = 0;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.AutoSize = true;
            this.btnmulti.BackColor = System.Drawing.SystemColors.Window;
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnmulti.Location = new System.Drawing.Point(267, 53);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(75, 34);
            this.btnmulti.TabIndex = 0;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnsub
            // 
            this.btnsub.AutoSize = true;
            this.btnsub.BackColor = System.Drawing.SystemColors.Window;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsub.Location = new System.Drawing.Point(267, 93);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 34);
            this.btnsub.TabIndex = 0;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsum
            // 
            this.btnsum.AutoSize = true;
            this.btnsum.BackColor = System.Drawing.SystemColors.Window;
            this.btnsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsum.Location = new System.Drawing.Point(267, 133);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(75, 34);
            this.btnsum.TabIndex = 0;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.SystemColors.Window;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(174, 53);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 34);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.SystemColors.Window;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(93, 53);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 34);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.SystemColors.Window;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(12, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 34);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.SystemColors.Window;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(12, 93);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 34);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.SystemColors.Window;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(93, 93);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 34);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.SystemColors.Window;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(174, 93);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 34);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.SystemColors.Window;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(93, 133);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 34);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.SystemColors.Window;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(12, 133);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 34);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.SystemColors.Window;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(174, 133);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 34);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnreset
            // 
            this.btnreset.AutoSize = true;
            this.btnreset.BackColor = System.Drawing.SystemColors.Window;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnreset.Location = new System.Drawing.Point(12, 173);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 34);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "C";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.SystemColors.Window;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(93, 173);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 34);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnpow
            // 
            this.btnpow.AutoSize = true;
            this.btnpow.BackColor = System.Drawing.SystemColors.Window;
            this.btnpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpow.Location = new System.Drawing.Point(174, 173);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(75, 34);
            this.btnpow.TabIndex = 0;
            this.btnpow.Text = "^";
            this.btnpow.UseVisualStyleBackColor = false;
            this.btnpow.Click += new System.EventHandler(this.btnpow_Click);
            // 
            // btnequal
            // 
            this.btnequal.AutoSize = true;
            this.btnequal.BackColor = System.Drawing.SystemColors.Window;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnequal.Location = new System.Drawing.Point(267, 173);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(75, 34);
            this.btnequal.TabIndex = 0;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // editer
            // 
            this.editer.AccessibleName = "";
            this.editer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editer.Location = new System.Drawing.Point(12, 12);
            this.editer.Name = "editer";
            this.editer.Size = new System.Drawing.Size(237, 29);
            this.editer.TabIndex = 1;
            this.editer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation.Location = new System.Drawing.Point(12, 209);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(0, 24);
            this.operation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(357, 248);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.editer);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btndiv);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox editer;
        private System.Windows.Forms.Label operation;
    }
}

