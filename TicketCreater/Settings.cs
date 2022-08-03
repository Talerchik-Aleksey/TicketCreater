using System.Collections.Generic;
using TicketCreater.models;
using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class Settings : Form
    {

        private List<ToggleState> settingsStates;

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            // TODO: SAVE SETTINGS SYSTEM

            this.Close();
        }


        // TODO: Delete this
        private void ChangeState(PictureBox sender)
        {
            if (sender == null)
            {
                models.EventSystem.Type = 0;
                models.EventSystem.Name = "Ошибка";
                models.EventSystem.Description = "Что-то пошло не так!";
                EventSystem.Visible = true;
                return;
            }

            if (sender.Equals(Toggle1))
            {
                settingsStates[0].IsChecked = !settingsStates[0].IsChecked;
                Toggle1.Image = settingsStates[0].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            }
            else if (sender.Equals(Toggle2))
            {
                settingsStates[1].IsChecked = !settingsStates[1].IsChecked;
                Toggle2.Image = settingsStates[1].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            }
            else
            {
                settingsStates[2].IsChecked = !settingsStates[2].IsChecked;
                Toggle3.Image = settingsStates[2].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // TODO: Read from file
            settingsStates = new()
            {
                new ToggleState() { IsChecked = true },
                new ToggleState() { IsChecked = true },
                new ToggleState() { IsChecked = true },
            };
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            Toggle1.Image = settingsStates[0].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            Toggle2.Image = settingsStates[1].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
            Toggle3.Image = settingsStates[2].IsChecked ? Resources.ToggleSwitchOn : Resources.ToggleSwitchOff;
        }

        private void Toggle3_Click(object sender, EventArgs e)
        {
            ChangeState((PictureBox)sender);
        }
    }
}
