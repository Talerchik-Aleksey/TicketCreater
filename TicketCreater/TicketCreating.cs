using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private async void TicketParser()
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

            if (!toggleState.IsChecked)
            {
                panel2.Visible = false;
                panel3.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.PButton;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.PButton_1;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.HButton;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.HButton_1;
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Button;
            pictureBox1.Image = Resources.Button_1;

        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Resources.Button;
            pictureBox1.Image = Resources.Button_1;
        }
    }
}
