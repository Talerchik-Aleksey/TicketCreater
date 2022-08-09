namespace TicketCreater
{
    partial class TicketInput
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.EventSystem = new TicketCreater.EventUserComponent();
            this.Footer = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Controls.Add(this.Description);
            this.MainPanel.Controls.Add(this.richTextBox1);
            this.MainPanel.Location = new System.Drawing.Point(40, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(746, 381);
            this.MainPanel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TicketCreater.Properties.Resources.ButtonClose;
            this.pictureBox1.Location = new System.Drawing.Point(47, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::TicketCreater.Properties.Resources.ButtonNext;
            this.pictureBox4.Location = new System.Drawing.Point(407, 308);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Top;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(0, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(746, 70);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // EventSystem
            // 
            this.EventSystem.AutoSize = true;
            this.EventSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.EventSystem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EventSystem.Location = new System.Drawing.Point(87, 13);
            this.EventSystem.Name = "EventSystem";
            this.EventSystem.Size = new System.Drawing.Size(640, 48);
            this.EventSystem.TabIndex = 0;
            this.EventSystem.Visible = false;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.EventSystem);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 470);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(867, 73);
            this.Footer.TabIndex = 16;
            // 
            // TicketInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 543);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных";
            this.Resize += new System.EventHandler(this.TicketInput_Resize);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private RichTextBox richTextBox1;
        private EventUserComponent EventSystem;
        private Panel Footer;
        private Label Description;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}