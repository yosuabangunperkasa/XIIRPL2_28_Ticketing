namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class MasterBandara
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            txtName = new TextBox();
            txtKota = new TextBox();
            txtAlamat = new TextBox();
            txtKodeiata = new TextBox();
            txtNegara = new ComboBox();
            txtJumlah_Terminal = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlah_Terminal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua Bandara Yang Terdaftar Akan Muncul Disini";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 344);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Nama :";
            label3.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(581, 322);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(589, 330);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(44, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 191);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 491);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 10;
            label4.Text = "Negara :";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 437);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 11;
            label5.Text = "Kota :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 391);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 12;
            label6.Text = "Kode Iata :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(511, 390);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 13;
            label7.Text = "Alamat :";
            label7.Click += label7_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(511, 344);
            label10.Name = "label10";
            label10.Size = new Size(108, 17);
            label10.TabIndex = 14;
            label10.Text = "Jumlah Terminal :";
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 338);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 15;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(179, 437);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(202, 23);
            txtKota.TabIndex = 17;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(647, 386);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(221, 74);
            txtAlamat.TabIndex = 18;
            txtAlamat.TextChanged += textBox4_TextChanged;
            // 
            // txtKodeiata
            // 
            txtKodeiata.Location = new Point(179, 390);
            txtKodeiata.Name = "txtKodeiata";
            txtKodeiata.Size = new Size(202, 23);
            txtKodeiata.TabIndex = 19;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(179, 491);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(202, 23);
            txtNegara.TabIndex = 20;
            // 
            // txtJumlah_Terminal
            // 
            txtJumlah_Terminal.Location = new Point(647, 338);
            txtJumlah_Terminal.Name = "txtJumlah_Terminal";
            txtJumlah_Terminal.Size = new Size(221, 23);
            txtJumlah_Terminal.TabIndex = 21;
            txtJumlah_Terminal.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(647, 482);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 22;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(764, 482);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 23;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 632);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtJumlah_Terminal);
            Controls.Add(txtNegara);
            Controls.Add(txtKodeiata);
            Controls.Add(txtAlamat);
            Controls.Add(txtKota);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MasterBandara";
            Text = "MasterBandara";
            Load += MasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlah_Terminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private TextBox txtName;
        private TextBox txtKota;
        private TextBox txtAlamat;
        private TextBox txtKodeiata;
        private ComboBox txtNegara;
        private NumericUpDown txtJumlah_Terminal;
        private Button button1;
        private Button button2;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}