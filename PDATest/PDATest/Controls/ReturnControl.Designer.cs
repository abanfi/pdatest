namespace PDATestProject
{
    partial class ReturnControl
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
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linkedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextLinkedBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAtDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnParcelReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postReturnButton = new System.Windows.Forms.Button();
            this.findParcelForReturnButton = new System.Windows.Forms.Button();
            this.bagBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.returnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnParcelReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(558, 96);
            this.defaultParametersControl1.TabIndex = 0;
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
            this.dataGridView.DataSource = this.returnParcelReturnDataBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(27, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(519, 166);
            this.dataGridView.TabIndex = 40;
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
            // returnParcelReturnDataBindingSource
            // 
            this.returnParcelReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ReturnParcelReturnData);
            // 
            // postReturnButton
            // 
            this.postReturnButton.Location = new System.Drawing.Point(417, 131);
            this.postReturnButton.Name = "postReturnButton";
            this.postReturnButton.Size = new System.Drawing.Size(129, 23);
            this.postReturnButton.TabIndex = 38;
            this.postReturnButton.Text = "PostReturn";
            this.postReturnButton.UseVisualStyleBackColor = true;
            this.postReturnButton.Click += new System.EventHandler(this.postReturnButton_Click);
            // 
            // findParcelForReturnButton
            // 
            this.findParcelForReturnButton.Location = new System.Drawing.Point(417, 102);
            this.findParcelForReturnButton.Name = "findParcelForReturnButton";
            this.findParcelForReturnButton.Size = new System.Drawing.Size(129, 23);
            this.findParcelForReturnButton.TabIndex = 36;
            this.findParcelForReturnButton.Text = "FindParcelForReturn";
            this.findParcelForReturnButton.UseVisualStyleBackColor = true;
            this.findParcelForReturnButton.Click += new System.EventHandler(this.findParcelForReturnButton_Click);
            // 
            // bagBarcodeTextBox
            // 
            this.bagBarcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnDataBindingSource, "bagBarcode", true));
            this.bagBarcodeTextBox.Location = new System.Drawing.Point(273, 131);
            this.bagBarcodeTextBox.Name = "bagBarcodeTextBox";
            this.bagBarcodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.bagBarcodeTextBox.TabIndex = 29;
            // 
            // returnDataBindingSource
            // 
            this.returnDataBindingSource.DataSource = typeof(PDATestProject.ReturnData);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bag barcode";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnDataBindingSource, "barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(273, 104);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.barcodeTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Parcel barcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultMessageTextBox.Location = new System.Drawing.Point(82, 335);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultMessageTextBox.Size = new System.Drawing.Size(464, 114);
            this.resultMessageTextBox.TabIndex = 51;
            // 
            // ReturnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.postReturnButton);
            this.Controls.Add(this.findParcelForReturnButton);
            this.Controls.Add(this.bagBarcodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultParametersControl1);
            this.Name = "ReturnControl";
            this.Size = new System.Drawing.Size(558, 469);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnParcelReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button postReturnButton;
        private System.Windows.Forms.Button findParcelForReturnButton;
        private System.Windows.Forms.TextBox bagBarcodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource returnDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextLinkedBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAtDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnParcelReturnDataBindingSource;
    }
}
