namespace PDATestProject
{
    partial class PartnerControl
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
            this.countPartnerByFilterButton = new System.Windows.Forms.Button();
            this.findPartnerByFilterButton = new System.Windows.Forms.Button();
            this.findPartnerByIdButton = new System.Windows.Forms.Button();
            this.partnerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.partnerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerDataGrid = new System.Windows.Forms.DataGridView();
            this.partnerNameTextBox = new System.Windows.Forms.TextBox();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // countPartnerByFilterButton
            // 
            this.countPartnerByFilterButton.Location = new System.Drawing.Point(427, 127);
            this.countPartnerByFilterButton.Name = "countPartnerByFilterButton";
            this.countPartnerByFilterButton.Size = new System.Drawing.Size(119, 23);
            this.countPartnerByFilterButton.TabIndex = 29;
            this.countPartnerByFilterButton.Text = "CountPartnerByFilter";
            this.countPartnerByFilterButton.UseVisualStyleBackColor = true;
            this.countPartnerByFilterButton.Click += new System.EventHandler(this.countPartnerByFilterButton_Click);
            // 
            // findPartnerByFilterButton
            // 
            this.findPartnerByFilterButton.Location = new System.Drawing.Point(284, 126);
            this.findPartnerByFilterButton.Name = "findPartnerByFilterButton";
            this.findPartnerByFilterButton.Size = new System.Drawing.Size(137, 23);
            this.findPartnerByFilterButton.TabIndex = 28;
            this.findPartnerByFilterButton.Text = "FindPartnerByFilter";
            this.findPartnerByFilterButton.UseVisualStyleBackColor = true;
            this.findPartnerByFilterButton.Click += new System.EventHandler(this.findPartnerByFilterButton_Click);
            // 
            // findPartnerByIdButton
            // 
            this.findPartnerByIdButton.Location = new System.Drawing.Point(427, 100);
            this.findPartnerByIdButton.Name = "findPartnerByIdButton";
            this.findPartnerByIdButton.Size = new System.Drawing.Size(119, 23);
            this.findPartnerByIdButton.TabIndex = 26;
            this.findPartnerByIdButton.Text = "FindPartnerById";
            this.findPartnerByIdButton.UseVisualStyleBackColor = true;
            this.findPartnerByIdButton.Click += new System.EventHandler(this.findPartnerByIdButton_Click);
            // 
            // partnerDatePicker
            // 
            this.partnerDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnerDataBindingSource, "partnerDate", true));
            this.partnerDatePicker.Location = new System.Drawing.Point(284, 101);
            this.partnerDatePicker.Name = "partnerDatePicker";
            this.partnerDatePicker.Size = new System.Drawing.Size(137, 20);
            this.partnerDatePicker.TabIndex = 25;
            // 
            // partnerDataBindingSource
            // 
            this.partnerDataBindingSource.DataSource = typeof(PDATestProject.PartnerData);
            // 
            // partnerDataGrid
            // 
            this.partnerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnerDataGrid.Location = new System.Drawing.Point(25, 156);
            this.partnerDataGrid.Name = "partnerDataGrid";
            this.partnerDataGrid.Size = new System.Drawing.Size(520, 120);
            this.partnerDataGrid.TabIndex = 24;
            // 
            // partnerNameTextBox
            // 
            this.partnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerDataBindingSource, "partnerNamePart", true));
            this.partnerNameTextBox.Location = new System.Drawing.Point(148, 127);
            this.partnerNameTextBox.Name = "partnerNameTextBox";
            this.partnerNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.partnerNameTextBox.TabIndex = 30;
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(556, 96);
            this.defaultParametersControl1.TabIndex = 31;
            // 
            // PartnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.partnerNameTextBox);
            this.Controls.Add(this.countPartnerByFilterButton);
            this.Controls.Add(this.findPartnerByFilterButton);
            this.Controls.Add(this.findPartnerByIdButton);
            this.Controls.Add(this.partnerDatePicker);
            this.Controls.Add(this.partnerDataGrid);
            this.Name = "PartnerControl";
            this.Size = new System.Drawing.Size(556, 293);
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countPartnerByFilterButton;
        private System.Windows.Forms.Button findPartnerByFilterButton;
        private System.Windows.Forms.Button findPartnerByIdButton;
        private System.Windows.Forms.DateTimePicker partnerDatePicker;
        private System.Windows.Forms.DataGridView partnerDataGrid;
        private System.Windows.Forms.TextBox partnerNameTextBox;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.BindingSource partnerDataBindingSource;
    }
}
