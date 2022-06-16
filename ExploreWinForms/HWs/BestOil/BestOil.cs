using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ExploreWinForms.HWs.BestOil
{

    public partial class BestOil : Form
    {
        User user;
        public Dictionary<string, decimal> CafeGoods { get; set; }
        public Dictionary<string, decimal> FuelPrices { get; set; }
        public decimal Earnings { get; set; }
        string fuelPath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()
               , "FuelPrices.txt");
        string cafePath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()
           , "CafeGoodsPrices.txt");
        public BestOil()
        {
            InitializeComponent();
            CafeGoods = new Dictionary<string, decimal>();
            FuelPrices = new Dictionary<string, decimal>();
            if (File.Exists(fuelPath) && File.Exists(cafePath))
            {
                using (StreamReader reader = File.OpenText(fuelPath))
                {
                    while (!reader.EndOfStream)
                        FuelPrices.Add(reader.ReadLine(), Convert.ToDecimal(reader.ReadLine()));
                }
                FuelCombBox.Items.AddRange(FuelPrices.Keys.ToArray());
                using (StreamReader reader = File.OpenText(cafePath))
                {
                    while (!reader.EndOfStream)
                        CafeGoods.Add(reader.ReadLine(), Convert.ToDecimal(reader.ReadLine()));
                }
                for (int i = 0; i < CafeGoods.Count; i++)
                {
                    addGood(i, CafeGoods.Keys.ToArray()[i], CafeGoods.Values.ToArray()[i].ToString());
                }
                FuelCombBox.SelectedIndex = 0;
            }



        }
        private void ElemsVisible(bool _visible)
        {
            textBoxAdminLogin.Visible = _visible;
            textBoxAdnimPassword.Visible = _visible;
            buttonAdminLogInLogOut.Visible = _visible;
        }
        private void ClearForm()
        {
            FuelCombBox.Focus();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[groupBox1.Controls[i].Name] is TextBox)
                    groupBox1.Controls[groupBox1.Controls[i].Name].Text = "";
            }
            FuelCombBox.SelectedItem = FuelCombBox.Items[0];
            if ((LitersOrMoneyGB.Controls[0] as RadioButton).Checked != true)
            {
                (LitersOrMoneyGB.Controls[1] as RadioButton).Checked = false;
                (LitersOrMoneyGB.Controls[0] as RadioButton).Checked = true;
            }
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                (panel1.Controls[i] as CheckBox).Checked = false;
            }
            label6.Text = "0";
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            ElemsVisible(true);
        }

        private void textBoxAdminLogin_Enter(object sender, EventArgs e)
        {
            textBoxAdminLogin.Text = "";
        }

        private void textBoxAdminLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxAdminLogin.Text == "")
                textBoxAdminLogin.Text = "Login";
        }

        private void textBoxAdnimPassword_Enter(object sender, EventArgs e)
        {
            textBoxAdnimPassword.Text = "";
        }

        private void textBoxAdnimPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxAdnimPassword.Text == "")
                textBoxAdnimPassword.Text = "Password";
        }

        private void buttonAdminLogInLogOut_Click(object sender, EventArgs e)
        {
            user = new Admin();
            if (textBoxAdnimPassword.Text.GetHashCode() == (user as Admin).Password && textBoxAdminLogin.Text == (user as Admin).Login)
            {
                if (MessageBox.Show("Ви успішно увійшли!", "", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    AdminMenu form = new AdminMenu(FuelPrices, CafeGoods);
                    form.ShowDialog();
                    FuelPrices = form.NewFuelPrices;
                    CafeGoods = form.NewGoods;
                    FuelCombBox.Items.Clear();
                    FuelCombBox.Items.AddRange(FuelPrices.Keys.ToArray());
                    for (int i = 0; i < groupBox2.Controls.Count; i++)
                    {
                        if (groupBox2.Controls[i] is Panel)
                            (groupBox2.Controls[i] as Panel).Controls.Clear();
                    }
                    int y = 0;
                    for (int i = 0; i < CafeGoods.Count; i++)
                    {
                        addGood(i, CafeGoods.Keys.ToArray()[i], CafeGoods.Values.ToArray()[i].ToString());

                    }
                    MessageBox.Show("Ви успішно вийшли!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user = null;
                    ElemsVisible(_visible: false);
                    textBoxAdminLogin.Text = "Login";
                    textBoxAdnimPassword.Text = "Password";
                }
            }
            else
            {
                user = null;
                MessageBox.Show("Помилка у вході!\nПароль або логін невірний!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addGood(int i, string textboxtext, string price)
        {
            var numericbox = new NumericUpDown();
            numericbox.Dock = System.Windows.Forms.DockStyle.Top;
            numericbox.Enabled = false;
            numericbox.Name = "numericUpDown" + (i + 1);
            numericbox.Size = new System.Drawing.Size(61, 20);
            numericbox.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            numericbox.Leave += new System.EventHandler(this.numericUpDown_Leave);
            panel2.Controls.Add(numericbox);
            var tempcheckbox = new CheckBox();
            tempcheckbox.AutoSize = true;
            tempcheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            tempcheckbox.Name = "CheckBox" + (i + 1);
            tempcheckbox.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            tempcheckbox.Size = new System.Drawing.Size(93, 19);
            tempcheckbox.Text = textboxtext;
            tempcheckbox.UseVisualStyleBackColor = true;
            tempcheckbox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            panel1.Controls.Add(tempcheckbox);
            var temptextbox = new TextBox();
            temptextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            temptextbox.Dock = System.Windows.Forms.DockStyle.Top;
            temptextbox.Enabled = false;
            temptextbox.Name = "textBoxGoodPrice" + (i + 1);
            temptextbox.Size = new System.Drawing.Size(48, 20);
            temptextbox.Text = price;
            panel3.Controls.Add(temptextbox);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    if (panel1.Controls[panel1.Controls[i].Name].Name == (sender as CheckBox).Name)
                    {
                        panel2.Controls[panel2.Controls[i].Name].Enabled = (sender as CheckBox).Checked;
                        panel2.Controls[panel2.Controls[i].Name].Focus();
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    if (panel1.Controls[panel1.Controls[i].Name].Name == (sender as CheckBox).Name)
                    {
                        panel2.Controls[panel2.Controls[i].Name].Enabled = (sender as CheckBox).Checked;
                        panel2.Controls[panel2.Controls[i].Name].Text = "0";
                        break;
                    }
                }
            }
        }
        private void FuelCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceLiterTextBox.Text = FuelPrices[FuelCombBox.Items[FuelCombBox.SelectedIndex].ToString()].ToString();
        }
        private void toPayFuel(object sender)
        {
            if ((sender as TextBox).Text == "")
            {
                FinalPriceLabel.Text = "0";
                return;
            }
            if (FuelCombBox.SelectedIndex != -1)
            {
                switch ((sender as TextBox).Tag)
                {
                    case "1":
                        FinalPriceLabel.Text = (Convert.ToDecimal((sender as TextBox).Text) * Convert.ToDecimal(PriceLiterTextBox.Text)).ToString();
                        break;
                    case "2":
                        FinalPriceLabel.Text = (Convert.ToDecimal((sender as TextBox).Text) / Convert.ToDecimal(PriceLiterTextBox.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
        private void LitersRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = LitersRadioBtn.Checked;
            textBox3.Text = "";
            groupBox3.Text = "До сплати:";
            label1.Text = "грн";
        }

        private void MoneyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = MoneyRadioBtn.Checked;
            textBox2.Text = "";
            groupBox3.Text = "Оплачено:";
            label1.Text = "л";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toPayFuel(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal toPay = Convert.ToDecimal(label3.Text);
            if (LitersRadioBtn.Checked)
                toPay += Convert.ToDecimal(FinalPriceLabel.Text);
            else
                toPay += Convert.ToDecimal(textBox3.Text);
            Earnings += toPay;
            label6.Text = toPay.ToString();
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult res = MessageBox.Show("Продовжуємо сесію?\n\nЯкщо ні, то почнеться нова!\n\nВсьго зароблено " + Earnings, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (res)
            {
                case DialogResult.No:
                    ClearForm();
                    break;
            }
        }
        private void PriceLiterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PriceLiterTextBox.Text != "")
                FuelPrices[FuelCombBox.Items[FuelCombBox.SelectedIndex].ToString()] = Convert.ToDecimal(PriceLiterTextBox.Text);
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                if (panel2.Controls[panel2.Controls[i].Name].Name == (sender as NumericUpDown).Name)
                {
                    if (panel2.Controls[i].Text == "")
                        break;
                    decimal tempSum = 0;
                    for (int r = 0; r < panel2.Controls.Count; r++)
                    {
                        if (panel2.Controls[panel2.Controls[r].Name].Enabled)
                            tempSum += Convert.ToDecimal(Convert.ToInt32(panel2.Controls[r].Text) * CafeGoods[CafeGoods.Keys.ToList().Find(pred => pred == panel1.Controls[r].Text)]);
                    }
                    label3.Text = tempSum.ToString();
                    break;
                }
            }
        }
        private void numericUpDown_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                if (panel2.Controls[panel2.Controls[i].Name].Text == "")
                {
                    panel2.Controls[panel2.Controls[i].Name].Text = "0";
                }
            }
        }

        private void BestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = File.CreateText(fuelPath))
            {
                var Keys = FuelPrices.Keys.ToList();
                var Values = FuelPrices.Values.ToList();
                for (int i = 0; i < FuelPrices.Count; i++)
                {
                    writer.WriteLine(Keys[i]);
                    writer.WriteLine(Values[i]);
                }
            }
            using (StreamWriter writer = File.CreateText(cafePath))
            {
                var Keys = CafeGoods.Keys.ToList();
                var Values = CafeGoods.Values.ToList();
                for (int i = 0; i < CafeGoods.Count; i++)
                {
                    writer.WriteLine(Keys[i]);
                    writer.WriteLine(Values[i]);
                }
            }
        }

        private void BestOil_Load(object sender, EventArgs e)
        {

        }
    }
    class User
    {
        public string Name { get; set; } = "None";
    }
    class Admin : User
    {
        public Admin()
        {
            base.Name = Login;
        }
        public string Login { get; set; } = "admin";
        public int Password { get; set; } = "admin".GetHashCode();
    }
}
