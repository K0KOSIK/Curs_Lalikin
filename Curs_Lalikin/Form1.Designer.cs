namespace Curs_Lalikin
{
    partial class Avtorisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Avtorisation_label = new Label();
            Avtorisation_label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            Avtoris_role = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Avtorisation_label
            // 
            Avtorisation_label.AutoSize = true;
            Avtorisation_label.Font = new Font("Bauhaus 93", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Avtorisation_label.ForeColor = Color.White;
            Avtorisation_label.Location = new Point(40, 46);
            Avtorisation_label.Name = "Avtorisation_label";
            Avtorisation_label.Size = new Size(158, 33);
            Avtorisation_label.TabIndex = 0;
            Avtorisation_label.Text = "ВЫМПЕЛ ";
            // 
            // Avtorisation_label2
            // 
            Avtorisation_label2.AutoSize = true;
            Avtorisation_label2.Font = new Font("Bauhaus 93", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Avtorisation_label2.ForeColor = SystemColors.ButtonHighlight;
            Avtorisation_label2.Location = new Point(70, 79);
            Avtorisation_label2.Name = "Avtorisation_label2";
            Avtorisation_label2.Size = new Size(246, 33);
            Avtorisation_label2.TabIndex = 1;
            Avtorisation_label2.Text = "АВТОРИЗАЦИЯ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(301, 343);
            button1.Name = "button1";
            button1.Size = new Size(151, 42);
            button1.TabIndex = 4;
            button1.Text = "ВХОД";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(301, 150);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 5;
            label1.Text = "Введите Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(301, 210);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 6;
            label2.Text = "Введите password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(bt_min);
            panel1.Controls.Add(bt_max);
            panel1.Controls.Add(bt_exit);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 24);
            panel1.TabIndex = 7;
            panel1.MouseDown += panelTop_MouseDown;
            // 
            // bt_min
            // 
            bt_min.BackColor = Color.LightSeaGreen;
            bt_min.Location = new Point(704, 0);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(28, 23);
            bt_min.TabIndex = 2;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_min_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Olive;
            bt_max.Location = new Point(738, 0);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(25, 23);
            bt_max.TabIndex = 1;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.SaddleBrown;
            bt_exit.Location = new Point(769, 0);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(27, 23);
            bt_exit.TabIndex = 0;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Avtoris_role
            // 
            Avtoris_role.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            Avtoris_role.ForeColor = Color.ForestGreen;
            Avtoris_role.Location = new Point(301, 262);
            Avtoris_role.Name = "Avtoris_role";
            Avtoris_role.Size = new Size(152, 56);
            Avtoris_role.TabIndex = 8;
            Avtoris_role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Avtorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(Avtoris_role);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Avtorisation_label2);
            Controls.Add(Avtorisation_label);
            Name = "Avtorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avtorisation";
            FormClosing += Avtorisation_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Avtorisation_label;
        private Label Avtorisation_label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
        private Label Avtoris_role;
    }
}
