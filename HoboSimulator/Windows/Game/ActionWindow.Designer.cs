
namespace HoboSimulator.Windows.Game.Action
{
    partial class ActionWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.fxMainTP = new System.Windows.Forms.TabControl();
            this.ActionTP = new System.Windows.Forms.TabPage();
            this.fxActionsTP = new System.Windows.Forms.TabControl();
            this.City_DistrictsTP = new System.Windows.Forms.TabPage();
            this.fxLookAroundBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.fxLootAbaddonedHousesBtn = new System.Windows.Forms.Button();
            this.fxLootTrashCanSmallBtn = new System.Windows.Forms.Button();
            this.fxLootTrashCanBigBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fxHuntCatBtn = new System.Windows.Forms.Button();
            this.fxHuntBirdBtn = new System.Windows.Forms.Button();
            this.fxHuntDogBtn = new System.Windows.Forms.Button();
            this.City_FoodStoreTP = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.fxDescriptionOfZoneText = new System.Windows.Forms.RichTextBox();
            this.fxNameOfZoneLabel = new System.Windows.Forms.Label();
            this.fxZoneIconPB = new System.Windows.Forms.PictureBox();
            this.FightTP = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.fxResultOfAction = new System.Windows.Forms.RichTextBox();
            this.fxHuntBirdTT = new System.Windows.Forms.ToolTip(this.components);
            this.fxHuntDogTT = new System.Windows.Forms.ToolTip(this.components);
            this.fxHuntCatTT = new System.Windows.Forms.ToolTip(this.components);
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fxHealthPB = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.fxMainTP.SuspendLayout();
            this.ActionTP.SuspendLayout();
            this.fxActionsTP.SuspendLayout();
            this.City_DistrictsTP.SuspendLayout();
            this.City_FoodStoreTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxZoneIconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 29);
            this.button1.TabIndex = 58;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackBtn);
            // 
            // fxMainTP
            // 
            this.fxMainTP.Controls.Add(this.ActionTP);
            this.fxMainTP.Controls.Add(this.FightTP);
            this.fxMainTP.ItemSize = new System.Drawing.Size(20, 10);
            this.fxMainTP.Location = new System.Drawing.Point(375, 13);
            this.fxMainTP.Name = "fxMainTP";
            this.fxMainTP.SelectedIndex = 0;
            this.fxMainTP.Size = new System.Drawing.Size(913, 752);
            this.fxMainTP.TabIndex = 59;
            // 
            // ActionTP
            // 
            this.ActionTP.Controls.Add(this.fxActionsTP);
            this.ActionTP.Controls.Add(this.fxDescriptionOfZoneText);
            this.ActionTP.Controls.Add(this.fxNameOfZoneLabel);
            this.ActionTP.Controls.Add(this.fxZoneIconPB);
            this.ActionTP.Location = new System.Drawing.Point(4, 14);
            this.ActionTP.Name = "ActionTP";
            this.ActionTP.Padding = new System.Windows.Forms.Padding(3);
            this.ActionTP.Size = new System.Drawing.Size(905, 734);
            this.ActionTP.TabIndex = 0;
            this.ActionTP.Text = "ActionTP";
            this.ActionTP.UseVisualStyleBackColor = true;
            // 
            // fxActionsTP
            // 
            this.fxActionsTP.Controls.Add(this.City_DistrictsTP);
            this.fxActionsTP.Controls.Add(this.City_FoodStoreTP);
            this.fxActionsTP.ItemSize = new System.Drawing.Size(20, 10);
            this.fxActionsTP.Location = new System.Drawing.Point(4, 402);
            this.fxActionsTP.Name = "fxActionsTP";
            this.fxActionsTP.SelectedIndex = 0;
            this.fxActionsTP.Size = new System.Drawing.Size(898, 314);
            this.fxActionsTP.TabIndex = 6;
            // 
            // City_DistrictsTP
            // 
            this.City_DistrictsTP.Controls.Add(this.fxLookAroundBtn);
            this.City_DistrictsTP.Controls.Add(this.label9);
            this.City_DistrictsTP.Controls.Add(this.fxLootAbaddonedHousesBtn);
            this.City_DistrictsTP.Controls.Add(this.fxLootTrashCanSmallBtn);
            this.City_DistrictsTP.Controls.Add(this.fxLootTrashCanBigBtn);
            this.City_DistrictsTP.Controls.Add(this.label8);
            this.City_DistrictsTP.Controls.Add(this.label1);
            this.City_DistrictsTP.Controls.Add(this.fxHuntCatBtn);
            this.City_DistrictsTP.Controls.Add(this.fxHuntBirdBtn);
            this.City_DistrictsTP.Controls.Add(this.fxHuntDogBtn);
            this.City_DistrictsTP.Location = new System.Drawing.Point(4, 14);
            this.City_DistrictsTP.Name = "City_DistrictsTP";
            this.City_DistrictsTP.Padding = new System.Windows.Forms.Padding(3);
            this.City_DistrictsTP.Size = new System.Drawing.Size(890, 296);
            this.City_DistrictsTP.TabIndex = 0;
            this.City_DistrictsTP.Text = "City_DistrictsTP";
            this.City_DistrictsTP.UseVisualStyleBackColor = true;
            // 
            // fxLookAroundBtn
            // 
            this.fxLookAroundBtn.Location = new System.Drawing.Point(237, 23);
            this.fxLookAroundBtn.Name = "fxLookAroundBtn";
            this.fxLookAroundBtn.Size = new System.Drawing.Size(227, 29);
            this.fxLookAroundBtn.TabIndex = 12;
            this.fxLookAroundBtn.Text = "Осмотреться";
            this.fxLookAroundBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Разведка:";
            // 
            // fxLootAbaddonedHousesBtn
            // 
            this.fxLootAbaddonedHousesBtn.Location = new System.Drawing.Point(4, 224);
            this.fxLootAbaddonedHousesBtn.Name = "fxLootAbaddonedHousesBtn";
            this.fxLootAbaddonedHousesBtn.Size = new System.Drawing.Size(227, 29);
            this.fxLootAbaddonedHousesBtn.TabIndex = 10;
            this.fxLootAbaddonedHousesBtn.Text = "Заброшенные строения";
            this.fxLootAbaddonedHousesBtn.UseVisualStyleBackColor = true;
            // 
            // fxLootTrashCanSmallBtn
            // 
            this.fxLootTrashCanSmallBtn.Location = new System.Drawing.Point(4, 189);
            this.fxLootTrashCanSmallBtn.Name = "fxLootTrashCanSmallBtn";
            this.fxLootTrashCanSmallBtn.Size = new System.Drawing.Size(227, 29);
            this.fxLootTrashCanSmallBtn.TabIndex = 9;
            this.fxLootTrashCanSmallBtn.Text = "Урны на улицах";
            this.fxLootTrashCanSmallBtn.UseVisualStyleBackColor = true;
            // 
            // fxLootTrashCanBigBtn
            // 
            this.fxLootTrashCanBigBtn.Location = new System.Drawing.Point(4, 153);
            this.fxLootTrashCanBigBtn.Name = "fxLootTrashCanBigBtn";
            this.fxLootTrashCanBigBtn.Size = new System.Drawing.Size(227, 29);
            this.fxLootTrashCanBigBtn.TabIndex = 8;
            this.fxLootTrashCanBigBtn.Text = "Мусорные баки";
            this.fxLootTrashCanBigBtn.UseVisualStyleBackColor = true;
            this.fxLootTrashCanBigBtn.Click += new System.EventHandler(this.LootTrashCanBigBtn);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Лутать:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Охота:";
            // 
            // fxHuntCatBtn
            // 
            this.fxHuntCatBtn.Location = new System.Drawing.Point(3, 93);
            this.fxHuntCatBtn.Name = "fxHuntCatBtn";
            this.fxHuntCatBtn.Size = new System.Drawing.Size(228, 29);
            this.fxHuntCatBtn.TabIndex = 5;
            this.fxHuntCatBtn.Text = "На кошку";
            this.fxHuntCatBtn.UseVisualStyleBackColor = true;
            // 
            // fxHuntBirdBtn
            // 
            this.fxHuntBirdBtn.Location = new System.Drawing.Point(3, 23);
            this.fxHuntBirdBtn.Name = "fxHuntBirdBtn";
            this.fxHuntBirdBtn.Size = new System.Drawing.Size(228, 29);
            this.fxHuntBirdBtn.TabIndex = 3;
            this.fxHuntBirdBtn.Text = "На голубя";
            this.fxHuntBirdBtn.UseVisualStyleBackColor = true;
            this.fxHuntBirdBtn.Click += new System.EventHandler(this.HuntBirdBtn);
            // 
            // fxHuntDogBtn
            // 
            this.fxHuntDogBtn.Location = new System.Drawing.Point(3, 58);
            this.fxHuntDogBtn.Name = "fxHuntDogBtn";
            this.fxHuntDogBtn.Size = new System.Drawing.Size(228, 29);
            this.fxHuntDogBtn.TabIndex = 4;
            this.fxHuntDogBtn.Text = "На собаку";
            this.fxHuntDogBtn.UseVisualStyleBackColor = true;
            // 
            // City_FoodStoreTP
            // 
            this.City_FoodStoreTP.Controls.Add(this.button12);
            this.City_FoodStoreTP.Controls.Add(this.button11);
            this.City_FoodStoreTP.Controls.Add(this.button10);
            this.City_FoodStoreTP.Controls.Add(this.label18);
            this.City_FoodStoreTP.Controls.Add(this.button9);
            this.City_FoodStoreTP.Controls.Add(this.button8);
            this.City_FoodStoreTP.Controls.Add(this.button7);
            this.City_FoodStoreTP.Controls.Add(this.button6);
            this.City_FoodStoreTP.Controls.Add(this.label17);
            this.City_FoodStoreTP.Controls.Add(this.button5);
            this.City_FoodStoreTP.Controls.Add(this.label16);
            this.City_FoodStoreTP.Controls.Add(this.button4);
            this.City_FoodStoreTP.Controls.Add(this.button3);
            this.City_FoodStoreTP.Controls.Add(this.button2);
            this.City_FoodStoreTP.Controls.Add(this.label10);
            this.City_FoodStoreTP.Location = new System.Drawing.Point(4, 14);
            this.City_FoodStoreTP.Name = "City_FoodStoreTP";
            this.City_FoodStoreTP.Padding = new System.Windows.Forms.Padding(3);
            this.City_FoodStoreTP.Size = new System.Drawing.Size(890, 296);
            this.City_FoodStoreTP.TabIndex = 1;
            this.City_FoodStoreTP.Text = "City_FoodStoreTP";
            this.City_FoodStoreTP.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(237, 170);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(227, 29);
            this.button11.TabIndex = 13;
            this.button11.Text = "Диалог с Галей";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.TestDialogBtn);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(4, 213);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(227, 29);
            this.button10.TabIndex = 12;
            this.button10.Text = "Покупки";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.TradeBtn);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 20);
            this.label18.TabIndex = 11;
            this.label18.Text = "Торговля:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(237, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(227, 29);
            this.button9.TabIndex = 10;
            this.button9.Text = "Помочиться посреди зала";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(237, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(227, 29);
            this.button8.TabIndex = 9;
            this.button8.Text = "Наложить кучу посреди зала";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(237, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(227, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Проповедь о конце света";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(237, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "Просить милостыню";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Социальное:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Товары в зале";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Воровство:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ячейки для хранения вещей";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ячейки для хранения вещей";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Мусорные урны";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Лутать:";
            // 
            // fxDescriptionOfZoneText
            // 
            this.fxDescriptionOfZoneText.Location = new System.Drawing.Point(4, 281);
            this.fxDescriptionOfZoneText.Name = "fxDescriptionOfZoneText";
            this.fxDescriptionOfZoneText.ReadOnly = true;
            this.fxDescriptionOfZoneText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.fxDescriptionOfZoneText.Size = new System.Drawing.Size(898, 115);
            this.fxDescriptionOfZoneText.TabIndex = 2;
            this.fxDescriptionOfZoneText.Text = "%Описание зоны%";
            // 
            // fxNameOfZoneLabel
            // 
            this.fxNameOfZoneLabel.AutoSize = true;
            this.fxNameOfZoneLabel.Location = new System.Drawing.Point(4, 257);
            this.fxNameOfZoneLabel.Name = "fxNameOfZoneLabel";
            this.fxNameOfZoneLabel.Size = new System.Drawing.Size(141, 20);
            this.fxNameOfZoneLabel.TabIndex = 1;
            this.fxNameOfZoneLabel.Text = "%Название зоны%";
            // 
            // fxZoneIconPB
            // 
            this.fxZoneIconPB.Location = new System.Drawing.Point(4, 4);
            this.fxZoneIconPB.Name = "fxZoneIconPB";
            this.fxZoneIconPB.Size = new System.Drawing.Size(898, 246);
            this.fxZoneIconPB.TabIndex = 0;
            this.fxZoneIconPB.TabStop = false;
            // 
            // FightTP
            // 
            this.FightTP.Location = new System.Drawing.Point(4, 14);
            this.FightTP.Name = "FightTP";
            this.FightTP.Padding = new System.Windows.Forms.Padding(3);
            this.FightTP.Size = new System.Drawing.Size(905, 734);
            this.FightTP.TabIndex = 2;
            this.FightTP.Text = "FightTP";
            this.FightTP.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Результат действия:";
            // 
            // fxResultOfAction
            // 
            this.fxResultOfAction.Location = new System.Drawing.Point(10, 271);
            this.fxResultOfAction.Name = "fxResultOfAction";
            this.fxResultOfAction.ReadOnly = true;
            this.fxResultOfAction.Size = new System.Drawing.Size(358, 316);
            this.fxResultOfAction.TabIndex = 61;
            this.fxResultOfAction.Text = "";
            // 
            // fxHuntBirdTT
            // 
            this.fxHuntBirdTT.ToolTipTitle = "Охота на голубей";
            // 
            // fxHuntDogTT
            // 
            this.fxHuntDogTT.ToolTipTitle = "Охота на собак";
            // 
            // fxHuntCatTT
            // 
            this.fxHuntCatTT.ToolTipTitle = "Охота на котов";
            // 
            // fxMoneyLabel
            // 
            this.fxMoneyLabel.AutoSize = true;
            this.fxMoneyLabel.Location = new System.Drawing.Point(164, 617);
            this.fxMoneyLabel.Name = "fxMoneyLabel";
            this.fxMoneyLabel.Size = new System.Drawing.Size(83, 20);
            this.fxMoneyLabel.TabIndex = 133;
            this.fxMoneyLabel.Text = "%Деньги%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Деньги:";
            // 
            // fxCurrentTimeLabel
            // 
            this.fxCurrentTimeLabel.AutoSize = true;
            this.fxCurrentTimeLabel.Location = new System.Drawing.Point(164, 592);
            this.fxCurrentTimeLabel.Name = "fxCurrentTimeLabel";
            this.fxCurrentTimeLabel.Size = new System.Drawing.Size(78, 20);
            this.fxCurrentTimeLabel.TabIndex = 131;
            this.fxCurrentTimeLabel.Text = "%Время%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 130;
            this.label6.Text = "Текущее время: ";
            // 
            // fxThirstLabel
            // 
            this.fxThirstLabel.AutoSize = true;
            this.fxThirstLabel.Location = new System.Drawing.Point(337, 668);
            this.fxThirstLabel.Name = "fxThirstLabel";
            this.fxThirstLabel.Size = new System.Drawing.Size(21, 20);
            this.fxThirstLabel.TabIndex = 129;
            this.fxThirstLabel.Text = "%";
            // 
            // fxThirstPB
            // 
            this.fxThirstPB.Location = new System.Drawing.Point(164, 668);
            this.fxThirstPB.Name = "fxThirstPB";
            this.fxThirstPB.Size = new System.Drawing.Size(167, 20);
            this.fxThirstPB.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 127;
            this.label7.Text = "Питьё:";
            // 
            // fxHungerLabel
            // 
            this.fxHungerLabel.AutoSize = true;
            this.fxHungerLabel.Location = new System.Drawing.Point(337, 693);
            this.fxHungerLabel.Name = "fxHungerLabel";
            this.fxHungerLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHungerLabel.TabIndex = 126;
            this.fxHungerLabel.Text = "%";
            // 
            // fxHungerPB
            // 
            this.fxHungerPB.Location = new System.Drawing.Point(164, 694);
            this.fxHungerPB.Name = "fxHungerPB";
            this.fxHungerPB.Size = new System.Drawing.Size(167, 19);
            this.fxHungerPB.TabIndex = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 693);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 124;
            this.label15.Text = "Сытость:";
            // 
            // fxSleepLabel
            // 
            this.fxSleepLabel.AutoSize = true;
            this.fxSleepLabel.Location = new System.Drawing.Point(337, 743);
            this.fxSleepLabel.Name = "fxSleepLabel";
            this.fxSleepLabel.Size = new System.Drawing.Size(21, 20);
            this.fxSleepLabel.TabIndex = 123;
            this.fxSleepLabel.Text = "%";
            // 
            // fxStaminaLabel
            // 
            this.fxStaminaLabel.AutoSize = true;
            this.fxStaminaLabel.Location = new System.Drawing.Point(337, 718);
            this.fxStaminaLabel.Name = "fxStaminaLabel";
            this.fxStaminaLabel.Size = new System.Drawing.Size(21, 20);
            this.fxStaminaLabel.TabIndex = 122;
            this.fxStaminaLabel.Text = "%";
            // 
            // fxHealthLabel
            // 
            this.fxHealthLabel.AutoSize = true;
            this.fxHealthLabel.Location = new System.Drawing.Point(337, 642);
            this.fxHealthLabel.Name = "fxHealthLabel";
            this.fxHealthLabel.Size = new System.Drawing.Size(21, 20);
            this.fxHealthLabel.TabIndex = 121;
            this.fxHealthLabel.Text = "%";
            // 
            // fxSleepPB
            // 
            this.fxSleepPB.Location = new System.Drawing.Point(164, 744);
            this.fxSleepPB.Name = "fxSleepPB";
            this.fxSleepPB.Size = new System.Drawing.Size(167, 19);
            this.fxSleepPB.TabIndex = 120;
            // 
            // fxStaminaPB
            // 
            this.fxStaminaPB.Location = new System.Drawing.Point(164, 719);
            this.fxStaminaPB.Name = "fxStaminaPB";
            this.fxStaminaPB.Size = new System.Drawing.Size(167, 19);
            this.fxStaminaPB.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "Выносливость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 744);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "Потребность во сне:";
            // 
            // fxHealthPB
            // 
            this.fxHealthPB.Location = new System.Drawing.Point(164, 643);
            this.fxHealthPB.Name = "fxHealthPB";
            this.fxHealthPB.Size = new System.Drawing.Size(167, 19);
            this.fxHealthPB.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 115;
            this.label12.Text = "Состояние здоровья:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(237, 205);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(227, 29);
            this.button12.TabIndex = 14;
            this.button12.Text = "Сражение с Галей";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.TestFightBtn);
            // 
            // ActionWindow
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fxHealthPB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fxResultOfAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fxMainTP);
            this.Controls.Add(this.button1);
            this.Name = "ActionWindow";
            this.Text = "HoboSimulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            this.Load += new System.EventHandler(this.InitializeForm);
            this.fxMainTP.ResumeLayout(false);
            this.ActionTP.ResumeLayout(false);
            this.ActionTP.PerformLayout();
            this.fxActionsTP.ResumeLayout(false);
            this.City_DistrictsTP.ResumeLayout(false);
            this.City_DistrictsTP.PerformLayout();
            this.City_FoodStoreTP.ResumeLayout(false);
            this.City_FoodStoreTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxZoneIconPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TabControl fxMainTP;
        public System.Windows.Forms.TabPage ActionTP;
        public System.Windows.Forms.PictureBox fxZoneIconPB;
        public System.Windows.Forms.Button fxHuntCatBtn;
        public System.Windows.Forms.Button fxHuntDogBtn;
        public System.Windows.Forms.Button fxHuntBirdBtn;
        public System.Windows.Forms.RichTextBox fxDescriptionOfZoneText;
        public System.Windows.Forms.Label fxNameOfZoneLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox fxResultOfAction;
        public System.Windows.Forms.TabControl fxActionsTP;
        public System.Windows.Forms.TabPage City_DistrictsTP;
        private System.Windows.Forms.TabPage City_FoodStoreTP;
        public System.Windows.Forms.TabPage FightTP;
        private System.Windows.Forms.Button fxLookAroundBtn;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button fxLootAbaddonedHousesBtn;
        public System.Windows.Forms.Button fxLootTrashCanSmallBtn;
        public System.Windows.Forms.Button fxLootTrashCanBigBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolTip fxHuntBirdTT;
        public System.Windows.Forms.ToolTip fxHuntDogTT;
        public System.Windows.Forms.ToolTip fxHuntCatTT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ProgressBar fxHealthPB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}