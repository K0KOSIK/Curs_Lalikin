using Curs_Lalikin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_Lalikin
{
    public partial class Users : Form
    {
        private Avtorisation _form1;
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        public Users(Avtorisation form1)
        {
            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Users_FormClosed;
        }
        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Projects.ToList();
            activeEntity = ActiveEntity.Projects;
            dataGridView1.Columns[6].Visible = false;
        }

        private void project_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Projects.ToList();
            activeEntity = ActiveEntity.Projects;
            dataGridView1.Columns[6].Visible = false;
        }
        private void materials_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Materials.ToList();
            activeEntity = ActiveEntity.Materials;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void project_materials_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.ProjectMaterials.ToList();
            activeEntity = ActiveEntity.ProjectMaterials;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Categories.ToList();
            activeEntity = ActiveEntity.Categories;
            dataGridView1.Columns[2].Visible = false;
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
