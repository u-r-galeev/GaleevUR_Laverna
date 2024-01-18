namespace GaleevUR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelClue = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(33, 56);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(156, 20);
            this.cityTextBox.TabIndex = 0;
            this.cityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityTextBox_KeyDown);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(213, 56);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 20);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelClue
            // 
            this.labelClue.AutoSize = true;
            this.labelClue.Location = new System.Drawing.Point(33, 40);
            this.labelClue.Name = "labelClue";
            this.labelClue.Size = new System.Drawing.Size(138, 13);
            this.labelClue.TabIndex = 2;
            this.labelClue.Text = "Введите название города";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(33, 94);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(123, 13);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "Температура воздуха: ";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Location = new System.Drawing.Point(33, 140);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(115, 13);
            this.labelWind.TabIndex = 4;
            this.labelWind.Text = "Скорость ветра м/с: ";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(33, 117);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(63, 13);
            this.labelDesc.TabIndex = 5;
            this.labelDesc.Text = "Описание: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 183);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelClue);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.cityTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelClue;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelDesc;
    }
}

