using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPK_PDPTA.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void CloseAllForms()
        {
            //foreach (var form in Application.OpenForms.Cast<Form>().Where(f => f.IsMdiChild).ToArray()) form.Close();
            if (pnlContainer.Controls.Count > 0)
            {
                pnlContainer.Controls.Clear();
            }
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            frmDosen myForm = new frmDosen();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            CloseAllForms();

            frmMahasiswa myForm = new frmMahasiswa();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlContainer.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
