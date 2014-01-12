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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.postReceiveButton = new System.Windows.Forms.Button();
            this.findParcelForReceiveButton = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(30, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(519, 166);
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
            // 
            // findParcelForReceiveButton
            // 
            this.findParcelForReceiveButton.Location = new System.Drawing.Point(420, 102);
            this.findParcelForReceiveButton.Name = "findParcelForReceiveButton";
            this.findParcelForReceiveButton.Size = new System.Drawing.Size(129, 23);
            this.findParcelForReceiveButton.TabIndex = 45;
            this.findParcelForReceiveButton.Text = "FindParcelForReceive";
            this.findParcelForReceiveButton.UseVisualStyleBackColor = true;
            // 
            // barcodeTextBox
            // 
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
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(575, 96);
            this.defaultParametersControl1.TabIndex = 48;
            // 
            // ReceiveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.postReceiveButton);
            this.Controls.Add(this.findParcelForReceiveButton);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ReceiveControl";
            this.Size = new System.Drawing.Size(575, 342);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
    }
}
