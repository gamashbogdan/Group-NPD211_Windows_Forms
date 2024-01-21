using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Moving_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse position : {e.X} : {e.Y}";
            Point mouse = e.Location;
            Random random = new Random();
            if (mouse.X >= buttonNo.Left - 20 && (mouse.X <= buttonNo.Left + buttonNo.Width + 20))
            {
                if (mouse.X >= buttonNo.Left + (buttonNo.Width / 2))
                {
                    buttonNo.Left = buttonNo.Left - 30;
                }
                else
                {
                    buttonNo.Left = buttonNo.Left + 30;
                }
            }
            else if (mouse.Y >= buttonNo.Top + 20 && (mouse.Y <= buttonNo.Top + buttonNo.Height + 20))
            {
                if (mouse.Y >= buttonNo.Top + (buttonNo.Width / 2))
                {
                    buttonNo.Top = buttonNo.Top - 20;
                }
                else
                {
                    buttonNo.Top = buttonNo.Top + 20;
                }

            }
            if (buttonNo.Top < 0)
            {
                buttonNo.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (buttonNo.Top + buttonNo.Height > this.ClientSize.Height)
            {
                buttonNo.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (buttonNo.Left < 0)
            {
                buttonNo.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
            if (buttonNo.Left + buttonNo.Width > this.ClientSize.Width)
            {
                buttonNo.Location = new Point(random.Next(this.Width), random.Next(this.Height));
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":))))))))))))))))))))))))))", "Good ;D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
