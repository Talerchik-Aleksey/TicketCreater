using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketCreater.models;

namespace TicketCreater
{
    public partial class TicketInput : Form
    {
        private const string V = "Введите вопросы для билета под номером ";
        private const string APP_PATH_FOR_TICKETS = "../../tickets.txt";
        private const string Caption = "Cформированно";
        private int currentTicketNumber = 1;
        private string path = APP_PATH_FOR_TICKETS;

        public TicketInput()
        {
            InitializeComponent();
            Description.Text = V + currentTicketNumber;
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };

            this.Controls.Add(titleBar);

            using (FileStream fs = File.Create(path))
            {
                return;
            }
        }

        private async void HeaderWrite(string path)
        {
            using (StreamWriter sw = new(path, true))
            {
                await sw.WriteLineAsync("Ф 05-422\n".PadLeft(127) +
                    "Главное управление образования Гродненской областного\n".PadLeft(73) +
                    "Учреждение образования\n".PadLeft(64) +
                    "«Гродненский государственный колледж техники, технологий и дизайна»\n".PadLeft(73) +
                    $"ЭКЗАМЕНАЦИОННЫЙ БИЛЕТ №_{currentTicketNumber}__\n".PadLeft(54) +
                    "Дисциплина_Иностранный язык(профессиональная лексика)\n") ; 
                // TODO: Read subject from settings
            }
        }

        // Body parser
        private async void BodyWrite(string path)
        {
            using (StreamWriter sw = new(path, true))
            {
                await sw.WriteLineAsync("Группа_03-09-31тп___Экзаменационная сессия 2021_/2022 учебного года\n" +
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

        private void TicketParser()
        {
            HeaderWrite(path);
            BodyWrite(path);
            FooterWrite(path);
        }

        private void TicketInput_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            MainPanel.Location = new Point((this.ClientSize.Width - MainPanel.Size.Width) / 2, MainPanel.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TicketParser();
            if (currentTicketNumber == TicketsInformation.numbers)
            {
                this.Close();
                Resaults resaults = new();
                resaults.Show();
                return;
            }
            currentTicketNumber++;
            Description.Text = V + currentTicketNumber;
            string text = $"Билет под номером {currentTicketNumber - 1}, сформированн";
            EventSystem.SuccessEvent(Caption, text);
        }
    }
}
