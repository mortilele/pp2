namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_menu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.color_picker = new System.Windows.Forms.Button();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.eraser_pick = new System.Windows.Forms.Button();
            this.fill_click = new System.Windows.Forms.Button();
            this.pencil_pick = new System.Windows.Forms.Button();
            this.size_pick = new System.Windows.Forms.ComboBox();
            this.figure_panel = new System.Windows.Forms.Panel();
            this.star_pick = new System.Windows.Forms.Button();
            this.right_triangle_pick = new System.Windows.Forms.Button();
            this.triangle_pick = new System.Windows.Forms.Button();
            this.rectangle_pick = new System.Windows.Forms.Button();
            this.ellipse_pick = new System.Windows.Forms.Button();
            this.dif_line_pick = new System.Windows.Forms.Button();
            this.line_pick = new System.Windows.Forms.Button();
            this.draw_area = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.caption = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tool_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tool_panel.SuspendLayout();
            this.figure_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(812, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveToolStripMenuItem.Text = "Open";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openToolStripMenuItem.Text = "Save";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tool_menu
            // 
            this.tool_menu.BackColor = System.Drawing.SystemColors.Menu;
            this.tool_menu.Controls.Add(this.pictureBox3);
            this.tool_menu.Controls.Add(this.pictureBox2);
            this.tool_menu.Controls.Add(this.pictureBox1);
            this.tool_menu.Controls.Add(this.label4);
            this.tool_menu.Controls.Add(this.label3);
            this.tool_menu.Controls.Add(this.label2);
            this.tool_menu.Controls.Add(this.label1);
            this.tool_menu.Controls.Add(this.color_picker);
            this.tool_menu.Controls.Add(this.tool_panel);
            this.tool_menu.Controls.Add(this.size_pick);
            this.tool_menu.Controls.Add(this.figure_panel);
            this.tool_menu.Location = new System.Drawing.Point(0, 22);
            this.tool_menu.Margin = new System.Windows.Forms.Padding(4);
            this.tool_menu.Name = "tool_menu";
            this.tool_menu.Size = new System.Drawing.Size(812, 107);
            this.tool_menu.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.Location = new System.Drawing.Point(693, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(4, 106);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(576, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(4, 106);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(271, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4, 106);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Figures";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tools";
            // 
            // color_picker
            // 
            this.color_picker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color_picker.BackgroundImage")));
            this.color_picker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.color_picker.FlatAppearance.BorderSize = 0;
            this.color_picker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_picker.Location = new System.Drawing.Point(713, 4);
            this.color_picker.Margin = new System.Windows.Forms.Padding(4);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(75, 75);
            this.color_picker.TabIndex = 4;
            this.color_picker.UseVisualStyleBackColor = true;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click_1);
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.White;
            this.tool_panel.Controls.Add(this.button2);
            this.tool_panel.Controls.Add(this.eraser_pick);
            this.tool_panel.Controls.Add(this.fill_click);
            this.tool_panel.Controls.Add(this.pencil_pick);
            this.tool_panel.Location = new System.Drawing.Point(13, 4);
            this.tool_panel.Margin = new System.Windows.Forms.Padding(4);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(231, 75);
            this.tool_panel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(180, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clear_Click);
            // 
            // eraser_pick
            // 
            this.eraser_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser_pick.BackgroundImage")));
            this.eraser_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraser_pick.FlatAppearance.BorderSize = 0;
            this.eraser_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser_pick.Location = new System.Drawing.Point(128, 20);
            this.eraser_pick.Margin = new System.Windows.Forms.Padding(4);
            this.eraser_pick.Name = "eraser_pick";
            this.eraser_pick.Size = new System.Drawing.Size(38, 35);
            this.eraser_pick.TabIndex = 0;
            this.eraser_pick.UseVisualStyleBackColor = true;
            this.eraser_pick.Click += new System.EventHandler(this.eraser_pick_Click);
            // 
            // fill_click
            // 
            this.fill_click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill_click.BackgroundImage")));
            this.fill_click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fill_click.FlatAppearance.BorderSize = 0;
            this.fill_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill_click.Location = new System.Drawing.Point(68, 17);
            this.fill_click.Margin = new System.Windows.Forms.Padding(4);
            this.fill_click.Name = "fill_click";
            this.fill_click.Size = new System.Drawing.Size(38, 35);
            this.fill_click.TabIndex = 0;
            this.fill_click.UseVisualStyleBackColor = true;
            this.fill_click.Click += new System.EventHandler(this.fill_click_Click);
            // 
            // pencil_pick
            // 
            this.pencil_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil_pick.BackgroundImage")));
            this.pencil_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencil_pick.FlatAppearance.BorderSize = 0;
            this.pencil_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil_pick.Location = new System.Drawing.Point(8, 17);
            this.pencil_pick.Margin = new System.Windows.Forms.Padding(4);
            this.pencil_pick.Name = "pencil_pick";
            this.pencil_pick.Size = new System.Drawing.Size(38, 35);
            this.pencil_pick.TabIndex = 0;
            this.pencil_pick.UseVisualStyleBackColor = true;
            this.pencil_pick.Click += new System.EventHandler(this.pencil_pick_Click);
            // 
            // size_pick
            // 
            this.size_pick.Items.AddRange(new object[] {
            ". . . . . . ",
            "-------",
            "=====",
            "##### "});
            this.size_pick.Location = new System.Drawing.Point(594, 26);
            this.size_pick.Margin = new System.Windows.Forms.Padding(4);
            this.size_pick.Name = "size_pick";
            this.size_pick.Size = new System.Drawing.Size(85, 26);
            this.size_pick.TabIndex = 2;
            this.size_pick.Text = "-------";
            this.size_pick.SelectedIndexChanged += new System.EventHandler(this.size_pick_SelectedIndexChanged);
            // 
            // figure_panel
            // 
            this.figure_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.figure_panel.Controls.Add(this.star_pick);
            this.figure_panel.Controls.Add(this.right_triangle_pick);
            this.figure_panel.Controls.Add(this.triangle_pick);
            this.figure_panel.Controls.Add(this.rectangle_pick);
            this.figure_panel.Controls.Add(this.ellipse_pick);
            this.figure_panel.Controls.Add(this.dif_line_pick);
            this.figure_panel.Controls.Add(this.line_pick);
            this.figure_panel.Location = new System.Drawing.Point(298, 4);
            this.figure_panel.Margin = new System.Windows.Forms.Padding(4);
            this.figure_panel.Name = "figure_panel";
            this.figure_panel.Size = new System.Drawing.Size(260, 75);
            this.figure_panel.TabIndex = 1;
            // 
            // star_pick
            // 
            this.star_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("star_pick.BackgroundImage")));
            this.star_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.star_pick.FlatAppearance.BorderSize = 0;
            this.star_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_pick.Location = new System.Drawing.Point(62, 36);
            this.star_pick.Margin = new System.Windows.Forms.Padding(4);
            this.star_pick.Name = "star_pick";
            this.star_pick.Size = new System.Drawing.Size(38, 35);
            this.star_pick.TabIndex = 0;
            this.star_pick.UseVisualStyleBackColor = true;
            this.star_pick.Click += new System.EventHandler(this.star_pick_Click);
            // 
            // right_triangle_pick
            // 
            this.right_triangle_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_triangle_pick.BackgroundImage")));
            this.right_triangle_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.right_triangle_pick.FlatAppearance.BorderSize = 0;
            this.right_triangle_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_triangle_pick.Location = new System.Drawing.Point(7, 36);
            this.right_triangle_pick.Margin = new System.Windows.Forms.Padding(4);
            this.right_triangle_pick.Name = "right_triangle_pick";
            this.right_triangle_pick.Size = new System.Drawing.Size(38, 35);
            this.right_triangle_pick.TabIndex = 0;
            this.right_triangle_pick.UseVisualStyleBackColor = true;
            this.right_triangle_pick.Click += new System.EventHandler(this.right_triangle_pick_Click);
            // 
            // triangle_pick
            // 
            this.triangle_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle_pick.BackgroundImage")));
            this.triangle_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.triangle_pick.FlatAppearance.BorderSize = 0;
            this.triangle_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle_pick.Location = new System.Drawing.Point(214, 5);
            this.triangle_pick.Margin = new System.Windows.Forms.Padding(4);
            this.triangle_pick.Name = "triangle_pick";
            this.triangle_pick.Size = new System.Drawing.Size(38, 35);
            this.triangle_pick.TabIndex = 0;
            this.triangle_pick.UseVisualStyleBackColor = true;
            this.triangle_pick.Click += new System.EventHandler(this.triangle_pick_Click);
            // 
            // rectangle_pick
            // 
            this.rectangle_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle_pick.BackgroundImage")));
            this.rectangle_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rectangle_pick.FlatAppearance.BorderSize = 0;
            this.rectangle_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle_pick.Location = new System.Drawing.Point(168, 5);
            this.rectangle_pick.Margin = new System.Windows.Forms.Padding(4);
            this.rectangle_pick.Name = "rectangle_pick";
            this.rectangle_pick.Size = new System.Drawing.Size(38, 35);
            this.rectangle_pick.TabIndex = 0;
            this.rectangle_pick.UseVisualStyleBackColor = true;
            this.rectangle_pick.Click += new System.EventHandler(this.rectangle_pick_Click);
            // 
            // ellipse_pick
            // 
            this.ellipse_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse_pick.BackgroundImage")));
            this.ellipse_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipse_pick.FlatAppearance.BorderSize = 0;
            this.ellipse_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipse_pick.Location = new System.Drawing.Point(114, 5);
            this.ellipse_pick.Margin = new System.Windows.Forms.Padding(4);
            this.ellipse_pick.Name = "ellipse_pick";
            this.ellipse_pick.Size = new System.Drawing.Size(38, 35);
            this.ellipse_pick.TabIndex = 0;
            this.ellipse_pick.UseVisualStyleBackColor = true;
            this.ellipse_pick.Click += new System.EventHandler(this.ellipse_pick_Click);
            // 
            // dif_line_pick
            // 
            this.dif_line_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dif_line_pick.BackgroundImage")));
            this.dif_line_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dif_line_pick.FlatAppearance.BorderSize = 0;
            this.dif_line_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dif_line_pick.Location = new System.Drawing.Point(62, 5);
            this.dif_line_pick.Margin = new System.Windows.Forms.Padding(4);
            this.dif_line_pick.Name = "dif_line_pick";
            this.dif_line_pick.Size = new System.Drawing.Size(38, 35);
            this.dif_line_pick.TabIndex = 0;
            this.dif_line_pick.UseVisualStyleBackColor = true;
            // 
            // line_pick
            // 
            this.line_pick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line_pick.BackgroundImage")));
            this.line_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.line_pick.FlatAppearance.BorderSize = 0;
            this.line_pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_pick.Location = new System.Drawing.Point(7, 5);
            this.line_pick.Margin = new System.Windows.Forms.Padding(4);
            this.line_pick.Name = "line_pick";
            this.line_pick.Size = new System.Drawing.Size(38, 35);
            this.line_pick.TabIndex = 0;
            this.line_pick.UseVisualStyleBackColor = true;
            this.line_pick.Click += new System.EventHandler(this.line_pick_Click);
            // 
            // draw_area
            // 
            this.draw_area.BackColor = System.Drawing.Color.White;
            this.draw_area.Location = new System.Drawing.Point(6, 136);
            this.draw_area.Margin = new System.Windows.Forms.Padding(4);
            this.draw_area.Name = "draw_area";
            this.draw_area.Size = new System.Drawing.Size(795, 390);
            this.draw_area.TabIndex = 2;
            this.draw_area.TabStop = false;
            this.draw_area.Paint += new System.Windows.Forms.PaintEventHandler(this.draw_area_Paint);
            this.draw_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseDown);
            this.draw_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseMove);
            this.draw_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseUp);
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.BackColor = System.Drawing.Color.White;
            this.caption.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption.Location = new System.Drawing.Point(77, 0);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(59, 20);
            this.caption.TabIndex = 3;
            this.caption.Text = "| Paint";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(787, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(812, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.draw_area);
            this.Controls.Add(this.tool_menu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tool_menu.ResumeLayout(false);
            this.tool_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tool_panel.ResumeLayout(false);
            this.figure_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel tool_menu;
        private System.Windows.Forms.PictureBox draw_area;
        private System.Windows.Forms.Button color_picker;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Button eraser_pick;
        private System.Windows.Forms.Button fill_click;
        private System.Windows.Forms.Button pencil_pick;
        private System.Windows.Forms.ComboBox size_pick;
        private System.Windows.Forms.Panel figure_panel;
        private System.Windows.Forms.Button rectangle_pick;
        private System.Windows.Forms.Button ellipse_pick;
        private System.Windows.Forms.Button dif_line_pick;
        private System.Windows.Forms.Button line_pick;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button star_pick;
        private System.Windows.Forms.Button right_triangle_pick;
        private System.Windows.Forms.Button triangle_pick;
    }
}

