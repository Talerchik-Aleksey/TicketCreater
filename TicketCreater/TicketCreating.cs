﻿using System;
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
    public partial class TicketCreating : Form
    {
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
            Settings settings = new();
            settings.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TicketsInformation.numbers = (int)numericUpDown1.Value;
            this.Close();
            TicketInput ticketInput = new();
            ticketInput.Show();

        }
    }
}