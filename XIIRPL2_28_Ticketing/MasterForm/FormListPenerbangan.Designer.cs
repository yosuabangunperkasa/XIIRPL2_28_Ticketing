namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class FormListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPenerbangan));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(28, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 63);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 14;
            label2.Text = "Juanda (SUB)";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 13;
            label1.Text = "List Penerbangan";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(17, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "00:00-16.00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 28);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 1;
            label3.Text = "Waktu Penerbangan";
            label3.Click += label3_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(143, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 21);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "00:00-16.00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(258, 56);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(94, 21);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "00:00-16.00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(386, 56);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(94, 21);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "00:00-16.00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 94);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 5;
            label4.Text = "urutan Berdasarkan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(726, 191);
            dataGridView1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 20);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 62);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 17;
            label5.Text = "Mon, 22 May 2023";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 62);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 18;
            label6.Text = "Soekarno-Hatta (CGK)";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 21);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(404, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 21);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 62);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 21;
            label7.Text = "1 penumpang";
            // 
            // FormListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormListPenerbangan";
            Text = "FormListPenerbangan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label3;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label7;
    }
}