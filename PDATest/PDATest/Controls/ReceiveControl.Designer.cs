namespace PDATestProject
{
    partial class ReceiveControl
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.postReceiveButton = new System.Windows.Forms.Button();
            this.findParcelForReceiveButton = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.destinationLocationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextLinkedBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelWorkflowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAtDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelCompositeSelectableReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiveDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeSelectableReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedDataGridViewCheckBoxColumn,
            this.locationIDDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.bagBarcodeDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerPostalCodeDataGridViewTextBoxColumn,
            this.damagedDataGridViewCheckBoxColumn,
            this.destinationLocationIDDataGridViewTextBoxColumn,
            this.linkedCountDataGridViewTextBoxColumn,
            this.nextLinkedBarcodeDataGridViewTextBoxColumn,
            this.oldBarcodeDataGridViewTextBoxColumn,
            this.parcelStateDataGridViewTextBoxColumn,
            this.parcelWorkflowDataGridViewTextBoxColumn,
            this.partnerIDDataGridViewTextBoxColumn,
            this.priceAtDeliveryDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.shipmentIDDataGridViewTextBoxColumn,
            this.partnerNameDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.parcelCompositeSelectableReturnDataBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(25, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(524, 166);
            this.dataGridView.TabIndex = 47;
            // 
            // postReceiveButton
            // 
            this.postReceiveButton.Location = new System.Drawing.Point(420, 131);
            this.postReceiveButton.Name = "postReceiveButton";
            this.postReceiveButton.Size = new System.Drawing.Size(129, 23);
            this.postReceiveButton.TabIndex = 46;
            this.postReceiveButton.Text = "PostReceive";
            this.postReceiveButton.UseVisualStyleBackColor = true;
            this.postReceiveButton.Click += new System.EventHandler(this.postReceiveButton_Click);
            // 
            // findParcelForReceiveButton
            // 
            this.findParcelForReceiveButton.Location = new System.Drawing.Point(420, 102);
            this.findParcelForReceiveButton.Name = "findParcelForReceiveButton";
            this.findParcelForReceiveButton.Size = new System.Drawing.Size(129, 23);
            this.findParcelForReceiveButton.TabIndex = 45;
            this.findParcelForReceiveButton.Text = "FindParcelForReceive";
            this.findParcelForReceiveButton.UseVisualStyleBackColor = true;
            this.findParcelForReceiveButton.Click += new System.EventHandler(this.findParcelForReceiveButton_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiveDataBindingSource, "barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(276, 104);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.barcodeTextBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Parcel barcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Location = new System.Drawing.Point(85, 332);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.Size = new System.Drawing.Size(464, 114);
            this.resultMessageTextBox.TabIndex = 49;
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(572, 96);
            this.defaultParametersControl1.TabIndex = 48;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            // 
            // bagBarcodeDataGridViewTextBoxColumn
            // 
            this.bagBarcodeDataGridViewTextBoxColumn.DataPropertyName = "BagBarcode";
            this.bagBarcodeDataGridViewTextBoxColumn.HeaderText = "BagBarcode";
            this.bagBarcodeDataGridViewTextBoxColumn.Name = "bagBarcodeDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerPostalCodeDataGridViewTextBoxColumn
            // 
            this.customerPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerPostalCode";
            this.customerPostalCodeDataGridViewTextBoxColumn.HeaderText = "CustomerPostalCode";
            this.customerPostalCodeDataGridViewTextBoxColumn.Name = "customerPostalCodeDataGridViewTextBoxColumn";
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "Damaged";
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            // 
            // destinationLocationIDDataGridViewTextBoxColumn
            // 
            this.destinationLocationIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationLocationID";
            this.destinationLocationIDDataGridViewTextBoxColumn.HeaderText = "DestinationLocationID";
            this.destinationLocationIDDataGridViewTextBoxColumn.Name = "destinationLocationIDDataGridViewTextBoxColumn";
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
            // oldBarcodeDataGridViewTextBoxColumn
            // 
            this.oldBarcodeDataGridViewTextBoxColumn.DataPropertyName = "OldBarcode";
            this.oldBarcodeDataGridViewTextBoxColumn.HeaderText = "OldBarcode";
            this.oldBarcodeDataGridViewTextBoxColumn.Name = "oldBarcodeDataGridViewTextBoxColumn";
            // 
            // parcelStateDataGridViewTextBoxColumn
            // 
            this.parcelStateDataGridViewTextBoxColumn.DataPropertyName = "ParcelState";
            this.parcelStateDataGridViewTextBoxColumn.HeaderText = "ParcelState";
            this.parcelStateDataGridViewTextBoxColumn.Name = "parcelStateDataGridViewTextBoxColumn";
            // 
            // parcelWorkflowDataGridViewTextBoxColumn
            // 
            this.parcelWorkflowDataGridViewTextBoxColumn.DataPropertyName = "ParcelWorkflow";
            this.parcelWorkflowDataGridViewTextBoxColumn.HeaderText = "ParcelWorkflow";
            this.parcelWorkflowDataGridViewTextBoxColumn.Name = "parcelWorkflowDataGridViewTextBoxColumn";
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
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
            // shipmentIDDataGridViewTextBoxColumn
            // 
            this.shipmentIDDataGridViewTextBoxColumn.DataPropertyName = "ShipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.HeaderText = "ShipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.Name = "shipmentIDDataGridViewTextBoxColumn";
            // 
            // partnerNameDataGridViewTextBoxColumn
            // 
            this.partnerNameDataGridViewTextBoxColumn.DataPropertyName = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.HeaderText = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.Name = "partnerNameDataGridViewTextBoxColumn";
            // 
            // parcelCompositeSelectableReturnDataBindingSource
            // 
            this.parcelCompositeSelectableReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ParcelCompositeSelectableReturnData);
            // 
            // receiveDataBindingSource
            // 
            this.receiveDataBindingSource.DataSource = typeof(PDATestProject.ReceiveData);
            // 
            // ReceiveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.postReceiveButton);
            this.Controls.Add(this.findParcelForReceiveButton);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ReceiveControl";
            this.Size = new System.Drawing.Size(572, 494);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeSelectableReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button postReceiveButton;
        private System.Windows.Forms.Button findParcelForReceiveButton;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.BindingSource receiveDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationLocationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextLinkedBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelWorkflowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAtDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parcelCompositeSelectableReturnDataBindingSource;
    }
}
