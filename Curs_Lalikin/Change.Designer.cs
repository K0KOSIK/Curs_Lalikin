﻿namespace Curs_Lalikin
{
    partial class Change
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
            cancellation = new Button();
            save = new Button();
            panel1 = new Panel();
            cmbStatus = new DomainUpDown();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            input6 = new Label();
            input5 = new Label();
            input4 = new Label();
            input3 = new Label();
            input2 = new Label();
            data_entry6 = new TextBox();
            data_entry5 = new TextBox();
            data_entry4 = new TextBox();
            data_entry3 = new TextBox();
            data_entry2 = new TextBox();
            input = new Label();
            data_entry = new TextBox();
            panel2 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cancellation
            // 
            cancellation.BackColor = Color.Silver;
            cancellation.Font = new Font("Stencil", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cancellation.ForeColor = SystemColors.ButtonHighlight;
            cancellation.Location = new Point(306, 325);
            cancellation.Name = "cancellation";
            cancellation.Size = new Size(174, 38);
            cancellation.TabIndex = 0;
            cancellation.Text = "ОТМЕНА";
            cancellation.UseVisualStyleBackColor = false;
            cancellation.Click += cancellation_Click;
            // 
            // save
            // 
            save.BackColor = Color.Silver;
            save.Font = new Font("Stencil", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            save.ForeColor = Color.White;
            save.Location = new Point(306, 263);
            save.Name = "save";
            save.Size = new Size(174, 43);
            save.TabIndex = 1;
            save.Text = "СОХРАНИТЬ";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(input6);
            panel1.Controls.Add(input5);
            panel1.Controls.Add(input4);
            panel1.Controls.Add(input3);
            panel1.Controls.Add(input2);
            panel1.Controls.Add(data_entry6);
            panel1.Controls.Add(data_entry5);
            panel1.Controls.Add(data_entry4);
            panel1.Controls.Add(data_entry3);
            panel1.Controls.Add(data_entry2);
            panel1.Controls.Add(input);
            panel1.Controls.Add(data_entry);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 450);
            panel1.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.Location = new Point(25, 323);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 14;
            cmbStatus.SelectedItemChanged += cmbStatus_SelectedItemChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(25, 201);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(25, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // input6
            // 
            input6.AutoSize = true;
            input6.Location = new Point(25, 305);
            input6.Name = "input6";
            input6.Size = new Size(41, 15);
            input6.TabIndex = 11;
            input6.Text = "input6";
            // 
            // input5
            // 
            input5.AutoSize = true;
            input5.Location = new Point(25, 243);
            input5.Name = "input5";
            input5.Size = new Size(41, 15);
            input5.TabIndex = 10;
            input5.Text = "input5";
            // 
            // input4
            // 
            input4.AutoSize = true;
            input4.Location = new Point(25, 183);
            input4.Name = "input4";
            input4.Size = new Size(41, 15);
            input4.TabIndex = 9;
            input4.Text = "input4";
            // 
            // input3
            // 
            input3.AutoSize = true;
            input3.Location = new Point(25, 128);
            input3.Name = "input3";
            input3.Size = new Size(41, 15);
            input3.TabIndex = 8;
            input3.Text = "input3";
            // 
            // input2
            // 
            input2.AutoSize = true;
            input2.Location = new Point(25, 71);
            input2.Name = "input2";
            input2.Size = new Size(41, 15);
            input2.TabIndex = 7;
            input2.Text = "input2";
            // 
            // data_entry6
            // 
            data_entry6.Location = new Point(25, 323);
            data_entry6.Name = "data_entry6";
            data_entry6.Size = new Size(200, 23);
            data_entry6.TabIndex = 6;
            // 
            // data_entry5
            // 
            data_entry5.Location = new Point(25, 261);
            data_entry5.Name = "data_entry5";
            data_entry5.Size = new Size(200, 23);
            data_entry5.TabIndex = 5;
            // 
            // data_entry4
            // 
            data_entry4.Location = new Point(25, 201);
            data_entry4.Name = "data_entry4";
            data_entry4.Size = new Size(148, 23);
            data_entry4.TabIndex = 4;
            // 
            // data_entry3
            // 
            data_entry3.Location = new Point(25, 146);
            data_entry3.Name = "data_entry3";
            data_entry3.Size = new Size(148, 23);
            data_entry3.TabIndex = 3;
            // 
            // data_entry2
            // 
            data_entry2.Location = new Point(25, 89);
            data_entry2.Name = "data_entry2";
            data_entry2.Size = new Size(200, 23);
            data_entry2.TabIndex = 2;
            // 
            // input
            // 
            input.AutoSize = true;
            input.Location = new Point(25, 17);
            input.Name = "input";
            input.Size = new Size(35, 15);
            input.TabIndex = 1;
            input.Text = "input";
            // 
            // data_entry
            // 
            data_entry.Location = new Point(25, 35);
            data_entry.Name = "data_entry";
            data_entry.Size = new Size(200, 23);
            data_entry.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(bt_min);
            panel2.Controls.Add(bt_max);
            panel2.Controls.Add(bt_exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(244, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 35);
            panel2.TabIndex = 3;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.LightSeaGreen;
            bt_min.Dock = DockStyle.Right;
            bt_min.Location = new Point(451, 0);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(35, 35);
            bt_min.TabIndex = 11;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Olive;
            bt_max.Dock = DockStyle.Right;
            bt_max.Location = new Point(486, 0);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(35, 35);
            bt_max.TabIndex = 10;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.SaddleBrown;
            bt_exit.Dock = DockStyle.Right;
            bt_exit.Location = new Point(521, 0);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(35, 35);
            bt_exit.TabIndex = 9;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(save);
            Controls.Add(cancellation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Change";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change";
            Load += Change_Load;
            MouseDown += panel1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button cancellation;
        private Button save;
        private Panel panel1;
        private Label input2;
        private TextBox data_entry6;
        private TextBox data_entry5;
        private TextBox data_entry4;
        private TextBox data_entry3;
        private TextBox data_entry2;
        private Label input;
        private TextBox data_entry;
        private Label input5;
        private Label input4;
        private Label input3;
        private Label input6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DomainUpDown cmbStatus;
        private Panel panel2;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}