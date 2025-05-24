using Curs_Lalikin.Models;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.InteropServices;

namespace Curs_Lalikin
{
    public partial class Avtorisation : Form
    {
        public Avtorisation()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.textBox2.KeyDown += TextBox2_KeyDown;
        }

        private void TextBox2_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ispr2525LalykinAdConstructionContext context = new();
                User? user = context.Users
                    .Where(user => user.Login == textBox1.Text && user.Password == textBox2.Text)
                    .FirstOrDefault();
                if (user.Role == "Администратор")
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = user.Role;
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    Admin form2 = new Admin(this);
                    form2.Show();
                }
                if (user.Role == "Пользователь")
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = user.Role;
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    Users form3 = new Users(this);
                    form3.Show();
                }
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Неправильный логин или пароль:");
                Avtoris_role.Text = "Неправильный логин или пароль";
                Avtoris_role.ForeColor = Color.IndianRed;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Avtorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

    

