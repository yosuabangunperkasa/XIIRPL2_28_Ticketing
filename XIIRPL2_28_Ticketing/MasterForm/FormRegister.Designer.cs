namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(319, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri anda agar bisa menggunakan bromo airlanes";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 177);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 228);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 277);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 329);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 329);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 23);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(246, 378);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 12;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 498);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 13;
            label8.Text = "Sudah punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(149, 498);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login disini";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 280);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 542);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label8;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
    }
}