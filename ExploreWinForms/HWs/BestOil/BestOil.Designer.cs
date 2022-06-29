namespace ExploreWinForms.HWs.BestOil
{
    partial class BestOil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LitersLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UAHLabelRadioBtn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PriceLiterTextBox = new System.Windows.Forms.TextBox();
            this.LitersOrMoneyGB = new System.Windows.Forms.GroupBox();
            this.LitersRadioBtn = new System.Windows.Forms.RadioButton();
            this.MoneyRadioBtn = new System.Windows.Forms.RadioButton();
            this.UAHLable = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.FuelCombBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FinalPriceLabel = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.textBoxAdminLogin = new System.Windows.Forms.TextBox();
            this.textBoxAdnimPassword = new System.Windows.Forms.TextBox();
            this.buttonAdminLogInLogOut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CafePriceLabel = new System.Windows.Forms.Label();
            this.AmountCafe = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.LitersOrMoneyGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LitersLabel);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.UAHLabelRadioBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.PriceLiterTextBox);
            this.groupBox1.Controls.Add(this.LitersOrMoneyGB);
            this.groupBox1.Controls.Add(this.UAHLable);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Controls.Add(this.FuelLabel);
            this.groupBox1.Controls.Add(this.FuelCombBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "АЗС";
            // 
            // LitersLabel
            // 
            this.LitersLabel.AutoSize = true;
            this.LitersLabel.Location = new System.Drawing.Point(160, 88);
            this.LitersLabel.Name = "LitersLabel";
            this.LitersLabel.Size = new System.Drawing.Size(13, 13);
            this.LitersLabel.TabIndex = 13;
            this.LitersLabel.Text = "л";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(79, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Tag = "2";
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UAHLabelRadioBtn
            // 
            this.UAHLabelRadioBtn.AutoSize = true;
            this.UAHLabelRadioBtn.Location = new System.Drawing.Point(160, 113);
            this.UAHLabelRadioBtn.Name = "UAHLabelRadioBtn";
            this.UAHLabelRadioBtn.Size = new System.Drawing.Size(24, 13);
            this.UAHLabelRadioBtn.TabIndex = 11;
            this.UAHLabelRadioBtn.Text = "грн";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(79, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Tag = "1";
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PriceLiterTextBox
            // 
            this.PriceLiterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLiterTextBox.Enabled = false;
            this.PriceLiterTextBox.Location = new System.Drawing.Point(90, 49);
            this.PriceLiterTextBox.Name = "PriceLiterTextBox";
            this.PriceLiterTextBox.Size = new System.Drawing.Size(64, 20);
            this.PriceLiterTextBox.TabIndex = 9;
            this.PriceLiterTextBox.TextChanged += new System.EventHandler(this.PriceLiterTextBox_TextChanged);
            // 
            // LitersOrMoneyGB
            // 
            this.LitersOrMoneyGB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LitersOrMoneyGB.Controls.Add(this.LitersRadioBtn);
            this.LitersOrMoneyGB.Controls.Add(this.MoneyRadioBtn);
            this.LitersOrMoneyGB.Location = new System.Drawing.Point(6, 75);
            this.LitersOrMoneyGB.Name = "LitersOrMoneyGB";
            this.LitersOrMoneyGB.Size = new System.Drawing.Size(67, 58);
            this.LitersOrMoneyGB.TabIndex = 8;
            this.LitersOrMoneyGB.TabStop = false;
            // 
            // LitersRadioBtn
            // 
            this.LitersRadioBtn.AutoSize = true;
            this.LitersRadioBtn.Checked = true;
            this.LitersRadioBtn.Location = new System.Drawing.Point(6, 11);
            this.LitersRadioBtn.Name = "LitersRadioBtn";
            this.LitersRadioBtn.Size = new System.Drawing.Size(57, 17);
            this.LitersRadioBtn.TabIndex = 0;
            this.LitersRadioBtn.TabStop = true;
            this.LitersRadioBtn.Tag = "1";
            this.LitersRadioBtn.Text = "Кіл-ть:";
            this.LitersRadioBtn.UseVisualStyleBackColor = true;
            this.LitersRadioBtn.CheckedChanged += new System.EventHandler(this.LitersRadioBtn_CheckedChanged);
            // 
            // MoneyRadioBtn
            // 
            this.MoneyRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MoneyRadioBtn.AutoSize = true;
            this.MoneyRadioBtn.Location = new System.Drawing.Point(6, 34);
            this.MoneyRadioBtn.Name = "MoneyRadioBtn";
            this.MoneyRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.MoneyRadioBtn.TabIndex = 1;
            this.MoneyRadioBtn.Tag = "2";
            this.MoneyRadioBtn.Text = "Сума:";
            this.MoneyRadioBtn.UseVisualStyleBackColor = true;
            this.MoneyRadioBtn.CheckedChanged += new System.EventHandler(this.MoneyRadioBtn_CheckedChanged);
            // 
            // UAHLable
            // 
            this.UAHLable.AutoSize = true;
            this.UAHLable.Location = new System.Drawing.Point(161, 56);
            this.UAHLable.Name = "UAHLable";
            this.UAHLable.Size = new System.Drawing.Size(24, 13);
            this.UAHLable.TabIndex = 6;
            this.UAHLable.Text = "грн";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(19, 56);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(65, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Ціна за 1 л:";
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Location = new System.Drawing.Point(19, 22);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(47, 13);
            this.FuelLabel.TabIndex = 3;
            this.FuelLabel.Text = "Бензин:";
            // 
            // FuelCombBox
            // 
            this.FuelCombBox.AccessibleDescription = "";
            this.FuelCombBox.AccessibleName = "";
            this.FuelCombBox.FormattingEnabled = true;
            this.FuelCombBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FuelCombBox.Location = new System.Drawing.Point(73, 19);
            this.FuelCombBox.Name = "FuelCombBox";
            this.FuelCombBox.Size = new System.Drawing.Size(121, 21);
            this.FuelCombBox.TabIndex = 2;
            this.FuelCombBox.SelectedIndexChanged += new System.EventHandler(this.FuelCombBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FinalPriceLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 49);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "До сплати:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "грн";
            // 
            // FinalPriceLabel
            // 
            this.FinalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalPriceLabel.Location = new System.Drawing.Point(73, 16);
            this.FinalPriceLabel.Name = "FinalPriceLabel";
            this.FinalPriceLabel.Size = new System.Drawing.Size(75, 24);
            this.FinalPriceLabel.TabIndex = 0;
            this.FinalPriceLabel.Text = "0";
            this.FinalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(26, 212);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 79);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Всього до сплати:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(206, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(229, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 60);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "грн";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Розрахувати:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(26, 292);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "Settings";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // textBoxAdminLogin
            // 
            this.textBoxAdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdminLogin.Location = new System.Drawing.Point(107, 295);
            this.textBoxAdminLogin.Name = "textBoxAdminLogin";
            this.textBoxAdminLogin.Size = new System.Drawing.Size(119, 20);
            this.textBoxAdminLogin.TabIndex = 14;
            this.textBoxAdminLogin.Text = "Login";
            this.textBoxAdminLogin.Visible = false;
            this.textBoxAdminLogin.Enter += new System.EventHandler(this.textBoxAdminLogin_Enter);
            this.textBoxAdminLogin.Leave += new System.EventHandler(this.textBoxAdminLogin_Leave);
            // 
            // textBoxAdnimPassword
            // 
            this.textBoxAdnimPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdnimPassword.Location = new System.Drawing.Point(232, 295);
            this.textBoxAdnimPassword.Name = "textBoxAdnimPassword";
            this.textBoxAdnimPassword.PasswordChar = '*';
            this.textBoxAdnimPassword.Size = new System.Drawing.Size(119, 20);
            this.textBoxAdnimPassword.TabIndex = 15;
            this.textBoxAdnimPassword.Text = "Password";
            this.textBoxAdnimPassword.Visible = false;
            this.textBoxAdnimPassword.Enter += new System.EventHandler(this.textBoxAdnimPassword_Enter);
            this.textBoxAdnimPassword.Leave += new System.EventHandler(this.textBoxAdnimPassword_Leave);
            // 
            // buttonAdminLogInLogOut
            // 
            this.buttonAdminLogInLogOut.Location = new System.Drawing.Point(357, 292);
            this.buttonAdminLogInLogOut.Name = "buttonAdminLogInLogOut";
            this.buttonAdminLogInLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminLogInLogOut.TabIndex = 16;
            this.buttonAdminLogInLogOut.Text = "LogIn";
            this.buttonAdminLogInLogOut.UseVisualStyleBackColor = true;
            this.buttonAdminLogInLogOut.Visible = false;
            this.buttonAdminLogInLogOut.Click += new System.EventHandler(this.buttonAdminLogInLogOut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(149, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 92);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 89);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(100, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 92);
            this.panel3.TabIndex = 16;
            // 
            // CafePriceLabel
            // 
            this.CafePriceLabel.AutoSize = true;
            this.CafePriceLabel.Location = new System.Drawing.Point(111, 21);
            this.CafePriceLabel.Name = "CafePriceLabel";
            this.CafePriceLabel.Size = new System.Drawing.Size(32, 13);
            this.CafePriceLabel.TabIndex = 7;
            this.CafePriceLabel.Text = "Ціна:";
            // 
            // AmountCafe
            // 
            this.AmountCafe.AutoSize = true;
            this.AmountCafe.Location = new System.Drawing.Point(154, 21);
            this.AmountCafe.Name = "AmountCafe";
            this.AmountCafe.Size = new System.Drawing.Size(39, 13);
            this.AmountCafe.TabIndex = 8;
            this.AmountCafe.Text = "Кіл-ть:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(14, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 49);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "До сплати:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "грн";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.AmountCafe);
            this.groupBox2.Controls.Add(this.CafePriceLabel);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кафе";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 318);
            this.Controls.Add(this.buttonAdminLogInLogOut);
            this.Controls.Add(this.textBoxAdnimPassword);
            this.Controls.Add(this.textBoxAdminLogin);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BestOil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BestOil_FormClosing);
            this.Load += new System.EventHandler(this.BestOil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LitersOrMoneyGB.ResumeLayout(false);
            this.LitersOrMoneyGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.ComboBox FuelCombBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox PriceLiterTextBox;
        private System.Windows.Forms.GroupBox LitersOrMoneyGB;
        private System.Windows.Forms.RadioButton MoneyRadioBtn;
        private System.Windows.Forms.RadioButton LitersRadioBtn;
        private System.Windows.Forms.Label UAHLable;
        private System.Windows.Forms.Label LitersLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label UAHLabelRadioBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FinalPriceLabel;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TextBox textBoxAdminLogin;
        private System.Windows.Forms.TextBox textBoxAdnimPassword;
        private System.Windows.Forms.Button buttonAdminLogInLogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CafePriceLabel;
        private System.Windows.Forms.Label AmountCafe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
    }
}