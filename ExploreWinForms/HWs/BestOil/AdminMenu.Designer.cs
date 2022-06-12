namespace ExploreWinForms.HWs.BestOil
{
    partial class AdminMenu
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
            this.BtnAddFuel = new System.Windows.Forms.Button();
            this.ProgressBarFuelAdd = new System.Windows.Forms.ProgressBar();
            this.labelPriceForLiter = new System.Windows.Forms.Label();
            this.ListBoxFuelExist = new System.Windows.Forms.ListBox();
            this.LabelFuelExist = new System.Windows.Forms.Label();
            this.maskedTextBoxFuelAdd = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxAddFuel = new System.Windows.Forms.GroupBox();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGoodsPrice = new System.Windows.Forms.TextBox();
            this.textBoxGoods = new System.Windows.Forms.TextBox();
            this.buttonGoods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarGoods = new System.Windows.Forms.ProgressBar();
            this.listBoxCafeGoods = new System.Windows.Forms.ListBox();
            this.labelGoods = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxAddFuel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddFuel
            // 
            this.BtnAddFuel.Enabled = false;
            this.BtnAddFuel.Location = new System.Drawing.Point(191, 19);
            this.BtnAddFuel.Name = "BtnAddFuel";
            this.BtnAddFuel.Size = new System.Drawing.Size(68, 47);
            this.BtnAddFuel.TabIndex = 0;
            this.BtnAddFuel.Text = "Додати паливо";
            this.BtnAddFuel.UseVisualStyleBackColor = true;
            this.BtnAddFuel.Click += new System.EventHandler(this.BtnAddFuel_Click);
            // 
            // ProgressBarFuelAdd
            // 
            this.ProgressBarFuelAdd.Location = new System.Drawing.Point(6, 72);
            this.ProgressBarFuelAdd.Maximum = 2;
            this.ProgressBarFuelAdd.Name = "ProgressBarFuelAdd";
            this.ProgressBarFuelAdd.Size = new System.Drawing.Size(253, 23);
            this.ProgressBarFuelAdd.TabIndex = 1;
            // 
            // labelPriceForLiter
            // 
            this.labelPriceForLiter.AutoSize = true;
            this.labelPriceForLiter.Location = new System.Drawing.Point(3, 46);
            this.labelPriceForLiter.Name = "labelPriceForLiter";
            this.labelPriceForLiter.Size = new System.Drawing.Size(107, 13);
            this.labelPriceForLiter.TabIndex = 4;
            this.labelPriceForLiter.Text = "Ціна палива за 1 л: ";
            // 
            // ListBoxFuelExist
            // 
            this.ListBoxFuelExist.FormattingEnabled = true;
            this.ListBoxFuelExist.Location = new System.Drawing.Point(265, 39);
            this.ListBoxFuelExist.Name = "ListBoxFuelExist";
            this.ListBoxFuelExist.Size = new System.Drawing.Size(120, 56);
            this.ListBoxFuelExist.TabIndex = 5;
            // 
            // LabelFuelExist
            // 
            this.LabelFuelExist.AutoSize = true;
            this.LabelFuelExist.Location = new System.Drawing.Point(262, 23);
            this.LabelFuelExist.Name = "LabelFuelExist";
            this.LabelFuelExist.Size = new System.Drawing.Size(127, 13);
            this.LabelFuelExist.TabIndex = 6;
            this.LabelFuelExist.Text = "Паливо яке існує у БД: ";
            // 
            // maskedTextBoxFuelAdd
            // 
            this.maskedTextBoxFuelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxFuelAdd.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBoxFuelAdd.Mask = "АИ-00A??????????????????????";
            this.maskedTextBoxFuelAdd.Name = "maskedTextBoxFuelAdd";
            this.maskedTextBoxFuelAdd.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBoxFuelAdd.TabIndex = 7;
            this.maskedTextBoxFuelAdd.TextChanged += new System.EventHandler(this.TextsChanged);
            this.maskedTextBoxFuelAdd.Leave += new System.EventHandler(this.Focus_Leave);
            // 
            // groupBoxAddFuel
            // 
            this.groupBoxAddFuel.Controls.Add(this.textBoxFuelPrice);
            this.groupBoxAddFuel.Controls.Add(this.maskedTextBoxFuelAdd);
            this.groupBoxAddFuel.Controls.Add(this.BtnAddFuel);
            this.groupBoxAddFuel.Controls.Add(this.LabelFuelExist);
            this.groupBoxAddFuel.Controls.Add(this.ProgressBarFuelAdd);
            this.groupBoxAddFuel.Controls.Add(this.ListBoxFuelExist);
            this.groupBoxAddFuel.Controls.Add(this.labelPriceForLiter);
            this.groupBoxAddFuel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFuel.Name = "groupBoxAddFuel";
            this.groupBoxAddFuel.Size = new System.Drawing.Size(393, 110);
            this.groupBoxAddFuel.TabIndex = 8;
            this.groupBoxAddFuel.TabStop = false;
            this.groupBoxAddFuel.Text = "Додати пальне";
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFuelPrice.Location = new System.Drawing.Point(106, 44);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.Size = new System.Drawing.Size(79, 20);
            this.textBoxFuelPrice.TabIndex = 9;
            this.textBoxFuelPrice.TextChanged += new System.EventHandler(this.textBoxFuelPrice_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGoodsPrice);
            this.groupBox1.Controls.Add(this.textBoxGoods);
            this.groupBox1.Controls.Add(this.buttonGoods);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBarGoods);
            this.groupBox1.Controls.Add(this.listBoxCafeGoods);
            this.groupBox1.Controls.Add(this.labelGoods);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати продукт";
            // 
            // textBoxGoodsPrice
            // 
            this.textBoxGoodsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGoodsPrice.Location = new System.Drawing.Point(122, 47);
            this.textBoxGoodsPrice.Name = "textBoxGoodsPrice";
            this.textBoxGoodsPrice.Size = new System.Drawing.Size(63, 20);
            this.textBoxGoodsPrice.TabIndex = 8;
            this.textBoxGoodsPrice.TextChanged += new System.EventHandler(this.textBoxGoodsPrice_TextChanged);
            // 
            // textBoxGoods
            // 
            this.textBoxGoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGoods.Location = new System.Drawing.Point(7, 20);
            this.textBoxGoods.Name = "textBoxGoods";
            this.textBoxGoods.Size = new System.Drawing.Size(178, 20);
            this.textBoxGoods.TabIndex = 7;
            this.textBoxGoods.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxGoods.Leave += new System.EventHandler(this.FocusLeaveGroupGoods);
            // 
            // buttonGoods
            // 
            this.buttonGoods.Enabled = false;
            this.buttonGoods.Location = new System.Drawing.Point(191, 19);
            this.buttonGoods.Name = "buttonGoods";
            this.buttonGoods.Size = new System.Drawing.Size(68, 47);
            this.buttonGoods.TabIndex = 0;
            this.buttonGoods.Text = "Додати продукт";
            this.buttonGoods.UseVisualStyleBackColor = true;
            this.buttonGoods.Click += new System.EventHandler(this.buttonGoods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Товари що існують у БД:";
            // 
            // progressBarGoods
            // 
            this.progressBarGoods.Location = new System.Drawing.Point(6, 72);
            this.progressBarGoods.Maximum = 2;
            this.progressBarGoods.Name = "progressBarGoods";
            this.progressBarGoods.Size = new System.Drawing.Size(253, 23);
            this.progressBarGoods.TabIndex = 1;
            // 
            // listBoxCafeGoods
            // 
            this.listBoxCafeGoods.FormattingEnabled = true;
            this.listBoxCafeGoods.Location = new System.Drawing.Point(265, 39);
            this.listBoxCafeGoods.Name = "listBoxCafeGoods";
            this.listBoxCafeGoods.Size = new System.Drawing.Size(120, 56);
            this.listBoxCafeGoods.TabIndex = 5;
            // 
            // labelGoods
            // 
            this.labelGoods.AutoSize = true;
            this.labelGoods.Location = new System.Drawing.Point(3, 46);
            this.labelGoods.Name = "labelGoods";
            this.labelGoods.Size = new System.Drawing.Size(123, 13);
            this.labelGoods.TabIndex = 4;
            this.labelGoods.Text = "Ціна продукту за 1 шт: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 249);
            this.button3.TabIndex = 12;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 263);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAddFuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.groupBoxAddFuel.ResumeLayout(false);
            this.groupBoxAddFuel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddFuel;
        private System.Windows.Forms.ProgressBar ProgressBarFuelAdd;
        private System.Windows.Forms.Label labelPriceForLiter;
        private System.Windows.Forms.ListBox ListBoxFuelExist;
        private System.Windows.Forms.Label LabelFuelExist;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFuelAdd;
        private System.Windows.Forms.GroupBox groupBoxAddFuel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarGoods;
        private System.Windows.Forms.ListBox listBoxCafeGoods;
        private System.Windows.Forms.Label labelGoods;
        private System.Windows.Forms.TextBox textBoxGoods;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.TextBox textBoxGoodsPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}