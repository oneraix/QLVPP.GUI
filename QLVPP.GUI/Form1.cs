using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVPP.DAL.enities;

namespace QLVPP.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isPasswordVisible = false;

        protected void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Nếu đang hiển thị mật khẩu, đặt TextBox để không ẩn mật khẩu
                textBox2.UseSystemPasswordChar = false;
                pictureBox4.Image = Properties.Resources.eye_open; // Đặt biểu tượng con mắt mở
            }
            else
            {
                // Ngược lại, đặt TextBox để ẩn mật khẩu
                textBox2.UseSystemPasswordChar = true;
                pictureBox4.Image = Properties.Resources.eye_closed; // Đặt biểu tượng con mắt đóng
            }
        }
    }
}
