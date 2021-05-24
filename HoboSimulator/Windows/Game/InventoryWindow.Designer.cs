
namespace HoboSimulator.Windows.Game
{
    partial class InventoryWindow
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
            this.fxInventoryDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fxNameOfItemLabel = new System.Windows.Forms.Label();
            this.fxDescriptionOfItemText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fxTtxText = new System.Windows.Forms.RichTextBox();
            this.fxUseBtn = new System.Windows.Forms.Button();
            this.fxDropBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fxWeightLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fxMaxWeightLabel = new System.Windows.Forms.Label();
            this.fxMoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fxCurrentTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fxHealthPB = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fxInventoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fxInventoryDGV
            // 
            this.fxInventoryDGV.AllowUserToAddRows = false;
            this.fxInventoryDGV.AllowUserToDeleteRows = false;
            this.fxInventoryDGV.AllowUserToResizeColumns = false;
            this.fxInventoryDGV.AllowUserToResizeRows = false;
            this.fxInventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fxInventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxInventoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.fxInventoryDGV.Location = new System.Drawing.Point(728, 13);
            this.fxInventoryDGV.Name = "fxInventoryDGV";
            this.fxInventoryDGV.ReadOnly = true;
            this.fxInventoryDGV.RowHeadersVisible = false;
            this.fxInventoryDGV.RowHeadersWidth = 51;
            this.fxInventoryDGV.RowTemplate.Height = 29;
            this.fxInventoryDGV.Size = new System.Drawing.Size(560, 729);
            this.fxInventoryDGV.TabIndex = 0;
            this.fxInventoryDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChosenItemDGV);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 85.82888F;
            this.Column1.HeaderText = "Изображение";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 85.82888F;
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Название: ";
            // 
            // fxNameOfItemLabel
            // 
            this.fxNameOfItemLabel.AutoSize = true;
            this.fxNameOfItemLabel.Location = new System.Drawing.Point(538, 13);
            this.fxNameOfItemLabel.Name = "fxNameOfItemLabel";
            this.fxNameOfItemLabel.Size = new System.Drawing.Size(101, 20);
            this.fxNameOfItemLabel.TabIndex = 62;
            this.fxNameOfItemLabel.Text = "%Название%";
            // 
            // fxDescriptionOfItemText
            // 
            this.fxDescriptionOfItemText.Location = new System.Drawing.Point(377, 123);
            this.fxDescriptionOfItemText.Name = "fxDescriptionOfItemText";
            this.fxDescriptionOfItemText.Size = new System.Drawing.Size(345, 220);
            this.fxDescriptionOfItemText.TabIndex = 63;
            this.fxDescriptionOfItemText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Описание: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Характеристики: ";
            // 
            // fxTtxText
            // 
            this.fxTtxText.Location = new System.Drawing.Point(377, 376);
            this.fxTtxText.Name = "fxTtxText";
            this.fxTtxText.Size = new System.Drawing.Size(345, 222);
            this.fxTtxText.TabIndex = 65;
            this.fxTtxText.Text = "";
            // 
            // fxUseBtn
            // 
            this.fxUseBtn.Location = new System.Drawing.Point(377, 604);
            this.fxUseBtn.Name = "fxUseBtn";
            this.fxUseBtn.Size = new System.Drawing.Size(345, 29);
            this.fxUseBtn.TabIndex = 67;
            this.fxUseBtn.Text = "Использовать";
            this.fxUseBtn.UseVisualStyleBackColor = true;
            this.fxUseBtn.Click += new System.EventHandler(this.UseBtn);
            // 
            // fxDropBtn
            // 
            this.fxDropBtn.Location = new System.Drawing.Point(377, 639);
            this.fxDropBtn.Name = "fxDropBtn";
            this.fxDropBtn.Size = new System.Drawing.Size(345, 29);
            this.fxDropBtn.TabIndex = 68;
            this.fxDropBtn.Text = "Выбросить";
            this.fxDropBtn.UseVisualStyleBackColor = true;
            this.fxDropBtn.Click += new System.EventHandler(this.DropBtn);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(728, 749);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 86;
            this.label9.Text = "Вес:";
            // 
            // fxWeightLabel
            // 
            this.fxWeightLabel.AutoSize = true;
            this.fxWeightLabel.Location = new System.Drawing.Point(770, 749);
            this.fxWeightLabel.Name = "fxWeightLabel";
            this.fxWeightLabel.Size = new System.Drawing.Size(57, 20);
            this.fxWeightLabel.TabIndex = 87;
            this.fxWeightLabel.Text = "%Вес%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(882, 749);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "Максимальный вес:";
            // 
            // fxMaxWeightLabel
            // 
            this.fxMaxWeightLabel.AutoSize = true;
            this.fxMaxWeightLabel.Location = new System.Drawing.Point(1035, 749);
            this.fxMaxWeightLabel.Name = "fxMaxWeightLabel";
            this.fxMaxWeightLabel.Size = new System.Drawing.Size(57, 20);
            this.fxMaxWeightLabel.TabIndex = 89;
            this.fxMaxWeightLabel.Text = "%Вес%";
            // 
            // fxMoneyLabel
            // 
            this.fxMoneyLabel.AutoSize = true;
            this.fxMoneyLabel.Location = new System.Drawing.Point(165, 613);
            this.fxMoneyLabel.Name = "fxMoneyLabel";
            this.fxMoneyLabel.Size = new System.Drawing.Size(83, 20);
            this.fxMoneyLabel.TabIndex = 133;
            this.fxMoneyLabel.Text = "%Деньги%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Деньги:";
            // 
            // fxCurrentTimeLabel
            // 
            this.fxCurrentTimeLabel.AutoSize = true;
            this.fxCurrentTimeLabel.Location = new System.Drawing.Point(165, 588);
            this.fxCurrentTimeLabel.Name = "fxCurrentTimeLabel";
            this.fxCurrentTimeLabel.Size = new System.Drawing.Size(78, 20);
            this.fxCurrentTimeLabel.TabIndex = 131;
            this.fxCurrentTimeLabel.Text = "%Время%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 130;
            this.label6.Text = "Текущее время: ";
            // 
            // fxThirstLabel
            // 
            this.fxThirstLabel.AutoSize = true;
            this.fxThirstLabel.Location = new System.Drawing.Point(338, 664);
            this.fxThirstLabel.Name = "fxThirstLabel";
            this.fxThirstLabel.Size = new System.Drawing.Size(21, 20);
            this.fxThirstLabel.TabIndex = 129;
            this.fxThirstLabel.Text = "%";
            // 
            // fxThirstPB
            // 
            this.fxThirstPB.Location = new System.Drawing.Point(165, 664);
            this.fxThirstPB.Name = "fxThirstPB";
            this.fxThirstPB.Size = new System.Drawing.Size(167, 20);
            this.fxThirstPB.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 127;
            this.label7.Text = "Питьё:";
            // 
            // fxHungerLabel
            // 
            this.fxHungerLabel.AutoSize = true;
            this.fxHungerLabel.Location = new System.Drawing.Point(338, 689);
            this.fxHungerLabel.Name = "fxHungerLabel";
            this.fxHungerLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHungerLabel.TabIndex = 126;
            this.fxHungerLabel.Text = "%";
            // 
            // fxHungerPB
            // 
            this.fxHungerPB.Location = new System.Drawing.Point(165, 690);
            this.fxHungerPB.Name = "fxHungerPB";
            this.fxHungerPB.Size = new System.Drawing.Size(167, 19);
            this.fxHungerPB.TabIndex = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 689);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 124;
            this.label15.Text = "Сытость:";
            // 
            // fxSleepLabel
            // 
            this.fxSleepLabel.AutoSize = true;
            this.fxSleepLabel.Location = new System.Drawing.Point(338, 739);
            this.fxSleepLabel.Name = "fxSleepLabel";
            this.fxSleepLabel.Size = new System.Drawing.Size(21, 20);
            this.fxSleepLabel.TabIndex = 123;
            this.fxSleepLabel.Text = "%";
            // 
            // fxStaminaLabel
            // 
            this.fxStaminaLabel.AutoSize = true;
            this.fxStaminaLabel.Location = new System.Drawing.Point(338, 714);
            this.fxStaminaLabel.Name = "fxStaminaLabel";
            this.fxStaminaLabel.Size = new System.Drawing.Size(21, 20);
            this.fxStaminaLabel.TabIndex = 122;
            this.fxStaminaLabel.Text = "%";
            // 
            // fxHealthLabel
            // 
            this.fxHealthLabel.AutoSize = true;
            this.fxHealthLabel.Location = new System.Drawing.Point(338, 638);
            this.fxHealthLabel.Name = "fxHealthLabel";
            this.fxHealthLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHealthLabel.TabIndex = 121;
            this.fxHealthLabel.Text = "%";
            // 
            // fxSleepPB
            // 
            this.fxSleepPB.Location = new System.Drawing.Point(165, 740);
            this.fxSleepPB.Name = "fxSleepPB";
            this.fxSleepPB.Size = new System.Drawing.Size(167, 19);
            this.fxSleepPB.TabIndex = 120;
            // 
            // fxStaminaPB
            // 
            this.fxStaminaPB.Location = new System.Drawing.Point(165, 715);
            this.fxStaminaPB.Name = "fxStaminaPB";
            this.fxStaminaPB.Size = new System.Drawing.Size(167, 19);
            this.fxStaminaPB.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 715);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "Выносливость:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 740);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 117;
            this.label8.Text = "Потребность во сне:";
            // 
            // fxHealthPB
            // 
            this.fxHealthPB.Location = new System.Drawing.Point(165, 639);
            this.fxHealthPB.Name = "fxHealthPB";
            this.fxHealthPB.Size = new System.Drawing.Size(167, 19);
            this.fxHealthPB.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "Состояние здоровья:";
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 778);
            this.Controls.Add(this.fxMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fxCurrentTimeLabel);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fxHealthPB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fxMaxWeightLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fxWeightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fxDropBtn);
            this.Controls.Add(this.fxUseBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fxTtxText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fxDescriptionOfItemText);
            this.Controls.Add(this.fxNameOfItemLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fxInventoryDGV);
            this.Name = "InventoryWindow";
            this.Text = "HoboSimulator";
            this.Load += new System.EventHandler(this.InitializeForm);
            ((System.ComponentModel.ISupportInitialize)(this.fxInventoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView fxInventoryDGV;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fxNameOfItemLabel;
        public System.Windows.Forms.RichTextBox fxDescriptionOfItemText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox fxTtxText;
        public System.Windows.Forms.Button fxUseBtn;
        public System.Windows.Forms.Button fxDropBtn;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label fxWeightLabel;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label fxMaxWeightLabel;
        public System.Windows.Forms.Label fxMoneyLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label fxCurrentTimeLabel;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ProgressBar fxHealthPB;
        private System.Windows.Forms.Label label10;
    }
}