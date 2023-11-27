namespace XIIRPL2_28_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            dataGridView1 = new DataGridView();
            txtkode_promo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBerlaku_sampai = new DateTimePicker();
            txtpersentase_diskon = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            txtmaksimun_diskon = new NumericUpDown();
            label7 = new Label();
            txtdeskripsi = new TextBox();
            btn_simpan = new Button();
            button1 = new Button();
            BtnDelete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpersentase_diskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimun_diskon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 1;
            label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(293, 15);
            label2.TabIndex = 2;
            label2.Text = "Semua Kode Promo yang Terdaftar akan Muncul disini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, BtnEdit });
            dataGridView1.Location = new Point(26, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 178);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtkode_promo
            // 
            txtkode_promo.Location = new Point(149, 301);
            txtkode_promo.Name = "txtkode_promo";
            txtkode_promo.Size = new Size(209, 23);
            txtkode_promo.TabIndex = 11;
            txtkode_promo.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 304);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 12;
            label3.Text = "Kode Promo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 362);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 13;
            label4.Text = "Berlaku Sampai :";
            // 
            // txtBerlaku_sampai
            // 
            txtBerlaku_sampai.Format = DateTimePickerFormat.Short;
            txtBerlaku_sampai.Location = new Point(149, 356);
            txtBerlaku_sampai.Name = "txtBerlaku_sampai";
            txtBerlaku_sampai.Size = new Size(209, 23);
            txtBerlaku_sampai.TabIndex = 14;
            txtBerlaku_sampai.ValueChanged += txtBerlaku_sampai_ValueChanged;
            // 
            // txtpersentase_diskon
            // 
            txtpersentase_diskon.Location = new Point(149, 411);
            txtpersentase_diskon.Name = "txtpersentase_diskon";
            txtpersentase_diskon.Size = new Size(209, 23);
            txtpersentase_diskon.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 411);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 16;
            label5.Text = "Persentase Diskon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 470);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 17;
            label6.Text = "Maksimum Diskon :";
            // 
            // txtmaksimun_diskon
            // 
            txtmaksimun_diskon.Location = new Point(149, 462);
            txtmaksimun_diskon.Name = "txtmaksimun_diskon";
            txtmaksimun_diskon.Size = new Size(209, 23);
            txtmaksimun_diskon.TabIndex = 18;
            txtmaksimun_diskon.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(479, 307);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 19;
            label7.Text = "Deskripsi :";
            // 
            // txtdeskripsi
            // 
            txtdeskripsi.Location = new Point(572, 301);
            txtdeskripsi.Multiline = true;
            txtdeskripsi.Name = "txtdeskripsi";
            txtdeskripsi.Size = new Size(231, 78);
            txtdeskripsi.TabIndex = 20;
            // 
            // btn_simpan
            // 
            btn_simpan.Location = new Point(694, 403);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(83, 23);
            btn_simpan.TabIndex = 44;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(570, 403);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 43;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 497);
            Controls.Add(btn_simpan);
            Controls.Add(button1);
            Controls.Add(txtdeskripsi);
            Controls.Add(label7);
            Controls.Add(txtmaksimun_diskon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtpersentase_diskon);
            Controls.Add(txtBerlaku_sampai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtkode_promo);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            Load += FormMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtpersentase_diskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtmaksimun_diskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox txtkode_promo;
        private Label label3;
        private Label label4;
        private DateTimePicker txtBerlaku_sampai;
        private NumericUpDown txtpersentase_diskon;
        private Label label5;
        private Label label6;
        private NumericUpDown txtmaksimun_diskon;
        private Label label7;
        private TextBox txtdeskripsi;
        private Button btn_simpan;
        private Button button1;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnEdit;
    }
}