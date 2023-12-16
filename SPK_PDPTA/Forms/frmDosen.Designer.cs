namespace SPK_PDPTA.Forms
{
    partial class frmDosen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle118 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle119 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle120 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNidn = new MetroFramework.Controls.MetroTextBox();
            this.txtNama = new MetroFramework.Controls.MetroTextBox();
            this.txtTempat = new MetroFramework.Controls.MetroTextBox();
            this.rbtLaki = new MetroFramework.Controls.MetroRadioButton();
            this.rbtPerempuan = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbAgama = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAlamat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTelp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cmbKbk = new MetroFramework.Controls.MetroComboBox();
            this.txtKode = new MetroFramework.Controls.MetroTextBox();
            this.dtpTanggal = new MetroFramework.Controls.MetroDateTime();
            this.pnlDosen = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtCari = new MetroFramework.Controls.MetroTextBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dgvDosen = new MetroFramework.Controls.MetroGrid();
            this.nidn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSimpan = new MetroFramework.Controls.MetroTile();
            this.mtBatal = new MetroFramework.Controls.MetroTile();
            this.pnlDosen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHeader.Location = new System.Drawing.Point(15, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(110, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Data Dosen";
            this.lblHeader.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 33);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1179, 2);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(50, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "NIDN";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(50, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nama";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(50, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tempat/Tanggal Lahir";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtNidn
            // 
            // 
            // 
            // 
            this.txtNidn.CustomButton.Image = null;
            this.txtNidn.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtNidn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNidn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNidn.CustomButton.TabIndex = 1;
            this.txtNidn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNidn.CustomButton.UseSelectable = true;
            this.txtNidn.CustomButton.Visible = false;
            this.txtNidn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNidn.Lines = new string[0];
            this.txtNidn.Location = new System.Drawing.Point(215, 61);
            this.txtNidn.MaxLength = 32767;
            this.txtNidn.Name = "txtNidn";
            this.txtNidn.PasswordChar = '\0';
            this.txtNidn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNidn.SelectionLength = 0;
            this.txtNidn.SelectionStart = 0;
            this.txtNidn.ShortcutsEnabled = true;
            this.txtNidn.Size = new System.Drawing.Size(171, 23);
            this.txtNidn.TabIndex = 0;
            this.txtNidn.UseSelectable = true;
            this.txtNidn.UseStyleColors = true;
            this.txtNidn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNidn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNama
            // 
            // 
            // 
            // 
            this.txtNama.CustomButton.Image = null;
            this.txtNama.CustomButton.Location = new System.Drawing.Point(294, 1);
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
            this.txtNama.SelectionLength = 0;
            this.txtNama.SelectionStart = 0;
            this.txtNama.ShortcutsEnabled = true;
            this.txtNama.Size = new System.Drawing.Size(316, 23);
            this.txtNama.TabIndex = 1;
            this.txtNama.UseSelectable = true;
            this.txtNama.UseStyleColors = true;
            this.txtNama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTempat
            // 
            // 
            // 
            // 
            this.txtTempat.CustomButton.Image = null;
            this.txtTempat.CustomButton.Location = new System.Drawing.Point(117, 1);
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
            this.txtTempat.SelectionLength = 0;
            this.txtTempat.SelectionStart = 0;
            this.txtTempat.ShortcutsEnabled = true;
            this.txtTempat.Size = new System.Drawing.Size(139, 23);
            this.txtTempat.TabIndex = 2;
            this.txtTempat.UseSelectable = true;
            this.txtTempat.UseStyleColors = true;
            this.txtTempat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTempat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbtLaki
            // 
            this.rbtLaki.AutoSize = true;
            this.rbtLaki.Location = new System.Drawing.Point(215, 155);
            this.rbtLaki.Name = "rbtLaki";
            this.rbtLaki.Size = new System.Drawing.Size(67, 15);
            this.rbtLaki.TabIndex = 4;
            this.rbtLaki.Text = "Laki-laki";
            this.rbtLaki.UseSelectable = true;
            this.rbtLaki.UseStyleColors = true;
            // 
            // rbtPerempuan
            // 
            this.rbtPerempuan.AutoSize = true;
            this.rbtPerempuan.Location = new System.Drawing.Point(302, 155);
            this.rbtPerempuan.Name = "rbtPerempuan";
            this.rbtPerempuan.Size = new System.Drawing.Size(84, 15);
            this.rbtPerempuan.TabIndex = 5;
            this.rbtPerempuan.Text = "Perempuan";
            this.rbtPerempuan.UseSelectable = true;
            this.rbtPerempuan.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(50, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Jenis Kelamin";
            this.metroLabel4.UseStyleColors = true;
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
            this.cmbAgama.TabIndex = 6;
            this.cmbAgama.UseSelectable = true;
            this.cmbAgama.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(50, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Agama";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtAlamat
            // 
            // 
            // 
            // 
            this.txtAlamat.CustomButton.Image = null;
            this.txtAlamat.CustomButton.Location = new System.Drawing.Point(238, 1);
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
            this.txtAlamat.SelectionLength = 0;
            this.txtAlamat.SelectionStart = 0;
            this.txtAlamat.ShortcutsEnabled = true;
            this.txtAlamat.Size = new System.Drawing.Size(316, 79);
            this.txtAlamat.TabIndex = 7;
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
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Alamat";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtTelp
            // 
            // 
            // 
            // 
            this.txtTelp.CustomButton.Image = null;
            this.txtTelp.CustomButton.Location = new System.Drawing.Point(294, 1);
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
            this.txtTelp.SelectionLength = 0;
            this.txtTelp.SelectionStart = 0;
            this.txtTelp.ShortcutsEnabled = true;
            this.txtTelp.Size = new System.Drawing.Size(316, 23);
            this.txtTelp.TabIndex = 8;
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
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "No Telp";
            this.metroLabel7.UseStyleColors = true;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(294, 1);
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
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(316, 23);
            this.txtEmail.TabIndex = 9;
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
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Email";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(50, 360);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(47, 19);
            this.metroLabel9.TabIndex = 20;
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
            this.cmbStatus.TabIndex = 10;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(50, 391);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(106, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Bidang Keahlian";
            this.metroLabel10.UseStyleColors = true;
            // 
            // cmbKbk
            // 
            this.cmbKbk.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbKbk.FormattingEnabled = true;
            this.cmbKbk.ItemHeight = 19;
            this.cmbKbk.Location = new System.Drawing.Point(313, 385);
            this.cmbKbk.Name = "cmbKbk";
            this.cmbKbk.Size = new System.Drawing.Size(218, 25);
            this.cmbKbk.TabIndex = 11;
            this.cmbKbk.UseSelectable = true;
            this.cmbKbk.UseStyleColors = true;
            this.cmbKbk.SelectedIndexChanged += new System.EventHandler(this.cmbKbk_SelectedIndexChanged);
            // 
            // txtKode
            // 
            // 
            // 
            // 
            this.txtKode.CustomButton.Image = null;
            this.txtKode.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtKode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKode.CustomButton.TabIndex = 1;
            this.txtKode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKode.CustomButton.UseSelectable = true;
            this.txtKode.CustomButton.Visible = false;
            this.txtKode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKode.Lines = new string[0];
            this.txtKode.Location = new System.Drawing.Point(215, 387);
            this.txtKode.MaxLength = 32767;
            this.txtKode.Name = "txtKode";
            this.txtKode.PasswordChar = '\0';
            this.txtKode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKode.SelectionLength = 0;
            this.txtKode.SelectionStart = 0;
            this.txtKode.ShortcutsEnabled = true;
            this.txtKode.Size = new System.Drawing.Size(92, 23);
            this.txtKode.TabIndex = 23;
            this.txtKode.UseSelectable = true;
            this.txtKode.UseStyleColors = true;
            this.txtKode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtpTanggal.Location = new System.Drawing.Point(360, 117);
            this.dtpTanggal.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(171, 25);
            this.dtpTanggal.TabIndex = 3;
            // 
            // pnlDosen
            // 
            this.pnlDosen.Controls.Add(this.metroLabel12);
            this.pnlDosen.Controls.Add(this.txtCari);
            this.pnlDosen.Controls.Add(this.metroTile3);
            this.pnlDosen.Controls.Add(this.metroTile2);
            this.pnlDosen.Controls.Add(this.metroLabel11);
            this.pnlDosen.Controls.Add(this.dgvDosen);
            this.pnlDosen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDosen.HorizontalScrollbarBarColor = true;
            this.pnlDosen.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDosen.HorizontalScrollbarSize = 10;
            this.pnlDosen.Location = new System.Drawing.Point(0, 0);
            this.pnlDosen.Name = "pnlDosen";
            this.pnlDosen.Size = new System.Drawing.Size(1050, 550);
            this.pnlDosen.TabIndex = 26;
            this.pnlDosen.UseStyleColors = true;
            this.pnlDosen.VerticalScrollbarBarColor = true;
            this.pnlDosen.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDosen.VerticalScrollbarSize = 10;
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
            // dgvDosen
            // 
            this.dgvDosen.AllowUserToAddRows = false;
            this.dgvDosen.AllowUserToDeleteRows = false;
            this.dgvDosen.AllowUserToResizeRows = false;
            this.dgvDosen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDosen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDosen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDosen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle118.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle118.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle118.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle118.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle118.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle118;
            this.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nidn,
            this.nama,
            this.ttl,
            this.jenis,
            this.telp,
            this.email,
            this.status,
            this.bidang,
            this.aksi});
            dataGridViewCellStyle119.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle119.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle119.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle119.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle119.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDosen.DefaultCellStyle = dataGridViewCellStyle119;
            this.dgvDosen.EnableHeadersVisualStyles = false;
            this.dgvDosen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDosen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDosen.Location = new System.Drawing.Point(30, 94);
            this.dgvDosen.Name = "dgvDosen";
            this.dgvDosen.ReadOnly = true;
            this.dgvDosen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle120.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle120.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle120.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle120.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle120.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDosen.RowHeadersDefaultCellStyle = dataGridViewCellStyle120;
            this.dgvDosen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDosen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDosen.Size = new System.Drawing.Size(1010, 432);
            this.dgvDosen.TabIndex = 2;
            this.dgvDosen.UseStyleColors = true;
            this.dgvDosen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDosen_CellContentClick);
            // 
            // nidn
            // 
            this.nidn.DataPropertyName = "nidn";
            this.nidn.HeaderText = "NIDN";
            this.nidn.Name = "nidn";
            this.nidn.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nm_dsn";
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
            // bidang
            // 
            this.bidang.DataPropertyName = "nm_kbk";
            this.bidang.HeaderText = "Bidang Keahlian";
            this.bidang.Name = "bidang";
            this.bidang.ReadOnly = true;
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
            // btnSimpan
            // 
            this.btnSimpan.ActiveControl = null;
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.btnSimpan.Location = new System.Drawing.Point(215, 416);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 39);
            this.btnSimpan.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSimpan.TabIndex = 12;
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
            this.mtBatal.TabIndex = 13;
            this.mtBatal.Text = "Batal";
            this.mtBatal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBatal.UseSelectable = true;
            this.mtBatal.Click += new System.EventHandler(this.mtBatal_Click);
            // 
            // frmDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.pnlDosen);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.mtBatal);
            this.Controls.Add(this.cmbKbk);
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
            this.Controls.Add(this.txtNidn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDosen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDosen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDosen_Load);
            this.pnlDosen.ResumeLayout(false);
            this.pnlDosen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblHeader;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNidn;
        private MetroFramework.Controls.MetroTextBox txtNama;
        private MetroFramework.Controls.MetroTextBox txtTempat;
        private MetroFramework.Controls.MetroRadioButton rbtLaki;
        private MetroFramework.Controls.MetroRadioButton rbtPerempuan;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbAgama;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAlamat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTelp;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cmbStatus;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox cmbKbk;
        private MetroFramework.Controls.MetroTextBox txtKode;
        private MetroFramework.Controls.MetroDateTime dtpTanggal;
        private MetroFramework.Controls.MetroPanel pnlDosen;
        private MetroFramework.Controls.MetroGrid dgvDosen;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidang;
        private System.Windows.Forms.DataGridViewButtonColumn aksi;
        private MetroFramework.Controls.MetroTile btnSimpan;
        private MetroFramework.Controls.MetroTile mtBatal;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtCari;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}