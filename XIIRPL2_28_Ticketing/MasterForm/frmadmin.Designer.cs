namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 75);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 0, 192);
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(261, 75);
            button6.TabIndex = 3;
            button6.Text = "Dashboar";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-1, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 533);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Purple;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(86, 487);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LogOut";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = Color.Yellow;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 466);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 214);
            button5.Name = "button5";
            button5.Size = new Size(261, 55);
            button5.TabIndex = 6;
            button5.Text = "Ubah Status Penerbangan";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 161);
            button4.Name = "button4";
            button4.Size = new Size(261, 55);
            button4.TabIndex = 5;
            button4.Text = "Master Kode Promo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 107);
            button3.Name = "button3";
            button3.Size = new Size(261, 55);
            button3.TabIndex = 4;
            button3.Text = "Master Jadwal Penerbangan";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 55);
            button2.Name = "button2";
            button2.Size = new Size(261, 55);
            button2.TabIndex = 3;
            button2.Text = "Master Maskapai";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 2);
            button1.Name = "button1";
            button1.Size = new Size(261, 55);
            button1.TabIndex = 2;
            button1.Text = "Master Bandara";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 597);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmadmin";
            Text = "frmPanel";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}