
namespace HoboSimulator.Windows.Game.MainGame
{
    partial class MainGameWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fxNameOfActor = new System.Windows.Forms.Label();
            this.fxAgeOfActor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fxThirstLabel = new System.Windows.Forms.Label();
            this.fxThirstPB = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.fxHungerLabel = new System.Windows.Forms.Label();
            this.fxHungerPB = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fxSkillPointsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fxSkillsDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxBiography = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fxSleepLabel = new System.Windows.Forms.Label();
            this.fxStaminaLabel = new System.Windows.Forms.Label();
            this.fxHealthLabel = new System.Windows.Forms.Label();
            this.fxSleepPB = new System.Windows.Forms.ProgressBar();
            this.fxStaminaPB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fxHealthPB = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxSkillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Действия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ActionBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Перемещения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MovingBtn);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 737);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Меню";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MenuBtn);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HoboSimulator.Properties.Resources.HoboIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 190);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя:";
            // 
            // fxNameOfActor
            // 
            this.fxNameOfActor.AutoSize = true;
            this.fxNameOfActor.Location = new System.Drawing.Point(236, 7);
            this.fxNameOfActor.Name = "fxNameOfActor";
            this.fxNameOfActor.Size = new System.Drawing.Size(63, 20);
            this.fxNameOfActor.TabIndex = 5;
            this.fxNameOfActor.Text = "%Имя%";
            // 
            // fxAgeOfActor
            // 
            this.fxAgeOfActor.AutoSize = true;
            this.fxAgeOfActor.Location = new System.Drawing.Point(261, 27);
            this.fxAgeOfActor.Name = "fxAgeOfActor";
            this.fxAgeOfActor.Size = new System.Drawing.Size(63, 20);
            this.fxAgeOfActor.TabIndex = 7;
            this.fxAgeOfActor.Text = "%Имя%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Состояние здоровья:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Местоположение:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(279, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 753);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.fxThirstLabel);
            this.tabPage1.Controls.Add(this.fxThirstPB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.fxHungerLabel);
            this.tabPage1.Controls.Add(this.fxHungerPB);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.fxSkillPointsLabel);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.fxSkillsDGV);
            this.tabPage1.Controls.Add(this.fxBiography);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.fxSleepLabel);
            this.tabPage1.Controls.Add(this.fxStaminaLabel);
            this.tabPage1.Controls.Add(this.fxHealthLabel);
            this.tabPage1.Controls.Add(this.fxSleepPB);
            this.tabPage1.Controls.Add(this.fxStaminaPB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.fxHealthPB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.fxAgeOfActor);
            this.tabPage1.Controls.Add(this.fxNameOfActor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fxThirstLabel
            // 
            this.fxThirstLabel.AutoSize = true;
            this.fxThirstLabel.Location = new System.Drawing.Point(524, 87);
            this.fxThirstLabel.Name = "fxThirstLabel";
            this.fxThirstLabel.Size = new System.Drawing.Size(21, 20);
            this.fxThirstLabel.TabIndex = 42;
            this.fxThirstLabel.Text = "%";
            // 
            // fxThirstPB
            // 
            this.fxThirstPB.Location = new System.Drawing.Point(351, 87);
            this.fxThirstPB.Name = "fxThirstPB";
            this.fxThirstPB.Size = new System.Drawing.Size(167, 20);
            this.fxThirstPB.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Питьё:";
            // 
            // fxHungerLabel
            // 
            this.fxHungerLabel.AutoSize = true;
            this.fxHungerLabel.Location = new System.Drawing.Point(524, 110);
            this.fxHungerLabel.Name = "fxHungerLabel";
            this.fxHungerLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHungerLabel.TabIndex = 37;
            this.fxHungerLabel.Text = "%";
            // 
            // fxHungerPB
            // 
            this.fxHungerPB.Location = new System.Drawing.Point(351, 111);
            this.fxHungerPB.Name = "fxHungerPB";
            this.fxHungerPB.Size = new System.Drawing.Size(167, 19);
            this.fxHungerPB.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Сытость:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "%местоположение%";
            // 
            // fxSkillPointsLabel
            // 
            this.fxSkillPointsLabel.AutoSize = true;
            this.fxSkillPointsLabel.Location = new System.Drawing.Point(715, 381);
            this.fxSkillPointsLabel.Name = "fxSkillPointsLabel";
            this.fxSkillPointsLabel.Size = new System.Drawing.Size(112, 20);
            this.fxSkillPointsLabel.TabIndex = 33;
            this.fxSkillPointsLabel.Text = "%количество%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Очки навыков:";
            // 
            // fxSkillsDGV
            // 
            this.fxSkillsDGV.AllowUserToAddRows = false;
            this.fxSkillsDGV.AllowUserToDeleteRows = false;
            this.fxSkillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fxSkillsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.fxSkillsDGV.Location = new System.Drawing.Point(599, 27);
            this.fxSkillsDGV.Name = "fxSkillsDGV";
            this.fxSkillsDGV.ReadOnly = true;
            this.fxSkillsDGV.RowHeadersVisible = false;
            this.fxSkillsDGV.RowHeadersWidth = 51;
            this.fxSkillsDGV.RowTemplate.Height = 29;
            this.fxSkillsDGV.Size = new System.Drawing.Size(289, 351);
            this.fxSkillsDGV.TabIndex = 21;
            this.fxSkillsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SkillUpCell);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Навык:";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 205;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Уровень:";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // fxBiography
            // 
            this.fxBiography.Location = new System.Drawing.Point(4, 241);
            this.fxBiography.Name = "fxBiography";
            this.fxBiography.Size = new System.Drawing.Size(541, 143);
            this.fxBiography.TabIndex = 19;
            this.fxBiography.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Биография:";
            // 
            // fxSleepLabel
            // 
            this.fxSleepLabel.AutoSize = true;
            this.fxSleepLabel.Location = new System.Drawing.Point(524, 161);
            this.fxSleepLabel.Name = "fxSleepLabel";
            this.fxSleepLabel.Size = new System.Drawing.Size(21, 20);
            this.fxSleepLabel.TabIndex = 17;
            this.fxSleepLabel.Text = "%";
            // 
            // fxStaminaLabel
            // 
            this.fxStaminaLabel.AutoSize = true;
            this.fxStaminaLabel.Location = new System.Drawing.Point(524, 135);
            this.fxStaminaLabel.Name = "fxStaminaLabel";
            this.fxStaminaLabel.Size = new System.Drawing.Size(21, 20);
            this.fxStaminaLabel.TabIndex = 16;
            this.fxStaminaLabel.Text = "%";
            // 
            // fxHealthLabel
            // 
            this.fxHealthLabel.AutoSize = true;
            this.fxHealthLabel.Location = new System.Drawing.Point(524, 61);
            this.fxHealthLabel.Name = "fxHealthLabel";
            this.fxHealthLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHealthLabel.TabIndex = 15;
            this.fxHealthLabel.Text = "%";
            // 
            // fxSleepPB
            // 
            this.fxSleepPB.Location = new System.Drawing.Point(351, 161);
            this.fxSleepPB.Name = "fxSleepPB";
            this.fxSleepPB.Size = new System.Drawing.Size(167, 19);
            this.fxSleepPB.TabIndex = 14;
            // 
            // fxStaminaPB
            // 
            this.fxStaminaPB.Location = new System.Drawing.Point(351, 136);
            this.fxStaminaPB.Name = "fxStaminaPB";
            this.fxStaminaPB.Size = new System.Drawing.Size(167, 19);
            this.fxStaminaPB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выносливость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Потребность во сне:";
            // 
            // fxHealthPB
            // 
            this.fxHealthPB.Location = new System.Drawing.Point(351, 62);
            this.fxHealthPB.Name = "fxHealthPB";
            this.fxHealthPB.Size = new System.Drawing.Size(167, 19);
            this.fxHealthPB.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Инвентарь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.InventoryBtn);
            // 
            // MainGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 778);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainGameWindow";
            this.Text = "HoboSimulator";
            this.Load += new System.EventHandler(this.InitializeForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxSkillsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fxNameOfActor;
        public System.Windows.Forms.Label fxAgeOfActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.RichTextBox fxBiography;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label fxSleepLabel;
        public System.Windows.Forms.Label fxStaminaLabel;
        public System.Windows.Forms.Label fxHealthLabel;
        public System.Windows.Forms.ProgressBar fxSleepPB;
        public System.Windows.Forms.ProgressBar fxStaminaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar fxHealthPB;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label fxHungerLabel;
        public System.Windows.Forms.ProgressBar fxHungerPB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label fxSkillPointsLabel;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView fxSkillsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Label fxThirstLabel;
        public System.Windows.Forms.ProgressBar fxThirstPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}