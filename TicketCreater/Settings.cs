using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };

            this.Controls.Add(titleBar);

            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            // TODO: SAVE SETTINGS SYSTEM

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // TODO: Create iternal class
            ChangeState((PictureBox)sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        // TODO: Delete this
        private void ChangeState(PictureBox sender)
        {
            if(sender == null)
            {
                models.EventSystem.Type = 0;
                models.EventSystem.Name = "Ошибка";
                models.EventSystem.Description = "Что-то пошло не так!";
                EventSystem.Visible = true;
                return;
            }

            if (sender.Image.GetHashCode == Resources.ToggleSwitchOn.GetHashCode)
            {
                sender.Image = Resources.ToggleSwitchOff;
            } else { sender.Image = Resources.ToggleSwitchOn; }
        }
    }
}
