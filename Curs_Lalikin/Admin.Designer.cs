namespace Curs_Lalikin
{
    partial class Admin
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
            panel1 = new Panel();
            bt_add = new Button();
            bt_edit = new Button();
            bt_delete = new Button();
            Categories = new Button();
            project_materials = new Button();
            materials = new Button();
            project = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(bt_add);
            panel1.Controls.Add(bt_edit);
            panel1.Controls.Add(bt_delete);
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(project_materials);
            panel1.Controls.Add(materials);
            panel1.Controls.Add(project);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 450);
            panel1.TabIndex = 0;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.Tan;
            bt_add.ForeColor = SystemColors.ActiveCaptionText;
            bt_add.Location = new Point(10, 381);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(146, 23);
            bt_add.TabIndex = 6;
            bt_add.Text = "ДОБАВИТЬ";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = Color.Tan;
            bt_edit.ForeColor = SystemColors.ActiveCaptionText;
            bt_edit.Location = new Point(10, 352);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(146, 23);
            bt_edit.TabIndex = 5;
            bt_edit.Text = "ИЗМЕНИТЬ";
            bt_edit.UseVisualStyleBackColor = false;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.Tan;
            bt_delete.ForeColor = SystemColors.ActiveCaptionText;
            bt_delete.Location = new Point(10, 323);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(146, 23);
            bt_delete.TabIndex = 4;
            bt_delete.Text = "УДАЛИТЬ";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // Categories
            // 
            Categories.BackColor = Color.Tan;
            Categories.ForeColor = SystemColors.ActiveCaptionText;
            Categories.Location = new Point(3, 99);
            Categories.Name = "Categories";
            Categories.Size = new Size(153, 23);
            Categories.TabIndex = 3;
            Categories.Text = "Categories";
            Categories.UseVisualStyleBackColor = false;
            Categories.Click += Categories_Click;
            // 
            // project_materials
            // 
            project_materials.BackColor = Color.Tan;
            project_materials.ForeColor = SystemColors.ActiveCaptionText;
            project_materials.Location = new Point(3, 70);
            project_materials.Name = "project_materials";
            project_materials.Size = new Size(153, 23);
            project_materials.TabIndex = 2;
            project_materials.Text = "project_materials";
            project_materials.UseVisualStyleBackColor = false;
            project_materials.Click += project_materials_Click;
            // 
            // materials
            // 
            materials.BackColor = Color.Tan;
            materials.ForeColor = SystemColors.ActiveCaptionText;
            materials.Location = new Point(3, 41);
            materials.Name = "materials";
            materials.Size = new Size(153, 23);
            materials.TabIndex = 1;
            materials.Text = "materials";
            materials.UseVisualStyleBackColor = false;
            materials.Click += materials_Click;
            // 
            // project
            // 
            project.BackColor = Color.Tan;
            project.ForeColor = SystemColors.ActiveCaptionText;
            project.Location = new Point(3, 12);
            project.Name = "project";
            project.Size = new Size(153, 23);
            project.TabIndex = 0;
            project.Text = "project";
            project.UseVisualStyleBackColor = false;
            project.Click += project_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(165, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(635, 415);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(bt_min);
            panel2.Controls.Add(bt_max);
            panel2.Controls.Add(bt_exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(165, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 35);
            panel2.TabIndex = 2;
            panel2.MouseDown += panelTop_MouseDown;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.LightSeaGreen;
            bt_min.Dock = DockStyle.Right;
            bt_min.Location = new Point(530, 0);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(35, 35);
            bt_min.TabIndex = 8;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click_1;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Olive;
            bt_max.Dock = DockStyle.Right;
            bt_max.Location = new Point(565, 0);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(35, 35);
            bt_max.TabIndex = 7;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.SaddleBrown;
            bt_exit.Dock = DockStyle.Right;
            bt_exit.Location = new Point(600, 0);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(35, 35);
            bt_exit.TabIndex = 6;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click_1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_delete;
        private Button Categories;
        private Button project_materials;
        private Button materials;
        private Button project;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}