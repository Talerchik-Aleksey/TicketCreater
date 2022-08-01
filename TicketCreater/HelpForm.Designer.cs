namespace TicketCreater
{
    partial class HelpForm
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
            this.EventSystem = new TicketCreater.EventUserComponent();
            this.Footer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dot1 = new System.Windows.Forms.PictureBox();
            this.Dot2 = new System.Windows.Forms.PictureBox();
            this.Dot3 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.Footer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            this.SuspendLayout();
            // 
            // EventSystem
            // 
            this.EventSystem.AutoSize = true;
            this.EventSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EventSystem.Location = new System.Drawing.Point(180, 13);
            this.EventSystem.Name = "EventSystem";
            this.EventSystem.Size = new System.Drawing.Size(640, 48);
            this.EventSystem.TabIndex = 0;
            this.EventSystem.Visible = false;
            this.EventSystem.VisibleChanged += new System.EventHandler(this.EventSystem_VisibleChanged);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.EventSystem);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 442);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1000, 73);
            this.Footer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 99);
            this.label1.TabIndex = 4;
            this.label1.Text = "ОСНОВНЫЕ МОМЕНТЫ РАБОТЫ С ПРИЛОЖЕНИЕМ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 343);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дальше вы сможете ознакомиться с основными особенностями работы с приложением";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dot1);
            this.panel1.Controls.Add(this.Dot2);
            this.panel1.Controls.Add(this.Dot3);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 6;
            // 
            // Dot1
            // 
            this.Dot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot1.Image = global::TicketCreater.Properties.Resources.Active;
            this.Dot1.Location = new System.Drawing.Point(478, 77);
            this.Dot1.Name = "Dot1";
            this.Dot1.Size = new System.Drawing.Size(20, 20);
            this.Dot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dot1.TabIndex = 3;
            this.Dot1.TabStop = false;
            this.Dot1.Click += new System.EventHandler(this.Dot1_Click);
            // 
            // Dot2
            // 
            this.Dot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot2.Image = global::TicketCreater.Properties.Resources.unActive;
            this.Dot2.Location = new System.Drawing.Point(504, 77);
            this.Dot2.Name = "Dot2";
            this.Dot2.Size = new System.Drawing.Size(20, 20);
            this.Dot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dot2.TabIndex = 2;
            this.Dot2.TabStop = false;
            this.Dot2.Click += new System.EventHandler(this.Dot1_Click);
            // 
            // Dot3
            // 
            this.Dot3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot3.Image = global::TicketCreater.Properties.Resources.unActive;
            this.Dot3.Location = new System.Drawing.Point(530, 77);
            this.Dot3.Name = "Dot3";
            this.Dot3.Size = new System.Drawing.Size(20, 20);
            this.Dot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dot3.TabIndex = 1;
            this.Dot3.TabStop = false;
            this.Dot3.Click += new System.EventHandler(this.Dot1_Click);
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Image = global::TicketCreater.Properties.Resources.ButtonNext;
            this.NextButton.Location = new System.Drawing.Point(367, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(280, 53);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NextButton.TabIndex = 0;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.Resize += new System.EventHandler(this.HelpForm_Resize);
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EventUserComponent EventSystem;
        private Panel Footer;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox Dot1;
        private PictureBox Dot2;
        private PictureBox Dot3;
        private PictureBox NextButton;
    }
}