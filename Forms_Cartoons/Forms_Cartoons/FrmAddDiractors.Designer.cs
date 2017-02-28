namespace Forms_Cartoons
{
    partial class FrmAddDiractors
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
            this.comboBoxAddDiractors = new System.Windows.Forms.ComboBox();
            this.dTADDDIRACTORS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCartoons = new Cartoons_DATA.DSCartoons();
            this.button_add_diractors = new System.Windows.Forms.Button();
            this.dtadD_DIRACTORS1TableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DTADD_DIRACTORS1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dTADDDIRACTORS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAddDiractors
            // 
            this.comboBoxAddDiractors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAddDiractors.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dTADDDIRACTORS1BindingSource, "DR_ID", true));
            this.comboBoxAddDiractors.DataSource = this.dTADDDIRACTORS1BindingSource;
            this.comboBoxAddDiractors.DisplayMember = "DR_NAME";
            this.comboBoxAddDiractors.FormattingEnabled = true;
            this.comboBoxAddDiractors.Location = new System.Drawing.Point(12, 37);
            this.comboBoxAddDiractors.Name = "comboBoxAddDiractors";
            this.comboBoxAddDiractors.Size = new System.Drawing.Size(158, 21);
            this.comboBoxAddDiractors.TabIndex = 0;
            this.comboBoxAddDiractors.ValueMember = "DR_ID";
            // 
            // dTADDDIRACTORS1BindingSource
            // 
            this.dTADDDIRACTORS1BindingSource.DataMember = "DTADD_DIRACTORS1";
            this.dTADDDIRACTORS1BindingSource.DataSource = this.dsCartoons;
            // 
            // dsCartoons
            // 
            this.dsCartoons.DataSetName = "DSCartoons";
            this.dsCartoons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_add_diractors
            // 
            this.button_add_diractors.Location = new System.Drawing.Point(197, 37);
            this.button_add_diractors.Name = "button_add_diractors";
            this.button_add_diractors.Size = new System.Drawing.Size(75, 23);
            this.button_add_diractors.TabIndex = 1;
            this.button_add_diractors.Text = "OK";
            this.button_add_diractors.UseVisualStyleBackColor = true;
            this.button_add_diractors.Click += new System.EventHandler(this.button_add_diractors_Click);
            // 
            // dtadD_DIRACTORS1TableAdapter1
            // 
            this.dtadD_DIRACTORS1TableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAddDiractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.button_add_diractors);
            this.Controls.Add(this.comboBoxAddDiractors);
            this.Name = "FrmAddDiractors";
            this.Text = "AddDiractors";
            ((System.ComponentModel.ISupportInitialize)(this.dTADDDIRACTORS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAddDiractors;
        private System.Windows.Forms.Button button_add_diractors;
        private Cartoons_DATA.DSCartoons dsCartoons;
        private System.Windows.Forms.BindingSource dTADDDIRACTORS1BindingSource;
        private Cartoons_DATA.DSCartoonsTableAdapters.DTADD_DIRACTORS1TableAdapter dtadD_DIRACTORS1TableAdapter1;
    }
}