namespace Forms_Cartoons
{
    partial class FrmAddGenre
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
            this.button_AddGenre = new System.Windows.Forms.Button();
            this.comboBox_AddGenre = new System.Windows.Forms.ComboBox();
            this.dICGENREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCartoons = new Cartoons_DATA.DSCartoons();
            this.dT_ADD_GENRETableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DT_ADD_GENRETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddGenre
            // 
            this.button_AddGenre.Location = new System.Drawing.Point(197, 40);
            this.button_AddGenre.Name = "button_AddGenre";
            this.button_AddGenre.Size = new System.Drawing.Size(75, 23);
            this.button_AddGenre.TabIndex = 0;
            this.button_AddGenre.Text = "ОК";
            this.button_AddGenre.UseVisualStyleBackColor = true;
            this.button_AddGenre.Click += new System.EventHandler(this.button_AddGenre_Click);
            // 
            // comboBox_AddGenre
            // 
            this.comboBox_AddGenre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dICGENREBindingSource, "GR_ID", true));
            this.comboBox_AddGenre.DataSource = this.dICGENREBindingSource;
            this.comboBox_AddGenre.DisplayMember = "GR_NAME";
            this.comboBox_AddGenre.FormattingEnabled = true;
            this.comboBox_AddGenre.Location = new System.Drawing.Point(12, 40);
            this.comboBox_AddGenre.Name = "comboBox_AddGenre";
            this.comboBox_AddGenre.Size = new System.Drawing.Size(162, 21);
            this.comboBox_AddGenre.TabIndex = 1;
            this.comboBox_AddGenre.ValueMember = "GR_ID";
            // 
            // dICGENREBindingSource
            // 
            this.dICGENREBindingSource.DataMember = "DT_ADD_GENRE";
            this.dICGENREBindingSource.DataSource = this.dsCartoons;
            // 
            // dsCartoons
            // 
            this.dsCartoons.DataSetName = "DSCartoons";
            this.dsCartoons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dT_ADD_GENRETableAdapter1
            // 
            this.dT_ADD_GENRETableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.comboBox_AddGenre);
            this.Controls.Add(this.button_AddGenre);
            this.Name = "FrmAddGenre";
            this.Text = "AddGenre";
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddGenre;
        private System.Windows.Forms.ComboBox comboBox_AddGenre;
        private Cartoons_DATA.DSCartoonsTableAdapters.DT_ADD_GENRETableAdapter dT_ADD_GENRETableAdapter1;
        private Cartoons_DATA.DSCartoons dsCartoons;
        private System.Windows.Forms.BindingSource dICGENREBindingSource;
    }
}