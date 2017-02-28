namespace Forms_Cartoons
{
    partial class Form_Cartoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cartoon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dICCARTOONSTATUSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCartoons = new Cartoons_DATA.DSCartoons();
            this.dICGENREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICDIRACTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICCOUNRTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICCOMPANYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARTOONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gENRECARTOONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPANYCARTOONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIRACTORSCARTOONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartoonsTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.CARTOONSTableAdapter();
            this.diC_COMPANYTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DIC_COMPANYTableAdapter();
            this.diC_COUNRTYTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DIC_COUNRTYTableAdapter();
            this.diC_DIRACTORSTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DIC_DIRACTORSTableAdapter();
            this.diC_GENRETableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DIC_GENRETableAdapter();
            this.diC_CARTOON_STATUSESTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DIC_CARTOON_STATUSESTableAdapter();
            this.tabStatuses = new System.Windows.Forms.TabPage();
            this.button_delete_statuses = new System.Windows.Forms.Button();
            this.button_save_statuses = new System.Windows.Forms.Button();
            this.dGVStatuses = new System.Windows.Forms.DataGridView();
            this.cSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGenre = new System.Windows.Forms.TabPage();
            this.button_delete_genre = new System.Windows.Forms.Button();
            this.button_save_genre = new System.Windows.Forms.Button();
            this.dGVGenre = new System.Windows.Forms.DataGridView();
            this.gRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDiractors = new System.Windows.Forms.TabPage();
            this.button_delete_directors = new System.Windows.Forms.Button();
            this.button_save_directors = new System.Windows.Forms.Button();
            this.dGVDiractors = new System.Windows.Forms.DataGridView();
            this.dRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.button_delete_company = new System.Windows.Forms.Button();
            this.button_save_company = new System.Windows.Forms.Button();
            this.dGVCompany = new System.Windows.Forms.DataGridView();
            this.tabCartoons = new System.Windows.Forms.TabPage();
            this.button_delete_diractor = new System.Windows.Forms.Button();
            this.dGVAddDiractor = new System.Windows.Forms.DataGridView();
            this.dRIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRINFODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDICDIRACORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGVAddGenre = new System.Windows.Forms.DataGridView();
            this.gRIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRINFODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDICGENREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_add_diractor = new System.Windows.Forms.Button();
            this.button_del_genre = new System.Windows.Forms.Button();
            this.button_add_genre = new System.Windows.Forms.Button();
            this.button_delete_cartoons = new System.Windows.Forms.Button();
            this.button_save_cartoons = new System.Windows.Forms.Button();
            this.dGVCartoons = new System.Windows.Forms.DataGridView();
            this.cRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_CS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cRANNOTATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRRATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRCSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCntr_Cartoons = new System.Windows.Forms.TabControl();
            this.dT_ADD_GENRETableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DT_ADD_GENRETableAdapter();
            this.dtdiC_DIRACORSTableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DTDIC_DIRACORSTableAdapter();
            this.dtdiC_GENRETableAdapter1 = new Cartoons_DATA.DSCartoonsTableAdapters.DTDIC_GENRETableAdapter();
            this.cPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP_CT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cPINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dICCARTOONSTATUSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICDIRACTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOUNRTYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOMPANYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTOONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRECARTOONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYCARTOONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIRACTORSCARTOONSBindingSource)).BeginInit();
            this.tabStatuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStatuses)).BeginInit();
            this.tabGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenre)).BeginInit();
            this.tabDiractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiractors)).BeginInit();
            this.tabCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompany)).BeginInit();
            this.tabCartoons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddDiractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDICDIRACORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDICGENREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCartoons)).BeginInit();
            this.tabCntr_Cartoons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dICCARTOONSTATUSESBindingSource
            // 
            this.dICCARTOONSTATUSESBindingSource.DataMember = "DIC_CARTOON_STATUSES";
            this.dICCARTOONSTATUSESBindingSource.DataSource = this.dsCartoons;
            // 
            // dsCartoons
            // 
            this.dsCartoons.DataSetName = "DSCartoons";
            this.dsCartoons.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICGENREBindingSource
            // 
            this.dICGENREBindingSource.DataMember = "DIC_GENRE";
            this.dICGENREBindingSource.DataSource = this.dsCartoons;
            // 
            // dICDIRACTORSBindingSource
            // 
            this.dICDIRACTORSBindingSource.DataMember = "DIC_DIRACTORS";
            this.dICDIRACTORSBindingSource.DataSource = this.dsCartoons;
            // 
            // dICCOUNRTYBindingSource
            // 
            this.dICCOUNRTYBindingSource.DataMember = "DIC_COUNRTY";
            this.dICCOUNRTYBindingSource.DataSource = this.dsCartoons;
            // 
            // dICCOMPANYBindingSource
            // 
            this.dICCOMPANYBindingSource.DataMember = "DIC_COMPANY";
            this.dICCOMPANYBindingSource.DataSource = this.dsCartoons;
            // 
            // cARTOONSBindingSource
            // 
            this.cARTOONSBindingSource.DataMember = "CARTOONS";
            this.cARTOONSBindingSource.DataSource = this.dsCartoons;
            // 
            // gENRECARTOONSBindingSource
            // 
            this.gENRECARTOONSBindingSource.DataMember = "GENRE_CARTOONS";
            this.gENRECARTOONSBindingSource.DataSource = typeof(Cartoons_DATA.DSCartoons);
            // 
            // cOMPANYCARTOONSBindingSource
            // 
            this.cOMPANYCARTOONSBindingSource.DataMember = "COMPANY_CARTOONS";
            this.cOMPANYCARTOONSBindingSource.DataSource = typeof(Cartoons_DATA.DSCartoons);
            // 
            // dIRACTORSCARTOONSBindingSource
            // 
            this.dIRACTORSCARTOONSBindingSource.DataMember = "DIRACTORS_CARTOONS";
            this.dIRACTORSCARTOONSBindingSource.DataSource = typeof(Cartoons_DATA.DSCartoons);
            // 
            // cartoonsTableAdapter1
            // 
            this.cartoonsTableAdapter1.ClearBeforeFill = true;
            // 
            // diC_COMPANYTableAdapter1
            // 
            this.diC_COMPANYTableAdapter1.ClearBeforeFill = true;
            // 
            // diC_COUNRTYTableAdapter1
            // 
            this.diC_COUNRTYTableAdapter1.ClearBeforeFill = true;
            // 
            // diC_DIRACTORSTableAdapter1
            // 
            this.diC_DIRACTORSTableAdapter1.ClearBeforeFill = true;
            // 
            // diC_GENRETableAdapter1
            // 
            this.diC_GENRETableAdapter1.ClearBeforeFill = true;
            // 
            // diC_CARTOON_STATUSESTableAdapter1
            // 
            this.diC_CARTOON_STATUSESTableAdapter1.ClearBeforeFill = true;
            // 
            // tabStatuses
            // 
            this.tabStatuses.Controls.Add(this.button_delete_statuses);
            this.tabStatuses.Controls.Add(this.button_save_statuses);
            this.tabStatuses.Controls.Add(this.dGVStatuses);
            this.tabStatuses.Location = new System.Drawing.Point(4, 22);
            this.tabStatuses.Name = "tabStatuses";
            this.tabStatuses.Size = new System.Drawing.Size(761, 552);
            this.tabStatuses.TabIndex = 5;
            this.tabStatuses.Text = "Статуси";
            this.tabStatuses.UseVisualStyleBackColor = true;
            // 
            // button_delete_statuses
            // 
            this.button_delete_statuses.Location = new System.Drawing.Point(149, 8);
            this.button_delete_statuses.Name = "button_delete_statuses";
            this.button_delete_statuses.Size = new System.Drawing.Size(75, 23);
            this.button_delete_statuses.TabIndex = 2;
            this.button_delete_statuses.Text = "Видалити";
            this.button_delete_statuses.UseVisualStyleBackColor = true;
            this.button_delete_statuses.Click += new System.EventHandler(this.button_delete_statuses_Click);
            // 
            // button_save_statuses
            // 
            this.button_save_statuses.Location = new System.Drawing.Point(7, 8);
            this.button_save_statuses.Name = "button_save_statuses";
            this.button_save_statuses.Size = new System.Drawing.Size(75, 23);
            this.button_save_statuses.TabIndex = 1;
            this.button_save_statuses.Text = "Зберегти";
            this.button_save_statuses.UseVisualStyleBackColor = true;
            this.button_save_statuses.Click += new System.EventHandler(this.button_save_statuses_Click);
            // 
            // dGVStatuses
            // 
            this.dGVStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVStatuses.AutoGenerateColumns = false;
            this.dGVStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStatuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSIDDataGridViewTextBoxColumn,
            this.cSNAMEDataGridViewTextBoxColumn});
            this.dGVStatuses.DataSource = this.dICCARTOONSTATUSESBindingSource;
            this.dGVStatuses.Location = new System.Drawing.Point(0, 37);
            this.dGVStatuses.Name = "dGVStatuses";
            this.dGVStatuses.Size = new System.Drawing.Size(761, 515);
            this.dGVStatuses.TabIndex = 0;
            // 
            // cSIDDataGridViewTextBoxColumn
            // 
            this.cSIDDataGridViewTextBoxColumn.DataPropertyName = "CS_ID";
            this.cSIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.cSIDDataGridViewTextBoxColumn.Name = "cSIDDataGridViewTextBoxColumn";
            this.cSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cSNAMEDataGridViewTextBoxColumn
            // 
            this.cSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CS_NAME";
            this.cSNAMEDataGridViewTextBoxColumn.HeaderText = "Назва статусу";
            this.cSNAMEDataGridViewTextBoxColumn.Name = "cSNAMEDataGridViewTextBoxColumn";
            // 
            // tabGenre
            // 
            this.tabGenre.Controls.Add(this.button_delete_genre);
            this.tabGenre.Controls.Add(this.button_save_genre);
            this.tabGenre.Controls.Add(this.dGVGenre);
            this.tabGenre.Location = new System.Drawing.Point(4, 22);
            this.tabGenre.Name = "tabGenre";
            this.tabGenre.Size = new System.Drawing.Size(761, 552);
            this.tabGenre.TabIndex = 4;
            this.tabGenre.Text = "Жанри";
            this.tabGenre.UseVisualStyleBackColor = true;
            // 
            // button_delete_genre
            // 
            this.button_delete_genre.Location = new System.Drawing.Point(141, 8);
            this.button_delete_genre.Name = "button_delete_genre";
            this.button_delete_genre.Size = new System.Drawing.Size(75, 23);
            this.button_delete_genre.TabIndex = 2;
            this.button_delete_genre.Text = "Видалити";
            this.button_delete_genre.UseVisualStyleBackColor = true;
            this.button_delete_genre.Click += new System.EventHandler(this.button_delete_genre_Click);
            // 
            // button_save_genre
            // 
            this.button_save_genre.Location = new System.Drawing.Point(3, 8);
            this.button_save_genre.Name = "button_save_genre";
            this.button_save_genre.Size = new System.Drawing.Size(75, 23);
            this.button_save_genre.TabIndex = 1;
            this.button_save_genre.Text = "Зберегти";
            this.button_save_genre.UseVisualStyleBackColor = true;
            this.button_save_genre.Click += new System.EventHandler(this.button_save_genre_Click);
            // 
            // dGVGenre
            // 
            this.dGVGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGenre.AutoGenerateColumns = false;
            this.dGVGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRIDDataGridViewTextBoxColumn,
            this.gRNAMEDataGridViewTextBoxColumn,
            this.gRINFODataGridViewTextBoxColumn});
            this.dGVGenre.DataSource = this.dICGENREBindingSource;
            this.dGVGenre.Location = new System.Drawing.Point(0, 37);
            this.dGVGenre.Name = "dGVGenre";
            this.dGVGenre.Size = new System.Drawing.Size(761, 515);
            this.dGVGenre.TabIndex = 0;
            // 
            // gRIDDataGridViewTextBoxColumn
            // 
            this.gRIDDataGridViewTextBoxColumn.DataPropertyName = "GR_ID";
            this.gRIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.gRIDDataGridViewTextBoxColumn.Name = "gRIDDataGridViewTextBoxColumn";
            this.gRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gRNAMEDataGridViewTextBoxColumn
            // 
            this.gRNAMEDataGridViewTextBoxColumn.DataPropertyName = "GR_NAME";
            this.gRNAMEDataGridViewTextBoxColumn.HeaderText = "Назва жанру";
            this.gRNAMEDataGridViewTextBoxColumn.Name = "gRNAMEDataGridViewTextBoxColumn";
            // 
            // gRINFODataGridViewTextBoxColumn
            // 
            this.gRINFODataGridViewTextBoxColumn.DataPropertyName = "GR_INFO";
            this.gRINFODataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.gRINFODataGridViewTextBoxColumn.Name = "gRINFODataGridViewTextBoxColumn";
            // 
            // tabDiractors
            // 
            this.tabDiractors.Controls.Add(this.button_delete_directors);
            this.tabDiractors.Controls.Add(this.button_save_directors);
            this.tabDiractors.Controls.Add(this.dGVDiractors);
            this.tabDiractors.Location = new System.Drawing.Point(4, 22);
            this.tabDiractors.Name = "tabDiractors";
            this.tabDiractors.Size = new System.Drawing.Size(761, 552);
            this.tabDiractors.TabIndex = 3;
            this.tabDiractors.Text = "Режисери";
            this.tabDiractors.UseVisualStyleBackColor = true;
            // 
            // button_delete_directors
            // 
            this.button_delete_directors.Location = new System.Drawing.Point(141, 8);
            this.button_delete_directors.Name = "button_delete_directors";
            this.button_delete_directors.Size = new System.Drawing.Size(75, 23);
            this.button_delete_directors.TabIndex = 2;
            this.button_delete_directors.Text = "Видалити";
            this.button_delete_directors.UseVisualStyleBackColor = true;
            this.button_delete_directors.Click += new System.EventHandler(this.button_delete_directors_Click);
            // 
            // button_save_directors
            // 
            this.button_save_directors.Location = new System.Drawing.Point(9, 8);
            this.button_save_directors.Name = "button_save_directors";
            this.button_save_directors.Size = new System.Drawing.Size(75, 23);
            this.button_save_directors.TabIndex = 1;
            this.button_save_directors.Text = "Зберегти";
            this.button_save_directors.UseVisualStyleBackColor = true;
            this.button_save_directors.Click += new System.EventHandler(this.button_save_directors_Click);
            // 
            // dGVDiractors
            // 
            this.dGVDiractors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVDiractors.AutoGenerateColumns = false;
            this.dGVDiractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDiractors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dRIDDataGridViewTextBoxColumn,
            this.dRNAMEDataGridViewTextBoxColumn,
            this.dRINFODataGridViewTextBoxColumn});
            this.dGVDiractors.DataSource = this.dICDIRACTORSBindingSource;
            this.dGVDiractors.Location = new System.Drawing.Point(-4, 37);
            this.dGVDiractors.Name = "dGVDiractors";
            this.dGVDiractors.Size = new System.Drawing.Size(765, 515);
            this.dGVDiractors.TabIndex = 0;
            // 
            // dRIDDataGridViewTextBoxColumn
            // 
            this.dRIDDataGridViewTextBoxColumn.DataPropertyName = "DR_ID";
            this.dRIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.dRIDDataGridViewTextBoxColumn.Name = "dRIDDataGridViewTextBoxColumn";
            this.dRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dRNAMEDataGridViewTextBoxColumn
            // 
            this.dRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DR_NAME";
            this.dRNAMEDataGridViewTextBoxColumn.HeaderText = "Ім\'я режисера";
            this.dRNAMEDataGridViewTextBoxColumn.Name = "dRNAMEDataGridViewTextBoxColumn";
            // 
            // dRINFODataGridViewTextBoxColumn
            // 
            this.dRINFODataGridViewTextBoxColumn.DataPropertyName = "DR_INFO";
            this.dRINFODataGridViewTextBoxColumn.HeaderText = "Коротка біографія";
            this.dRINFODataGridViewTextBoxColumn.Name = "dRINFODataGridViewTextBoxColumn";
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.button_delete_company);
            this.tabCompany.Controls.Add(this.button_save_company);
            this.tabCompany.Controls.Add(this.dGVCompany);
            this.tabCompany.Location = new System.Drawing.Point(4, 22);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompany.Size = new System.Drawing.Size(761, 552);
            this.tabCompany.TabIndex = 1;
            this.tabCompany.Text = "Компанії";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // button_delete_company
            // 
            this.button_delete_company.Location = new System.Drawing.Point(138, 6);
            this.button_delete_company.Name = "button_delete_company";
            this.button_delete_company.Size = new System.Drawing.Size(75, 23);
            this.button_delete_company.TabIndex = 2;
            this.button_delete_company.Text = "Видаити";
            this.button_delete_company.UseVisualStyleBackColor = true;
            this.button_delete_company.Click += new System.EventHandler(this.button_delete_company_Click);
            // 
            // button_save_company
            // 
            this.button_save_company.Location = new System.Drawing.Point(3, 6);
            this.button_save_company.Name = "button_save_company";
            this.button_save_company.Size = new System.Drawing.Size(75, 23);
            this.button_save_company.TabIndex = 1;
            this.button_save_company.Text = "Зберегти";
            this.button_save_company.UseVisualStyleBackColor = true;
            this.button_save_company.Click += new System.EventHandler(this.button_save_company_Click);
            // 
            // dGVCompany
            // 
            this.dGVCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCompany.AutoGenerateColumns = false;
            this.dGVCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPIDDataGridViewTextBoxColumn,
            this.cPNAMEDataGridViewTextBoxColumn,
            this.CP_CT,
            this.cPINFODataGridViewTextBoxColumn});
            this.dGVCompany.DataSource = this.dICCOMPANYBindingSource;
            this.dGVCompany.Location = new System.Drawing.Point(0, 35);
            this.dGVCompany.Name = "dGVCompany";
            this.dGVCompany.Size = new System.Drawing.Size(758, 517);
            this.dGVCompany.TabIndex = 0;
            // 
            // tabCartoons
            // 
            this.tabCartoons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCartoons.BackgroundImage")));
            this.tabCartoons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCartoons.Controls.Add(this.button_delete_diractor);
            this.tabCartoons.Controls.Add(this.dGVAddDiractor);
            this.tabCartoons.Controls.Add(this.dGVAddGenre);
            this.tabCartoons.Controls.Add(this.button_add_diractor);
            this.tabCartoons.Controls.Add(this.button_del_genre);
            this.tabCartoons.Controls.Add(this.button_add_genre);
            this.tabCartoons.Controls.Add(this.button_delete_cartoons);
            this.tabCartoons.Controls.Add(this.button_save_cartoons);
            this.tabCartoons.Controls.Add(this.dGVCartoons);
            this.tabCartoons.Location = new System.Drawing.Point(4, 22);
            this.tabCartoons.Name = "tabCartoons";
            this.tabCartoons.Padding = new System.Windows.Forms.Padding(3);
            this.tabCartoons.Size = new System.Drawing.Size(761, 552);
            this.tabCartoons.TabIndex = 0;
            this.tabCartoons.Text = "Мультфільми";
            this.tabCartoons.UseVisualStyleBackColor = true;
            // 
            // button_delete_diractor
            // 
            this.button_delete_diractor.Location = new System.Drawing.Point(575, 519);
            this.button_delete_diractor.Name = "button_delete_diractor";
            this.button_delete_diractor.Size = new System.Drawing.Size(75, 23);
            this.button_delete_diractor.TabIndex = 9;
            this.button_delete_diractor.Text = "Видалити";
            this.button_delete_diractor.UseVisualStyleBackColor = true;
            this.button_delete_diractor.Click += new System.EventHandler(this.button_delete_diractor_Click);
            // 
            // dGVAddDiractor
            // 
            this.dGVAddDiractor.AllowUserToOrderColumns = true;
            this.dGVAddDiractor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAddDiractor.AutoGenerateColumns = false;
            this.dGVAddDiractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAddDiractor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dRIDDataGridViewTextBoxColumn1,
            this.dRNAMEDataGridViewTextBoxColumn1,
            this.dRINFODataGridViewTextBoxColumn1});
            this.dGVAddDiractor.DataSource = this.dTDICDIRACORSBindingSource;
            this.dGVAddDiractor.Location = new System.Drawing.Point(414, 348);
            this.dGVAddDiractor.Name = "dGVAddDiractor";
            this.dGVAddDiractor.Size = new System.Drawing.Size(341, 169);
            this.dGVAddDiractor.TabIndex = 8;
            // 
            // dRIDDataGridViewTextBoxColumn1
            // 
            this.dRIDDataGridViewTextBoxColumn1.DataPropertyName = "DR_ID";
            this.dRIDDataGridViewTextBoxColumn1.HeaderText = "DR_ID";
            this.dRIDDataGridViewTextBoxColumn1.Name = "dRIDDataGridViewTextBoxColumn1";
            this.dRIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dRIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dRNAMEDataGridViewTextBoxColumn1
            // 
            this.dRNAMEDataGridViewTextBoxColumn1.DataPropertyName = "DR_NAME";
            this.dRNAMEDataGridViewTextBoxColumn1.HeaderText = "Режисер";
            this.dRNAMEDataGridViewTextBoxColumn1.Name = "dRNAMEDataGridViewTextBoxColumn1";
            // 
            // dRINFODataGridViewTextBoxColumn1
            // 
            this.dRINFODataGridViewTextBoxColumn1.DataPropertyName = "DR_INFO";
            this.dRINFODataGridViewTextBoxColumn1.HeaderText = "Коротка біографія";
            this.dRINFODataGridViewTextBoxColumn1.Name = "dRINFODataGridViewTextBoxColumn1";
            // 
            // dTDICDIRACORSBindingSource
            // 
            this.dTDICDIRACORSBindingSource.DataMember = "DTDIC_DIRACORS";
            this.dTDICDIRACORSBindingSource.DataSource = this.dsCartoons;
            // 
            // dGVAddGenre
            // 
            this.dGVAddGenre.AllowUserToOrderColumns = true;
            this.dGVAddGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAddGenre.AutoGenerateColumns = false;
            this.dGVAddGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAddGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRIDDataGridViewTextBoxColumn1,
            this.gRNAMEDataGridViewTextBoxColumn1,
            this.gRINFODataGridViewTextBoxColumn1});
            this.dGVAddGenre.DataSource = this.dTDICGENREBindingSource;
            this.dGVAddGenre.Location = new System.Drawing.Point(3, 348);
            this.dGVAddGenre.Name = "dGVAddGenre";
            this.dGVAddGenre.Size = new System.Drawing.Size(405, 169);
            this.dGVAddGenre.TabIndex = 7;
            // 
            // gRIDDataGridViewTextBoxColumn1
            // 
            this.gRIDDataGridViewTextBoxColumn1.DataPropertyName = "GR_ID";
            this.gRIDDataGridViewTextBoxColumn1.HeaderText = "GR_ID";
            this.gRIDDataGridViewTextBoxColumn1.Name = "gRIDDataGridViewTextBoxColumn1";
            this.gRIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gRIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // gRNAMEDataGridViewTextBoxColumn1
            // 
            this.gRNAMEDataGridViewTextBoxColumn1.DataPropertyName = "GR_NAME";
            this.gRNAMEDataGridViewTextBoxColumn1.HeaderText = "Назва жанру";
            this.gRNAMEDataGridViewTextBoxColumn1.Name = "gRNAMEDataGridViewTextBoxColumn1";
            // 
            // gRINFODataGridViewTextBoxColumn1
            // 
            this.gRINFODataGridViewTextBoxColumn1.DataPropertyName = "GR_INFO";
            this.gRINFODataGridViewTextBoxColumn1.HeaderText = "Інформація";
            this.gRINFODataGridViewTextBoxColumn1.Name = "gRINFODataGridViewTextBoxColumn1";
            // 
            // dTDICGENREBindingSource
            // 
            this.dTDICGENREBindingSource.DataMember = "DTDIC_GENRE";
            this.dTDICGENREBindingSource.DataSource = this.dsCartoons;
            // 
            // button_add_diractor
            // 
            this.button_add_diractor.Location = new System.Drawing.Point(463, 519);
            this.button_add_diractor.Name = "button_add_diractor";
            this.button_add_diractor.Size = new System.Drawing.Size(75, 23);
            this.button_add_diractor.TabIndex = 6;
            this.button_add_diractor.Text = "Додати";
            this.button_add_diractor.UseVisualStyleBackColor = true;
            this.button_add_diractor.Click += new System.EventHandler(this.button_add_diractor_Click);
            // 
            // button_del_genre
            // 
            this.button_del_genre.Location = new System.Drawing.Point(140, 526);
            this.button_del_genre.Name = "button_del_genre";
            this.button_del_genre.Size = new System.Drawing.Size(66, 23);
            this.button_del_genre.TabIndex = 5;
            this.button_del_genre.Text = "Видалити";
            this.button_del_genre.UseVisualStyleBackColor = true;
            this.button_del_genre.Click += new System.EventHandler(this.button_del_genre_Click);
            // 
            // button_add_genre
            // 
            this.button_add_genre.Location = new System.Drawing.Point(37, 523);
            this.button_add_genre.Name = "button_add_genre";
            this.button_add_genre.Size = new System.Drawing.Size(63, 23);
            this.button_add_genre.TabIndex = 4;
            this.button_add_genre.Text = "Додати";
            this.button_add_genre.UseVisualStyleBackColor = true;
            this.button_add_genre.Click += new System.EventHandler(this.button_add_genre_Click);
            // 
            // button_delete_cartoons
            // 
            this.button_delete_cartoons.Location = new System.Drawing.Point(105, 3);
            this.button_delete_cartoons.Name = "button_delete_cartoons";
            this.button_delete_cartoons.Size = new System.Drawing.Size(75, 23);
            this.button_delete_cartoons.TabIndex = 2;
            this.button_delete_cartoons.Text = "Видалити";
            this.button_delete_cartoons.UseVisualStyleBackColor = true;
            this.button_delete_cartoons.Click += new System.EventHandler(this.button_delete_Cartoons_Click);
            // 
            // button_save_cartoons
            // 
            this.button_save_cartoons.Location = new System.Drawing.Point(0, 3);
            this.button_save_cartoons.Name = "button_save_cartoons";
            this.button_save_cartoons.Size = new System.Drawing.Size(75, 23);
            this.button_save_cartoons.TabIndex = 1;
            this.button_save_cartoons.Text = "Зберегти";
            this.button_save_cartoons.UseVisualStyleBackColor = true;
            this.button_save_cartoons.Click += new System.EventHandler(this.buttn_save_Cartoons_Click);
            // 
            // dGVCartoons
            // 
            this.dGVCartoons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCartoons.AutoGenerateColumns = false;
            this.dGVCartoons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCartoons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRIDDataGridViewTextBoxColumn,
            this.cRNAMEDataGridViewTextBoxColumn,
            this.CR_CS,
            this.cRANNOTATIONDataGridViewTextBoxColumn,
            this.cRYEARDataGridViewTextBoxColumn,
            this.cRRATINGDataGridViewTextBoxColumn,
            this.cRDURATIONDataGridViewTextBoxColumn,
            this.cRCSDataGridViewTextBoxColumn,
            this.cRADRESSDataGridViewTextBoxColumn});
            this.dGVCartoons.DataSource = this.cARTOONSBindingSource;
            this.dGVCartoons.Location = new System.Drawing.Point(0, 32);
            this.dGVCartoons.Name = "dGVCartoons";
            this.dGVCartoons.Size = new System.Drawing.Size(765, 305);
            this.dGVCartoons.TabIndex = 0;
            this.dGVCartoons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCartoons_CellDoubleClick);
            // 
            // cRIDDataGridViewTextBoxColumn
            // 
            this.cRIDDataGridViewTextBoxColumn.DataPropertyName = "CR_ID";
            this.cRIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.cRIDDataGridViewTextBoxColumn.Name = "cRIDDataGridViewTextBoxColumn";
            this.cRIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRNAMEDataGridViewTextBoxColumn
            // 
            this.cRNAMEDataGridViewTextBoxColumn.DataPropertyName = "CR_NAME";
            this.cRNAMEDataGridViewTextBoxColumn.HeaderText = "Назва мультфільму";
            this.cRNAMEDataGridViewTextBoxColumn.Name = "cRNAMEDataGridViewTextBoxColumn";
            // 
            // CR_CS
            // 
            this.CR_CS.DataPropertyName = "CR_CS";
            this.CR_CS.DataSource = this.dICCARTOONSTATUSESBindingSource;
            this.CR_CS.DisplayMember = "CS_NAME";
            this.CR_CS.HeaderText = "Статус";
            this.CR_CS.Name = "CR_CS";
            this.CR_CS.ValueMember = "CS_ID";
            // 
            // cRANNOTATIONDataGridViewTextBoxColumn
            // 
            this.cRANNOTATIONDataGridViewTextBoxColumn.DataPropertyName = "CR_ANNOTATION";
            this.cRANNOTATIONDataGridViewTextBoxColumn.HeaderText = "Короткий зміст";
            this.cRANNOTATIONDataGridViewTextBoxColumn.Name = "cRANNOTATIONDataGridViewTextBoxColumn";
            // 
            // cRYEARDataGridViewTextBoxColumn
            // 
            this.cRYEARDataGridViewTextBoxColumn.DataPropertyName = "CR_YEAR";
            this.cRYEARDataGridViewTextBoxColumn.HeaderText = "Рік виходу";
            this.cRYEARDataGridViewTextBoxColumn.Name = "cRYEARDataGridViewTextBoxColumn";
            // 
            // cRRATINGDataGridViewTextBoxColumn
            // 
            this.cRRATINGDataGridViewTextBoxColumn.DataPropertyName = "CR_RATING";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cRRATINGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cRRATINGDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.cRRATINGDataGridViewTextBoxColumn.Name = "cRRATINGDataGridViewTextBoxColumn";
            // 
            // cRDURATIONDataGridViewTextBoxColumn
            // 
            this.cRDURATIONDataGridViewTextBoxColumn.DataPropertyName = "CR_DURATION";
            this.cRDURATIONDataGridViewTextBoxColumn.HeaderText = "Тривалість";
            this.cRDURATIONDataGridViewTextBoxColumn.Name = "cRDURATIONDataGridViewTextBoxColumn";
            // 
            // cRCSDataGridViewTextBoxColumn
            // 
            this.cRCSDataGridViewTextBoxColumn.DataPropertyName = "CR_CS";
            this.cRCSDataGridViewTextBoxColumn.HeaderText = "CR_CS";
            this.cRCSDataGridViewTextBoxColumn.Name = "cRCSDataGridViewTextBoxColumn";
            this.cRCSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRADRESSDataGridViewTextBoxColumn
            // 
            this.cRADRESSDataGridViewTextBoxColumn.DataPropertyName = "CR_ADRESS";
            this.cRADRESSDataGridViewTextBoxColumn.HeaderText = "Лінк";
            this.cRADRESSDataGridViewTextBoxColumn.Name = "cRADRESSDataGridViewTextBoxColumn";
            // 
            // tabCntr_Cartoons
            // 
            this.tabCntr_Cartoons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCntr_Cartoons.Controls.Add(this.tabCartoons);
            this.tabCntr_Cartoons.Controls.Add(this.tabCompany);
            this.tabCntr_Cartoons.Controls.Add(this.tabDiractors);
            this.tabCntr_Cartoons.Controls.Add(this.tabGenre);
            this.tabCntr_Cartoons.Controls.Add(this.tabStatuses);
            this.tabCntr_Cartoons.Location = new System.Drawing.Point(1, 100);
            this.tabCntr_Cartoons.Name = "tabCntr_Cartoons";
            this.tabCntr_Cartoons.SelectedIndex = 0;
            this.tabCntr_Cartoons.Size = new System.Drawing.Size(769, 578);
            this.tabCntr_Cartoons.TabIndex = 0;
            // 
            // dT_ADD_GENRETableAdapter1
            // 
            this.dT_ADD_GENRETableAdapter1.ClearBeforeFill = true;
            // 
            // dtdiC_DIRACORSTableAdapter1
            // 
            this.dtdiC_DIRACORSTableAdapter1.ClearBeforeFill = true;
            // 
            // dtdiC_GENRETableAdapter1
            // 
            this.dtdiC_GENRETableAdapter1.ClearBeforeFill = true;
            // 
            // cPIDDataGridViewTextBoxColumn
            // 
            this.cPIDDataGridViewTextBoxColumn.DataPropertyName = "CP_ID";
            this.cPIDDataGridViewTextBoxColumn.HeaderText = "№";
            this.cPIDDataGridViewTextBoxColumn.Name = "cPIDDataGridViewTextBoxColumn";
            this.cPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPNAMEDataGridViewTextBoxColumn
            // 
            this.cPNAMEDataGridViewTextBoxColumn.DataPropertyName = "CP_NAME";
            this.cPNAMEDataGridViewTextBoxColumn.HeaderText = "Назва компанії";
            this.cPNAMEDataGridViewTextBoxColumn.Name = "cPNAMEDataGridViewTextBoxColumn";
            // 
            // CP_CT
            // 
            this.CP_CT.DataPropertyName = "CP_CT";
            this.CP_CT.DataSource = this.dICCOUNRTYBindingSource;
            this.CP_CT.DisplayMember = "CT_NAME";
            this.CP_CT.HeaderText = "Країна";
            this.CP_CT.Name = "CP_CT";
            this.CP_CT.ValueMember = "CT_ID";
            // 
            // cPINFODataGridViewTextBoxColumn
            // 
            this.cPINFODataGridViewTextBoxColumn.DataPropertyName = "CP_INFO";
            this.cPINFODataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.cPINFODataGridViewTextBoxColumn.Name = "cPINFODataGridViewTextBoxColumn";
            // 
            // Form_Cartoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms_Cartoons.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(772, 676);
            this.Controls.Add(this.tabCntr_Cartoons);
            this.Name = "Form_Cartoon";
            this.Text = "Кінозал";
            this.Load += new System.EventHandler(this.Form_Cartoon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dICCARTOONSTATUSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCartoons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICGENREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICDIRACTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOUNRTYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICCOMPANYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTOONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRECARTOONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPANYCARTOONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIRACTORSCARTOONSBindingSource)).EndInit();
            this.tabStatuses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStatuses)).EndInit();
            this.tabGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenre)).EndInit();
            this.tabDiractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiractors)).EndInit();
            this.tabCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCompany)).EndInit();
            this.tabCartoons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddDiractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDICDIRACORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDICGENREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCartoons)).EndInit();
            this.tabCntr_Cartoons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cARTOONSBindingSource;
        private Cartoons_DATA.DSCartoons dsCartoons;
        private System.Windows.Forms.BindingSource dICCOMPANYBindingSource;
        private System.Windows.Forms.BindingSource dICCOUNRTYBindingSource;
        private System.Windows.Forms.BindingSource dICCARTOONSTATUSESBindingSource;
        private System.Windows.Forms.BindingSource dICGENREBindingSource;
        private System.Windows.Forms.BindingSource dICDIRACTORSBindingSource;
        private Cartoons_DATA.DSCartoonsTableAdapters.CARTOONSTableAdapter cartoonsTableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DIC_COMPANYTableAdapter diC_COMPANYTableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DIC_COUNRTYTableAdapter diC_COUNRTYTableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DIC_DIRACTORSTableAdapter diC_DIRACTORSTableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DIC_GENRETableAdapter diC_GENRETableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DIC_CARTOON_STATUSESTableAdapter diC_CARTOON_STATUSESTableAdapter1;
        private System.Windows.Forms.BindingSource gENRECARTOONSBindingSource;
        private System.Windows.Forms.BindingSource cOMPANYCARTOONSBindingSource;
        private System.Windows.Forms.BindingSource dIRACTORSCARTOONSBindingSource;
        private System.Windows.Forms.TabPage tabStatuses;
        private System.Windows.Forms.Button button_delete_statuses;
        private System.Windows.Forms.Button button_save_statuses;
        private System.Windows.Forms.DataGridView dGVStatuses;
        private System.Windows.Forms.TabPage tabGenre;
        private System.Windows.Forms.Button button_delete_genre;
        private System.Windows.Forms.Button button_save_genre;
        private System.Windows.Forms.DataGridView dGVGenre;
        private System.Windows.Forms.TabPage tabDiractors;
        private System.Windows.Forms.Button button_delete_directors;
        private System.Windows.Forms.Button button_save_directors;
        private System.Windows.Forms.DataGridView dGVDiractors;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.Button button_delete_company;
        private System.Windows.Forms.Button button_save_company;
        private System.Windows.Forms.DataGridView dGVCompany;
        private System.Windows.Forms.TabPage tabCartoons;
        private System.Windows.Forms.Button button_delete_cartoons;
        private System.Windows.Forms.Button button_save_cartoons;
        private System.Windows.Forms.DataGridView dGVCartoons;
        private System.Windows.Forms.TabControl tabCntr_Cartoons;
        private System.Windows.Forms.Button button_del_genre;
        private System.Windows.Forms.Button button_add_genre;
        private System.Windows.Forms.Button button_add_diractor;
        private Cartoons_DATA.DSCartoonsTableAdapters.DT_ADD_GENRETableAdapter dT_ADD_GENRETableAdapter1;
        private System.Windows.Forms.DataGridView dGVAddDiractor;
        private System.Windows.Forms.DataGridView dGVAddGenre;
        private System.Windows.Forms.Button button_delete_diractor;
        private Cartoons_DATA.DSCartoonsTableAdapters.DTDIC_DIRACORSTableAdapter dtdiC_DIRACORSTableAdapter1;
        private Cartoons_DATA.DSCartoonsTableAdapters.DTDIC_GENRETableAdapter dtdiC_GENRETableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource dTDICDIRACORSBindingSource;
        private System.Windows.Forms.BindingSource dTDICGENREBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRINFODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRINFODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CR_CS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRANNOTATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRRATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRCSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CP_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPINFODataGridViewTextBoxColumn;

    }
}