
namespace HoboSimulator
{
    partial class MainMenuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fxVersion = new System.Windows.Forms.Label();
            this.fxResumeGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Начать новую игру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StartNewGameBtn);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Загрузить игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadGameBtn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить игру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveGameBtn);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(386, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Настройки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SettingsBtn);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(196, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(386, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Выйти из игры";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CloseGameBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hobo Simulator v.";
            // 
            // fxVersion
            // 
            this.fxVersion.AutoSize = true;
            this.fxVersion.Location = new System.Drawing.Point(148, 677);
            this.fxVersion.Name = "fxVersion";
            this.fxVersion.Size = new System.Drawing.Size(83, 20);
            this.fxVersion.TabIndex = 8;
            this.fxVersion.Text = "%Версия%";
            // 
            // fxResumeGameBtn
            // 
            this.fxResumeGameBtn.Location = new System.Drawing.Point(196, 210);
            this.fxResumeGameBtn.Name = "fxResumeGameBtn";
            this.fxResumeGameBtn.Size = new System.Drawing.Size(386, 29);
            this.fxResumeGameBtn.TabIndex = 9;
            this.fxResumeGameBtn.Text = "Вернуться к игре";
            this.fxResumeGameBtn.UseVisualStyleBackColor = true;
            this.fxResumeGameBtn.Visible = false;
            this.fxResumeGameBtn.Click += new System.EventHandler(this.ResumeGameBtn);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 714);
            this.Controls.Add(this.fxResumeGameBtn);
            this.Controls.Add(this.fxVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "MainMenu";
            this.Text = "HoboSimulator";
            this.Load += new System.EventHandler(this.initializeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fxVersion;
        public System.Windows.Forms.Button fxResumeGameBtn;
    }
}

