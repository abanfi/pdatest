namespace PDATestProject
{
    partial class HolidayControl
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
            this.holiday1label = new System.Windows.Forms.Label();
            this.holiday1FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holidayDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holiday1ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.defaultParametersControl1 = new PDATestProject.DefaultParametersControl();
            this.holiday2ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday2FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday2label = new System.Windows.Forms.Label();
            this.holiday3ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday3FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday3label = new System.Windows.Forms.Label();
            this.holiday4ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday4FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.holiday4label = new System.Windows.Forms.Label();
            this.getHolidayButton = new System.Windows.Forms.Button();
            this.setHolidaysButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // holiday1label
            // 
            this.holiday1label.AutoSize = true;
            this.holiday1label.Location = new System.Drawing.Point(24, 99);
            this.holiday1label.Name = "holiday1label";
            this.holiday1label.Size = new System.Drawing.Size(51, 13);
            this.holiday1label.TabIndex = 0;
            this.holiday1label.Text = "Holiday 1";
            // 
            // holiday1FromDatePicker
            // 
            this.holiday1FromDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday1From", true));
            this.holiday1FromDatePicker.Location = new System.Drawing.Point(27, 115);
            this.holiday1FromDatePicker.Name = "holiday1FromDatePicker";
            this.holiday1FromDatePicker.ShowCheckBox = true;
            this.holiday1FromDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday1FromDatePicker.TabIndex = 1;
            // 
            // holidayDataBindingSource
            // 
            this.holidayDataBindingSource.DataSource = typeof(PDATestProject.HolidayData);
            // 
            // holiday1ToDatePicker
            // 
            this.holiday1ToDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday1To", true));
            this.holiday1ToDatePicker.Location = new System.Drawing.Point(27, 141);
            this.holiday1ToDatePicker.Name = "holiday1ToDatePicker";
            this.holiday1ToDatePicker.ShowCheckBox = true;
            this.holiday1ToDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday1ToDatePicker.TabIndex = 2;
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(626, 96);
            this.defaultParametersControl1.TabIndex = 3;
            // 
            // holiday2ToDatePicker
            // 
            this.holiday2ToDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday2To", true));
            this.holiday2ToDatePicker.Location = new System.Drawing.Point(172, 141);
            this.holiday2ToDatePicker.Name = "holiday2ToDatePicker";
            this.holiday2ToDatePicker.ShowCheckBox = true;
            this.holiday2ToDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday2ToDatePicker.TabIndex = 6;
            // 
            // holiday2FromDatePicker
            // 
            this.holiday2FromDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday2From", true));
            this.holiday2FromDatePicker.Location = new System.Drawing.Point(172, 115);
            this.holiday2FromDatePicker.Name = "holiday2FromDatePicker";
            this.holiday2FromDatePicker.ShowCheckBox = true;
            this.holiday2FromDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday2FromDatePicker.TabIndex = 5;
            // 
            // holiday2label
            // 
            this.holiday2label.AutoSize = true;
            this.holiday2label.Location = new System.Drawing.Point(169, 99);
            this.holiday2label.Name = "holiday2label";
            this.holiday2label.Size = new System.Drawing.Size(51, 13);
            this.holiday2label.TabIndex = 4;
            this.holiday2label.Text = "Holiday 2";
            // 
            // holiday3ToDatePicker
            // 
            this.holiday3ToDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday3To", true));
            this.holiday3ToDatePicker.Location = new System.Drawing.Point(317, 141);
            this.holiday3ToDatePicker.Name = "holiday3ToDatePicker";
            this.holiday3ToDatePicker.ShowCheckBox = true;
            this.holiday3ToDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday3ToDatePicker.TabIndex = 9;
            // 
            // holiday3FromDatePicker
            // 
            this.holiday3FromDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday3From", true));
            this.holiday3FromDatePicker.Location = new System.Drawing.Point(317, 115);
            this.holiday3FromDatePicker.Name = "holiday3FromDatePicker";
            this.holiday3FromDatePicker.ShowCheckBox = true;
            this.holiday3FromDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday3FromDatePicker.TabIndex = 8;
            // 
            // holiday3label
            // 
            this.holiday3label.AutoSize = true;
            this.holiday3label.Location = new System.Drawing.Point(314, 99);
            this.holiday3label.Name = "holiday3label";
            this.holiday3label.Size = new System.Drawing.Size(51, 13);
            this.holiday3label.TabIndex = 7;
            this.holiday3label.Text = "Holiday 3";
            // 
            // holiday4ToDatePicker
            // 
            this.holiday4ToDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday4To", true));
            this.holiday4ToDatePicker.Location = new System.Drawing.Point(462, 141);
            this.holiday4ToDatePicker.Name = "holiday4ToDatePicker";
            this.holiday4ToDatePicker.ShowCheckBox = true;
            this.holiday4ToDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday4ToDatePicker.TabIndex = 12;
            // 
            // holiday4FromDatePicker
            // 
            this.holiday4FromDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidayDataBindingSource, "holiday4From", true));
            this.holiday4FromDatePicker.Location = new System.Drawing.Point(462, 115);
            this.holiday4FromDatePicker.Name = "holiday4FromDatePicker";
            this.holiday4FromDatePicker.ShowCheckBox = true;
            this.holiday4FromDatePicker.Size = new System.Drawing.Size(139, 20);
            this.holiday4FromDatePicker.TabIndex = 11;
            // 
            // holiday4label
            // 
            this.holiday4label.AutoSize = true;
            this.holiday4label.Location = new System.Drawing.Point(459, 99);
            this.holiday4label.Name = "holiday4label";
            this.holiday4label.Size = new System.Drawing.Size(51, 13);
            this.holiday4label.TabIndex = 10;
            this.holiday4label.Text = "Holiday 4";
            // 
            // getHolidayButton
            // 
            this.getHolidayButton.Location = new System.Drawing.Point(382, 167);
            this.getHolidayButton.Name = "getHolidayButton";
            this.getHolidayButton.Size = new System.Drawing.Size(107, 23);
            this.getHolidayButton.TabIndex = 13;
            this.getHolidayButton.Text = "GetHolidays";
            this.getHolidayButton.UseVisualStyleBackColor = true;
            this.getHolidayButton.Click += new System.EventHandler(this.getHolidayButton_Click);
            // 
            // setHolidaysButton
            // 
            this.setHolidaysButton.Location = new System.Drawing.Point(495, 167);
            this.setHolidaysButton.Name = "setHolidaysButton";
            this.setHolidaysButton.Size = new System.Drawing.Size(106, 23);
            this.setHolidaysButton.TabIndex = 14;
            this.setHolidaysButton.Text = "SetHolidays";
            this.setHolidaysButton.UseVisualStyleBackColor = true;
            this.setHolidaysButton.Click += new System.EventHandler(this.setHolidaysButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultMessageTextBox.Location = new System.Drawing.Point(89, 196);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.Size = new System.Drawing.Size(512, 167);
            this.resultMessageTextBox.TabIndex = 26;
            // 
            // HolidayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.setHolidaysButton);
            this.Controls.Add(this.getHolidayButton);
            this.Controls.Add(this.holiday4ToDatePicker);
            this.Controls.Add(this.holiday4FromDatePicker);
            this.Controls.Add(this.holiday4label);
            this.Controls.Add(this.holiday3ToDatePicker);
            this.Controls.Add(this.holiday3FromDatePicker);
            this.Controls.Add(this.holiday3label);
            this.Controls.Add(this.holiday2ToDatePicker);
            this.Controls.Add(this.holiday2FromDatePicker);
            this.Controls.Add(this.holiday2label);
            this.Controls.Add(this.defaultParametersControl1);
            this.Controls.Add(this.holiday1ToDatePicker);
            this.Controls.Add(this.holiday1FromDatePicker);
            this.Controls.Add(this.holiday1label);
            this.Name = "HolidayControl";
            this.Size = new System.Drawing.Size(626, 379);
            ((System.ComponentModel.ISupportInitialize)(this.holidayDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label holiday1label;
        private System.Windows.Forms.DateTimePicker holiday1FromDatePicker;
        private System.Windows.Forms.DateTimePicker holiday1ToDatePicker;
        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.DateTimePicker holiday2ToDatePicker;
        private System.Windows.Forms.DateTimePicker holiday2FromDatePicker;
        private System.Windows.Forms.Label holiday2label;
        private System.Windows.Forms.DateTimePicker holiday3ToDatePicker;
        private System.Windows.Forms.DateTimePicker holiday3FromDatePicker;
        private System.Windows.Forms.Label holiday3label;
        private System.Windows.Forms.DateTimePicker holiday4ToDatePicker;
        private System.Windows.Forms.DateTimePicker holiday4FromDatePicker;
        private System.Windows.Forms.Label holiday4label;
        private System.Windows.Forms.Button getHolidayButton;
        private System.Windows.Forms.Button setHolidaysButton;
        private System.Windows.Forms.BindingSource holidayDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
    }
}
