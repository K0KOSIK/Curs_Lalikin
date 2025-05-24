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
            panel1 = new Panel();
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
            panel1.Controls.Add(Categories);
            panel1.Controls.Add(project_materials);
            panel1.Controls.Add(materials);
            panel1.Controls.Add(project);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 450);
            panel1.TabIndex = 0;
            // 
            // Categories
            // 
            Categories.BackColor = Color.Tan;
            Categories.Location = new Point(10, 97);
            Categories.Name = "Categories";
            Categories.Size = new Size(138, 23);
            Categories.TabIndex = 3;
            Categories.Text = "Categories";
            Categories.UseVisualStyleBackColor = false;
            Categories.Click += Categories_Click;
            // 
            // project_materials
            // 
            project_materials.BackColor = Color.Tan;
            project_materials.Location = new Point(10, 68);
            project_materials.Name = "project_materials";
            project_materials.Size = new Size(138, 23);
            project_materials.TabIndex = 2;
            project_materials.Text = "project_materials";
            project_materials.UseVisualStyleBackColor = false;
            project_materials.Click += project_materials_Click;
            // 
            // materials
            // 
            materials.BackColor = Color.Tan;
            materials.Location = new Point(10, 39);
            materials.Name = "materials";
            materials.Size = new Size(138, 23);
            materials.TabIndex = 1;
            materials.Text = "materials";
            materials.UseVisualStyleBackColor = false;
            materials.Click += materials_Click;
            // 
            // project
            // 
            project.BackColor = Color.Tan;
            project.Location = new Point(10, 10);
            project.Name = "project";
            project.Size = new Size(138, 23);
            project.TabIndex = 0;
            project.Text = "project";
            project.UseVisualStyleBackColor = false;
            project.Click += project_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(645, 421);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_min);
            panel2.Controls.Add(bt_max);
            panel2.Controls.Add(bt_exit);
            panel2.Location = new Point(156, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 31);
            panel2.TabIndex = 2;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.LightSeaGreen;
            bt_min.Location = new Point(550, 3);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(28, 23);
            bt_min.TabIndex = 5;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Olive;
            bt_max.Location = new Point(584, 3);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(25, 23);
            bt_max.TabIndex = 4;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.SaddleBrown;
            bt_exit.Location = new Point(615, 3);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(27, 23);
            bt_exit.TabIndex = 3;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button project;
        private Button Categories;
        private Button project_materials;
        private Button materials;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}