namespace Forms_Cartoons
{
    partial class Form_Cartoons
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCntrCartoons = new System.Windows.Forms.TabControl();
            this.tabCartoons = new System.Windows.Forms.TabPage();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.tabCntrCartoons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCntrCartoons
            // 
            this.tabCntrCartoons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCntrCartoons.Controls.Add(this.tabCartoons);
            this.tabCntrCartoons.Controls.Add(this.tabCompany);
            this.tabCntrCartoons.Location = new System.Drawing.Point(0, 1);
            this.tabCntrCartoons.Name = "tabCntrCartoons";
            this.tabCntrCartoons.SelectedIndex = 0;
            this.tabCntrCartoons.Size = new System.Drawing.Size(416, 256);
            this.tabCntrCartoons.TabIndex = 0;
            // 
            // tabCartoons
            // 
            this.tabCartoons.Location = new System.Drawing.Point(4, 22);
            this.tabCartoons.Name = "tabCartoons";
            this.tabCartoons.Padding = new System.Windows.Forms.Padding(3);
            this.tabCartoons.Size = new System.Drawing.Size(408, 230);
            this.tabCartoons.TabIndex = 0;
            this.tabCartoons.Text = "Мультфільми";
            this.tabCartoons.UseVisualStyleBackColor = true;
            // 
            // tabCompany
            // 
            this.tabCompany.Location = new System.Drawing.Point(4, 22);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompany.Size = new System.Drawing.Size(408, 230);
            this.tabCompany.TabIndex = 1;
            this.tabCompany.Text = "tabPage2";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // Form_Cartoons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 262);
            this.Controls.Add(this.tabCntrCartoons);
            this.Name = "Form_Cartoons";
            this.Text = "Кінозал";
            this.tabCntrCartoons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrCartoons;
        private System.Windows.Forms.TabPage tabCartoons;
        private System.Windows.Forms.TabPage tabCompany;

    }
}

