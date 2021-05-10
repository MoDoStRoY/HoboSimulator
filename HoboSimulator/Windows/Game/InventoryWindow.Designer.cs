
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.fxInventoryDGV.Size = new System.Drawing.Size(560, 753);
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
            this.fxDescriptionOfItemText.Size = new System.Drawing.Size(262, 120);
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
            this.label4.Location = new System.Drawing.Point(377, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Характеристики: ";
            // 
            // fxTtxText
            // 
            this.fxTtxText.Location = new System.Drawing.Point(377, 269);
            this.fxTtxText.Name = "fxTtxText";
            this.fxTtxText.Size = new System.Drawing.Size(262, 222);
            this.fxTtxText.TabIndex = 65;
            this.fxTtxText.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 29);
            this.button2.TabIndex = 67;
            this.button2.Text = "Использовать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UseBtn);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 29);
            this.button3.TabIndex = 68;
            this.button3.Text = "Выбросить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DropBtn);
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 778);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}