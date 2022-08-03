using System.Drawing.Drawing2D;
using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class EventUserComponent : UserControl
    {
        public EventUserComponent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void EventUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (models.EventSystem.Type == 2) // info
            {
                pictureBox2.Image = new Bitmap(Resources.InformationIcon);
                this.BackColor = Color.FromArgb(50, 246, 246, 246);
            }
            else if (models.EventSystem.Type == 0)
            { // critical
                pictureBox2.Image = new Bitmap(Resources.CriticalIcon);
                this.BackColor = Color.FromArgb(253, 231, 233);
            }
            else if (models.EventSystem.Type == 1)
            { // warning
                pictureBox2.Image = new Bitmap(Resources.WarningIcon);
                this.BackColor = Color.FromArgb(255, 244, 206);
            }
            else
            { // success
                pictureBox2.Image = new Bitmap(Resources.SuccessIcon);
                this.BackColor = Color.FromArgb(223, 246, 221);
            }

            Title.Text = models.EventSystem.Name;
            Description.Text = models.EventSystem.Description;
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void EventUserComponent_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CriticalEvent(string caption, string text)
        {
            this.Visible = false;
            models.EventSystem.Type = 0;
            models.EventSystem.Name = caption;
            models.EventSystem.Description = text;
            this.Visible = true;
            this.UpdateStyles();
        }

        public void InfoEvent(string caption, string text)
        {
            this.Visible = false;
            models.EventSystem.Type = 2;
            models.EventSystem.Name = caption;
            models.EventSystem.Description = text;
            this.Visible = true;
            this.UpdateStyles();
        }
    }
}
