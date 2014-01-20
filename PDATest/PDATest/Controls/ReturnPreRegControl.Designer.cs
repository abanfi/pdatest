namespace PDATestProject
{
    partial class ReturnPreRegControl
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
            this.postCustRetUnexpectedButton = new System.Windows.Forms.Button();
            this.postCustRetPreregButton = new System.Windows.Forms.Button();
            this.postRefuseCustRetPreregButton = new System.Windows.Forms.Button();
            this.findParcelForCustRetPreRegButton = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.returnPreRegDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.partnerIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.damagedCheckBox = new System.Windows.Forms.CheckBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noLabelCheckBox = new System.Windows.Forms.CheckBox();
            this.unexpectedDamagedCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linkedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextLinkedBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAtDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelMinimalReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refuseReasonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.returnPreRegReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnPreRegDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelMinimalReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPreRegReturnDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // postCustRetUnexpectedButton
            // 
            this.postCustRetUnexpectedButton.Location = new System.Drawing.Point(392, 187);
            this.postCustRetUnexpectedButton.Name = "postCustRetUnexpectedButton";
            this.postCustRetUnexpectedButton.Size = new System.Drawing.Size(158, 23);
            this.postCustRetUnexpectedButton.TabIndex = 38;
            this.postCustRetUnexpectedButton.Text = "PostCustRetUnexpected";
            this.postCustRetUnexpectedButton.UseVisualStyleBackColor = true;
            this.postCustRetUnexpectedButton.Click += new System.EventHandler(this.postCustRetUnexpectedButton_Click);
            // 
            // postCustRetPreregButton
            // 
            this.postCustRetPreregButton.Location = new System.Drawing.Point(392, 158);
            this.postCustRetPreregButton.Name = "postCustRetPreregButton";
            this.postCustRetPreregButton.Size = new System.Drawing.Size(158, 23);
            this.postCustRetPreregButton.TabIndex = 37;
            this.postCustRetPreregButton.Text = "PostCustRetPrereg";
            this.postCustRetPreregButton.UseVisualStyleBackColor = true;
            this.postCustRetPreregButton.Click += new System.EventHandler(this.postCustRetPreregButton_Click);
            // 
            // postRefuseCustRetPreregButton
            // 
            this.postRefuseCustRetPreregButton.Location = new System.Drawing.Point(392, 129);
            this.postRefuseCustRetPreregButton.Name = "postRefuseCustRetPreregButton";
            this.postRefuseCustRetPreregButton.Size = new System.Drawing.Size(158, 23);
            this.postRefuseCustRetPreregButton.TabIndex = 36;
            this.postRefuseCustRetPreregButton.Text = "PostRefuseCustRetPrereg";
            this.postRefuseCustRetPreregButton.UseVisualStyleBackColor = true;
            this.postRefuseCustRetPreregButton.Click += new System.EventHandler(this.postRefuseCustRetPreregButton_Click);
            // 
            // findParcelForCustRetPreRegButton
            // 
            this.findParcelForCustRetPreRegButton.Location = new System.Drawing.Point(392, 100);
            this.findParcelForCustRetPreRegButton.Name = "findParcelForCustRetPreRegButton";
            this.findParcelForCustRetPreRegButton.Size = new System.Drawing.Size(158, 23);
            this.findParcelForCustRetPreRegButton.TabIndex = 35;
            this.findParcelForCustRetPreRegButton.Text = "FindParcelForCustRetPreReg";
            this.findParcelForCustRetPreRegButton.UseVisualStyleBackColor = true;
            this.findParcelForCustRetPreRegButton.Click += new System.EventHandler(this.findParcelForCustRetPreRegButton_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnPreRegDataBindingSource, "customerName", true));
            this.customerTextBox.Location = new System.Drawing.Point(285, 189);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerTextBox.TabIndex = 34;
            // 
            // returnPreRegDataBindingSource
            // 
            this.returnPreRegDataBindingSource.DataSource = typeof(PDATestProject.ReturnPreRegData);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Customer Name";
            // 
            // partnerIdTextBox
            // 
            this.partnerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnPreRegDataBindingSource, "partnerId", true));
            this.partnerIdTextBox.Location = new System.Drawing.Point(189, 190);
            this.partnerIdTextBox.Name = "partnerIdTextBox";
            this.partnerIdTextBox.Size = new System.Drawing.Size(90, 20);
            this.partnerIdTextBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Partner ID";
            // 
            // damagedCheckBox
            // 
            this.damagedCheckBox.AutoSize = true;
            this.damagedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.returnPreRegDataBindingSource, "damaged", true));
            this.damagedCheckBox.Location = new System.Drawing.Point(313, 133);
            this.damagedCheckBox.Name = "damagedCheckBox";
            this.damagedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.damagedCheckBox.TabIndex = 22;
            this.damagedCheckBox.Text = "Damaged";
            this.damagedCheckBox.UseVisualStyleBackColor = true;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnPreRegDataBindingSource, "packageCode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(313, 102);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(72, 20);
            this.barcodeTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Parcel barcode";
            // 
            // noLabelCheckBox
            // 
            this.noLabelCheckBox.AutoSize = true;
            this.noLabelCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.returnPreRegDataBindingSource, "noLabel", true));
            this.noLabelCheckBox.Location = new System.Drawing.Point(111, 193);
            this.noLabelCheckBox.Name = "noLabelCheckBox";
            this.noLabelCheckBox.Size = new System.Drawing.Size(65, 17);
            this.noLabelCheckBox.TabIndex = 40;
            this.noLabelCheckBox.Text = "No label";
            this.noLabelCheckBox.UseVisualStyleBackColor = true;
            // 
            // unexpectedDamagedCheckBox
            // 
            this.unexpectedDamagedCheckBox.AutoSize = true;
            this.unexpectedDamagedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.returnPreRegDataBindingSource, "returnDamaged", true));
            this.unexpectedDamagedCheckBox.Location = new System.Drawing.Point(33, 193);
            this.unexpectedDamagedCheckBox.Name = "unexpectedDamagedCheckBox";
            this.unexpectedDamagedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.unexpectedDamagedCheckBox.TabIndex = 41;
            this.unexpectedDamagedCheckBox.Text = "Damaged";
            this.unexpectedDamagedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultMessageTextBox.Location = new System.Drawing.Point(99, 388);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultMessageTextBox.Size = new System.Drawing.Size(453, 104);
            this.resultMessageTextBox.TabIndex = 54;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedDataGridViewCheckBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.damagedDataGridViewCheckBoxColumn,
            this.linkedCountDataGridViewTextBoxColumn,
            this.nextLinkedBarcodeDataGridViewTextBoxColumn,
            this.parcelStateDataGridViewTextBoxColumn,
            this.priceAtDeliveryDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.parcelMinimalReturnDataBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(33, 225);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(519, 157);
            this.dataGridView.TabIndex = 53;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            // 
            // linkedCountDataGridViewTextBoxColumn
            // 
            this.linkedCountDataGridViewTextBoxColumn.DataPropertyName = "LinkedCount";
            this.linkedCountDataGridViewTextBoxColumn.HeaderText = "LinkedCount";
            this.linkedCountDataGridViewTextBoxColumn.Name = "linkedCountDataGridViewTextBoxColumn";
            // 
            // nextLinkedBarcodeDataGridViewTextBoxColumn
            // 
            this.nextLinkedBarcodeDataGridViewTextBoxColumn.DataPropertyName = "NextLinkedBarcode";
            this.nextLinkedBarcodeDataGridViewTextBoxColumn.HeaderText = "NextLinkedBarcode";
            this.nextLinkedBarcodeDataGridViewTextBoxColumn.Name = "nextLinkedBarcodeDataGridViewTextBoxColumn";
            // 
            // parcelStateDataGridViewTextBoxColumn
            // 
            this.parcelStateDataGridViewTextBoxColumn.DataPropertyName = "ParcelState";
            this.parcelStateDataGridViewTextBoxColumn.HeaderText = "ParcelState";
            this.parcelStateDataGridViewTextBoxColumn.Name = "parcelStateDataGridViewTextBoxColumn";
            // 
            // priceAtDeliveryDataGridViewTextBoxColumn
            // 
            this.priceAtDeliveryDataGridViewTextBoxColumn.DataPropertyName = "PriceAtDelivery";
            this.priceAtDeliveryDataGridViewTextBoxColumn.HeaderText = "PriceAtDelivery";
            this.priceAtDeliveryDataGridViewTextBoxColumn.Name = "priceAtDeliveryDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // parcelMinimalReturnDataBindingSource
            // 
            this.parcelMinimalReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ParcelMinimalReturnData);
            // 
            // refuseReasonTextBox
            // 
            this.refuseReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnPreRegDataBindingSource, "refuseReason", true));
            this.refuseReasonTextBox.Location = new System.Drawing.Point(247, 131);
            this.refuseReasonTextBox.Name = "refuseReasonTextBox";
            this.refuseReasonTextBox.Size = new System.Drawing.Size(60, 20);
            this.refuseReasonTextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Refuse reason";
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(580, 96);
            this.defaultParametersControl1.TabIndex = 39;
            // 
            // returnPreRegReturnDataBindingSource
            // 
            this.returnPreRegReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ReturnPreRegReturnData);
            // 
            // ReturnPreRegControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refuseReasonTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.unexpectedDamagedCheckBox);
            this.Controls.Add(this.noLabelCheckBox);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.postCustRetUnexpectedButton);
            this.Controls.Add(this.postCustRetPreregButton);
            this.Controls.Add(this.postRefuseCustRetPreregButton);
            this.Controls.Add(this.findParcelForCustRetPreRegButton);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partnerIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.damagedCheckBox);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ReturnPreRegControl";
            this.Size = new System.Drawing.Size(580, 510);
            ((System.ComponentModel.ISupportInitialize)(this.returnPreRegDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelMinimalReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPreRegReturnDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button postCustRetUnexpectedButton;
        private System.Windows.Forms.Button postCustRetPreregButton;
        private System.Windows.Forms.Button postRefuseCustRetPreregButton;
        private System.Windows.Forms.Button findParcelForCustRetPreRegButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partnerIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox damagedCheckBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.CheckBox noLabelCheckBox;
        private System.Windows.Forms.CheckBox unexpectedDamagedCheckBox;
        private System.Windows.Forms.BindingSource returnPreRegDataBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox refuseReasonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource returnPreRegReturnDataBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextLinkedBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAtDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parcelMinimalReturnDataBindingSource;
    }
}
