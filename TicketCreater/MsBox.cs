using TicketCreater.Properties;

namespace TicketCreater
{
    public partial class MsBox : Form
    {
        public MsBox(string caption, string text)
        {
            InitializeComponent();
            Caption.Text = caption;
            BodyLabel.Text = text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox5))
            {
                pictureBox.Image = Resources.PNextButton;
            }
            else if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.PButtonClose;
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (sender.Equals(pictureBox5))
            {
                pictureBox.Image = Resources.HButtonNext;
            }
            else if (sender.Equals(pictureBox4))
            {
                pictureBox.Image = Resources.HButtonClose;
            }
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Resources.ButtonNext;
            pictureBox4.Image = Resources.ButtonClose;

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.ButtonNext;
            pictureBox4.Image = Resources.ButtonClose;
        }
    }
}
