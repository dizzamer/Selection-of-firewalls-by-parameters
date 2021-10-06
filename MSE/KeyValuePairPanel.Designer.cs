namespace MSE
{
    partial class KeyValuePairPanel
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.positionLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.spacerLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.valueNum = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).BeginInit();
            this.SuspendLayout();
            // 
            // positionLabel
            // 
            this.positionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.positionLabel.Location = new System.Drawing.Point(3, 3);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(26, 20);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "1";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyTextBox
            // 
            this.keyTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.keyTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.keyTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.keyTextBox.Location = new System.Drawing.Point(29, 3);
            this.keyTextBox.MinimumSize = new System.Drawing.Size(206, 4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(206, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // spacerLabel
            // 
            this.spacerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.spacerLabel.Location = new System.Drawing.Point(235, 3);
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new System.Drawing.Size(53, 20);
            this.spacerLabel.TabIndex = 3;
            this.spacerLabel.Text = "=";
            this.spacerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.spacerLabel.Click += new System.EventHandler(this.spacerLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.Location = new System.Drawing.Point(418, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(26, 20);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // valueNum
            // 
            this.valueNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.valueNum.Location = new System.Drawing.Point(288, 3);
            this.valueNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.valueNum.Name = "valueNum";
            this.valueNum.Size = new System.Drawing.Size(100, 20);
            this.valueNum.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(403, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // KeyValuePairPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.valueNum);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.spacerLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.positionLabel);
            this.MinimumSize = new System.Drawing.Size(447, 0);
            this.Name = "KeyValuePairPanel";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(447, 26);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.KeyValuePairPanel_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label spacerLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.NumericUpDown valueNum;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
