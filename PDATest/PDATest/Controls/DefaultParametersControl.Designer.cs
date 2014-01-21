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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultParametersControl));
            this.terminalLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.offlineLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.terminalTextBox = new System.Windows.Forms.TextBox();
            this.defaultDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.offlineComboBox = new System.Windows.Forms.ComboBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataBindingSource)).BeginInit();
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
            this.transactionLabel.Location = new System.Drawing.Point(123, 23);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(113, 13);
            this.transactionLabel.TabIndex = 1;
            this.transactionLabel.Text = "Tranzakció azonosító:";
            // 
            // offlineLabel
            // 
            this.offlineLabel.AutoSize = true;
            this.offlineLabel.Location = new System.Drawing.Point(263, 23);
            this.offlineLabel.Name = "offlineLabel";
            this.offlineLabel.Size = new System.Drawing.Size(37, 13);
            this.offlineLabel.TabIndex = 2;
            this.offlineLabel.Text = "Offline";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(460, 23);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(57, 13);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "Nyelvi kód";
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defaultDataBindingSource, "terminalId", true));
            this.terminalTextBox.Location = new System.Drawing.Point(23, 37);
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.Size = new System.Drawing.Size(97, 20);
            this.terminalTextBox.TabIndex = 4;
            // 
            // defaultDataBindingSource
            // 
            this.defaultDataBindingSource.DataSource = typeof(PDATestProject.Models.DefaultModel);
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.defaultDataBindingSource, "transactionId", true));
            this.transactionTextBox.Location = new System.Drawing.Point(126, 37);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(110, 20);
            this.transactionTextBox.TabIndex = 5;
            // 
            // offlineComboBox
            // 
            this.offlineComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.defaultDataBindingSource, "offline", true));
            this.offlineComboBox.FormattingEnabled = true;
            this.offlineComboBox.Items.AddRange(new object[] {
            "Igen",
            "Nem"});
            this.offlineComboBox.Location = new System.Drawing.Point(263, 36);
            this.offlineComboBox.Name = "offlineComboBox";
            this.offlineComboBox.Size = new System.Drawing.Size(57, 21);
            this.offlineComboBox.TabIndex = 6;
            // 
            // languageComboBox
            // 
            this.languageComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.defaultDataBindingSource, "languageCode", true));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "EN",
            "HU",
            "FR",
            "NL"});
            this.languageComboBox.Location = new System.Drawing.Point(463, 37);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(84, 21);
            this.languageComboBox.TabIndex = 7;
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(233, 35);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 23);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.defaultDataBindingSource, "createDate", true));
            this.createdDateTimePicker.Location = new System.Drawing.Point(326, 37);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.createdDateTimePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Létrehozás ideje";
            // 
            // DefaultParametersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.offlineComboBox);
            this.Controls.Add(this.transactionTextBox);
            this.Controls.Add(this.terminalTextBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.offlineLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.terminalLabel);
            this.Name = "DefaultParametersControl";
            this.Size = new System.Drawing.Size(640, 82);
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource defaultDataBindingSource;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}
