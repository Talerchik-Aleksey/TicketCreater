namespace TicketCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };

            this.Controls.Add(titleBar);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MainMenuPanel.Location = new Point((this.ClientSize.Width - MainMenuPanel.Size.Width) / 2, MainMenuPanel.Location.Y);
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TicketCreating ticketCreating = new TicketCreating();
            ticketCreating.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EventSystem.Visible = false;
            models.EventSystem.Type = 2;
            models.EventSystem.Name = "Настройка";
            models.EventSystem.Description = "Перед созданием билетов выполните настройку приложения";
            EventSystem.Visible = true;
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}