using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPK_PDPTA.Class;

namespace SPK_PDPTA.Forms
{
    public partial class frmDosen : Form
    {
        servKamusKata kam = new servKamusKata();
        servDosen dos = new servDosen();
        public frmDosen()
        {
            InitializeComponent();
        }

        private void frmDosen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            LoadNamaKbk();
            Tampil();
        }
        void Clear()
        {
            txtNidn.Text = "";
            txtNama.Text = "";
            txtTempat.Text = "";
            dtpTanggal.Value = DateTime.Now;
            rbtLaki.Checked = false;
            rbtPerempuan.Checked = false;
            cmbAgama.SelectedIndex = -1;
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtEmail.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbKbk.SelectedIndex = -1;
            txtKode.Text = "";
        }
        void LoadNamaKbk()
        {
            for (int i = 0; i <= kam.TampilKBK().Rows.Count - 1; i++)
            {
                cmbKbk.Items.Add(kam.TampilKBK().Rows[i].ItemArray[1]);
            }
        }
        void LoadKodeKbk()
        {
            KBK cell;
            cell = new KBK();
            cell = kam.TampilDataByNama(cmbKbk.Text);
            txtKode.Text = cell.KODE_KBK;
        }
        void LoadDataDsn()
        {
            Dosen cell;
            if (dos.Cek(txtNidn.Text))
            {
                cell = new Dosen();
                cell = dos.TampilDataByNidn(txtNidn.Text);

                txtNama.Text = cell.NAMA_DSN;
                txtTempat.Text = cell.TEMPAT_LHR;
                dtpTanggal.Text = cell.TGL_LHR;
                if (cell.JNS_KELAMIN == "Laki-laki")
                {
                    rbtLaki.Checked = true;
                }
                else
                {
                    rbtPerempuan.Checked = true;
                }
                cmbAgama.Text = cell.AGAMA;
                txtAlamat.Text = cell.ALAMAT;
                txtTelp.Text = cell.TELP;
                txtEmail.Text = cell.EMAIL;
                cmbStatus.Text = cell.STATUS;
                cmbKbk.Text = cell.KODE_KBK;
            }
        }

        //CRUD
        void Simpan()
        {
            if (!(dos.Cek(txtNidn.Text)))
            {
                dos.NIDN = txtNidn.Text;
                dos.NAMA_DSN = txtNama.Text;
                dos.TEMPAT_LHR = txtTempat.Text;
                dos.TGL_LHR = dtpTanggal.Value.ToString("yyyy-MM-dd");
                if (rbtLaki.Checked == true)
                {
                    dos.JNS_KELAMIN = rbtLaki.Text;
                }
                else
                {
                    dos.JNS_KELAMIN = rbtPerempuan.Text;
                }
                dos.AGAMA = cmbAgama.Text;
                dos.ALAMAT = txtAlamat.Text;
                dos.TELP = txtTelp.Text;
                dos.EMAIL = txtEmail.Text;
                dos.STATUS = cmbStatus.Text;
                dos.KODE_KBK = txtKode.Text;

                dos.Simpan();
                MessageBox.Show("Data berhasil disimpan!", "Simpan Data");
                Clear();
                pnlDosen.Visible = true;
                Tampil();
            }
            else
            {
                MessageBox.Show("Data sudah ada!", "PERINGATAN");
            }
        }
        void Ubah()
        {
            if (dos.Cek(txtNidn.Text))
            {
                if (MessageBox.Show("Data tersebut akan diubah? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dos.NAMA_DSN = txtNama.Text;
                    dos.TEMPAT_LHR = txtTempat.Text;
                    dos.TGL_LHR = dtpTanggal.Value.ToString("yyyy-MM-dd");
                    if (rbtLaki.Checked == true)
                    {
                        dos.JNS_KELAMIN = rbtLaki.Text;
                    }
                    else
                    {
                        dos.JNS_KELAMIN = rbtPerempuan.Text;
                    }
                    dos.AGAMA = cmbAgama.Text;
                    dos.ALAMAT = txtAlamat.Text;
                    dos.TELP = txtTelp.Text;
                    dos.EMAIL = txtEmail.Text;
                    dos.STATUS = cmbStatus.Text;
                    dos.KODE_KBK = txtKode.Text;

                    dos.Ubah(txtNidn.Text);
                    MessageBox.Show("Data berhasil diubah!", "Ubah Data");
                    Clear();
                    pnlDosen.Visible = true;
                    Tampil();
                }
            }
            else
            {
                MessageBox.Show("Data tidak ada", "PERINGATAN");
            }
        }
        void Tampil()
        {
            dgvDosen.DataSource = dos.Tampil();
        }

        //button
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text == "Simpan")
            {
                Simpan();
            }
            else
            {
                Ubah();
            }
        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            Clear();
            pnlDosen.Visible = false;
            btnSimpan.Text = "Simpan";
            lblHeader.Text = "Tambah Data Dosen";
            txtNidn.Focus();
        }
        private void mtBatal_Click(object sender, EventArgs e)
        {
            Clear();
            pnlDosen.Visible = true;
        }

        //datagrid
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDosen.DataSource;
            bs.Filter = dgvDosen.Columns["nama"].DataPropertyName.ToString() + " LIKE '%" + txtCari.Text + "%'";
            dgvDosen.DataSource = bs;
        }
        private void dgvDosen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDosen.Columns[e.ColumnIndex].HeaderText == "Aksi")
            {
                DataGridViewRow row = this.dgvDosen.Rows[e.RowIndex];
                txtNidn.Text = row.Cells["nidn"].Value.ToString();
                pnlDosen.Visible = false;
                btnSimpan.Text = "Ubah";
                lblHeader.Text = "Edit Data Dosen";
            }
            LoadDataDsn();
        }

        private void cmbKbk_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKodeKbk();
        }
    }
}
