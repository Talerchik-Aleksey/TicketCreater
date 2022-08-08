namespace TicketCreater
{
    public partial class HelpForm3 : Form
    {
        public HelpForm3()
        {
            InitializeComponent();
            TitleBar titleBar = new TitleBar()
            {
                Dock = DockStyle.Top,
            };

            this.Controls.Add(titleBar);
            NextButton.Location = new Point((this.ClientSize.Width - NextButton.Size.Width) / 2, NextButton.Location.Y);

            int DotY = Dot1.Location.Y;

            Dot1.Location = new Point((this.ClientSize.Width - Dot1.Size.Width) / 2 - 25, DotY);
            Dot2.Location = new Point((this.ClientSize.Width - Dot2.Size.Width) / 2, DotY);
            Dot3.Location = new Point((this.ClientSize.Width - Dot3.Size.Width) / 2 + 25, DotY);
        }

        private void EventSystem_VisibleChanged(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
        }

        private void HelpForm_Resize(object sender, EventArgs e)
        {
            EventSystem.Location = new Point((this.ClientSize.Width - EventSystem.Size.Width) / 2, EventSystem.Location.Y);
            NextButton.Location = new Point((this.ClientSize.Width - NextButton.Size.Width) / 2, NextButton.Location.Y);

            int DotY = Dot1.Location.Y;

            Dot1.Location = new Point((this.ClientSize.Width - Dot1.Size.Width) / 2 - 25, DotY);
            Dot2.Location = new Point((this.ClientSize.Width - Dot2.Size.Width) / 2, DotY);
            Dot3.Location = new Point((this.ClientSize.Width - Dot3.Size.Width) / 2 + 25, DotY);
        }

        private void Dot1_Click(object sender, EventArgs e)
        {
            int formWindowState = (int)this.WindowState;
            if (sender.Equals(Dot1))
            {
                this.Close();
                HelpForm helpForm = new();
                helpForm.Show();
                helpForm.WindowState = (FormWindowState)formWindowState;
            }
            else if (sender.Equals(Dot2))
            {
                this.Close();
                HelpForm2 helpForm2 = new();
                helpForm2.Show();
                helpForm2.WindowState = (FormWindowState)formWindowState;
            }
            else if (sender.Equals(Dot3))
            {

            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
