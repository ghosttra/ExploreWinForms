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
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mousedown(object sender, MouseEventArgs e)
        {
            width = e.X;
            height = e.Y;
            Label label = new Label()
            {
                AutoSize = false,
                ForeColor = Color.DarkCyan,
                Location = new Point(e.X, e.Y),
                Name = "label" + labels.Count,
                TabIndex = 0,
                Text = "label" + labels.Count,
                BackColor = Color.DarkCyan
            };
            labels.Add(label);
        }

        private void mouseup(object sender, MouseEventArgs e)
        {
            int pointX;
            int pointY;
            if (e.X < labels[labels.Count - 1].Location.X)
            {
                width -= e.X;
                pointX = e.X;
            }
            else
            {
                width = e.X - width;
                pointX = labels[labels.Count - 1].Location.X;
            }

            if (e.Y < labels[labels.Count - 1].Location.Y)
            {
                height -= e.Y;
                pointY = e.Y;
            }
            else
            {
                height = e.Y - height;
                pointY = labels[labels.Count - 1].Location.Y;
            }
            if (height <= 10 && width <= 10)
            {
                MessageBox.Show("Мінімальний розмір \"статика\" складає 10×10", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labels.RemoveAt(labels.Count - 1);
            }
            else
            {
                labels[labels.Count - 1].Location = new Point(pointX, pointY);
                labels[labels.Count - 1].Size = new Size(width, height);
                labels[labels.Count - 1].DoubleClick += new EventHandler(AnyLabelDoubleClick);
                labels[labels.Count - 1].MouseClick += new MouseEventHandler(AnyLabelMouseClick);
                Controls.Add(labels[labels.Count - 1]);
            }
        }

        private void AnyLabelDoubleClick(object sender, EventArgs e)
        {
            Controls.Remove(labels.Find(pred => (Label)sender == pred));
            labels.Remove(labels.Find(pred => (Label)sender == pred));
        }

        private void AnyLabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Text = (sender as Label).Location.ToString() + " " + (sender as Label).Width * (sender as Label).Height;
        }
    }
}
