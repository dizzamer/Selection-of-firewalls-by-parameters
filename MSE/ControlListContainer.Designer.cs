namespace MSE
{
    partial class ControlListContainer
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
            this.itemAddButtonContainer = new System.Windows.Forms.Panel();
            this.addItemAddParamButton = new System.Windows.Forms.Button();
            this.itemAddButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemAddButtonContainer
            // 
            this.itemAddButtonContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemAddButtonContainer.Controls.Add(this.addItemAddParamButton);
            this.itemAddButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemAddButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.itemAddButtonContainer.Name = "itemAddButtonContainer";
            this.itemAddButtonContainer.Size = new System.Drawing.Size(423, 26);
            this.itemAddButtonContainer.TabIndex = 1;
            // 
            // addItemAddParamButton
            // 
            this.addItemAddParamButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addItemAddParamButton.Location = new System.Drawing.Point(395, 0);
            this.addItemAddParamButton.Name = "addItemAddParamButton";
            this.addItemAddParamButton.Size = new System.Drawing.Size(26, 24);
            this.addItemAddParamButton.TabIndex = 0;
            this.addItemAddParamButton.Text = "+";
            this.addItemAddParamButton.UseVisualStyleBackColor = true;
            this.addItemAddParamButton.Click += new System.EventHandler(this.addItemAddParamButton_Click);
            // 
            // ControlListContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.itemAddButtonContainer);
            this.Name = "ControlListContainer";
            this.Size = new System.Drawing.Size(423, 147);
            this.itemAddButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemAddButtonContainer;
        private System.Windows.Forms.Button addItemAddParamButton;
    }
}
