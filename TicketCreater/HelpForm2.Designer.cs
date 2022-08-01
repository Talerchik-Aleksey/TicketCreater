namespace TicketCreater
{
    partial class HelpForm2
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
            this.label2 = new System.Windows.Forms.Label();
            this.EventSystem = new TicketCreater.EventUserComponent();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dot1 = new System.Windows.Forms.PictureBox();
            this.Dot2 = new System.Windows.Forms.PictureBox();
            this.Dot3 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 154);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дальше вы сможете ознакомиться с основными особенностями работы с приложением";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Dot1);
            this.panel1.Controls.Add(this.Dot2);
            this.panel1.Controls.Add(this.Dot3);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 727);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 10;
            // 
            // Dot1
            // 
            this.Dot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot1.Image = global::TicketCreater.Properties.Resources.unActive;
            this.Dot1.Location = new System.Drawing.Point(457, 77);
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
            this.Dot2.Image = global::TicketCreater.Properties.Resources.Active;
            this.Dot2.Location = new System.Drawing.Point(483, 77);
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
            this.Dot3.Location = new System.Drawing.Point(509, 77);
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
            this.NextButton.Location = new System.Drawing.Point(360, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(280, 53);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NextButton.TabIndex = 0;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 99);
            this.label1.TabIndex = 8;
            this.label1.Text = "Основные моменты работы с приложением";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.EventSystem);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 827);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1000, 73);
            this.Footer.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TicketCreater.Properties.Resources.image_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HelpForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка 2";
            this.Resize += new System.EventHandler(this.HelpForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private EventUserComponent EventSystem;
        private Panel panel1;
        private PictureBox Dot1;
        private PictureBox Dot2;
        private PictureBox Dot3;
        private PictureBox NextButton;
        private Label label1;
        private Panel Footer;
        private PictureBox pictureBox1;
    }
}