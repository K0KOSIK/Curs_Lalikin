using Curs_Lalikin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void project_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Projects.ToList();
            activeEntity = ActiveEntity.Projects;
        }
        private void materials_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Materials.ToList();
            activeEntity = ActiveEntity.Materials;

        }

        private void project_materials_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.ProjectMaterials.ToList();
            activeEntity = ActiveEntity.ProjectMaterials;
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Categories.ToList();
            activeEntity = ActiveEntity.Categories;
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
    }
}
