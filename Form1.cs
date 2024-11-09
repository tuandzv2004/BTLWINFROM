using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quanlynhahang
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=DESKTOP-8M88ESB\\SQLEXPRESS;Database=quanlynhahang; Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            Classes.a db= new Classes.a();

            try
            {

                int count = db.login(username, password);
                if (count == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công!");
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            txtPass.UseSystemPasswordChar = false;
            else
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register rs = new register();
            rs.Show();
        }
    }
}
