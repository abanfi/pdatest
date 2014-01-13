namespace PDATestProject
{
    partial class PackageControl
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
            this.offlineDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.packageTextBox = new System.Windows.Forms.TextBox();
            this.findParcelByBarCodeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerAddresstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.packageCodeTextBox = new System.Windows.Forms.TextBox();
            this.findParcelByFilterButton = new System.Windows.Forms.Button();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.packageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelCompositeReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelCompositeReturnDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageReturnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeReturnDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // offlineDataGrid
            // 
            this.offlineDataGrid.AutoGenerateColumns = false;
            this.offlineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offlineDataGrid.DataSource = this.parcelCompositeReturnDataBindingSource;
            this.offlineDataGrid.Location = new System.Drawing.Point(22, 225);
            this.offlineDataGrid.Name = "offlineDataGrid";
            this.offlineDataGrid.Size = new System.Drawing.Size(527, 120);
            this.offlineDataGrid.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Csomag vonalkód:";
            // 
            // packageTextBox
            // 
            this.packageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageDataBindingSource, "packageCode", true));
            this.packageTextBox.Location = new System.Drawing.Point(268, 114);
            this.packageTextBox.Name = "packageTextBox";
            this.packageTextBox.Size = new System.Drawing.Size(139, 20);
            this.packageTextBox.TabIndex = 2;
            // 
            // findParcelByBarCodeButton
            // 
            this.findParcelByBarCodeButton.Location = new System.Drawing.Point(413, 112);
            this.findParcelByBarCodeButton.Name = "findParcelByBarCodeButton";
            this.findParcelByBarCodeButton.Size = new System.Drawing.Size(136, 23);
            this.findParcelByBarCodeButton.TabIndex = 8;
            this.findParcelByBarCodeButton.Text = "FindParcelByBarCode";
            this.findParcelByBarCodeButton.UseVisualStyleBackColor = true;
            this.findParcelByBarCodeButton.Click += new System.EventHandler(this.findParcelByBarCodeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageDataBindingSource, "customerZip", true));
            this.zipTextBox.Location = new System.Drawing.Point(357, 157);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(50, 20);
            this.zipTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ügyfél címe:";
            // 
            // customerAddresstextBox
            // 
            this.customerAddresstextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageDataBindingSource, "customerAddress", true));
            this.customerAddresstextBox.Location = new System.Drawing.Point(239, 158);
            this.customerAddresstextBox.Name = "customerAddresstextBox";
            this.customerAddresstextBox.Size = new System.Drawing.Size(112, 20);
            this.customerAddresstextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ügyfél neve:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageDataBindingSource, "customerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(128, 158);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(105, 20);
            this.customerNameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Csomag vonalkód:";
            // 
            // packageCodeTextBox
            // 
            this.packageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageDataBindingSource, "filterPackageCode", true));
            this.packageCodeTextBox.Location = new System.Drawing.Point(22, 158);
            this.packageCodeTextBox.Name = "packageCodeTextBox";
            this.packageCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.packageCodeTextBox.TabIndex = 9;
            // 
            // findParcelByFilterButton
            // 
            this.findParcelByFilterButton.Location = new System.Drawing.Point(413, 155);
            this.findParcelByFilterButton.Name = "findParcelByFilterButton";
            this.findParcelByFilterButton.Size = new System.Drawing.Size(136, 23);
            this.findParcelByFilterButton.TabIndex = 17;
            this.findParcelByFilterButton.Text = "FindParcelByFilter";
            this.findParcelByFilterButton.UseVisualStyleBackColor = true;
            this.findParcelByFilterButton.Click += new System.EventHandler(this.findParcelByFilterButton_Click);
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Location = new System.Drawing.Point(82, 199);
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.Size = new System.Drawing.Size(467, 20);
            this.resultMessageTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Eredmény:";
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(565, 96);
            this.defaultParametersControl1.TabIndex = 18;
            // 
            // packageDataBindingSource
            // 
            this.packageDataBindingSource.DataSource = typeof(PDATestProject.PackageData);
            // 
            // parcelCompositeReturnDataBindingSource
            // 
            this.parcelCompositeReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.ParcelCompositeReturnData);
            // 
            // packageReturnDataBindingSource
            // 
            this.packageReturnDataBindingSource.DataSource = typeof(PDATestProject.Datas.PackageReturnData);
            // 
            // parcelCompositeReturnDataBindingSource1
            // 
            this.parcelCompositeReturnDataBindingSource1.DataSource = typeof(PDATestProject.Datas.ParcelCompositeReturnData);
            // 
            // PackageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.findParcelByFilterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerAddresstextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packageCodeTextBox);
            this.Controls.Add(this.findParcelByBarCodeButton);
            this.Controls.Add(this.offlineDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.packageTextBox);
            this.Name = "PackageControl";
            this.Size = new System.Drawing.Size(565, 357);
            ((System.ComponentModel.ISupportInitialize)(this.offlineDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageReturnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelCompositeReturnDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox packageTextBox;
        private System.Windows.Forms.DataGridView offlineDataGrid;
        private System.Windows.Forms.Button findParcelByFilterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerAddresstextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox packageCodeTextBox;
        private System.Windows.Forms.Button findParcelByBarCodeButton;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.BindingSource packageDataBindingSource;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource parcelCompositeReturnDataBindingSource;
        private System.Windows.Forms.BindingSource packageReturnDataBindingSource;
        private System.Windows.Forms.BindingSource parcelCompositeReturnDataBindingSource1;
      

        public DefaultParametersControl defaultParametersControl { get; set; }
    }
}
