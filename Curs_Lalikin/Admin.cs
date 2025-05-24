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
using static System.Windows.Forms.DataFormats;

namespace Curs_Lalikin
{
    public partial class Admin : Form
    {
        private Avtorisation _form1;
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        public Admin(Avtorisation form1)
        {

            InitializeComponent();
            _form1 = form1;
            this.FormClosed += Admin_FormClosed;

        }
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
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
            //dataGridView1.DataSource = context.ProjectMaterials.ToList();
            Ispr2525LalykinAdConstructionContext context = new();
            var data = context.ProjectMaterials
                .Include(pm => pm.Project)
                .Include(pm => pm.Material)
                .Select(pm => new
                {
                    project_id = pm.ProjectId,
                    material_id = pm.MaterialId,
                    ProjectName = pm.Project.ProjectName,
                    MaterialName = pm.Material.MaterialName,
                    pm.Quantity
                }).ToList();
            dataGridView1.DataSource = data;
            activeEntity = ActiveEntity.ProjectMaterials;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Ispr2525LalykinAdConstructionContext context = new();
            dataGridView1.DataSource = context.Categories.ToList();
            activeEntity = ActiveEntity.Categories;
            dataGridView1.Columns[2].Visible = false;
        }
        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525LalykinAdConstructionContext context = new();
            var Projects = context.Projects
                .OrderBy(x => x.ProjectId)
                .Select(x => new
                {
                    x.ProjectId,
                    x.ProjectName,
                    x.StartDate,
                    x.EndDate,
                    x.Budget,
                    x.Status,

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525LalykinAdConstructionContext contex = new();
            var Materials = contex.Materials
                .Include(x => x.CategoriesIdCategories)
                .OrderBy(x => x.MaterialId)
                .Select(x => new
                {
                    x.MaterialId,
                    x.MaterialName,
                    x.UnitOfMeasure,
                    x.UnitPrice,
                    x.CategoriesIdCategories

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            //dataGridView1.DataSource = context.ProjectMaterials.ToList();
            Ispr2525LalykinAdConstructionContext context2 = new();
            var ProjectMaterials = context2.ProjectMaterials
                .OrderBy(x => x.ProjectId)
                .Select(x => new
                {
                    x.ProjectId,
                    x.MaterialId,
                    x.Quantity,


                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525LalykinAdConstructionContext context3 = new();
            var Categories = context3.Categories
                .OrderBy(x => x.IdCategories)
                .Select(x => new
                {
                    x.IdCategories,
                    x.CategoriesName,

                });
        }

        private void bt_min_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click_1(object sender, EventArgs e)
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

        private void bt_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (activeEntity == ActiveEntity.Projects)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525LalykinAdConstructionContext context = new();
                        var Projects = context.Projects.Where(x => x.ProjectId == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Projects.ExecuteDelete();
                            context.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = context.Projects.ToList();
                            dataGridView1.Columns[6].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }

            if (activeEntity == ActiveEntity.Materials)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525LalykinAdConstructionContext contex = new();
                        var Materials = contex.Materials.Where(x => x.MaterialId == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Materials.ExecuteDelete();
                            contex.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex.Materials.ToList();
                            dataGridView1.Columns[5].Visible = false;
                            dataGridView1.Columns[6].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }
            }
            if (activeEntity == ActiveEntity.ProjectMaterials)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525LalykinAdConstructionContext contex2 = new();
                        var ProjectMaterials = contex2.ProjectMaterials.Where(x => x.ProjectId == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            ProjectMaterials.ExecuteDelete();
                            contex2.SaveChanges();
                            UpdateInfo();
                            Ispr2525LalykinAdConstructionContext context = new();
                            var data = context.ProjectMaterials
                                .Include(pm => pm.Project)
                                .Include(pm => pm.Material)
                                .Select(pm => new
                                {
                                    project_id = pm.ProjectId,
                                    material_id = pm.MaterialId,
                                    ProjectName = pm.Project.ProjectName,
                                    MaterialName = pm.Material.MaterialName,
                                    pm.Quantity
                                }).ToList();
                            dataGridView1.DataSource = data;
                            activeEntity = ActiveEntity.ProjectMaterials;
                            dataGridView1.Columns[0].Visible = false;
                            dataGridView1.Columns[1].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Categories)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525LalykinAdConstructionContext contex3 = new();
                        var Categories = contex3.Categories.Where(x => x.IdCategories == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Categories.ExecuteDelete();
                            contex3.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex3.Categories.ToList();
                            dataGridView1.Columns[2].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.Y;
            if (activeEntity == ActiveEntity.Projects)
            {
                try
                {
                    var Projects = new Project
                    {
                        ProjectId = ((int)dataGridView1.SelectedRows[0].Cells[0].Value),
                        ProjectName = ((string)dataGridView1.SelectedRows[0].Cells[1].Value),
                        StartDate = (DateOnly)dataGridView1.SelectedRows[0].Cells[2].Value,
                        EndDate = (DateOnly?)dataGridView1.SelectedRows[0].Cells[3].Value,
                        Budget = ((decimal)dataGridView1.SelectedRows[0].Cells[4].Value),
                        Status = ((string)dataGridView1.SelectedRows[0].Cells[5].Value)
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Projects, Projects);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context = new();
                        dataGridView1.DataSource = context.Projects.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Materials)
            {
                try
                {
                    var Materials = new Material
                    {
                        MaterialId = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        MaterialName = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        UnitOfMeasure = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        UnitPrice = (decimal)dataGridView1.SelectedRows[0].Cells[3].Value,
                        CategoriesIdCategories = (int)dataGridView1.SelectedRows[0].Cells[4].Value
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Materials, Materials);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context1 = new();
                        dataGridView1.DataSource = context1.Materials.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.ProjectMaterials)
            {
                try
                {
                    var ProjectMaterials = new ProjectMaterial
                    {
                        ProjectId = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        MaterialId = (int)dataGridView1.SelectedRows[0].Cells[1].Value,
                        Quantity = (decimal)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.ProjectMaterials, ProjectMaterials);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context = new();
                        var data = context.ProjectMaterials
                            .Include(pm => pm.Project)
                            .Include(pm => pm.Material)
                            .Select(pm => new
                            {
                                project_id = pm.ProjectId,
                                material_id = pm.MaterialId,
                                ProjectName = pm.Project.ProjectName,
                                MaterialName = pm.Material.MaterialName,
                                pm.Quantity
                            }).ToList();
                        dataGridView1.DataSource = data;
                        activeEntity = ActiveEntity.ProjectMaterials;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Categories)
            {
                try
                {
                    var Categories = new Category
                    {
                        IdCategories = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        CategoriesName = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Categories, Categories);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context3 = new();
                        dataGridView1.DataSource = context3.Categories.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.N;
            if (activeEntity == ActiveEntity.Projects)
            {
                try
                {
                    var Project = new Project
                    {
                        ProjectId = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        ProjectName = "",
                        StartDate = DateOnly.FromDateTime(DateTime.Now),
                        EndDate = DateOnly.FromDateTime(DateTime.Now),
                        Budget = 0m,
                        Status = "",
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Projects, Project);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context = new();
                        dataGridView1.DataSource = context.Projects.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Materials)
            {
                try
                {
                    var Material = new Material
                    {
                        MaterialId = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        MaterialName = "",
                        UnitOfMeasure = "",
                        UnitPrice = 0,
                        CategoriesIdCategories = 0,
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Materials, Material);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context1 = new();
                        dataGridView1.DataSource = context1.Materials.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.ProjectMaterials)
            {
                try
                {
                    var ProjectMaterials = new ProjectMaterial
                    {
                        ProjectId = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        MaterialId = 0,
                        Quantity = 0,
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.ProjectMaterials, ProjectMaterials);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context2 = new();
                        var data = context2.ProjectMaterials
                            .Include(pm => pm.Project)
                            .Include(pm => pm.Material)
                            .Select(pm => new
                            {
                                project_id = pm.ProjectId,
                                material_id = pm.MaterialId,
                                ProjectName = pm.Project.ProjectName,
                                MaterialName = pm.Material.MaterialName,
                                pm.Quantity
                            }).ToList();
                        dataGridView1.DataSource = data;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Categories)
            {
                try
                {
                    var Categories = new Category
                    {
                        IdCategories = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        CategoriesName = "",
                    };
                    this.Hide();
                    var editing = new Change(ActiveEntity.Categories, Categories);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525LalykinAdConstructionContext context3 = new();
                        dataGridView1.DataSource = context3.Categories.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
