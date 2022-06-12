using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreWinForms.HWs.BestOil
{
    public partial class AdminMenu : Form
    {
        public AdminMenu(Dictionary<string, decimal> FuelPrices, Dictionary<string, decimal> CafeGoods)
        {
            InitializeComponent();
            NewFuelPrices = FuelPrices;
            NewGoods = CafeGoods;
            ListBoxFuelExist.Items.AddRange(FuelPrices.Keys.ToArray());
            listBoxCafeGoods.Items.AddRange(CafeGoods.Keys.ToArray());
        }
        public Dictionary<string, decimal> NewFuelPrices { get; } = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> NewGoods { get; } = new Dictionary<string, decimal>();
        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
        private void ClearAddFuelGroup()
        {
            maskedTextBoxFuelAdd.Text = "";
            textBoxFuelPrice.Text = "0";
            ProgressBarFuelAdd.Value = 0;
        }
        private void ClearAddGoodsGroup()
        {
            textBoxGoods.Text = "";
            textBoxGoodsPrice.Text = "0";
            progressBarGoods.Value = 0;
        }
        private void BtnAddFuel_Click(object sender, EventArgs e)
        {
            var temp = textBoxFuelPrice.Text.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '.')
                {
                    temp[i] = ',';
                    textBoxFuelPrice.Text = new string(temp);
                    break;
                }
            if (Decimal.TryParse(textBoxFuelPrice.Text, out decimal price))
            {
                for (int i = 0; i < ListBoxFuelExist.Items.Count; i++)
                {
                    if (ListBoxFuelExist.Items[i].ToString() == maskedTextBoxFuelAdd.Text)
                    {
                        MessageBox.Show("Такий бензин вже існує!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearAddFuelGroup();
                        return;
                    }

                }
                NewFuelPrices[maskedTextBoxFuelAdd.Text] = price;
                ListBoxFuelExist.Items.Add(maskedTextBoxFuelAdd.Text);
            }
            ClearAddFuelGroup();
        }

        private void TextsChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxFuelAdd.Text.Length > 3)
                textBoxFuelPrice.Enabled = true;
            else
                textBoxFuelPrice.Enabled = false;
        }

        private void Focus_Leave(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox && (sender as MaskedTextBox).Text.Length > 3 && ProgressBarFuelAdd.Value < 3 || sender is MaskedTextBox && (sender as NumericUpDown).Value > 0 && ProgressBarFuelAdd.Value < 3)
                ProgressBarFuelAdd.Value++;
            else if (ProgressBarFuelAdd.Value > 0)
                ProgressBarFuelAdd.Value--;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGoods.Text.Length > 1)
                textBoxGoodsPrice.Enabled = true;
            else
                textBoxGoodsPrice.Enabled = false;
        }

        private void FocusLeaveGroupGoods(object sender, EventArgs e)
        {
            if (sender is TextBox && (sender as TextBox).Text.Length > 3 && progressBarGoods.Value < 2 || sender is NumericUpDown && (sender as NumericUpDown).Value > 0 && progressBarGoods.Value < 2)
                progressBarGoods.Value++;
            else if (progressBarGoods.Value > 0)
                progressBarGoods.Value--;
        }

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            var temp = textBoxGoodsPrice.Text.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '.')
                {
                    temp[i] = ',';
                    textBoxGoodsPrice.Text = new string(temp);
                    break;
                }
            if (Decimal.TryParse(textBoxGoodsPrice.Text, out decimal price))
            {
                for (int i = 0; i < listBoxCafeGoods.Items.Count; i++)
                {
                    if (listBoxCafeGoods.Items[i].ToString() == textBoxGoodsPrice.Text)
                    {
                        MessageBox.Show("Такий товар вже існує!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearAddGoodsGroup();
                        return;
                    }
                }
                NewGoods[textBoxGoods.Text] = price;
                listBoxCafeGoods.Items.Add(textBoxGoods.Text);
            }
            ClearAddGoodsGroup();
        }

        private void textBoxGoodsPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGoodsPrice.Text.Length > 0)
                buttonGoods.Enabled = true;
            else
                buttonGoods.Enabled = false;
        }

        private void textBoxFuelPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFuelPrice.Text.Length > 0)
                BtnAddFuel.Enabled = true;
            else
                BtnAddFuel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is GroupBox)
                {
                    for (int j = 0; j < Controls[i].Controls.Count; j++)
                    {
                        if (Controls[i].Controls[j] is ListBox && (Controls[i].Controls[j] as ListBox).SelectedIndex > -1)
                        {
                            if ((Controls[i].Controls[j] as ListBox).Name == ListBoxFuelExist.Name)
                            {
                                NewFuelPrices.Remove((Controls[i].Controls[j] as ListBox).SelectedItem.ToString());
                            }
                            else if ((Controls[i].Controls[j] as ListBox).Name == listBoxCafeGoods.Name)
                            {
                                NewGoods.Remove((Controls[i].Controls[j] as ListBox).SelectedItem.ToString());
                            }
                            (Controls[i].Controls[j] as ListBox).Items.Remove((Controls[i].Controls[j] as ListBox).SelectedItem);
                        }
                    }
                }
            }
        }
    }
}
