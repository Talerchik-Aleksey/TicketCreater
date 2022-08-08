using TicketCreater.models;
using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class TicketCreating : Form
    {
        ToggleState toggleState = null;
        bool ticketDesign = true;

        public TicketCreating()
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

        private void TicketCreating_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void TicketCreating_Shown(object sender, EventArgs e)
        {
            EventSystem.InfoEvent("Настройка", "Выберите количество билетов");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            SettingsForm settings = new();
            settings.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadSettings();
            TicketsInformation.numbers = (int)numericUpDown1.Value;
            this.Close();
            TicketInput ticketInput = new();

            ticketInput.Show();
        }

        private void LoadSettings()
        {
            Settings.TicketDesign = ticketDesign;
            Settings.Group = Group.Text;
            Settings.Subject = Subject.Text;
            Settings.ReadSettingsFromIniFile();
        }

        private void TicketCreating_Load(object sender, EventArgs e)
        {
            toggleState = new ToggleState() { IsChecked = true };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toggleState.IsChecked = !toggleState.IsChecked;
            Toggle.Image = toggleState.IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            ticketDesign = !ticketDesign;
        }
    }
}
