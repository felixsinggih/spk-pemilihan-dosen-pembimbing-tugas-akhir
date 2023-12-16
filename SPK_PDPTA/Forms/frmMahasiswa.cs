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
    public partial class frmMahasiswa : Form
    {
        servMahasiswa mhs = new servMahasiswa();
        public frmMahasiswa()
        {
            InitializeComponent();
        }

        private void frmMahasiswa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            LoadAgama();
            LoadProdi();
            Tampil();
        }
        void LoadAgama()
        {
            cmbAgama.Items.Clear();
            cmbAgama.Items.Add("Islam");
            cmbAgama.Items.Add("Kristen");
            cmbAgama.Items.Add("Katholik");
            cmbAgama.Items.Add("Hindu");
            cmbAgama.Items.Add("Buddha");
            cmbAgama.Items.Add("Kong Hu Cu");
        }
        void LoadProdi()
        {
            cmbProdi.Items.Clear();
            cmbProdi.Items.Add("Teknik Informatika");
        }
        void Clear()
        {
            txtNpm.Text = "";
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
            cmbProdi.SelectedIndex = -1;
        }
        void LoadDataMhs()
        {
            Mahasiswa cell;
            if (mhs.Cek(txtNpm.Text))
            {
                cell = new Mahasiswa();
                cell = mhs.TampilDataByNpm(txtNpm.Text);

                txtNama.Text = cell.NAMA_MHS;
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
                cmbProdi.Text = cell.PRODI;
            }
        }

        //CRUD
        void Simpan()
        {
            if (!(mhs.Cek(txtNpm.Text)))
            {
                mhs.NPM = txtNpm.Text;
                mhs.NAMA_MHS = txtNama.Text;
                mhs.TEMPAT_LHR = txtTempat.Text;
                mhs.TGL_LHR = dtpTanggal.Value.ToString("yyyy-MM-dd");
                if (rbtLaki.Checked == true)
                {
                    mhs.JNS_KELAMIN = rbtLaki.Text;
                }
                else
                {
                    mhs.JNS_KELAMIN = rbtPerempuan.Text;
                }
                mhs.AGAMA = cmbAgama.Text;
                mhs.ALAMAT = txtAlamat.Text;
                mhs.TELP = txtTelp.Text;
                mhs.EMAIL = txtEmail.Text;
                mhs.STATUS = cmbStatus.Text;
                mhs.PRODI = cmbProdi.Text;

                mhs.Simpan();
                MessageBox.Show("Data berhasil disimpan!", "Simpan Data");
                Clear();
                pnlMahasiswa.Visible = true;
                Tampil();
            }
            else
            {
                MessageBox.Show("Data sudah ada!", "PERINGATAN");
            }
        }
        void Ubah()
        {
            if (mhs.Cek(txtNpm.Text))
            {
                if (MessageBox.Show("Data tersebut akan diubah? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mhs.NAMA_MHS = txtNama.Text;
                    mhs.TEMPAT_LHR = txtTempat.Text;
                    mhs.TGL_LHR = dtpTanggal.Value.ToString("yyyy-MM-dd");
                    if (rbtLaki.Checked == true)
                    {
                        mhs.JNS_KELAMIN = rbtLaki.Text;
                    }
                    else
                    {
                        mhs.JNS_KELAMIN = rbtPerempuan.Text;
                    }
                    mhs.AGAMA = cmbAgama.Text;
                    mhs.ALAMAT = txtAlamat.Text;
                    mhs.TELP = txtTelp.Text;
                    mhs.EMAIL = txtEmail.Text;
                    mhs.STATUS = cmbStatus.Text;
                    mhs.PRODI = cmbProdi.Text;

                    mhs.Ubah(txtNpm.Text);
                    MessageBox.Show("Data berhasil diubah!", "Ubah Data");
                    Clear();
                    pnlMahasiswa.Visible = true;
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
            dgvMahasiswa.DataSource = mhs.Tampil();
        }

        //button
        private void metroTile3_Click(object sender, EventArgs e)
        {
            Clear();
            pnlMahasiswa.Visible = false;
            btnSimpan.Text = "Simpan";
            lblHeader.Text = "Tambah Data Mahasiswa";
            txtNpm.Focus();
        }

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

        private void mtBatal_Click(object sender, EventArgs e)
        {
            Clear();
            pnlMahasiswa.Visible = true;
        }

        //datagrid
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMahasiswa.DataSource;
            bs.Filter = dgvMahasiswa.Columns["nama"].DataPropertyName.ToString() + " LIKE '%" + txtCari.Text + "%'";
            dgvMahasiswa.DataSource = bs;
        }
        private void dgvMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMahasiswa.Columns[e.ColumnIndex].HeaderText == "Aksi")
            {
                DataGridViewRow row = this.dgvMahasiswa.Rows[e.RowIndex];
                txtNpm.Text = row.Cells["npm"].Value.ToString();
                pnlMahasiswa.Visible = false;
                btnSimpan.Text = "Ubah";
                lblHeader.Text = "Edit Data Mahasiswa";
            }
            LoadDataMhs();
        }
    }
}
