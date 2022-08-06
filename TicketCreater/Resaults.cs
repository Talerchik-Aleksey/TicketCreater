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
            MessageBox.Show($"{numberOfTickets}");
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
            this.Close();
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
            saveFileDialog.ShowDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                if (path != "")
                {
                    File.Copy(SourceFileName, path);
                    this.Close();
                }
            }
        }
    }
}
