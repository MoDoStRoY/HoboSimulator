
namespace HoboSimulator.Windows.Game
{
    partial class TradeWindow
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
            this.fxChosenGoodsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.fxAssortmentDGV = new System.Windows.Forms.DataGridView();
            this.NameOfPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostOfPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightOfPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.fxSummaryWeightLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.fxSummaryCostLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fxCurrentTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fxThirstLabel = new System.Windows.Forms.Label();
            this.fxThirstPB = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.fxHungerLabel = new System.Windows.Forms.Label();
            this.fxHungerPB = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.fxSleepLabel = new System.Windows.Forms.Label();
            this.fxStaminaLabel = new System.Windows.Forms.Label();
            this.fxHealthLabel = new System.Windows.Forms.Label();
            this.fxSleepPB = new System.Windows.Forms.ProgressBar();
            this.fxStaminaPB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fxHealthPB = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fxTtxText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fxDescriptionOfItemText = new System.Windows.Forms.RichTextBox();
            this.fxNameOfItemLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fxMoneyLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fxChosenGoodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAssortmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fxChosenGoodsDGV
            // 
            this.fxChosenGoodsDGV.AllowUserToAddRows = false;
            this.fxChosenGoodsDGV.AllowUserToDeleteRows = false;
            this.fxChosenGoodsDGV.AllowUserToResizeColumns = false;
            this.fxChosenGoodsDGV.AllowUserToResizeRows = false;
            this.fxChosenGoodsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fxChosenGoodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxChosenGoodsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fxChosenGoodsDGV.Location = new System.Drawing.Point(841, 159);
            this.fxChosenGoodsDGV.Name = "fxChosenGoodsDGV";
            this.fxChosenGoodsDGV.ReadOnly = true;
            this.fxChosenGoodsDGV.RowHeadersVisible = false;
            this.fxChosenGoodsDGV.RowHeadersWidth = 51;
            this.fxChosenGoodsDGV.RowTemplate.Height = 29;
            this.fxChosenGoodsDGV.Size = new System.Drawing.Size(441, 607);
            this.fxChosenGoodsDGV.TabIndex = 18;
            this.fxChosenGoodsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoGoodChosenDGV);
            this.fxChosenGoodsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteGoodDGV);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Вес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(841, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(165, 20);
            this.label24.TabIndex = 17;
            this.label24.Text = "Выбрано для покупки:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(384, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "Ассортимент:";
            // 
            // fxAssortmentDGV
            // 
            this.fxAssortmentDGV.AllowUserToAddRows = false;
            this.fxAssortmentDGV.AllowUserToDeleteRows = false;
            this.fxAssortmentDGV.AllowUserToResizeColumns = false;
            this.fxAssortmentDGV.AllowUserToResizeRows = false;
            this.fxAssortmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fxAssortmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxAssortmentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfPosition,
            this.CostOfPosition,
            this.WeightOfPosition});
            this.fxAssortmentDGV.Location = new System.Drawing.Point(384, 159);
            this.fxAssortmentDGV.Name = "fxAssortmentDGV";
            this.fxAssortmentDGV.ReadOnly = true;
            this.fxAssortmentDGV.RowHeadersVisible = false;
            this.fxAssortmentDGV.RowHeadersWidth = 51;
            this.fxAssortmentDGV.RowTemplate.Height = 29;
            this.fxAssortmentDGV.Size = new System.Drawing.Size(441, 607);
            this.fxAssortmentDGV.TabIndex = 15;
            this.fxAssortmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoGoodAssortmentDGV);
            this.fxAssortmentDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoseGoodDGV);
            // 
            // NameOfPosition
            // 
            this.NameOfPosition.HeaderText = "Название";
            this.NameOfPosition.MinimumWidth = 6;
            this.NameOfPosition.Name = "NameOfPosition";
            this.NameOfPosition.ReadOnly = true;
            // 
            // CostOfPosition
            // 
            this.CostOfPosition.HeaderText = "Цена";
            this.CostOfPosition.MinimumWidth = 6;
            this.CostOfPosition.Name = "CostOfPosition";
            this.CostOfPosition.ReadOnly = true;
            // 
            // WeightOfPosition
            // 
            this.WeightOfPosition.HeaderText = "Вес";
            this.WeightOfPosition.MinimumWidth = 6;
            this.WeightOfPosition.Name = "WeightOfPosition";
            this.WeightOfPosition.ReadOnly = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(384, 55);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(299, 29);
            this.button11.TabIndex = 14;
            this.button11.Text = "Купить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BuyBtn);
            // 
            // fxSummaryWeightLabel
            // 
            this.fxSummaryWeightLabel.AutoSize = true;
            this.fxSummaryWeightLabel.Location = new System.Drawing.Point(526, 32);
            this.fxSummaryWeightLabel.Name = "fxSummaryWeightLabel";
            this.fxSummaryWeightLabel.Size = new System.Drawing.Size(110, 20);
            this.fxSummaryWeightLabel.TabIndex = 13;
            this.fxSummaryWeightLabel.Text = "%Общий вес%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(384, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Общий вес:";
            // 
            // fxSummaryCostLabel
            // 
            this.fxSummaryCostLabel.AutoSize = true;
            this.fxSummaryCostLabel.Location = new System.Drawing.Point(526, 12);
            this.fxSummaryCostLabel.Name = "fxSummaryCostLabel";
            this.fxSummaryCostLabel.Size = new System.Drawing.Size(157, 20);
            this.fxSummaryCostLabel.TabIndex = 11;
            this.fxSummaryCostLabel.Text = "%Общая стоимость%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(384, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Общая стоимость:";
            // 
            // fxCurrentTimeLabel
            // 
            this.fxCurrentTimeLabel.AutoSize = true;
            this.fxCurrentTimeLabel.Location = new System.Drawing.Point(172, 602);
            this.fxCurrentTimeLabel.Name = "fxCurrentTimeLabel";
            this.fxCurrentTimeLabel.Size = new System.Drawing.Size(78, 20);
            this.fxCurrentTimeLabel.TabIndex = 81;
            this.fxCurrentTimeLabel.Text = "%Время%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Текущее время: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 29);
            this.button1.TabIndex = 79;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // fxThirstLabel
            // 
            this.fxThirstLabel.AutoSize = true;
            this.fxThirstLabel.Location = new System.Drawing.Point(345, 670);
            this.fxThirstLabel.Name = "fxThirstLabel";
            this.fxThirstLabel.Size = new System.Drawing.Size(21, 20);
            this.fxThirstLabel.TabIndex = 78;
            this.fxThirstLabel.Text = "%";
            // 
            // fxThirstPB
            // 
            this.fxThirstPB.Location = new System.Drawing.Point(172, 670);
            this.fxThirstPB.Name = "fxThirstPB";
            this.fxThirstPB.Size = new System.Drawing.Size(167, 20);
            this.fxThirstPB.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 670);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Питьё:";
            // 
            // fxHungerLabel
            // 
            this.fxHungerLabel.AutoSize = true;
            this.fxHungerLabel.Location = new System.Drawing.Point(345, 693);
            this.fxHungerLabel.Name = "fxHungerLabel";
            this.fxHungerLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHungerLabel.TabIndex = 75;
            this.fxHungerLabel.Text = "%";
            // 
            // fxHungerPB
            // 
            this.fxHungerPB.Location = new System.Drawing.Point(172, 694);
            this.fxHungerPB.Name = "fxHungerPB";
            this.fxHungerPB.Size = new System.Drawing.Size(167, 19);
            this.fxHungerPB.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 693);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "Сытость:";
            // 
            // fxSleepLabel
            // 
            this.fxSleepLabel.AutoSize = true;
            this.fxSleepLabel.Location = new System.Drawing.Point(345, 744);
            this.fxSleepLabel.Name = "fxSleepLabel";
            this.fxSleepLabel.Size = new System.Drawing.Size(21, 20);
            this.fxSleepLabel.TabIndex = 72;
            this.fxSleepLabel.Text = "%";
            // 
            // fxStaminaLabel
            // 
            this.fxStaminaLabel.AutoSize = true;
            this.fxStaminaLabel.Location = new System.Drawing.Point(345, 718);
            this.fxStaminaLabel.Name = "fxStaminaLabel";
            this.fxStaminaLabel.Size = new System.Drawing.Size(21, 20);
            this.fxStaminaLabel.TabIndex = 71;
            this.fxStaminaLabel.Text = "%";
            // 
            // fxHealthLabel
            // 
            this.fxHealthLabel.AutoSize = true;
            this.fxHealthLabel.Location = new System.Drawing.Point(345, 644);
            this.fxHealthLabel.Name = "fxHealthLabel";
            this.fxHealthLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHealthLabel.TabIndex = 70;
            this.fxHealthLabel.Text = "%";
            // 
            // fxSleepPB
            // 
            this.fxSleepPB.Location = new System.Drawing.Point(172, 744);
            this.fxSleepPB.Name = "fxSleepPB";
            this.fxSleepPB.Size = new System.Drawing.Size(167, 19);
            this.fxSleepPB.TabIndex = 69;
            // 
            // fxStaminaPB
            // 
            this.fxStaminaPB.Location = new System.Drawing.Point(172, 719);
            this.fxStaminaPB.Name = "fxStaminaPB";
            this.fxStaminaPB.Size = new System.Drawing.Size(167, 19);
            this.fxStaminaPB.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Выносливость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 744);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Потребность во сне:";
            // 
            // fxHealthPB
            // 
            this.fxHealthPB.Location = new System.Drawing.Point(172, 645);
            this.fxHealthPB.Name = "fxHealthPB";
            this.fxHealthPB.Size = new System.Drawing.Size(167, 19);
            this.fxHealthPB.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Состояние здоровья:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 88;
            this.label4.Text = "Характеристики: ";
            // 
            // fxTtxText
            // 
            this.fxTtxText.Location = new System.Drawing.Point(12, 360);
            this.fxTtxText.Name = "fxTtxText";
            this.fxTtxText.Size = new System.Drawing.Size(345, 200);
            this.fxTtxText.TabIndex = 87;
            this.fxTtxText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Описание: ";
            // 
            // fxDescriptionOfItemText
            // 
            this.fxDescriptionOfItemText.Location = new System.Drawing.Point(12, 134);
            this.fxDescriptionOfItemText.Name = "fxDescriptionOfItemText";
            this.fxDescriptionOfItemText.Size = new System.Drawing.Size(345, 200);
            this.fxDescriptionOfItemText.TabIndex = 85;
            this.fxDescriptionOfItemText.Text = "";
            // 
            // fxNameOfItemLabel
            // 
            this.fxNameOfItemLabel.AutoSize = true;
            this.fxNameOfItemLabel.Location = new System.Drawing.Point(173, 44);
            this.fxNameOfItemLabel.Name = "fxNameOfItemLabel";
            this.fxNameOfItemLabel.Size = new System.Drawing.Size(101, 20);
            this.fxNameOfItemLabel.TabIndex = 84;
            this.fxNameOfItemLabel.Text = "%Название%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Название: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // fxMoneyLabel
            // 
            this.fxMoneyLabel.AutoSize = true;
            this.fxMoneyLabel.Location = new System.Drawing.Point(172, 622);
            this.fxMoneyLabel.Name = "fxMoneyLabel";
            this.fxMoneyLabel.Size = new System.Drawing.Size(83, 20);
            this.fxMoneyLabel.TabIndex = 95;
            this.fxMoneyLabel.Text = "%Деньги%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 624);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 94;
            this.label13.Text = "Деньги:";
            // 
            // TradeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 778);
            this.Controls.Add(this.fxMoneyLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fxTtxText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fxDescriptionOfItemText);
            this.Controls.Add(this.fxNameOfItemLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fxCurrentTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fxThirstLabel);
            this.Controls.Add(this.fxThirstPB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fxHungerLabel);
            this.Controls.Add(this.fxHungerPB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fxSleepLabel);
            this.Controls.Add(this.fxStaminaLabel);
            this.Controls.Add(this.fxHealthLabel);
            this.Controls.Add(this.fxSleepPB);
            this.Controls.Add(this.fxStaminaPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fxHealthPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fxChosenGoodsDGV);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.fxAssortmentDGV);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.fxSummaryWeightLabel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.fxSummaryCostLabel);
            this.Controls.Add(this.label19);
            this.Name = "TradeWindow";
            this.Text = "HoboSimulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            this.Load += new System.EventHandler(this.InitializeForm);
            ((System.ComponentModel.ISupportInitialize)(this.fxChosenGoodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAssortmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView fxChosenGoodsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.DataGridView fxAssortmentDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostOfPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightOfPosition;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.Label fxSummaryWeightLabel;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label fxSummaryCostLabel;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label fxCurrentTimeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label fxThirstLabel;
        public System.Windows.Forms.ProgressBar fxThirstPB;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label fxHungerLabel;
        public System.Windows.Forms.ProgressBar fxHungerPB;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label fxSleepLabel;
        public System.Windows.Forms.Label fxStaminaLabel;
        public System.Windows.Forms.Label fxHealthLabel;
        public System.Windows.Forms.ProgressBar fxSleepPB;
        public System.Windows.Forms.ProgressBar fxStaminaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar fxHealthPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox fxTtxText;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox fxDescriptionOfItemText;
        public System.Windows.Forms.Label fxNameOfItemLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label fxMoneyLabel;
        private System.Windows.Forms.Label label13;
    }
}