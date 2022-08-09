using TicketCreater.models;
using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class Resaults : Form
    {
        private const string SourceFileName = "../../tickets.txt";

        public Resaults()
        {
            InitializeComponent();

            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };

            this.Controls.Add(titleBar);

            FormLabel();

            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void FormLabel()
        {
            int numberOfTickets = TicketsInformation.numbers;
            string labelString = $"Сформированно: {numberOfTickets} {GetTicketWord(numberOfTickets)}";
            Description.Text = labelString;
        }

        private string GetTicketWord(int numberOfTicket)
        {
            string result = numberOfTicket switch
            {
                1 => "билет",
                > 2 and < 5 => "билета",
                _ => "билетов"
            };
            return result;
        }

        private void Resaults_Shown(object sender, EventArgs e)
        {
            EventSystem.SuccessEvent("Сформированно", "Cозданные вами билеты готовы к сохранению");
        }

        private void Resaults_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MsBox msBox = new("Вы действительно хотите выйти?", "После закрытия окна вы не сможете восстановить введённые вами данные");
            if (msBox.ShowDialog() == DialogResult.Cancel) { this.Close(); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SaveTickets();
        }

        private void SaveTickets()
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Text File|*.txt|Word File|*.doc";
            saveFileDialog.Title = "Save your tickets";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                if (path != "")
                {
                    File.Copy(SourceFileName, path, true);
                    this.Close();
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.PSaveButton;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.PButtonClose;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.HSaveButton;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.HButtonClose;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.SaveButton;
            pictureBox1.Image = Resources.ButtonClose;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Resources.SaveButton;
            pictureBox1.Image = Resources.ButtonClose;
        }
    }
}
