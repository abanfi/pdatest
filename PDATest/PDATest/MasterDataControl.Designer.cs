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
            this.findInsertedDictionarySinceButton = new System.Windows.Forms.Button();
            this.offlineDataGrid = new System.Windows.Forms.DataGridView();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.masterDataDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataDataBindingSource)).BeginInit();
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
            // 
            // findDeletedPartnerSinceButton
            // 
            this.findDeletedPartnerSinceButton.Location = new System.Drawing.Point(330, 129);
            this.findDeletedPartnerSinceButton.Name = "findDeletedPartnerSinceButton";
            this.findDeletedPartnerSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findDeletedPartnerSinceButton.TabIndex = 30;
            this.findDeletedPartnerSinceButton.Text = "FindDeletedPartnerSince";
            this.findDeletedPartnerSinceButton.UseVisualStyleBackColor = true;
            // 
            // findDeletedDictionarySinceButton
            // 
            this.findDeletedDictionarySinceButton.Location = new System.Drawing.Point(168, 129);
            this.findDeletedDictionarySinceButton.Name = "findDeletedDictionarySinceButton";
            this.findDeletedDictionarySinceButton.Size = new System.Drawing.Size(156, 23);
            this.findDeletedDictionarySinceButton.TabIndex = 29;
            this.findDeletedDictionarySinceButton.Text = "FindDeletedDictionarySince";
            this.findDeletedDictionarySinceButton.UseVisualStyleBackColor = true;
            // 
            // findInsertedParcelSinceButton
            // 
            this.findInsertedParcelSinceButton.Location = new System.Drawing.Point(492, 102);
            this.findInsertedParcelSinceButton.Name = "findInsertedParcelSinceButton";
            this.findInsertedParcelSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedParcelSinceButton.TabIndex = 28;
            this.findInsertedParcelSinceButton.Text = "FindInsertedParcelSince";
            this.findInsertedParcelSinceButton.UseVisualStyleBackColor = true;
            // 
            // findInsertedPartnerSinceButton
            // 
            this.findInsertedPartnerSinceButton.Location = new System.Drawing.Point(330, 102);
            this.findInsertedPartnerSinceButton.Name = "findInsertedPartnerSinceButton";
            this.findInsertedPartnerSinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedPartnerSinceButton.TabIndex = 27;
            this.findInsertedPartnerSinceButton.Text = "FindInsertedPartnerSince";
            this.findInsertedPartnerSinceButton.UseVisualStyleBackColor = true;
            // 
            // offlineDatePicker
            // 
            this.offlineDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.masterDataDataBindingSource, "date", true));
            this.offlineDatePicker.Location = new System.Drawing.Point(25, 103);
            this.offlineDatePicker.Name = "offlineDatePicker";
            this.offlineDatePicker.Size = new System.Drawing.Size(137, 20);
            this.offlineDatePicker.TabIndex = 26;
            // 
            // findInsertedDictionarySinceButton
            // 
            this.findInsertedDictionarySinceButton.Location = new System.Drawing.Point(168, 102);
            this.findInsertedDictionarySinceButton.Name = "findInsertedDictionarySinceButton";
            this.findInsertedDictionarySinceButton.Size = new System.Drawing.Size(156, 23);
            this.findInsertedDictionarySinceButton.TabIndex = 25;
            this.findInsertedDictionarySinceButton.Text = "FindInsertedDictionarySince";
            this.findInsertedDictionarySinceButton.UseVisualStyleBackColor = true;
            // 
            // offlineDataGrid
            // 
            this.offlineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offlineDataGrid.Location = new System.Drawing.Point(25, 158);
            this.offlineDataGrid.Name = "offlineDataGrid";
            this.offlineDataGrid.Size = new System.Drawing.Size(623, 120);
            this.offlineDataGrid.TabIndex = 24;
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(674, 96);
            this.defaultParametersControl1.TabIndex = 32;
            // 
            // masterDataDataBindingSource
            // 
            this.masterDataDataBindingSource.DataSource = typeof(PDATestProject.MasterDataData);
            // 
            // MasterDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(674, 293);
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataDataBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}
