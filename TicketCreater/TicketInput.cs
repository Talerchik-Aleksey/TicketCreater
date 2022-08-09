using TicketCreater.models;
using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class TicketInput : Form
    {
        private const string V = "Введите вопросы для билета под номером ";
        private const string APP_PATH_FOR_TICKETS = "../../tickets.txt";
        private int _currentTicketNumber = 1;
        private string _path = APP_PATH_FOR_TICKETS;

        public TicketInput()
        {
            InitializeComponent();

            Description.Text = V + _currentTicketNumber;

            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);

            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };
            this.Controls.Add(titleBar);

            using (FileStream fs = File.Create(_path))
            {
                return;
            }
        }

        private void TicketInput_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MsBox msBox = new MsBox("Вы действительно хотите выйти?", "После закрытия окна вы не сможете восстановить введённые вами данные");
            if (msBox.ShowDialog() == DialogResult.Cancel) { this.Close(); return; }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Settings.TicketDesign) TicketParser();
            else TestWriter();

            if (_currentTicketNumber == TicketsInformation.numbers)
            {
                this.Close();
                Resaults resaults = new();
                resaults.Show();
                return;
            }
            EventSystem.SuccessEvent("Успешно", $"Билет {_currentTicketNumber} успешно сформированн");
            _currentTicketNumber++;
            Description.Text = V + _currentTicketNumber;

            richTextBox1.Clear();
        }

        private async void TestWriter()
        {
            using (StreamWriter sw = new(_path, true))
            {
                var lines = richTextBox1.Text.Split('\n');
                foreach (string line in lines)
                {
                    await sw.WriteLineAsync(line);
                }
                await sw.WriteLineAsync();
            }
        }

        private void TicketParser()
        {
            HeaderWrite(_path);
            BodyWrite(_path);
            FooterWrite(_path);
        }

        private async void HeaderWrite(string path)
        {
            using (StreamWriter sw = new(path, true))
            {
                await sw.WriteLineAsync("Ф 05-422\n".PadLeft(127) +
                    $"Главное управление образования {Settings.EducationRegion}\n".PadLeft(73) +
                    "Учреждение образования\n".PadLeft(64) +
                    $"«{Settings.EducateInstitution}»\n".PadLeft(73) +
                    $"ЭКЗАМЕНАЦИОННЫЙ БИЛЕТ №_{_currentTicketNumber}__\n".PadLeft(54) +
                    $"Дисциплина_{Settings.Subject}\n");
            }
        }

        // Body parser
        private async void BodyWrite(string path)
        {
            YearsParser.ParseYears();
            using (StreamWriter sw = new(path, true))
            {
                await sw.WriteLineAsync($"Группа_{Settings.Group}___Экзаменационная сессия {StartEndYears.StartYear}_/{StartEndYears.EndYear} учебного года\n" +
                                         "                                         зимняя/летняя\n");
                var lines = richTextBox1.Text.Split('\n');
                foreach (string line in lines)
                {
                    await sw.WriteLineAsync(line);
                }
                await sw.WriteLineAsync();
            }
        }

        // footer parser
        private async void FooterWrite(string path)
        {
            using (StreamWriter sw = new(path, true))
            {
                await sw.WriteLineAsync("Преподаватель____________     Председатель цикловой комиссии__________\n" +
                    "                             подпись                                                                        подпись" +
                    "                                                        ______________");
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.PNextButton;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.PButtonClose;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.HButtonNext;
            }
            else if (sender.Equals(pictureBox1))
            {
                pictureBox.Image = Resources.HButtonClose;
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.ButtonClose;
            pictureBox4.Image = Resources.ButtonNext;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.ButtonClose;
            pictureBox4.Image = Resources.ButtonNext;
        }
    }
}
