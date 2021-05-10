
namespace HoboSimulator.Windows.Game.CreateActor
{
    partial class CreateActorWindow
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
            this.fxListOfPresets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fxName = new System.Windows.Forms.TextBox();
            this.fxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fxBiography = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EndCreateBtn);
            // 
            // fxListOfPresets
            // 
            this.fxListOfPresets.FormattingEnabled = true;
            this.fxListOfPresets.ItemHeight = 20;
            this.fxListOfPresets.Location = new System.Drawing.Point(13, 158);
            this.fxListOfPresets.Name = "fxListOfPresets";
            this.fxListOfPresets.Size = new System.Drawing.Size(211, 544);
            this.fxListOfPresets.TabIndex = 2;
            this.fxListOfPresets.SelectedIndexChanged += new System.EventHandler(this.HoboPresetChosenLB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя персонажа:";
            // 
            // fxName
            // 
            this.fxName.Location = new System.Drawing.Point(239, 158);
            this.fxName.Name = "fxName";
            this.fxName.Size = new System.Drawing.Size(191, 27);
            this.fxName.TabIndex = 4;
            // 
            // fxAge
            // 
            this.fxAge.Location = new System.Drawing.Point(446, 158);
            this.fxAge.Name = "fxAge";
            this.fxAge.Size = new System.Drawing.Size(191, 27);
            this.fxAge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Готовые персонажи:";
            // 
            // fxBiography
            // 
            this.fxBiography.Location = new System.Drawing.Point(239, 270);
            this.fxBiography.Name = "fxBiography";
            this.fxBiography.Size = new System.Drawing.Size(398, 145);
            this.fxBiography.TabIndex = 8;
            this.fxBiography.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Краткая биография:";
            // 
            // CreateActorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fxBiography);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fxListOfPresets);
            this.Controls.Add(this.button1);
            this.Name = "CreateActorWindow";
            this.Text = "HoboSimulator";
            this.Load += new System.EventHandler(this.InitializeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox fxListOfPresets;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox fxName;
        public System.Windows.Forms.TextBox fxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox fxBiography;
        private System.Windows.Forms.Label label4;
    }
}