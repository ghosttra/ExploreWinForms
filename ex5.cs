using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreWinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Width = 800;
            Height = 500;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void MyStaticMouseEnter(object sender, MouseEventArgs e)
        {
            Text = Size.ToString();
            var label = (Label)sender;
            if (label.Location.X + label.Height > Width || label.Location.X < 0 || label.Location.Y < 0 || label.Location.Y + label.Height > Height)
                label.Location = new Point(Width / 2, Height / 2);
            if (e.Location.X == 0 && e.Location.X < label.Width - 25)
            {
                label.Location = new Point(label.Location.X + 1, label.Location.Y);
            }
            if (e.Location.X == label.Width - 1 && e.Location.X > label.Width - 25)
            {
                label.Location = new Point(label.Location.X - 1, label.Location.Y);
            }
            if (e.Location.Y == 0 && e.Location.Y < label.Height - 25)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + 1);
            }
            if (e.Location.Y == label.Height - 1 && e.Location.Y > label.Height - 25)
            {
                label.Location = new Point(label.Location.X, label.Location.Y - 1);
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (MyStatic.Size.Width < 151)
                MyStatic.Size = new Size(MyStatic.Width + 50, MyStatic.Height + 50);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (MyStatic.Size.Width > 50)
                MyStatic.Size = new Size(MyStatic.Width - 50, MyStatic.Height - 50);
        }
    }
}
