using System;
using Npgsql;
using System.Windows.Forms;
using PROJECT_PBO.Controller;
using PROJECT_PBO.Model;
using PROJECT_PBO.View;
using PROJECT_PBO.Model;
using System.Data;

namespace PROJECT_PBO
{
    public partial class LOGIN : Form
    {
        private AkunContext akun;

        public LOGIN()
        {
            InitializeComponent();
            akun = new AkunContext();

            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            textBoxPASSWORD.PasswordChar = '*';

            // Event handler untuk checkbox 'showPasswordCheckBox'
            showPasswordCheckBox.CheckedChanged += new EventHandler(showPasswordCheckBox_CheckedChanged);
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            string username = textBoxUSERNAME.Text.Trim();
            string password = textBoxPASSWORD.Text.Trim();

            string role = ValidateLogin(username, password);
            if (!string.IsNullOrEmpty(role))
            {
                MessageBox.Show($"Login berhasil sebagai {role}", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "admin")
                {
                    FormAdmin formAdmin = new FormAdmin(); // Form khusus untuk Admin
                    formAdmin.Show();
                }
                else if (role == "pelanggan")
                {
                    FormPelanggan formPelanggan = new FormPelanggan(); // Form khusus untuk User
                    formPelanggan.Show();
                }

                this.Hide(); // Menutup form login setelah login berhasil
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logika untuk checkbox yang mengubah visibilitas password
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPASSWORD.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        public string ValidateLogin(string username, string password)
        {
            DataTable result = akun.GetAkunByUsernamePassword(username, password);

            if (result.Rows.Count > 0)
            {
                // Ambil data role dari hasil query
                string role = result.Rows[0]["role"].ToString();
                return role;
            }
            return null; // Jika tidak ada hasil (login gagal)
        }


        private void textBoxPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister(); // Form khusus untuk Register
            formRegister.Show();

            this.Hide();
        }

        private void buttonLOGIN_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}