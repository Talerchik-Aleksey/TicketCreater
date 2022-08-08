using MyProg;
using TicketCreater.models;

namespace TicketCreater
{
    public partial class SettingsForm : Form
    {
        private List<ToggleState> settingsStates;

        public SettingsForm()
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SaveSettings();

            this.Close();
        }


        private void SaveSettings()
        {
            WriteSettings();
            Settings.ReadSettingsFromIniFile();
        }

        private void WriteSettings()
        {
            try
            {
                IniFile MyIni = new(Settings.IniPath);                
                MyIni.Write("EducateInstitution", EducateInstitutionTextBox.Text);
                MyIni.Write("EducationRegion", EducationRegionComboBox.Text);
            }
            catch (Exception ex)
            {
                EventSystem.CriticalEvent("Ошибка", "Ошибка при записи настроек");
                MessageBox.Show(ex.Message);
            }

        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            Settings.ReadSettingsFromIniFile();
            EducateInstitutionTextBox.Text = Settings.EducateInstitution;
            EducationRegionComboBox.Text = Settings.EducationRegion;
        }
    }
}
