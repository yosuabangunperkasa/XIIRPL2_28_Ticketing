namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class MasterMaskpaics
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
            dataGridView1 = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtDeskripsi = new TextBox();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            button1 = new Button();
            btnSimpan = new Button();
            txtJumlahKru = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, BtnEdit });
            dataGridView1.Location = new Point(24, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 191);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 11;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 86);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 12;
            label2.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(515, 371);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 19;
            label10.Text = "Deskripsi :";
            label10.Click += label10_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 436);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 18;
            label6.Text = "Perusahaan :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 509);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 17;
            label5.Text = "Jumlah Kru :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 370);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 16;
            label3.Text = "Nama :";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(617, 370);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(227, 89);
            txtDeskripsi.TabIndex = 20;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(134, 436);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(216, 23);
            txtPerusahaan.TabIndex = 21;
            txtPerusahaan.TextChanged += textBox2_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(134, 370);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(216, 23);
            txtNama.TabIndex = 22;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(617, 494);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 23;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(741, 494);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(103, 32);
            btnSimpan.TabIndex = 24;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(134, 509);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(216, 23);
            txtJumlahKru.TabIndex = 25;
            txtJumlahKru.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // MasterMaskpaics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 605);
            Controls.Add(txtJumlahKru);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtNama);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtDeskripsi);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MasterMaskpaics";
            Text = "MasterMaskapai";
            Load += MasterMaskpaics_Load;
            Click += MasterMaskpaics_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtDeskripsi;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Button button1;
        private Button btnSimpan;
        private NumericUpDown txtJumlahKru;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnEdit;
    }
}