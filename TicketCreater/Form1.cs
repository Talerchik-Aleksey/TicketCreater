using TicketCreater.Properties;

using TicketCreater.models;

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
            SettingsForm settings = new SettingsForm();
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.HButton;
            } else if (sender.Equals(pictureBox2))
            {
                pictureBox.Image = Resources.HButton_1;
            } else { pictureBox.Image = Resources.HButton_2; }
            
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.HButton;
            }
            else if (sender.Equals(pictureBox2))
            {
                pictureBox.Image = Resources.HButton_1;
            }
            else { pictureBox.Image = Resources.HButton_2; }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Button;
            pictureBox2.Image = Resources.Button_1;
            pictureBox3.Image = Resources.Button_2;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.PButton;
            }
            else if (sender.Equals(pictureBox2))
            {
                pictureBox.Image = Resources.PButton_1;
            }
            else { pictureBox.Image = Resources.PButton_2; }
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.Button;
            pictureBox2.Image = Resources.Button_1;
            pictureBox3.Image = Resources.Button_2;
        }
    }
}