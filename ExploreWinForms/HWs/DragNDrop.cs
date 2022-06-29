using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreWinForms.HWs
{
    public partial class DragNDrop : Form
    {
        public DragNDrop()
        {
            InitializeComponent();
        }
        public int pounds { get; set; }
        public int pence { get; set; }
        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            var count = listView1.SelectedIndices.Count;
            var str = listView1.Items[listView1.SelectedIndices[0]].ImageKey;
            if (count > 0)
            {
                string s = str.Substring(0, str.Length - 4);
                switch (s[s.Length - 1])
                {
                    case 'f':
                        pounds += int.Parse(s.Substring(0, s.Length - 1));
                        break;
                    case 'p':
                        pence += int.Parse(s.Substring(0, s.Length - 1));
                        break;
                }
                if (pence > 99)
                {
                    pence -= 100;
                    pounds++;
                }
                listView2.Items.Add(new ListViewItem("", listView1.SelectedIndices[0]));
                label1.Text = $"{pounds}f, {pence}p";
            }
        }
        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var count = listView1.SelectedIndices.Count;
            if (count > 0)
            {
                listView1.DoDragDrop(listView1.SelectedIndices[0], DragDropEffects.Copy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            label1.Text = "No money";
            pence = 0;
            pounds = 0;
        }
    }
}
