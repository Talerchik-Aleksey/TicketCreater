namespace TicketCreater
{
    partial class Resaults
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EventSystem = new TicketCreater.EventUserComponent();
            this.Footer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TicketCreater.Properties.Resources.SaveButton;
            this.pictureBox4.Location = new System.Drawing.Point(231, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Description);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Location = new System.Drawing.Point(123, 103);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(718, 279);
            this.MainPanel.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(0, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(718, 70);
            this.Description.TabIndex = 7;
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketCreater.Properties.Resources.ButtonClose;
            this.pictureBox1.Location = new System.Drawing.Point(231, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EventSystem
            // 
            this.EventSystem.AutoSize = true;
            this.EventSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EventSystem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EventSystem.Location = new System.Drawing.Point(146, 13);
            this.EventSystem.Name = "EventSystem";
            this.EventSystem.Size = new System.Drawing.Size(640, 48);
            this.EventSystem.TabIndex = 0;
            this.EventSystem.Visible = false;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.EventSystem);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 485);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(941, 73);
            this.Footer.TabIndex = 16;
            // 
            // Resaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 558);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resaults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resaults";
            this.Shown += new System.EventHandler(this.Resaults_Shown);
            this.Resize += new System.EventHandler(this.Resaults_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox4;
        private Panel MainPanel;
        private PictureBox pictureBox1;
        private EventUserComponent EventSystem;
        private Panel Footer;
        private Label Description;
    }
}