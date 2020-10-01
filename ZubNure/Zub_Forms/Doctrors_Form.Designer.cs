namespace Zub_Forms
{
    partial class Doctrors_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctrors_Form));
            this.Back = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Maroon;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.Location = new System.Drawing.Point(1, 73);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 50);
            this.Back.TabIndex = 5;
            this.Back.UseVisualStyleBackColor = false;
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 70);
            this.panel1.TabIndex = 4;
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
            this.Menu.Location = new System.Drawing.Point(47, 73);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(727, 33);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "menuStrip1";
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(133, 29);
            this.Main.Text = "Главная         ";
            // 
            // Doctors
            // 
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(149, 29);
            this.Doctors.Text = "Доктора           ";
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
            this.Feedback.Size = new System.Drawing.Size(131, 29);
            this.Feedback.Text = "Отывы          ";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(70, 29);
            this.About.Text = "О нас";
            // 
            // Doctrors_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 433);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctrors_Form";
            this.Text = "Doctrors_Form";
            this.Load += new System.EventHandler(this.Doctrors_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
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
    }
}