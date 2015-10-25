namespace SimpleWebScraper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andréRodriguesMeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Images = new System.Windows.Forms.CheckBox();
            this.Sounds = new System.Windows.Forms.CheckBox();
            this.Videos = new System.Windows.Forms.CheckBox();
            this.Documents = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(20, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(562, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(264, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Scrap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(21, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dest. Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(102, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(480, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.andréRodriguesMeloToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // andréRodriguesMeloToolStripMenuItem
            // 
            this.andréRodriguesMeloToolStripMenuItem.Name = "andréRodriguesMeloToolStripMenuItem";
            this.andréRodriguesMeloToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.andréRodriguesMeloToolStripMenuItem.Text = "By : André Rodrigues melo";
            // 
            // Images
            // 
            this.Images.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Images.AutoSize = true;
            this.Images.Location = new System.Drawing.Point(172, 105);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(60, 17);
            this.Images.TabIndex = 5;
            this.Images.Text = "Images";
            this.Images.UseVisualStyleBackColor = true;
            // 
            // Sounds
            // 
            this.Sounds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sounds.AutoSize = true;
            this.Sounds.Location = new System.Drawing.Point(238, 105);
            this.Sounds.Name = "Sounds";
            this.Sounds.Size = new System.Drawing.Size(62, 17);
            this.Sounds.TabIndex = 6;
            this.Sounds.Text = "Sounds";
            this.Sounds.UseVisualStyleBackColor = true;
            // 
            // Videos
            // 
            this.Videos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Videos.AutoSize = true;
            this.Videos.Location = new System.Drawing.Point(306, 105);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(58, 17);
            this.Videos.TabIndex = 7;
            this.Videos.Text = "Videos";
            this.Videos.UseVisualStyleBackColor = true;
            // 
            // Documents
            // 
            this.Documents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Documents.AutoSize = true;
            this.Documents.Location = new System.Drawing.Point(370, 105);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(80, 17);
            this.Documents.TabIndex = 8;
            this.Documents.Text = "Documents";
            this.Documents.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 157);
            this.Controls.Add(this.Documents);
            this.Controls.Add(this.Videos);
            this.Controls.Add(this.Sounds);
            this.Controls.Add(this.Images);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Web Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andréRodriguesMeloToolStripMenuItem;
        private System.Windows.Forms.CheckBox Images;
        private System.Windows.Forms.CheckBox Sounds;
        private System.Windows.Forms.CheckBox Videos;
        private System.Windows.Forms.CheckBox Documents;
    }
}

