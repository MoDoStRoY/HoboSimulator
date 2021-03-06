
namespace HoboSimulator.Windows.Game
{
    partial class DialogWindow
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
            this.fxDialogDGW = new System.Windows.Forms.DataGridView();
            this.DialogueVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxNPCRelationLabel = new System.Windows.Forms.Label();
            this.fxNPCGroupLabel = new System.Windows.Forms.Label();
            this.fxNPCNameLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fxNPCIconPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fxMoneyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fxHealthPB = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.fxActorIconPB = new System.Windows.Forms.PictureBox();
            this.fxActorRelationLabel = new System.Windows.Forms.Label();
            this.fxActorGroupLabel = new System.Windows.Forms.Label();
            this.fxActorNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fxNPCAnswersText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fxDialogDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxNPCIconPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxActorIconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // fxDialogDGW
            // 
            this.fxDialogDGW.AllowUserToAddRows = false;
            this.fxDialogDGW.AllowUserToDeleteRows = false;
            this.fxDialogDGW.AllowUserToResizeColumns = false;
            this.fxDialogDGW.AllowUserToResizeRows = false;
            this.fxDialogDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fxDialogDGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.fxDialogDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxDialogDGW.ColumnHeadersVisible = false;
            this.fxDialogDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DialogueVariant});
            this.fxDialogDGW.Location = new System.Drawing.Point(390, 478);
            this.fxDialogDGW.MultiSelect = false;
            this.fxDialogDGW.Name = "fxDialogDGW";
            this.fxDialogDGW.ReadOnly = true;
            this.fxDialogDGW.RowHeadersWidth = 51;
            this.fxDialogDGW.RowTemplate.Height = 29;
            this.fxDialogDGW.Size = new System.Drawing.Size(898, 288);
            this.fxDialogDGW.TabIndex = 17;
            this.fxDialogDGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoseDialogVariantDGV);
            // 
            // DialogueVariant
            // 
            this.DialogueVariant.HeaderText = "DialogueVariant";
            this.DialogueVariant.MinimumWidth = 6;
            this.DialogueVariant.Name = "DialogueVariant";
            this.DialogueVariant.ReadOnly = true;
            // 
            // fxNPCRelationLabel
            // 
            this.fxNPCRelationLabel.AutoSize = true;
            this.fxNPCRelationLabel.Location = new System.Drawing.Point(715, 52);
            this.fxNPCRelationLabel.Name = "fxNPCRelationLabel";
            this.fxNPCRelationLabel.Size = new System.Drawing.Size(114, 20);
            this.fxNPCRelationLabel.TabIndex = 16;
            this.fxNPCRelationLabel.Text = "%Отношение%";
            // 
            // fxNPCGroupLabel
            // 
            this.fxNPCGroupLabel.AutoSize = true;
            this.fxNPCGroupLabel.Location = new System.Drawing.Point(715, 32);
            this.fxNPCGroupLabel.Name = "fxNPCGroupLabel";
            this.fxNPCGroupLabel.Size = new System.Drawing.Size(124, 20);
            this.fxNPCGroupLabel.TabIndex = 15;
            this.fxNPCGroupLabel.Text = "%Группировка%";
            // 
            // fxNPCNameLabel
            // 
            this.fxNPCNameLabel.AutoSize = true;
            this.fxNPCNameLabel.Location = new System.Drawing.Point(715, 12);
            this.fxNPCNameLabel.Name = "fxNPCNameLabel";
            this.fxNPCNameLabel.Size = new System.Drawing.Size(63, 20);
            this.fxNPCNameLabel.TabIndex = 14;
            this.fxNPCNameLabel.Text = "%Имя%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(606, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Отношение:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(606, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Группировка:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Имя:";
            // 
            // fxNPCIconPB
            // 
            this.fxNPCIconPB.Location = new System.Drawing.Point(390, 12);
            this.fxNPCIconPB.Name = "fxNPCIconPB";
            this.fxNPCIconPB.Size = new System.Drawing.Size(210, 210);
            this.fxNPCIconPB.TabIndex = 10;
            this.fxNPCIconPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 29);
            this.button1.TabIndex = 59;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // fxMoneyLabel
            // 
            this.fxMoneyLabel.AutoSize = true;
            this.fxMoneyLabel.Location = new System.Drawing.Point(167, 619);
            this.fxMoneyLabel.Name = "fxMoneyLabel";
            this.fxMoneyLabel.Size = new System.Drawing.Size(83, 20);
            this.fxMoneyLabel.TabIndex = 114;
            this.fxMoneyLabel.Text = "%Деньги%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Деньги:";
            // 
            // fxCurrentTimeLabel
            // 
            this.fxCurrentTimeLabel.AutoSize = true;
            this.fxCurrentTimeLabel.Location = new System.Drawing.Point(167, 594);
            this.fxCurrentTimeLabel.Name = "fxCurrentTimeLabel";
            this.fxCurrentTimeLabel.Size = new System.Drawing.Size(78, 20);
            this.fxCurrentTimeLabel.TabIndex = 112;
            this.fxCurrentTimeLabel.Text = "%Время%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Текущее время: ";
            // 
            // fxThirstLabel
            // 
            this.fxThirstLabel.AutoSize = true;
            this.fxThirstLabel.Location = new System.Drawing.Point(340, 670);
            this.fxThirstLabel.Name = "fxThirstLabel";
            this.fxThirstLabel.Size = new System.Drawing.Size(21, 20);
            this.fxThirstLabel.TabIndex = 110;
            this.fxThirstLabel.Text = "%";
            // 
            // fxThirstPB
            // 
            this.fxThirstPB.Location = new System.Drawing.Point(167, 670);
            this.fxThirstPB.Name = "fxThirstPB";
            this.fxThirstPB.Size = new System.Drawing.Size(167, 20);
            this.fxThirstPB.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 670);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 108;
            this.label7.Text = "Питьё:";
            // 
            // fxHungerLabel
            // 
            this.fxHungerLabel.AutoSize = true;
            this.fxHungerLabel.Location = new System.Drawing.Point(340, 695);
            this.fxHungerLabel.Name = "fxHungerLabel";
            this.fxHungerLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHungerLabel.TabIndex = 107;
            this.fxHungerLabel.Text = "%";
            // 
            // fxHungerPB
            // 
            this.fxHungerPB.Location = new System.Drawing.Point(167, 696);
            this.fxHungerPB.Name = "fxHungerPB";
            this.fxHungerPB.Size = new System.Drawing.Size(167, 19);
            this.fxHungerPB.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 695);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 105;
            this.label15.Text = "Сытость:";
            // 
            // fxSleepLabel
            // 
            this.fxSleepLabel.AutoSize = true;
            this.fxSleepLabel.Location = new System.Drawing.Point(340, 745);
            this.fxSleepLabel.Name = "fxSleepLabel";
            this.fxSleepLabel.Size = new System.Drawing.Size(21, 20);
            this.fxSleepLabel.TabIndex = 104;
            this.fxSleepLabel.Text = "%";
            // 
            // fxStaminaLabel
            // 
            this.fxStaminaLabel.AutoSize = true;
            this.fxStaminaLabel.Location = new System.Drawing.Point(340, 720);
            this.fxStaminaLabel.Name = "fxStaminaLabel";
            this.fxStaminaLabel.Size = new System.Drawing.Size(21, 20);
            this.fxStaminaLabel.TabIndex = 103;
            this.fxStaminaLabel.Text = "%";
            // 
            // fxHealthLabel
            // 
            this.fxHealthLabel.AutoSize = true;
            this.fxHealthLabel.Location = new System.Drawing.Point(340, 644);
            this.fxHealthLabel.Name = "fxHealthLabel";
            this.fxHealthLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHealthLabel.TabIndex = 102;
            this.fxHealthLabel.Text = "%";
            // 
            // fxSleepPB
            // 
            this.fxSleepPB.Location = new System.Drawing.Point(167, 746);
            this.fxSleepPB.Name = "fxSleepPB";
            this.fxSleepPB.Size = new System.Drawing.Size(167, 19);
            this.fxSleepPB.TabIndex = 101;
            // 
            // fxStaminaPB
            // 
            this.fxStaminaPB.Location = new System.Drawing.Point(167, 721);
            this.fxStaminaPB.Name = "fxStaminaPB";
            this.fxStaminaPB.Size = new System.Drawing.Size(167, 19);
            this.fxStaminaPB.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Выносливость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 746);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Потребность во сне:";
            // 
            // fxHealthPB
            // 
            this.fxHealthPB.Location = new System.Drawing.Point(167, 645);
            this.fxHealthPB.Name = "fxHealthPB";
            this.fxHealthPB.Size = new System.Drawing.Size(167, 19);
            this.fxHealthPB.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Состояние здоровья:";
            // 
            // fxActorIconPB
            // 
            this.fxActorIconPB.Location = new System.Drawing.Point(1078, 12);
            this.fxActorIconPB.Name = "fxActorIconPB";
            this.fxActorIconPB.Size = new System.Drawing.Size(210, 210);
            this.fxActorIconPB.TabIndex = 115;
            this.fxActorIconPB.TabStop = false;
            // 
            // fxActorRelationLabel
            // 
            this.fxActorRelationLabel.AutoSize = true;
            this.fxActorRelationLabel.Location = new System.Drawing.Point(949, 202);
            this.fxActorRelationLabel.Name = "fxActorRelationLabel";
            this.fxActorRelationLabel.Size = new System.Drawing.Size(114, 20);
            this.fxActorRelationLabel.TabIndex = 121;
            this.fxActorRelationLabel.Text = "%Отношение%";
            // 
            // fxActorGroupLabel
            // 
            this.fxActorGroupLabel.AutoSize = true;
            this.fxActorGroupLabel.Location = new System.Drawing.Point(949, 182);
            this.fxActorGroupLabel.Name = "fxActorGroupLabel";
            this.fxActorGroupLabel.Size = new System.Drawing.Size(124, 20);
            this.fxActorGroupLabel.TabIndex = 120;
            this.fxActorGroupLabel.Text = "%Группировка%";
            // 
            // fxActorNameLabel
            // 
            this.fxActorNameLabel.AutoSize = true;
            this.fxActorNameLabel.Location = new System.Drawing.Point(949, 162);
            this.fxActorNameLabel.Name = "fxActorNameLabel";
            this.fxActorNameLabel.Size = new System.Drawing.Size(63, 20);
            this.fxActorNameLabel.TabIndex = 119;
            this.fxActorNameLabel.Text = "%Имя%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(840, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 118;
            this.label10.Text = "Отношение:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(840, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 117;
            this.label12.Text = "Группировка:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(840, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 116;
            this.label16.Text = "Имя:";
            // 
            // fxNPCAnswersText
            // 
            this.fxNPCAnswersText.Location = new System.Drawing.Point(390, 229);
            this.fxNPCAnswersText.Name = "fxNPCAnswersText";
            this.fxNPCAnswersText.ReadOnly = true;
            this.fxNPCAnswersText.Size = new System.Drawing.Size(898, 243);
            this.fxNPCAnswersText.TabIndex = 122;
            this.fxNPCAnswersText.Text = "";
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 778);
            this.Controls.Add(this.fxNPCAnswersText);
            this.Controls.Add(this.fxActorRelationLabel);
            this.Controls.Add(this.fxActorGroupLabel);
            this.Controls.Add(this.fxActorNameLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fxActorIconPB);
            this.Controls.Add(this.fxMoneyLabel);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fxHealthPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fxDialogDGW);
            this.Controls.Add(this.fxNPCRelationLabel);
            this.Controls.Add(this.fxNPCGroupLabel);
            this.Controls.Add(this.fxNPCNameLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fxNPCIconPB);
            this.Name = "DialogWindow";
            this.Text = "HoboSimulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            ((System.ComponentModel.ISupportInitialize)(this.fxDialogDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxNPCIconPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxActorIconPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView fxDialogDGW;
        public System.Windows.Forms.DataGridViewTextBoxColumn DialogueVariant;
        public System.Windows.Forms.Label fxNPCRelationLabel;
        public System.Windows.Forms.Label fxNPCGroupLabel;
        public System.Windows.Forms.Label fxNPCNameLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox fxNPCIconPB;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label fxMoneyLabel;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar fxHealthPB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox fxActorIconPB;
        public System.Windows.Forms.Label fxActorRelationLabel;
        public System.Windows.Forms.Label fxActorGroupLabel;
        public System.Windows.Forms.Label fxActorNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.RichTextBox fxNPCAnswersText;
    }
}