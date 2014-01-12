namespace PDATestProject
{
    partial class DefaultParametersControl
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
            this.terminalLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.offlineLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.terminalTextBox = new System.Windows.Forms.TextBox();
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.offlineComboBox = new System.Windows.Forms.ComboBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // terminalLabel
            // 
            this.terminalLabel.AutoSize = true;
            this.terminalLabel.Location = new System.Drawing.Point(20, 23);
            this.terminalLabel.Name = "terminalLabel";
            this.terminalLabel.Size = new System.Drawing.Size(100, 13);
            this.terminalLabel.TabIndex = 0;
            this.terminalLabel.Text = "Terminál azonosító:";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(158, 23);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(113, 13);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "Tranzakció azonosító:";
            // 
            // offlineLabel
            // 
            this.offlineLabel.AutoSize = true;
            this.offlineLabel.Location = new System.Drawing.Point(296, 23);
            this.offlineLabel.Name = "offlineLabel";
            this.offlineLabel.Size = new System.Drawing.Size(60, 13);
            this.offlineLabel.TabIndex = 2;
            this.offlineLabel.Text = "Offline mód";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(423, 23);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(57, 13);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Nyelvi kód";
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.Location = new System.Drawing.Point(23, 37);
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.Size = new System.Drawing.Size(132, 20);
            this.terminalTextBox.TabIndex = 4;
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.Location = new System.Drawing.Point(161, 38);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(132, 20);
            this.transactionTextBox.TabIndex = 5;
            // 
            // offlineComboBox
            // 
            this.offlineComboBox.FormattingEnabled = true;
            this.offlineComboBox.Location = new System.Drawing.Point(299, 37);
            this.offlineComboBox.Name = "offlineComboBox";
            this.offlineComboBox.Size = new System.Drawing.Size(121, 21);
            this.offlineComboBox.TabIndex = 6;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(426, 37);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageComboBox.TabIndex = 7;
            // 
            // DefaultParametersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.offlineComboBox);
            this.Controls.Add(this.transactionTextBox);
            this.Controls.Add(this.terminalTextBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.offlineLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.terminalLabel);
            this.Name = "DefaultParametersControl";
            this.Size = new System.Drawing.Size(640, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label terminalLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label offlineLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox terminalTextBox;
        private System.Windows.Forms.TextBox transactionTextBox;
        private System.Windows.Forms.ComboBox offlineComboBox;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}
