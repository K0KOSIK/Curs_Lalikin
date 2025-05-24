namespace Curs_Lalikin
{
    partial class Users
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
            Categories = new Button();
            project_materials = new Button();
            materials = new Button();
            project = new Button();
            panel1 = new Panel();
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
            // Categories
            // 
            Categories.BackColor = Color.Tan;
            Categories.Dock = DockStyle.Top;
            Categories.ForeColor = SystemColors.ActiveCaptionText;
            Categories.Location = new Point(0, 69);
            Categories.Name = "Categories";
            Categories.Size = new Size(165, 23);
            Categories.TabIndex = 3;
            Categories.Text = "Categories";
            Categories.UseVisualStyleBackColor = false;
            Categories.Click += Categories_Click;
            // 
            // project_materials
            // 
            project_materials.BackColor = Color.Tan;
            project_materials.Dock = DockStyle.Top;
            project_materials.ForeColor = SystemColors.ActiveCaptionText;
            project_materials.Location = new Point(0, 46);
            project_materials.Name = "project_materials";
            project_materials.Size = new Size(165, 23);
            project_materials.TabIndex = 2;
            project_materials.Text = "project_materials";
            project_materials.UseVisualStyleBackColor = false;
            project_materials.Click += project_materials_Click;
            // 
            // materials
            // 
            materials.BackColor = Color.Tan;
            materials.Dock = DockStyle.Top;
            materials.ForeColor = SystemColors.ActiveCaptionText;
            materials.Location = new Point(0, 23);
            materials.Name = "materials";
            materials.Size = new Size(165, 23);
            materials.TabIndex = 1;
            materials.Text = "materials";
            materials.UseVisualStyleBackColor = false;
            materials.Click += materials_Click;
            // 
            // project
            // 
            project.BackColor = Color.Tan;
            project.Dock = DockStyle.Top;
            project.ForeColor = SystemColors.ActiveCaptionText;
            project.Location = new Point(0, 0);
            project.Name = "project";
            project.Size = new Size(165, 23);
            project.TabIndex = 0;
            project.Text = "project";
            project.UseVisualStyleBackColor = false;
            project.Click += project_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(project_materials);
            panel1.Controls.Add(materials);
            panel1.Controls.Add(project);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 450);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(165, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(635, 415);
            dataGridView1.TabIndex = 4;
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
            panel2.TabIndex = 5;
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
            bt_min.Click += bt_min_Click;
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
            bt_exit.Click += bt_exit_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Categories;
        private Button project_materials;
        private Button materials;
        private Button project;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}