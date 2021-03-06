﻿namespace PDATestProject
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
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partnerIdTextBox = new System.Windows.Forms.TextBox();
            this.partnerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.partnerNameTextBox = new System.Windows.Forms.TextBox();
            this.countPartnerByFilterButton = new System.Windows.Forms.Button();
            this.findPartnerByFilterButton = new System.Windows.Forms.Button();
            this.findPartnerByIdButton = new System.Windows.Forms.Button();
            this.partnerDataGrid = new System.Windows.Forms.DataGridView();
            this.partnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerReturnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerReturnDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultMessageTextBox.Location = new System.Drawing.Point(568, 38);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultMessageTextBox.Size = new System.Drawing.Size(202, 388);
            this.resultMessageTextBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Partner név része";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Partner azonosító";
            // 
            // partnerIdTextBox
            // 
            this.partnerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerDataBindingSource, "partnerId", true));
            this.partnerIdTextBox.Location = new System.Drawing.Point(285, 89);
            this.partnerIdTextBox.Name = "partnerIdTextBox";
            this.partnerIdTextBox.Size = new System.Drawing.Size(136, 20);
            this.partnerIdTextBox.TabIndex = 32;
            // 
            // partnerDataBindingSource
            // 
            this.partnerDataBindingSource.DataSource = typeof(PDATestProject.Models.PartnerModel);
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(793, 68);
            this.defaultParametersControl1.TabIndex = 31;
            // 
            // partnerNameTextBox
            // 
            this.partnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerDataBindingSource, "partnerNamePart", true));
            this.partnerNameTextBox.Location = new System.Drawing.Point(148, 130);
            this.partnerNameTextBox.Name = "partnerNameTextBox";
            this.partnerNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.partnerNameTextBox.TabIndex = 30;
            // 
            // countPartnerByFilterButton
            // 
            this.countPartnerByFilterButton.Location = new System.Drawing.Point(427, 130);
            this.countPartnerByFilterButton.Name = "countPartnerByFilterButton";
            this.countPartnerByFilterButton.Size = new System.Drawing.Size(119, 23);
            this.countPartnerByFilterButton.TabIndex = 29;
            this.countPartnerByFilterButton.Text = "CountPartnerByFilter";
            this.countPartnerByFilterButton.UseVisualStyleBackColor = true;
            this.countPartnerByFilterButton.Click += new System.EventHandler(this.countPartnerByFilterButton_Click);
            // 
            // findPartnerByFilterButton
            // 
            this.findPartnerByFilterButton.Location = new System.Drawing.Point(284, 129);
            this.findPartnerByFilterButton.Name = "findPartnerByFilterButton";
            this.findPartnerByFilterButton.Size = new System.Drawing.Size(137, 23);
            this.findPartnerByFilterButton.TabIndex = 28;
            this.findPartnerByFilterButton.Text = "FindPartnerByFilter";
            this.findPartnerByFilterButton.UseVisualStyleBackColor = true;
            this.findPartnerByFilterButton.Click += new System.EventHandler(this.findPartnerByFilterButton_Click);
            // 
            // findPartnerByIdButton
            // 
            this.findPartnerByIdButton.Location = new System.Drawing.Point(427, 87);
            this.findPartnerByIdButton.Name = "findPartnerByIdButton";
            this.findPartnerByIdButton.Size = new System.Drawing.Size(119, 23);
            this.findPartnerByIdButton.TabIndex = 26;
            this.findPartnerByIdButton.Text = "FindPartnerById";
            this.findPartnerByIdButton.UseVisualStyleBackColor = true;
            this.findPartnerByIdButton.Click += new System.EventHandler(this.findPartnerByIdButton_Click);
            // 
            // partnerDataGrid
            // 
            this.partnerDataGrid.AllowUserToAddRows = false;
            this.partnerDataGrid.AllowUserToDeleteRows = false;
            this.partnerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.partnerDataGrid.AutoGenerateColumns = false;
            this.partnerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIDDataGridViewTextBoxColumn,
            this.partnerNameDataGridViewTextBoxColumn});
            this.partnerDataGrid.DataSource = this.partnerReturnDataBindingSource;
            this.partnerDataGrid.Location = new System.Drawing.Point(25, 168);
            this.partnerDataGrid.Name = "partnerDataGrid";
            this.partnerDataGrid.Size = new System.Drawing.Size(521, 258);
            this.partnerDataGrid.TabIndex = 24;
            // 
            // partnerIDDataGridViewTextBoxColumn
            // 
            this.partnerIDDataGridViewTextBoxColumn.DataPropertyName = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.HeaderText = "PartnerID";
            this.partnerIDDataGridViewTextBoxColumn.Name = "partnerIDDataGridViewTextBoxColumn";
            // 
            // partnerNameDataGridViewTextBoxColumn
            // 
            this.partnerNameDataGridViewTextBoxColumn.DataPropertyName = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.HeaderText = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.Name = "partnerNameDataGridViewTextBoxColumn";
            // 
            // partnerReturnDataBindingSource
            // 
            this.partnerReturnDataBindingSource.DataSource = typeof(PDATestProject.Models.PartnerReturnModel);
            // 
            // PartnerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partnerIdTextBox);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.partnerNameTextBox);
            this.Controls.Add(this.countPartnerByFilterButton);
            this.Controls.Add(this.findPartnerByFilterButton);
            this.Controls.Add(this.findPartnerByIdButton);
            this.Controls.Add(this.partnerDataGrid);
            this.Name = "PartnerControl";
            this.Size = new System.Drawing.Size(793, 445);
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerReturnDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countPartnerByFilterButton;
        private System.Windows.Forms.Button findPartnerByFilterButton;
        private System.Windows.Forms.Button findPartnerByIdButton;
        private System.Windows.Forms.DataGridView partnerDataGrid;
        private System.Windows.Forms.TextBox partnerNameTextBox;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.BindingSource partnerDataBindingSource;
        private System.Windows.Forms.TextBox partnerIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerReturnDataBindingSource;
    }
}
