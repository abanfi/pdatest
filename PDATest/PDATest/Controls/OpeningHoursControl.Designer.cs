namespace PDATestProject
{
    partial class OpeningHoursControl
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
            this.mondayLabel = new System.Windows.Forms.Label();
            this.mondayFirstTextBox = new System.Windows.Forms.TextBox();
            this.openingHoursDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mondaySecondTextBox = new System.Windows.Forms.TextBox();
            this.tuesdaySecondTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayFirstTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.wednesdaySecondTextBox = new System.Windows.Forms.TextBox();
            this.wednesdayFirstTextBox = new System.Windows.Forms.TextBox();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.thursdaySecondTextBox = new System.Windows.Forms.TextBox();
            this.thursdayFirstTextBox = new System.Windows.Forms.TextBox();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridaySecondTextBox = new System.Windows.Forms.TextBox();
            this.fridayFirstTextBox = new System.Windows.Forms.TextBox();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.saturdaySecondTextBox = new System.Windows.Forms.TextBox();
            this.saturdayFirstTextBox = new System.Windows.Forms.TextBox();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.sundaySecondTextBox = new System.Windows.Forms.TextBox();
            this.sundayFirstTextBox = new System.Windows.Forms.TextBox();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.setOpeningHoursButton = new System.Windows.Forms.Button();
            this.getOpeningHoursButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resultMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openingHoursDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultParametersControl1
            // 
            this.defaultParametersControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.defaultParametersControl1.Location = new System.Drawing.Point(0, 0);
            this.defaultParametersControl1.Name = "defaultParametersControl1";
            this.defaultParametersControl1.Size = new System.Drawing.Size(888, 70);
            this.defaultParametersControl1.TabIndex = 0;
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(19, 110);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(45, 13);
            this.mondayLabel.TabIndex = 1;
            this.mondayLabel.Text = "Monday";
            // 
            // mondayFirstTextBox
            // 
            this.mondayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "mondayFirts", true));
            this.mondayFirstTextBox.Location = new System.Drawing.Point(22, 127);
            this.mondayFirstTextBox.Name = "mondayFirstTextBox";
            this.mondayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.mondayFirstTextBox.TabIndex = 2;
            // 
            // openingHoursDataBindingSource
            // 
            this.openingHoursDataBindingSource.DataSource = typeof(PDATestProject.OpeningHoursData);
            // 
            // mondaySecondTextBox
            // 
            this.mondaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "mondaySecond", true));
            this.mondaySecondTextBox.Location = new System.Drawing.Point(22, 153);
            this.mondaySecondTextBox.Name = "mondaySecondTextBox";
            this.mondaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.mondaySecondTextBox.TabIndex = 3;
            // 
            // tuesdaySecondTextBox
            // 
            this.tuesdaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "tuesdaySecond", true));
            this.tuesdaySecondTextBox.Location = new System.Drawing.Point(114, 153);
            this.tuesdaySecondTextBox.Name = "tuesdaySecondTextBox";
            this.tuesdaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.tuesdaySecondTextBox.TabIndex = 6;
            // 
            // tuesdayFirstTextBox
            // 
            this.tuesdayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "tuesdayFirts", true));
            this.tuesdayFirstTextBox.Location = new System.Drawing.Point(114, 127);
            this.tuesdayFirstTextBox.Name = "tuesdayFirstTextBox";
            this.tuesdayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.tuesdayFirstTextBox.TabIndex = 5;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(111, 110);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.tuesdayLabel.TabIndex = 4;
            this.tuesdayLabel.Text = "Tuesday";
            // 
            // wednesdaySecondTextBox
            // 
            this.wednesdaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "wednesdaySecond", true));
            this.wednesdaySecondTextBox.Location = new System.Drawing.Point(206, 153);
            this.wednesdaySecondTextBox.Name = "wednesdaySecondTextBox";
            this.wednesdaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.wednesdaySecondTextBox.TabIndex = 9;
            // 
            // wednesdayFirstTextBox
            // 
            this.wednesdayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "wednesdayFirts", true));
            this.wednesdayFirstTextBox.Location = new System.Drawing.Point(206, 127);
            this.wednesdayFirstTextBox.Name = "wednesdayFirstTextBox";
            this.wednesdayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.wednesdayFirstTextBox.TabIndex = 8;
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Location = new System.Drawing.Point(203, 110);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(64, 13);
            this.wednesdayLabel.TabIndex = 7;
            this.wednesdayLabel.Text = "Wednesday";
            // 
            // thursdaySecondTextBox
            // 
            this.thursdaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "thursdaySecond", true));
            this.thursdaySecondTextBox.Location = new System.Drawing.Point(298, 153);
            this.thursdaySecondTextBox.Name = "thursdaySecondTextBox";
            this.thursdaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.thursdaySecondTextBox.TabIndex = 12;
            // 
            // thursdayFirstTextBox
            // 
            this.thursdayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "thursdayFirts", true));
            this.thursdayFirstTextBox.Location = new System.Drawing.Point(298, 127);
            this.thursdayFirstTextBox.Name = "thursdayFirstTextBox";
            this.thursdayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.thursdayFirstTextBox.TabIndex = 11;
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Location = new System.Drawing.Point(295, 110);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(51, 13);
            this.thursdayLabel.TabIndex = 10;
            this.thursdayLabel.Text = "Thursday";
            // 
            // fridaySecondTextBox
            // 
            this.fridaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "fridaySecond", true));
            this.fridaySecondTextBox.Location = new System.Drawing.Point(387, 153);
            this.fridaySecondTextBox.Name = "fridaySecondTextBox";
            this.fridaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.fridaySecondTextBox.TabIndex = 15;
            // 
            // fridayFirstTextBox
            // 
            this.fridayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "fridayFirts", true));
            this.fridayFirstTextBox.Location = new System.Drawing.Point(387, 127);
            this.fridayFirstTextBox.Name = "fridayFirstTextBox";
            this.fridayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.fridayFirstTextBox.TabIndex = 14;
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(384, 110);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(35, 13);
            this.fridayLabel.TabIndex = 13;
            this.fridayLabel.Text = "Friday";
            // 
            // saturdaySecondTextBox
            // 
            this.saturdaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "saturdaySecond", true));
            this.saturdaySecondTextBox.Location = new System.Drawing.Point(22, 225);
            this.saturdaySecondTextBox.Name = "saturdaySecondTextBox";
            this.saturdaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.saturdaySecondTextBox.TabIndex = 18;
            // 
            // saturdayFirstTextBox
            // 
            this.saturdayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "saturdayFirts", true));
            this.saturdayFirstTextBox.Location = new System.Drawing.Point(22, 199);
            this.saturdayFirstTextBox.Name = "saturdayFirstTextBox";
            this.saturdayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.saturdayFirstTextBox.TabIndex = 17;
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Location = new System.Drawing.Point(19, 182);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(49, 13);
            this.saturdayLabel.TabIndex = 16;
            this.saturdayLabel.Text = "Saturday";
            // 
            // sundaySecondTextBox
            // 
            this.sundaySecondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "sundaySecond", true));
            this.sundaySecondTextBox.Location = new System.Drawing.Point(114, 225);
            this.sundaySecondTextBox.Name = "sundaySecondTextBox";
            this.sundaySecondTextBox.Size = new System.Drawing.Size(86, 20);
            this.sundaySecondTextBox.TabIndex = 21;
            // 
            // sundayFirstTextBox
            // 
            this.sundayFirstTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.openingHoursDataBindingSource, "sundayFirts", true));
            this.sundayFirstTextBox.Location = new System.Drawing.Point(114, 198);
            this.sundayFirstTextBox.Name = "sundayFirstTextBox";
            this.sundayFirstTextBox.Size = new System.Drawing.Size(86, 20);
            this.sundayFirstTextBox.TabIndex = 20;
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Location = new System.Drawing.Point(111, 182);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(43, 13);
            this.sundayLabel.TabIndex = 19;
            this.sundayLabel.Text = "Sunday";
            // 
            // setOpeningHoursButton
            // 
            this.setOpeningHoursButton.Location = new System.Drawing.Point(441, 222);
            this.setOpeningHoursButton.Name = "setOpeningHoursButton";
            this.setOpeningHoursButton.Size = new System.Drawing.Size(108, 23);
            this.setOpeningHoursButton.TabIndex = 22;
            this.setOpeningHoursButton.Text = "SetOpeningHours";
            this.setOpeningHoursButton.UseVisualStyleBackColor = true;
            this.setOpeningHoursButton.Click += new System.EventHandler(this.setOpeningHoursButton_Click);
            // 
            // getOpeningHoursButton
            // 
            this.getOpeningHoursButton.Location = new System.Drawing.Point(441, 73);
            this.getOpeningHoursButton.Name = "getOpeningHoursButton";
            this.getOpeningHoursButton.Size = new System.Drawing.Size(108, 23);
            this.getOpeningHoursButton.TabIndex = 23;
            this.getOpeningHoursButton.Text = "GetOpeningHours";
            this.getOpeningHoursButton.UseVisualStyleBackColor = true;
            this.getOpeningHoursButton.Click += new System.EventHandler(this.getOpeningHoursButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Eredmény:";
            // 
            // resultMessageTextBox
            // 
            this.resultMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultMessageTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultMessageTextBox.Location = new System.Drawing.Point(570, 35);
            this.resultMessageTextBox.Multiline = true;
            this.resultMessageTextBox.Name = "resultMessageTextBox";
            this.resultMessageTextBox.ReadOnly = true;
            this.resultMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultMessageTextBox.Size = new System.Drawing.Size(296, 305);
            this.resultMessageTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Helyes formátum példa: 10:15-11:45";
            // 
            // OpeningHoursControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultMessageTextBox);
            this.Controls.Add(this.getOpeningHoursButton);
            this.Controls.Add(this.setOpeningHoursButton);
            this.Controls.Add(this.sundaySecondTextBox);
            this.Controls.Add(this.sundayFirstTextBox);
            this.Controls.Add(this.sundayLabel);
            this.Controls.Add(this.saturdaySecondTextBox);
            this.Controls.Add(this.saturdayFirstTextBox);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.fridaySecondTextBox);
            this.Controls.Add(this.fridayFirstTextBox);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.thursdaySecondTextBox);
            this.Controls.Add(this.thursdayFirstTextBox);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.wednesdaySecondTextBox);
            this.Controls.Add(this.wednesdayFirstTextBox);
            this.Controls.Add(this.wednesdayLabel);
            this.Controls.Add(this.tuesdaySecondTextBox);
            this.Controls.Add(this.tuesdayFirstTextBox);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.mondaySecondTextBox);
            this.Controls.Add(this.mondayFirstTextBox);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.defaultParametersControl1);
            this.Name = "OpeningHoursControl";
            this.Size = new System.Drawing.Size(888, 356);
            ((System.ComponentModel.ISupportInitialize)(this.openingHoursDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DefaultParametersControl defaultParametersControl1;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.TextBox mondayFirstTextBox;
        private System.Windows.Forms.TextBox mondaySecondTextBox;
        private System.Windows.Forms.TextBox tuesdaySecondTextBox;
        private System.Windows.Forms.TextBox tuesdayFirstTextBox;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.TextBox wednesdaySecondTextBox;
        private System.Windows.Forms.TextBox wednesdayFirstTextBox;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.TextBox thursdaySecondTextBox;
        private System.Windows.Forms.TextBox thursdayFirstTextBox;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.TextBox fridaySecondTextBox;
        private System.Windows.Forms.TextBox fridayFirstTextBox;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.TextBox saturdaySecondTextBox;
        private System.Windows.Forms.TextBox saturdayFirstTextBox;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.TextBox sundaySecondTextBox;
        private System.Windows.Forms.TextBox sundayFirstTextBox;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Button setOpeningHoursButton;
        private System.Windows.Forms.Button getOpeningHoursButton;
        private System.Windows.Forms.BindingSource openingHoursDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultMessageTextBox;
        private System.Windows.Forms.Label label1;
    }
}
