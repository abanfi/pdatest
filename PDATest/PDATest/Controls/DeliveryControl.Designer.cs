namespace PDATestProject
{
    partial class DeliveryControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.damagedCheckBox = new System.Windows.Forms.CheckBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refuseIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.refuseDocIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryDocIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.findParcelForDeliveryButton = new System.Windows.Forms.Button();
            this.postCancelDeliveryButton = new System.Windows.Forms.Button();
            this.postRefuseDeliveryButton = new System.Windows.Forms.Button();
            this.postDeliveryButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.deliveryParleccMinimumReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.linkedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextLinkedBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceAtDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryParleccMinimumReturnDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parcel barcode";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "packageCode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(277, 102);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.barcodeTextBox.TabIndex = 2;
            // 
            // damagedCheckBox
            // 
            this.damagedCheckBox.AutoSize = true;
            this.damagedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.deliveryDataBindingSource, "damaged", true));
            this.damagedCheckBox.Location = new System.Drawing.Point(343, 133);
            this.damagedCheckBox.Name = "damagedCheckBox";
            this.damagedCheckBox.Size = new System.Drawing.Size(72, 17);
            this.damagedCheckBox.TabIndex = 3;
            this.damagedCheckBox.Text = "Damaged";
            this.damagedCheckBox.UseVisualStyleBackColor = true;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "reason", true));
            this.reasonTextBox.Location = new System.Drawing.Point(113, 160);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(47, 20);
            this.reasonTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reason";
            // 
            // refuseIdTextBox
            // 
            this.refuseIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "refuseIdType", true));
            this.refuseIdTextBox.Location = new System.Drawing.Point(208, 160);
            this.refuseIdTextBox.Name = "refuseIdTextBox";
            this.refuseIdTextBox.Size = new System.Drawing.Size(44, 20);
            this.refuseIdTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID type";
            // 
            // refuseDocIdTextBox
            // 
            this.refuseDocIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "refuseDocNo", true));
            this.refuseDocIdTextBox.Location = new System.Drawing.Point(315, 160);
            this.refuseDocIdTextBox.Name = "refuseDocIdTextBox";
            this.refuseDocIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.refuseDocIdTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID doc no.";
            // 
            // deliveryDocIdTextBox
            // 
            this.deliveryDocIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "postDocNo", true));
            this.deliveryDocIdTextBox.Location = new System.Drawing.Point(315, 189);
            this.deliveryDocIdTextBox.Name = "deliveryDocIdTextBox";
            this.deliveryDocIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryDocIdTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID doc no.";
            // 
            // deliveryIdTextBox
            // 
            this.deliveryIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "postIdType", true));
            this.deliveryIdTextBox.Location = new System.Drawing.Point(208, 189);
            this.deliveryIdTextBox.Name = "deliveryIdTextBox";
            this.deliveryIdTextBox.Size = new System.Drawing.Size(44, 20);
            this.deliveryIdTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID type";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryDataBindingSource, "payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(113, 189);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(47, 20);
            this.paymentTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Payment";
            // 
            // findParcelForDeliveryButton
            // 
            this.findParcelForDeliveryButton.Location = new System.Drawing.Point(421, 100);
            this.findParcelForDeliveryButton.Name = "findParcelForDeliveryButton";
            this.findParcelForDeliveryButton.Size = new System.Drawing.Size(129, 23);
            this.findParcelForDeliveryButton.TabIndex = 16;
            this.findParcelForDeliveryButton.Text = "FindParcelForDelivery";
            this.findParcelForDeliveryButton.UseVisualStyleBackColor = true;
            this.findParcelForDeliveryButton.Click += new System.EventHandler(this.findParcelForDeliveryButton_Click);
            // 
            // postCancelDeliveryButton
            // 
            this.postCancelDeliveryButton.Location = new System.Drawing.Point(421, 129);
            this.postCancelDeliveryButton.Name = "postCancelDeliveryButton";
            this.postCancelDeliveryButton.Size = new System.Drawing.Size(129, 23);
            this.postCancelDeliveryButton.TabIndex = 17;
            this.postCancelDeliveryButton.Text = "PostCancelDelivery";
            this.postCancelDeliveryButton.UseVisualStyleBackColor = true;
            this.postCancelDeliveryButton.Click += new System.EventHandler(this.postCancelDeliveryButton_Click);
            // 
            // postRefuseDeliveryButton
            // 
            this.postRefuseDeliveryButton.Location = new System.Drawing.Point(421, 158);
            this.postRefuseDeliveryButton.Name = "postRefuseDeliveryButton";
            this.postRefuseDeliveryButton.Size = new System.Drawing.Size(129, 23);
            this.postRefuseDeliveryButton.TabIndex = 18;
            this.postRefuseDeliveryButton.Text = "PostRefuseDelivery";
            this.postRefuseDeliveryButton.UseVisualStyleBackColor = true;
            this.postRefuseDeliveryButton.Click += new System.EventHandler(this.postRefuseDeliveryButton_Click);
            // 
            // postDeliveryButton
            // 
            this.postDeliveryButton.Location = new System.Drawing.Point(421, 187);
            this.postDeliveryButton.Name = "postDeliveryButton";
            this.postDeliveryButton.Size = new System.Drawing.Size(129, 23);
            this.postDeliveryButton.TabIndex = 19;
            this.postDeliveryButton.Text = "PostDelivery";
            this.postDeliveryButton.UseVisualStyleBackColor = true;
            this.postDeliveryButton.Click += new System.EventHandler(this.postDeliveryButton_Click);
            // 
            // dataGridView
            // 
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
            this.dataGridView.DataSource = this.deliveryParleccMinimumReturnDataBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(31, 217);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(519, 157);
            this.dataGridView.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Location = new System.Drawing.Point(97, 380);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.Size = new System.Drawing.Size(453, 104);
            this.resultMessageTextBox.TabIndex = 51;
            // 
            // deliveryDataBindingSource
            // 
            this.deliveryDataBindingSource.DataSource = typeof(PDATestProject.DeliveryData);
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(572, 96);
            this.defaultParametersControl1.TabIndex = 0;
            // 
            // deliveryParleccMinimumReturnDataBindingSource
            // 
            this.deliveryParleccMinimumReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.DeliveryParleccMinimumReturnData);
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
            // DeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.postDeliveryButton);
            this.Controls.Add(this.postRefuseDeliveryButton);
            this.Controls.Add(this.postCancelDeliveryButton);
            this.Controls.Add(this.findParcelForDeliveryButton);
            this.Controls.Add(this.deliveryDocIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deliveryIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.refuseDocIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refuseIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.damagedCheckBox);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultParametersControl1);
            this.Name = "DeliveryControl";
            this.Size = new System.Drawing.Size(572, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryParleccMinimumReturnDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.CheckBox damagedCheckBox;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox refuseIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox refuseDocIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deliveryDocIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deliveryIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findParcelForDeliveryButton;
        private System.Windows.Forms.Button postCancelDeliveryButton;
        private System.Windows.Forms.Button postRefuseDeliveryButton;
        private System.Windows.Forms.Button postDeliveryButton;
        private System.Windows.Forms.BindingSource deliveryDataBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextLinkedBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAtDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveryParleccMinimumReturnDataBindingSource;
    }
}
