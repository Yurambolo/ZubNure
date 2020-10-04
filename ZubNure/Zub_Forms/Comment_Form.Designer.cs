namespace Zub_Forms
{
    partial class Comment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comment_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Main = new System.Windows.Forms.ToolStripMenuItem();
            this.Doctors = new System.Windows.Forms.ToolStripMenuItem();
            this.Appoint = new System.Windows.Forms.ToolStripMenuItem();
            this.Feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.l3 = new System.Windows.Forms.Panel();
            this.label67 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Panel();
            this.label77 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.l3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.l1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.l2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 70);
            this.panel1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(737, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(446, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон : 095 67 786 45";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стоматологическая клиника ZubNure";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main,
            this.Doctors,
            this.Appoint,
            this.Feedback,
            this.About});
            this.Menu.Location = new System.Drawing.Point(43, 73);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(722, 33);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Main.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(133, 29);
            this.Main.Text = "Главная         ";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // Doctors
            // 
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(149, 29);
            this.Doctors.Text = "Доктора           ";
            this.Doctors.Click += new System.EventHandler(this.Doctors_Click);
            // 
            // Appoint
            // 
            this.Appoint.Name = "Appoint";
            this.Appoint.Size = new System.Drawing.Size(236, 29);
            this.Appoint.Text = "Записатся к доктору         ";
            // 
            // Feedback
            // 
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(107, 29);
            this.Feedback.Text = "Услуги      ";
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // About
            // 
            this.About.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(89, 29);
            this.About.Text = "Отзывы";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Maroon;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Back.Location = new System.Drawing.Point(-6, 73);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 50);
            this.Back.TabIndex = 4;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(126, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 54);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(50, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "пациенты различного возраста посещают стоматологов с разными проблемами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(186, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Отзывы клиентов";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.l3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(5, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 262);
            this.panel3.TabIndex = 14;
            // 
            // l3
            // 
            this.l3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l3.Controls.Add(this.label77);
            this.l3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l3.Location = new System.Drawing.Point(514, 3);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(253, 50);
            this.l3.TabIndex = 2;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label67.Location = new System.Drawing.Point(0, 17);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(58, 22);
            this.label67.TabIndex = 0;
            this.label67.Text = "label6";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.l1);
            this.panel4.Location = new System.Drawing.Point(7, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 200);
            this.panel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l1.Controls.Add(this.label5);
            this.l1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l1.Location = new System.Drawing.Point(3, 3);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(219, 50);
            this.l1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(514, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(259, 200);
            this.panel8.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.l2);
            this.panel5.Location = new System.Drawing.Point(256, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 200);
            this.panel5.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            // 
            // l2
            // 
            this.l2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.l2.Controls.Add(this.label67);
            this.l2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l2.Location = new System.Drawing.Point(3, 3);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(246, 50);
            this.l2.TabIndex = 2;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label77.Location = new System.Drawing.Point(3, 17);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(58, 22);
            this.label77.TabIndex = 0;
            this.label77.Text = "label7";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(288, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(398, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Comment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(784, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comment_Form";
            this.Text = "Comment_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.l3.ResumeLayout(false);
            this.l3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.l1.ResumeLayout(false);
            this.l1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.l2.ResumeLayout(false);
            this.l2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Main;
        private System.Windows.Forms.ToolStripMenuItem Doctors;
        private System.Windows.Forms.ToolStripMenuItem Appoint;
        private System.Windows.Forms.ToolStripMenuItem Feedback;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel l3;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel l1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel l2;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}