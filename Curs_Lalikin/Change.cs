using Curs_Lalikin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curs_Lalikin
{
    public partial class Change : Form
    {
        public int MaterialId { get; set; }

        public string MaterialName { get; set; } = null!;

        public string UnitOfMeasure { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public int CategoriesIdCategories { get; set; }
        public int ProjectId { get; set; }

        public string ProjectName { get; set; } = null!;

        public DateOnly StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public decimal Budget { get; set; }

        public string Status { get; set; } = null!;

        public decimal Quantity { get; set; }

        public int IdCategories { get; set; }

        public string CategoriesName { get; set; } = null!;

        public ActiveEntity x { get; set; }

        public IsEdit isEdit { get; set; }
        public IsError isError;
        private int materialId;

        public Change(ActiveEntity activeEntity, object entityData)
        {
            InitializeComponent();
            x = activeEntity;
            ConfigureForm(entityData);
            isError = IsError.N;
        }

        private void ConfigureForm(object entityData)
        {
            switch (x)
            {
                case ActiveEntity.Projects:
                    BindProjects((Project)entityData);
                    break;
                case ActiveEntity.Materials:
                    BindMaterials((Material)entityData);
                    break;
                case ActiveEntity.ProjectMaterials:
                    BindProjectMaterials((ProjectMaterial)entityData);
                    break;
                case ActiveEntity.Categories:
                    BindCategories((Category)entityData);
                    break;
            }
        }

        private void BindProjects(Project Projects)
        {
            data_entry.DataBindings.Add("Text", Projects, nameof(Projects.ProjectId));
            data_entry2.DataBindings.Add("Text", Projects, nameof(Projects.ProjectName));
            dateTimePicker1.DataBindings.Add("Text", Projects, nameof(Projects.StartDate));
            dateTimePicker2.DataBindings.Add("Text", Projects, nameof(Projects.EndDate));
            data_entry5.DataBindings.Add("Text", Projects, nameof(Projects.Budget));
            data_entry6.DataBindings.Add("Text", Projects, nameof(Projects.Status));
            data_entry3.Visible = false;
            data_entry4.Visible = false;
            data_entry6.Visible = false;
            input.Text = "ProjectId";
            input2.Text = "ProjectName";
            input3.Text = "StartDate";
            input4.Text = "EndDate";
            input5.Text = "Budget";
            input6.Text = "Status";
            List<string> Status = new List<string>
            {
            "Планирование", "В процессе", "Завершено", "На удержании",
            };
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(Status);
        }
        private void BindMaterials(Material Materials)
        {
            data_entry.DataBindings.Add("Text", Materials, nameof(Materials.MaterialId));
            data_entry2.DataBindings.Add("Text", Materials, nameof(Materials.MaterialName));
            data_entry3.DataBindings.Add("Text", Materials, nameof(Materials.UnitOfMeasure));
            data_entry4.DataBindings.Add("Text", Materials, nameof(Materials.UnitPrice));
            data_entry5.DataBindings.Add("Text", Materials, nameof(Materials.CategoriesIdCategories));
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            data_entry6.Visible = false;
            input6.Visible = false;
            cmbStatus.Visible = false;
            input.Text = "MaterialId";
            input2.Text = "MaterialName";
            input3.Text = "UnitOfMeasure";
            input4.Text = "UnitPrice";
            input5.Text = "CategoriesIdCategories";
        }
        private void BindProjectMaterials(ProjectMaterial ProjectMaterials)
        {
            data_entry.DataBindings.Add("Text", ProjectMaterials, nameof(ProjectMaterials.ProjectId));
            data_entry2.DataBindings.Add("Text", ProjectMaterials, nameof(ProjectMaterials.MaterialId));
            data_entry3.DataBindings.Add("Text", ProjectMaterials, nameof(ProjectMaterials.Quantity));
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            data_entry4.Visible = false;
            data_entry5.Visible = false;
            data_entry6.Visible = false;
            input4.Visible = false;
            input5.Visible = false;
            input6.Visible = false;
            cmbStatus.Visible = false;
            input.Text = "ProjectId";
            input2.Text = "MaterialId";
            input3.Text = "Quantity";
        }
        private void BindCategories(Category Categories)
        {
            data_entry.DataBindings.Add("Text", Categories, nameof(Categories.IdCategories));
            data_entry2.DataBindings.Add("Text", Categories, nameof(Categories.CategoriesName));
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            data_entry3.Visible = false;
            data_entry4.Visible = false;
            data_entry5.Visible = false;
            data_entry6.Visible = false;
            input3.Visible = false;
            input4.Visible = false;
            input5.Visible = false;
            input6.Visible = false;
            cmbStatus.Visible = false;
            input.Text = "IdCategories";
            input2.Text = "CategoriesName";
        }
        private void Change_Load(object sender, EventArgs e)
        {
            if (x == ActiveEntity.ProjectMaterials && isEdit == IsEdit.Y)
            {
                using (var context = new Ispr2525LalykinAdConstructionContext())
                {
                    // Получаем pm из БД
                    var pm = context.ProjectMaterials
                        .FirstOrDefault(p => p.ProjectId == Convert.ToInt32(data_entry.Text) &&
                        p.MaterialId == Convert.ToInt32(data_entry2.Text));

                    if (pm != null)
                    {
                        data_entry.Text = pm.ProjectId.ToString();
                        data_entry2.Text = pm.MaterialId.ToString();
                        data_entry.Tag = pm.ProjectId;
                        data_entry2.Tag = pm.MaterialId;
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена!");
                        this.Close();
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int QuanityCol;
            if (isError == IsError.Y) return;

            try
            {
                switch (x)
                {
                    case ActiveEntity.Projects:
                        Project Project = new();
                        Project.ProjectId = Convert.ToInt32(data_entry.Text);
                        Project.ProjectName = data_entry2.Text;
                        Project.StartDate = DateOnly.FromDateTime(dateTimePicker1.Value);
                        Project.EndDate = DateOnly.FromDateTime(dateTimePicker2.Value);
                        Project.Budget = decimal.Parse(
                        data_entry5.Text.Trim().Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture
                        );
                        Project.Status = cmbStatus.Text;
                        Ispr2525LalykinAdConstructionContext context = new();
                        if (isEdit == IsEdit.Y)
                            context.Update(Project);
                        if (isEdit == IsEdit.N)
                            context.Add(Project);
                        context.SaveChanges();
                        break;
                    case ActiveEntity.Materials:
                        Material Material = new();
                        Material.MaterialId = Convert.ToInt32(data_entry.Text);
                        Material.MaterialName = data_entry2.Text;
                        Material.UnitOfMeasure = data_entry3.Text;
                        Material.UnitPrice = decimal.Parse(
                        data_entry4.Text.Trim().Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture
                        );
                        Ispr2525LalykinAdConstructionContext context5 = new();
                        QuanityCol = context5.Categories.Count();
                        if (Convert.ToInt32(data_entry5.Text) > QuanityCol || Convert.ToInt32(data_entry5.Text) < 0)
                        {
                            MessageBox.Show("CategoriesIdCategories не может быть меньше нуля или больше:" + QuanityCol);
                            isError = IsError.Y;
                            break;
                        }
                        else
                            Material.CategoriesIdCategories = Convert.ToInt32(data_entry5.Text);
                        Ispr2525LalykinAdConstructionContext context2 = new();
                        if (isEdit == IsEdit.Y)
                        {
                            context2.Update(Material);
                        }
                        if (isEdit == IsEdit.N)
                        {
                            context2.Add(Material);
                        }
                        context2.SaveChanges();
                        break;
                    case ActiveEntity.Categories:
                        Category Categories = new();
                        Categories.IdCategories = Convert.ToInt32(data_entry.Text);
                        Categories.CategoriesName = data_entry2.Text;
                        Ispr2525LalykinAdConstructionContext context4 = new();
                        if (isEdit == IsEdit.Y)
                            context4.Update(Categories);
                        if (isEdit == IsEdit.N)
                            context4.Add(Categories);
                        context4.SaveChanges();
                        break;
                    case ActiveEntity.ProjectMaterials:
                        if (isEdit == IsEdit.N)
                        {
                            ProjectMaterial ProjectMaterial = new();
                            Ispr2525LalykinAdConstructionContext context6 = new();
                            QuanityCol = context6.Projects.Count();
                            if (Convert.ToInt32(data_entry.Text) > QuanityCol || Convert.ToInt32(data_entry.Text) < 0)
                            {
                                MessageBox.Show("ProjectId не может быть меньше нуля или больше:" + QuanityCol);
                                isError = IsError.Y;
                                break;
                            }
                            else
                                ProjectMaterial.ProjectId = Convert.ToInt32(data_entry.Text);
                            QuanityCol = context6.Materials.Count();
                            if (Convert.ToInt32(data_entry2.Text) > QuanityCol || Convert.ToInt32(data_entry2.Text) < 0)
                            {
                                MessageBox.Show("MaterialId не может быть меньше нуля или больше:" + QuanityCol);
                                isError = IsError.Y;
                                break;
                            }
                            else
                                ProjectMaterial.MaterialId = Convert.ToInt32(data_entry2.Text);
                            ProjectMaterial.Quantity = decimal.Parse(
                            data_entry3.Text.Trim().Replace(',', '.'),
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture
                            );
                            Ispr2525LalykinAdConstructionContext context3 = new();
                            if (isEdit == IsEdit.Y)
                                context3.Update(ProjectMaterial);
                            if (isEdit == IsEdit.N)
                                context3.Add(ProjectMaterial);
                            context3.SaveChanges();
                        }
                        if (isEdit == IsEdit.Y)
                        {
                            using (var context6 = new Ispr2525LalykinAdConstructionContext())
                            {
                                int oldProjectId = (data_entry.Tag as int?) ?? 0;
                                int oldMaterialId = (data_entry2.Tag as int?) ?? 0;
                                int projectId = Convert.ToInt32(data_entry.Text);
                                int materialIdNew = Convert.ToInt32(data_entry2.Text);
                                decimal quantity = decimal.Parse(data_entry3.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);

                                // Проверка существования проекта и материала
                                if (!context6.Projects.Any(p => p.ProjectId == projectId) ||
                                    !context6.Materials.Any(m => m.MaterialId == materialIdNew))
                                {
                                    MessageBox.Show("Проект или материал не найден!");
                                    return;
                                }

                                // Проверка на дубликат новой записи
                                if (context6.ProjectMaterials.Any(p => p.ProjectId == projectId && p.MaterialId == materialIdNew))
                                {
                                    MessageBox.Show("Такая связь уже существует!");
                                    return;
                                }

                                // Удаление старой записи
                                var oldPm = context6.ProjectMaterials
                                    .FirstOrDefault(p => p.ProjectId == oldProjectId && p.MaterialId == oldMaterialId);

                                if (oldPm == null)
                                {
                                    context6.ProjectMaterials.Add(new ProjectMaterial
                                    {
                                        ProjectId = projectId,
                                        MaterialId = materialIdNew,
                                        Quantity = quantity
                                    });

                                    context6.SaveChanges();
                                    break;
                                }

                                context6.ProjectMaterials.Remove(oldPm);

                                // Добавление новой записи
                                context6.ProjectMaterials.Add(new ProjectMaterial
                                {
                                    ProjectId = projectId,
                                    MaterialId = materialIdNew,
                                    Quantity = quantity
                                });

                                context6.SaveChanges();
                            }
                        }
                        break;

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Ошибка: данные были изменены другим пользователем. Обновите данные.");
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void cancellation_Click(object sender, EventArgs e)
        {
            if (isEdit == IsEdit.Y)
            {
                switch (x)
                {
                    case ActiveEntity.Projects:
                        Ispr2525LalykinAdConstructionContext context = new();
                        context.SaveChanges();
                        break;
                    case ActiveEntity.Materials:
                        Ispr2525LalykinAdConstructionContext context2 = new();
                        context2.SaveChanges();
                        break;
                    case ActiveEntity.ProjectMaterials:
                        Ispr2525LalykinAdConstructionContext context3 = new();
                        context3.SaveChanges();
                        break;
                    case ActiveEntity.Categories:
                        Ispr2525LalykinAdConstructionContext context4 = new();
                        context4.SaveChanges();
                        break;

                }

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbStatus_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            cancellation.PerformClick();
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
