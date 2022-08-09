namespace TicketCreater
{
    partial class TicketCreating
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Group = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Toggle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EventSystem = new TicketCreater.EventUserComponent();
            this.Footer = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 77);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сколько нужно сформировать";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 77);
            this.panel4.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(536, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TicketCreater.Properties.Resources.Button;
            this.pictureBox4.Location = new System.Drawing.Point(229, 342);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Location = new System.Drawing.Point(314, 105);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(718, 495);
            this.MainPanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Subject);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 77);
            this.panel3.TabIndex = 9;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(536, 32);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(179, 23);
            this.Subject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 77);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дисциплина";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Group);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 77);
            this.panel2.TabIndex = 8;
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(536, 32);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(179, 23);
            this.Group.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 77);
            this.label2.TabIndex = 0;
            this.label2.Text = "Группа";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Toggle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 77);
            this.panel1.TabIndex = 7;
            // 
            // Toggle
            // 
            this.Toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.Toggle.Image = global::TicketCreater.Properties.Resources.ToggleSwitchOn;
            this.Toggle.Location = new System.Drawing.Point(536, 0);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(182, 77);
            this.Toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Toggle.TabIndex = 1;
            this.Toggle.TabStop = false;
            this.Toggle.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление билетов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketCreater.Properties.Resources.Button_1;
            this.pictureBox1.Location = new System.Drawing.Point(229, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // EventSystem
            // 
            this.EventSystem.AutoSize = true;
            this.EventSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EventSystem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EventSystem.Location = new System.Drawing.Point(249, 13);
            this.EventSystem.Name = "EventSystem";
            this.EventSystem.Size = new System.Drawing.Size(640, 48);
            this.EventSystem.TabIndex = 0;
            this.EventSystem.Visible = false;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.EventSystem);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 695);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1366, 73);
            this.Footer.TabIndex = 14;
            // 
            // TicketCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketCreating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные для формирования";
            this.Load += new System.EventHandler(this.TicketCreating_Load);
            this.Shown += new System.EventHandler(this.TicketCreating_Shown);
            this.Resize += new System.EventHandler(this.TicketCreating_Resize);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Toggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label4;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel MainPanel;
        private EventUserComponent EventSystem;
        private Panel Footer;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox Toggle;
        private Panel panel2;
        private TextBox Group;
        private Label label2;
        private Panel panel3;
        private TextBox Subject;
        private Label label3;
    }
}