using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace XIIRPL2_28_Ticketing.MasterForm
{
    public partial class MasterJadwalPenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_jadwal_penerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO tbl_jadwal_penerbangan (kode_penerbangan,bandara_keberangkatan_id,bandara_tujuan_id,maskapai_id,tanggal_waktu_keberangkatan,durasi_penerbangan,harga_pertiket) VALUES ('" + txtcodepenerbangan.Text + "','" + txtdari.Text + "','" + txtke.Text + "','" + txtmaskapai.Text + "', '" + txttanggal.Text + "','" + txtwaktu_keberangkatan.Text + "','" + txtwaktu_keberangkatan.Text + "','" + txthargapertiket + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil simpan data bandara");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_jadwal_penerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil hapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak berhasil dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }
    }

}
