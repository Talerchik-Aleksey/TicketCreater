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
    public partial class TitleBar : UserControl
    {

        public TitleBar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var CurrentForm = Controls.Owner.FindForm();
            CurrentForm.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var CurrentForm = Controls.Owner.FindForm();
            if (CurrentForm.WindowState == 0)
            {
                CurrentForm.WindowState = FormWindowState.Maximized;
            } 
            else
            {
                CurrentForm.WindowState = FormWindowState.Normal;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var CurrentForm = Controls.Owner.FindForm();
            CurrentForm.WindowState = FormWindowState.Minimized;
        }

        private void CaptionParser()
        {
            var CurrentForm = Controls.Owner.FindForm();
            Caption.Text = CurrentForm.Text;
        }

        private void TitleBar_Load(object sender, EventArgs e)
        {
            CaptionParser();
        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void TitleBar_DoubleClick(object sender, EventArgs e)
        {
            var CurrentForm = Controls.Owner.FindForm();
            if (CurrentForm.WindowState == 0)
            {
                CurrentForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                CurrentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {
            if (this.Controls.Find("ChromeBack", true).FirstOrDefault() != default) return;
            if (Caption.Text == "Справка")
            {
                PictureBox ChromeBack = new PictureBox()
                {
                    Dock = DockStyle.Left,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    //Width = 48,
                    //Height = 32,
                    Image = new Bitmap(Resources.BackTitleButton),
                    Size = new Size(48, 32),
                    Name = "ChromeBack",
                };
                ChromeBack.Click += ChromeBack_Click; ;
                Controls.Add(ChromeBack);
                Caption.Location = new Point(Caption.Location.X + 30, Caption.Location.Y) ;
            }
        }

        private void ChromeBack_Click(object? sender, EventArgs e)
        {
            var CurrentForm = Controls.Owner.FindForm();
            var footers = CurrentForm.Controls.Find("Footer", true);
            foreach(var elem in footers)
            {
                var elems = elem.Controls.Find("EventSystem", true);
                foreach(var eventSystem in elems)
                {
                    models.EventSystem.Type = 0;
                    models.EventSystem.Name = "Ошибка";
                    models.EventSystem.Description = "Нет возможности вернуться на прошлую страницу";
                    eventSystem.Visible = true;
                }
            }
        }
    }
}
