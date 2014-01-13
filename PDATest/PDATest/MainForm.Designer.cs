namespace PDATestProject
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.packageButton = new System.Windows.Forms.ToolStripButton();
            this.masterDataButton = new System.Windows.Forms.ToolStripButton();
            this.partnerButton = new System.Windows.Forms.ToolStripButton();
            this.holidayButton = new System.Windows.Forms.ToolStripButton();
            this.openingHoursButton = new System.Windows.Forms.ToolStripButton();
            this.deliveryButton = new System.Windows.Forms.ToolStripButton();
            this.preRegButton = new System.Windows.Forms.ToolStripButton();
            this.returnButton = new System.Windows.Forms.ToolStripButton();
            this.receiveButton = new System.Windows.Forms.ToolStripButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 523);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1147, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageButton,
            this.masterDataButton,
            this.partnerButton,
            this.holidayButton,
            this.openingHoursButton,
            this.deliveryButton,
            this.preRegButton,
            this.returnButton,
            this.receiveButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(1147, 38);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // packageButton
            // 
            this.packageButton.Image = ((System.Drawing.Image)(resources.GetObject("packageButton.Image")));
            this.packageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.packageButton.Name = "packageButton";
            this.packageButton.Size = new System.Drawing.Size(55, 35);
            this.packageButton.Text = "Csomag";
            this.packageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.packageButton.Click += new System.EventHandler(this.packageButton_Click);
            // 
            // masterDataButton
            // 
            this.masterDataButton.Image = ((System.Drawing.Image)(resources.GetObject("masterDataButton.Image")));
            this.masterDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.masterDataButton.Name = "masterDataButton";
            this.masterDataButton.Size = new System.Drawing.Size(39, 35);
            this.masterDataButton.Text = "Törzs";
            this.masterDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.masterDataButton.Click += new System.EventHandler(this.masterDataButton_Click);
            // 
            // partnerButton
            // 
            this.partnerButton.Image = ((System.Drawing.Image)(resources.GetObject("partnerButton.Image")));
            this.partnerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.partnerButton.Name = "partnerButton";
            this.partnerButton.Size = new System.Drawing.Size(49, 35);
            this.partnerButton.Text = "Partner";
            this.partnerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.partnerButton.Click += new System.EventHandler(this.partnerButton_Click);
            // 
            // holidayButton
            // 
            this.holidayButton.Image = ((System.Drawing.Image)(resources.GetObject("holidayButton.Image")));
            this.holidayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.holidayButton.Name = "holidayButton";
            this.holidayButton.Size = new System.Drawing.Size(66, 35);
            this.holidayButton.Text = "Szabadság";
            this.holidayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.holidayButton.Click += new System.EventHandler(this.holidayButton_Click);
            // 
            // openingHoursButton
            // 
            this.openingHoursButton.Image = ((System.Drawing.Image)(resources.GetObject("openingHoursButton.Image")));
            this.openingHoursButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openingHoursButton.Name = "openingHoursButton";
            this.openingHoursButton.Size = new System.Drawing.Size(74, 35);
            this.openingHoursButton.Text = "Nyitvatartás";
            this.openingHoursButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openingHoursButton.Click += new System.EventHandler(this.openingHoursButton_Click);
            // 
            // deliveryButton
            // 
            this.deliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("deliveryButton.Image")));
            this.deliveryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(79, 35);
            this.deliveryButton.Text = "Vevői pickup";
            this.deliveryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deliveryButton.Click += new System.EventHandler(this.deliveryButton_Click);
            // 
            // preRegButton
            // 
            this.preRegButton.Image = ((System.Drawing.Image)(resources.GetObject("preRegButton.Image")));
            this.preRegButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.preRegButton.Name = "preRegButton";
            this.preRegButton.Size = new System.Drawing.Size(83, 35);
            this.preRegButton.Text = "Vevői dropoff";
            this.preRegButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.preRegButton.Click += new System.EventHandler(this.preRegButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(53, 35);
            this.returnButton.Text = "Visszáru";
            this.returnButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // receiveButton
            // 
            this.receiveButton.Image = ((System.Drawing.Image)(resources.GetObject("receiveButton.Image")));
            this.receiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(63, 35);
            this.receiveButton.Text = "Érkeztetés";
            this.receiveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.receiveButton.Click += new System.EventHandler(this.receiveButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 38);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1147, 485);
            this.contentPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 545);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "PDA Teszt";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton packageButton;
        private System.Windows.Forms.ToolStripButton masterDataButton;
        private System.Windows.Forms.ToolStripButton partnerButton;
        private System.Windows.Forms.ToolStripButton holidayButton;
        private System.Windows.Forms.ToolStripButton openingHoursButton;
        private System.Windows.Forms.ToolStripButton deliveryButton;
        private System.Windows.Forms.ToolStripButton returnButton;
        private System.Windows.Forms.ToolStripButton receiveButton;
        private System.Windows.Forms.ToolStripButton preRegButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}

