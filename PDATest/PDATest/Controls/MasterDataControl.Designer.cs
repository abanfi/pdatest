namespace PDATestProject
{
    partial class MasterDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.findDeletedParcelSinceButton = new System.Windows.Forms.Button();
            this.findDeletedPartnerSinceButton = new System.Windows.Forms.Button();
            this.findDeletedDictionarySinceButton = new System.Windows.Forms.Button();
            this.findInsertedParcelSinceButton = new System.Windows.Forms.Button();
            this.findInsertedPartnerSinceButton = new System.Windows.Forms.Button();
            this.offlineDatePicker = new System.Windows.Forms.DateTimePicker();
            this.masterDataDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findInsertedDictionarySinceButton = new System.Windows.Forms.Button();
            this.offlineDataGrid = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionaryReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.partnerReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelReturnDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // findDeletedParcelSinceButton
            // 
            this.findDeletedParcelSinceButton.Location = new System.Drawing.Point(492, 129);
            this.findDeletedParcelSinceButton.Name = "findDeletedParcelSinceButton";
            this.findDeletedParcelSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findDeletedParcelSinceButton.TabIndex = 31;
            this.findDeletedParcelSinceButton.Text = "FindDeletedParcelSince";
            this.findDeletedParcelSinceButton.UseVisualStyleBackColor = true;
            this.findDeletedParcelSinceButton.Click += new System.EventHandler(this.findDeletedParcelSinceButton_Click);
            // 
            // findDeletedPartnerSinceButton
            // 
            this.findDeletedPartnerSinceButton.Location = new System.Drawing.Point(330, 129);
            this.findDeletedPartnerSinceButton.Name = "findDeletedPartnerSinceButton";
            this.findDeletedPartnerSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findDeletedPartnerSinceButton.TabIndex = 30;
            this.findDeletedPartnerSinceButton.Text = "FindDeletedPartnerSince";
            this.findDeletedPartnerSinceButton.UseVisualStyleBackColor = true;
            this.findDeletedPartnerSinceButton.Click += new System.EventHandler(this.findDeletedPartnerSinceButton_Click);
            // 
            // findDeletedDictionarySinceButton
            // 
            this.findDeletedDictionarySinceButton.Location = new System.Drawing.Point(168, 129);
            this.findDeletedDictionarySinceButton.Name = "findDeletedDictionarySinceButton";
            this.findDeletedDictionarySinceButton.Size = new System.Drawing.Size(156, 23);
            this.findDeletedDictionarySinceButton.TabIndex = 29;
            this.findDeletedDictionarySinceButton.Text = "FindDeletedDictionarySince";
            this.findDeletedDictionarySinceButton.UseVisualStyleBackColor = true;
            this.findDeletedDictionarySinceButton.Click += new System.EventHandler(this.findDeletedDictionarySinceButton_Click);
            // 
            // findInsertedParcelSinceButton
            // 
            this.findInsertedParcelSinceButton.Location = new System.Drawing.Point(492, 102);
            this.findInsertedParcelSinceButton.Name = "findInsertedParcelSinceButton";
            this.findInsertedParcelSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedParcelSinceButton.TabIndex = 28;
            this.findInsertedParcelSinceButton.Text = "FindInsertedParcelSince";
            this.findInsertedParcelSinceButton.UseVisualStyleBackColor = true;
            this.findInsertedParcelSinceButton.Click += new System.EventHandler(this.findInsertedParcelSinceButton_Click);
            // 
            // findInsertedPartnerSinceButton
            // 
            this.findInsertedPartnerSinceButton.Location = new System.Drawing.Point(330, 102);
            this.findInsertedPartnerSinceButton.Name = "findInsertedPartnerSinceButton";
            this.findInsertedPartnerSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedPartnerSinceButton.TabIndex = 27;
            this.findInsertedPartnerSinceButton.Text = "FindInsertedPartnerSince";
            this.findInsertedPartnerSinceButton.UseVisualStyleBackColor = true;
            this.findInsertedPartnerSinceButton.Click += new System.EventHandler(this.findInsertedPartnerSinceButton_Click);
            // 
            // offlineDatePicker
            // 
            this.offlineDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.masterDataDataBindingSource, "date", true));
            this.offlineDatePicker.Location = new System.Drawing.Point(25, 103);
            this.offlineDatePicker.Name = "offlineDatePicker";
            this.offlineDatePicker.Size = new System.Drawing.Size(137, 20);
            this.offlineDatePicker.TabIndex = 26;
            // 
            // masterDataDataBindingSource
            // 
            this.masterDataDataBindingSource.DataSource = typeof(PDATestProject.MasterDataData);
            // 
            // findInsertedDictionarySinceButton
            // 
            this.findInsertedDictionarySinceButton.Location = new System.Drawing.Point(168, 102);
            this.findInsertedDictionarySinceButton.Name = "findInsertedDictionarySinceButton";
            this.findInsertedDictionarySinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedDictionarySinceButton.TabIndex = 25;
            this.findInsertedDictionarySinceButton.Text = "FindInsertedDictionarySince";
            this.findInsertedDictionarySinceButton.UseVisualStyleBackColor = true;
            this.findInsertedDictionarySinceButton.Click += new System.EventHandler(this.findInsertedDictionarySinceButton_Click);
            // 
            // offlineDataGrid
            // 
            this.offlineDataGrid.AutoGenerateColumns = false;
            this.offlineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offlineDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.dictionaryClassDataGridViewTextBoxColumn,
            this.keyValueDataGridViewTextBoxColumn});
            this.offlineDataGrid.DataSource = this.dictionaryReturnDataBindingSource;
            this.offlineDataGrid.Location = new System.Drawing.Point(25, 158);
            this.offlineDataGrid.Name = "offlineDataGrid";
            this.offlineDataGrid.Size = new System.Drawing.Size(623, 120);
            this.offlineDataGrid.TabIndex = 24;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dictionaryClassDataGridViewTextBoxColumn
            // 
            this.dictionaryClassDataGridViewTextBoxColumn.DataPropertyName = "DictionaryClass";
            this.dictionaryClassDataGridViewTextBoxColumn.HeaderText = "DictionaryClass";
            this.dictionaryClassDataGridViewTextBoxColumn.Name = "dictionaryClassDataGridViewTextBoxColumn";
            // 
            // keyValueDataGridViewTextBoxColumn
            // 
            this.keyValueDataGridViewTextBoxColumn.DataPropertyName = "KeyValue";
            this.keyValueDataGridViewTextBoxColumn.HeaderText = "KeyValue";
            this.keyValueDataGridViewTextBoxColumn.Name = "keyValueDataGridViewTextBoxColumn";
            // 
            // dictionaryReturnDataBindingSource
            // 
            this.dictionaryReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.DictionaryReturnData);
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(674, 96);
            this.defaultParametersControl1.TabIndex = 32;
            // 
            // partnerReturnDataBindingSource
            // 
            this.partnerReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.PartnerReturnData);
            // 
            // parcelReturnDataBindingSource
            // 
            this.parcelReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ParcelReturnData);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Location = new System.Drawing.Point(87, 284);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.Size = new System.Drawing.Size(561, 114);
            this.resultMessageTextBox.TabIndex = 51;
            // 
            // MasterDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.findDeletedParcelSinceButton);
            this.Controls.Add(this.findDeletedPartnerSinceButton);
            this.Controls.Add(this.findDeletedDictionarySinceButton);
            this.Controls.Add(this.findInsertedParcelSinceButton);
            this.Controls.Add(this.findInsertedPartnerSinceButton);
            this.Controls.Add(this.offlineDatePicker);
            this.Controls.Add(this.findInsertedDictionarySinceButton);
            this.Controls.Add(this.offlineDataGrid);
            this.Name = "MasterDataControl";
            this.Size = new System.Drawing.Size(674, 475);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelReturnDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findDeletedParcelSinceButton;
        private System.Windows.Forms.Button findDeletedPartnerSinceButton;
        private System.Windows.Forms.Button findDeletedDictionarySinceButton;
        private System.Windows.Forms.Button findInsertedParcelSinceButton;
        private System.Windows.Forms.Button findInsertedPartnerSinceButton;
        private System.Windows.Forms.DateTimePicker offlineDatePicker;
        private System.Windows.Forms.Button findInsertedDictionarySinceButton;
        private System.Windows.Forms.DataGridView offlineDataGrid;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.BindingSource masterDataDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionaryClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dictionaryReturnDataBindingSource;
        private System.Windows.Forms.BindingSource partnerReturnDataBindingSource;
        private System.Windows.Forms.BindingSource parcelReturnDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
    }
}
