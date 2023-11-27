namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class MasterJadwalPenerbangan
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            label3 = new Label();
            txtwaktukeberangkatan = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtcodepenerbangan = new TextBox();
            txtdari = new ComboBox();
            txtke = new ComboBox();
            txtmaskapai = new ComboBox();
            txttanggal = new DateTimePicker();
            txtwaktu_keberangkatan = new TextBox();
            txtdurasi_penerbangan = new TextBox();
            txthargapertiket = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txthargapertiket).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 15;
            label2.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(275, 30);
            label1.TabIndex = 14;
            label1.Text = "Master Jadwal Penerbagan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, BtnEdit });
            dataGridView1.Location = new Point(39, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1079, 191);
            dataGridView1.TabIndex = 13;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(545, 479);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 16;
            label3.Text = "Durasi Penerbangan :";
            label3.Click += label3_Click;
            // 
            // txtwaktukeberangkatan
            // 
            txtwaktukeberangkatan.AutoSize = true;
            txtwaktukeberangkatan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtwaktukeberangkatan.Location = new Point(545, 418);
            txtwaktukeberangkatan.Name = "txtwaktukeberangkatan";
            txtwaktukeberangkatan.Size = new Size(142, 17);
            txtwaktukeberangkatan.TabIndex = 17;
            txtwaktukeberangkatan.Text = "Waktu Keberangkatan :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(545, 357);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 18;
            label5.Text = "Tanggal :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 544);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 19;
            label6.Text = "Maskapai :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(39, 479);
            label7.Name = "label7";
            label7.Size = new Size(30, 17);
            label7.TabIndex = 20;
            label7.Text = "Ke :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 419);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 21;
            label8.Text = "Dari :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(39, 357);
            label9.Name = "label9";
            label9.Size = new Size(127, 17);
            label9.TabIndex = 22;
            label9.Text = "Code Penerbangan :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(545, 544);
            label10.Name = "label10";
            label10.Size = new Size(98, 17);
            label10.TabIndex = 23;
            label10.Text = "Harga Pertiket :";
            // 
            // txtcodepenerbangan
            // 
            txtcodepenerbangan.Location = new Point(196, 357);
            txtcodepenerbangan.Name = "txtcodepenerbangan";
            txtcodepenerbangan.Size = new Size(232, 23);
            txtcodepenerbangan.TabIndex = 24;
            // 
            // txtdari
            // 
            txtdari.FormattingEnabled = true;
            txtdari.Location = new Point(196, 418);
            txtdari.Name = "txtdari";
            txtdari.Size = new Size(232, 23);
            txtdari.TabIndex = 25;
            // 
            // txtke
            // 
            txtke.FormattingEnabled = true;
            txtke.Location = new Point(196, 479);
            txtke.Name = "txtke";
            txtke.Size = new Size(232, 23);
            txtke.TabIndex = 26;
            // 
            // txtmaskapai
            // 
            txtmaskapai.FormattingEnabled = true;
            txtmaskapai.Location = new Point(196, 544);
            txtmaskapai.Name = "txtmaskapai";
            txtmaskapai.Size = new Size(232, 23);
            txtmaskapai.TabIndex = 27;
            // 
            // txttanggal
            // 
            txttanggal.Location = new Point(707, 357);
            txttanggal.Name = "txttanggal";
            txttanggal.Size = new Size(232, 23);
            txttanggal.TabIndex = 28;
            // 
            // txtwaktu_keberangkatan
            // 
            txtwaktu_keberangkatan.Location = new Point(707, 418);
            txtwaktu_keberangkatan.Name = "txtwaktu_keberangkatan";
            txtwaktu_keberangkatan.Size = new Size(232, 23);
            txtwaktu_keberangkatan.TabIndex = 29;
            // 
            // txtdurasi_penerbangan
            // 
            txtdurasi_penerbangan.Location = new Point(707, 479);
            txtdurasi_penerbangan.Name = "txtdurasi_penerbangan";
            txtdurasi_penerbangan.Size = new Size(232, 23);
            txtdurasi_penerbangan.TabIndex = 30;
            // 
            // txthargapertiket
            // 
            txthargapertiket.Location = new Point(707, 544);
            txthargapertiket.Name = "txthargapertiket";
            txthargapertiket.Size = new Size(232, 23);
            txthargapertiket.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(836, 588);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(712, 588);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // MasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 632);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txthargapertiket);
            Controls.Add(txtdurasi_penerbangan);
            Controls.Add(txtwaktu_keberangkatan);
            Controls.Add(txttanggal);
            Controls.Add(txtmaskapai);
            Controls.Add(txtke);
            Controls.Add(txtdari);
            Controls.Add(txtcodepenerbangan);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtwaktukeberangkatan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MasterJadwalPenerbangan";
            Text = "MasterJadwalPenerbangan";
            Load += MasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txthargapertiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label txtwaktukeberangkatan;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtcodepenerbangan;
        private ComboBox txtdari;
        private ComboBox txtke;
        private ComboBox txtmaskapai;
        private DateTimePicker txttanggal;
        private TextBox txtwaktu_keberangkatan;
        private TextBox txtdurasi_penerbangan;
        private NumericUpDown txthargapertiket;
        private Button button2;
        private Button button1;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnEdit;
    }
}