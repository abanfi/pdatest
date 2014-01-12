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
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.postReturnButton = new System.Windows.Forms.Button();
            this.findParcelForReturnButton = new System.Windows.Forms.Button();
            this.bagBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(519, 166);
            this.dataGridView.TabIndex = 40;
            // 
            // postReturnButton
            // 
            this.postReturnButton.Location = new System.Drawing.Point(417, 131);
            this.postReturnButton.Name = "postReturnButton";
            this.postReturnButton.Size = new System.Drawing.Size(129, 23);
            this.postReturnButton.TabIndex = 38;
            this.postReturnButton.Text = "PostReturn";
            this.postReturnButton.UseVisualStyleBackColor = true;
            // 
            // findParcelForReturnButton
            // 
            this.findParcelForReturnButton.Location = new System.Drawing.Point(417, 102);
            this.findParcelForReturnButton.Name = "findParcelForReturnButton";
            this.findParcelForReturnButton.Size = new System.Drawing.Size(129, 23);
            this.findParcelForReturnButton.TabIndex = 36;
            this.findParcelForReturnButton.Text = "FindParcelForReturn";
            this.findParcelForReturnButton.UseVisualStyleBackColor = true;
            // 
            // bagBarcodeTextBox
            // 
            this.bagBarcodeTextBox.Location = new System.Drawing.Point(273, 131);
            this.bagBarcodeTextBox.Name = "bagBarcodeTextBox";
            this.bagBarcodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.bagBarcodeTextBox.TabIndex = 29;
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
            // ReturnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.postReturnButton);
            this.Controls.Add(this.findParcelForReturnButton);
            this.Controls.Add(this.bagBarcodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultParametersControl1);
            this.Name = "ReturnControl";
            this.Size = new System.Drawing.Size(558, 339);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}
