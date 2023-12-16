namespace SPK_PDPTA.Forms
{
    partial class frmMahasiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtCari = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pnlMahasiswa = new MetroFramework.Controls.MetroPanel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dgvMahasiswa = new MetroFramework.Controls.MetroGrid();
            this.npm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtpTanggal = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnSimpan = new MetroFramework.Controls.MetroTile();
            this.mtBatal = new MetroFramework.Controls.MetroTile();
            this.cmbProdi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbStatus = new MetroFramework.Controls.MetroComboBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtTelp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtAlamat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbAgama = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rbtPerempuan = new MetroFramework.Controls.MetroRadioButton();
            this.rbtLaki = new MetroFramework.Controls.MetroRadioButton();
            this.txtTempat = new MetroFramework.Controls.MetroTextBox();
            this.txtNama = new MetroFramework.Controls.MetroTextBox();
            this.txtNpm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lblHeader = new MetroFramework.Controls.MetroLabel();
            this.pnlMahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(622, 69);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(65, 19);
            this.metroLabel12.TabIndex = 30;
            this.metroLabel12.Text = "Pencarian";
            this.metroLabel12.UseStyleColors = true;
            // 
            // txtCari
            // 
            // 
            // 
            // 
            this.txtCari.CustomButton.Image = null;
            this.txtCari.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtCari.CustomButton.Name = "";
            this.txtCari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCari.CustomButton.TabIndex = 1;
            this.txtCari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCari.CustomButton.UseSelectable = true;
            this.txtCari.CustomButton.Visible = false;
            this.txtCari.Lines = new string[0];
            this.txtCari.Location = new System.Drawing.Point(693, 65);
            this.txtCari.MaxLength = 32767;
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCari.SelectedText = "";
            this.txtCari.SelectionLength = 0;
            this.txtCari.SelectionStart = 0;
            this.txtCari.ShortcutsEnabled = true;
            this.txtCari.Size = new System.Drawing.Size(328, 23);
            this.txtCari.TabIndex = 29;
            this.txtCari.UseSelectable = true;
            this.txtCari.UseStyleColors = true;
            this.txtCari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(0, 33);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(1179, 2);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // pnlMahasiswa
            // 
            this.pnlMahasiswa.Controls.Add(this.metroLabel12);
            this.pnlMahasiswa.Controls.Add(this.txtCari);
            this.pnlMahasiswa.Controls.Add(this.metroTile3);
            this.pnlMahasiswa.Controls.Add(this.metroTile2);
            this.pnlMahasiswa.Controls.Add(this.metroLabel11);
            this.pnlMahasiswa.Controls.Add(this.dgvMahasiswa);
            this.pnlMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMahasiswa.HorizontalScrollbarBarColor = true;
            this.pnlMahasiswa.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMahasiswa.HorizontalScrollbarSize = 10;
            this.pnlMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.pnlMahasiswa.Name = "pnlMahasiswa";
            this.pnlMahasiswa.Size = new System.Drawing.Size(1050, 550);
            this.pnlMahasiswa.TabIndex = 54;
            this.pnlMahasiswa.UseStyleColors = true;
            this.pnlMahasiswa.VerticalScrollbarBarColor = true;
            this.pnlMahasiswa.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMahasiswa.VerticalScrollbarSize = 10;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.Control;
            this.metroTile3.Location = new System.Drawing.Point(30, 49);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(75, 39);
            this.metroTile3.TabIndex = 28;
            this.metroTile3.Text = "Tambah";
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(15, 7);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(110, 25);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "Data Dosen";
            this.metroLabel11.UseStyleColors = true;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AllowUserToAddRows = false;
            this.dgvMahasiswa.AllowUserToDeleteRows = false;
            this.dgvMahasiswa.AllowUserToResizeRows = false;
            this.dgvMahasiswa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMahasiswa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMahasiswa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMahasiswa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMahasiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.npm,
            this.nama,
            this.ttl,
            this.jenis,
            this.telp,
            this.email,
            this.status,
            this.prosi,
            this.aksi});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMahasiswa.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMahasiswa.EnableHeadersVisualStyles = false;
            this.dgvMahasiswa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMahasiswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMahasiswa.Location = new System.Drawing.Point(30, 94);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.ReadOnly = true;
            this.dgvMahasiswa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMahasiswa.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMahasiswa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMahasiswa.Size = new System.Drawing.Size(1010, 432);
            this.dgvMahasiswa.TabIndex = 2;
            this.dgvMahasiswa.UseStyleColors = true;
            this.dgvMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellContentClick);
            // 
            // npm
            // 
            this.npm.DataPropertyName = "npm";
            this.npm.HeaderText = "NPM";
            this.npm.Name = "npm";
            this.npm.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nm_mhs";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 200;
            // 
            // ttl
            // 
            this.ttl.DataPropertyName = "ttl";
            this.ttl.HeaderText = "Tempat/Tanggal Lahir";
            this.ttl.Name = "ttl";
            this.ttl.ReadOnly = true;
            this.ttl.Width = 120;
            // 
            // jenis
            // 
            this.jenis.DataPropertyName = "jns_kelamin";
            this.jenis.HeaderText = "Jenis Kelamin";
            this.jenis.Name = "jenis";
            this.jenis.ReadOnly = true;
            this.jenis.Width = 80;
            // 
            // telp
            // 
            this.telp.DataPropertyName = "telp";
            this.telp.HeaderText = "Telp";
            this.telp.Name = "telp";
            this.telp.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // prosi
            // 
            this.prosi.DataPropertyName = "prodi";
            this.prosi.HeaderText = "Bidang Keahlian";
            this.prosi.Name = "prosi";
            this.prosi.ReadOnly = true;
            // 
            // aksi
            // 
            this.aksi.HeaderText = "Aksi";
            this.aksi.Name = "aksi";
            this.aksi.ReadOnly = true;
            this.aksi.Text = "Edit";
            this.aksi.UseColumnTextForButtonValue = true;
            this.aksi.Width = 50;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtpTanggal.Location = new System.Drawing.Point(360, 117);
            this.dtpTanggal.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(171, 25);
            this.dtpTanggal.TabIndex = 33;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(50, 391);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(106, 19);
            this.metroLabel10.TabIndex = 52;
            this.metroLabel10.Text = "Bidang Keahlian";
            this.metroLabel10.UseStyleColors = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.ActiveControl = null;
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.Location = new System.Drawing.Point(215, 416);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 39);
            this.btnSimpan.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSimpan.TabIndex = 46;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSimpan.UseSelectable = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // mtBatal
            // 
            this.mtBatal.ActiveControl = null;
            this.mtBatal.BackColor = System.Drawing.SystemColors.Control;
            this.mtBatal.Location = new System.Drawing.Point(302, 416);
            this.mtBatal.Name = "mtBatal";
            this.mtBatal.Size = new System.Drawing.Size(75, 39);
            this.mtBatal.Style = MetroFramework.MetroColorStyle.Red;
            this.mtBatal.TabIndex = 48;
            this.mtBatal.Text = "Batal";
            this.mtBatal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBatal.UseSelectable = true;
            this.mtBatal.Click += new System.EventHandler(this.mtBatal_Click);
            // 
            // cmbProdi
            // 
            this.cmbProdi.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.ItemHeight = 19;
            this.cmbProdi.Items.AddRange(new object[] {
            "Teknik Informatika"});
            this.cmbProdi.Location = new System.Drawing.Point(215, 385);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(316, 25);
            this.cmbProdi.TabIndex = 44;
            this.cmbProdi.UseSelectable = true;
            this.cmbProdi.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(50, 360);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 19);
            this.metroLabel9.TabIndex = 51;
            this.metroLabel9.Text = "Status";
            this.metroLabel9.UseStyleColors = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 19;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif",
            "Cuti"});
            this.cmbStatus.Location = new System.Drawing.Point(215, 354);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(139, 25);
            this.cmbStatus.TabIndex = 43;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.UseStyleColors = true;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(215, 325);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(316, 23);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(50, 329);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 50;
            this.metroLabel8.Text = "Email";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txtTelp
            // 
            // 
            // 
            // 
            this.txtTelp.CustomButton.Image = null;
            this.txtTelp.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtTelp.CustomButton.Name = "";
            this.txtTelp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelp.CustomButton.TabIndex = 1;
            this.txtTelp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelp.CustomButton.UseSelectable = true;
            this.txtTelp.CustomButton.Visible = false;
            this.txtTelp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelp.Lines = new string[0];
            this.txtTelp.Location = new System.Drawing.Point(215, 296);
            this.txtTelp.MaxLength = 32767;
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.PasswordChar = '\0';
            this.txtTelp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelp.SelectedText = "";
            this.txtTelp.SelectionLength = 0;
            this.txtTelp.SelectionStart = 0;
            this.txtTelp.ShortcutsEnabled = true;
            this.txtTelp.Size = new System.Drawing.Size(316, 23);
            this.txtTelp.TabIndex = 40;
            this.txtTelp.UseSelectable = true;
            this.txtTelp.UseStyleColors = true;
            this.txtTelp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(50, 300);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 49;
            this.metroLabel7.Text = "No Telp";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txtAlamat
            // 
            // 
            // 
            // 
            this.txtAlamat.CustomButton.Image = null;
            this.txtAlamat.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.txtAlamat.CustomButton.Name = "";
            this.txtAlamat.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.txtAlamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlamat.CustomButton.TabIndex = 1;
            this.txtAlamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlamat.CustomButton.UseSelectable = true;
            this.txtAlamat.CustomButton.Visible = false;
            this.txtAlamat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAlamat.Lines = new string[0];
            this.txtAlamat.Location = new System.Drawing.Point(215, 211);
            this.txtAlamat.MaxLength = 32767;
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PasswordChar = '\0';
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlamat.SelectedText = "";
            this.txtAlamat.SelectionLength = 0;
            this.txtAlamat.SelectionStart = 0;
            this.txtAlamat.ShortcutsEnabled = true;
            this.txtAlamat.Size = new System.Drawing.Size(316, 79);
            this.txtAlamat.TabIndex = 39;
            this.txtAlamat.UseSelectable = true;
            this.txtAlamat.UseStyleColors = true;
            this.txtAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(50, 215);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 47;
            this.metroLabel6.Text = "Alamat";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(50, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Agama";
            this.metroLabel5.UseStyleColors = true;
            // 
            // cmbAgama
            // 
            this.cmbAgama.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAgama.FormattingEnabled = true;
            this.cmbAgama.ItemHeight = 19;
            this.cmbAgama.Items.AddRange(new object[] {
            "Islam",
            "Kristen",
            "Katholik",
            "Hindu",
            "Buddha",
            "Kong Hu Cu"});
            this.cmbAgama.Location = new System.Drawing.Point(215, 180);
            this.cmbAgama.Name = "cmbAgama";
            this.cmbAgama.Size = new System.Drawing.Size(139, 25);
            this.cmbAgama.TabIndex = 38;
            this.cmbAgama.UseSelectable = true;
            this.cmbAgama.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(50, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Jenis Kelamin";
            this.metroLabel4.UseStyleColors = true;
            // 
            // rbtPerempuan
            // 
            this.rbtPerempuan.AutoSize = true;
            this.rbtPerempuan.Location = new System.Drawing.Point(302, 155);
            this.rbtPerempuan.Name = "rbtPerempuan";
            this.rbtPerempuan.Size = new System.Drawing.Size(84, 15);
            this.rbtPerempuan.TabIndex = 37;
            this.rbtPerempuan.Text = "Perempuan";
            this.rbtPerempuan.UseSelectable = true;
            this.rbtPerempuan.UseStyleColors = true;
            // 
            // rbtLaki
            // 
            this.rbtLaki.AutoSize = true;
            this.rbtLaki.Location = new System.Drawing.Point(215, 155);
            this.rbtLaki.Name = "rbtLaki";
            this.rbtLaki.Size = new System.Drawing.Size(67, 15);
            this.rbtLaki.TabIndex = 35;
            this.rbtLaki.Text = "Laki-laki";
            this.rbtLaki.UseSelectable = true;
            this.rbtLaki.UseStyleColors = true;
            // 
            // txtTempat
            // 
            // 
            // 
            // 
            this.txtTempat.CustomButton.Image = null;
            this.txtTempat.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtTempat.CustomButton.Name = "";
            this.txtTempat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTempat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTempat.CustomButton.TabIndex = 1;
            this.txtTempat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTempat.CustomButton.UseSelectable = true;
            this.txtTempat.CustomButton.Visible = false;
            this.txtTempat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTempat.Lines = new string[0];
            this.txtTempat.Location = new System.Drawing.Point(215, 119);
            this.txtTempat.MaxLength = 32767;
            this.txtTempat.Name = "txtTempat";
            this.txtTempat.PasswordChar = '\0';
            this.txtTempat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTempat.SelectedText = "";
            this.txtTempat.SelectionLength = 0;
            this.txtTempat.SelectionStart = 0;
            this.txtTempat.ShortcutsEnabled = true;
            this.txtTempat.Size = new System.Drawing.Size(139, 23);
            this.txtTempat.TabIndex = 32;
            this.txtTempat.UseSelectable = true;
            this.txtTempat.UseStyleColors = true;
            this.txtTempat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTempat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNama
            // 
            // 
            // 
            // 
            this.txtNama.CustomButton.Image = null;
            this.txtNama.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtNama.CustomButton.Name = "";
            this.txtNama.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNama.CustomButton.TabIndex = 1;
            this.txtNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNama.CustomButton.UseSelectable = true;
            this.txtNama.CustomButton.Visible = false;
            this.txtNama.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNama.Lines = new string[0];
            this.txtNama.Location = new System.Drawing.Point(215, 90);
            this.txtNama.MaxLength = 32767;
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNama.SelectedText = "";
            this.txtNama.SelectionLength = 0;
            this.txtNama.SelectionStart = 0;
            this.txtNama.ShortcutsEnabled = true;
            this.txtNama.Size = new System.Drawing.Size(316, 23);
            this.txtNama.TabIndex = 29;
            this.txtNama.UseSelectable = true;
            this.txtNama.UseStyleColors = true;
            this.txtNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNpm
            // 
            // 
            // 
            // 
            this.txtNpm.CustomButton.Image = null;
            this.txtNpm.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtNpm.CustomButton.Name = "";
            this.txtNpm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNpm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNpm.CustomButton.TabIndex = 1;
            this.txtNpm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNpm.CustomButton.UseSelectable = true;
            this.txtNpm.CustomButton.Visible = false;
            this.txtNpm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNpm.Lines = new string[0];
            this.txtNpm.Location = new System.Drawing.Point(215, 61);
            this.txtNpm.MaxLength = 32767;
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.PasswordChar = '\0';
            this.txtNpm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNpm.SelectedText = "";
            this.txtNpm.SelectionLength = 0;
            this.txtNpm.SelectionStart = 0;
            this.txtNpm.ShortcutsEnabled = true;
            this.txtNpm.Size = new System.Drawing.Size(171, 23);
            this.txtNpm.TabIndex = 27;
            this.txtNpm.UseSelectable = true;
            this.txtNpm.UseStyleColors = true;
            this.txtNpm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNpm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(50, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Tempat/Tanggal Lahir";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(50, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Nama";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(50, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "NIDN";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(-81, 33);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1179, 2);
            this.metroTile1.TabIndex = 30;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeader.Location = new System.Drawing.Point(15, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(110, 25);
            this.lblHeader.TabIndex = 28;
            this.lblHeader.Text = "Data Dosen";
            this.lblHeader.UseStyleColors = true;
            // 
            // frmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.pnlMahasiswa);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.mtBatal);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbAgama);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.rbtPerempuan);
            this.Controls.Add(this.rbtLaki);
            this.Controls.Add(this.txtTempat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNpm);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMahasiswa";
            this.Text = "frmMahasiswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMahasiswa_Load);
            this.pnlMahasiswa.ResumeLayout(false);
            this.pnlMahasiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtCari;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel pnlMahasiswa;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroGrid dgvMahasiswa;
        private MetroFramework.Controls.MetroDateTime dtpTanggal;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btnSimpan;
        private MetroFramework.Controls.MetroTile mtBatal;
        private MetroFramework.Controls.MetroComboBox cmbProdi;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cmbStatus;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtTelp;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtAlamat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbAgama;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton rbtPerempuan;
        private MetroFramework.Controls.MetroRadioButton rbtLaki;
        private MetroFramework.Controls.MetroTextBox txtTempat;
        private MetroFramework.Controls.MetroTextBox txtNama;
        private MetroFramework.Controls.MetroTextBox txtNpm;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel lblHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn npm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosi;
        private System.Windows.Forms.DataGridViewButtonColumn aksi;
    }
}