namespace TextileEngineeringVirtualLaboratory
{
    partial class MainMenu
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
            this.newTextileButton = new System.Windows.Forms.Button();
            this.textileModelControls = new System.Windows.Forms.Panel();
            this.textileViewEditHintLabel = new System.Windows.Forms.Label();
            this.textileViewer = new System.Windows.Forms.PictureBox();
            this.resultsWindow = new System.Windows.Forms.PictureBox();
            this.textileModelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textileViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // newTextileButton
            // 
            this.newTextileButton.Location = new System.Drawing.Point(11, 12);
            this.newTextileButton.Name = "newTextileButton";
            this.newTextileButton.Size = new System.Drawing.Size(105, 23);
            this.newTextileButton.TabIndex = 0;
            this.newTextileButton.Text = "New Textile";
            this.newTextileButton.UseVisualStyleBackColor = true;
            this.newTextileButton.Click += new System.EventHandler(this.newWeaveButton_Click);
            // 
            // textileModelControls
            // 
            this.textileModelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textileModelControls.Controls.Add(this.newTextileButton);
            this.textileModelControls.Controls.Add(this.textileViewEditHintLabel);
            this.textileModelControls.Controls.Add(this.textileViewer);
            this.textileModelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.textileModelControls.Location = new System.Drawing.Point(0, 0);
            this.textileModelControls.Name = "textileModelControls";
            this.textileModelControls.Size = new System.Drawing.Size(133, 477);
            this.textileModelControls.TabIndex = 1;
            // 
            // textileViewEditHintLabel
            // 
            this.textileViewEditHintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textileViewEditHintLabel.AutoSize = true;
            this.textileViewEditHintLabel.Enabled = false;
            this.textileViewEditHintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textileViewEditHintLabel.Location = new System.Drawing.Point(8, 348);
            this.textileViewEditHintLabel.Name = "textileViewEditHintLabel";
            this.textileViewEditHintLabel.Size = new System.Drawing.Size(110, 13);
            this.textileViewEditHintLabel.TabIndex = 13;
            this.textileViewEditHintLabel.Text = "Click to edit the textile";
            // 
            // textileViewer
            // 
            this.textileViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textileViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textileViewer.Enabled = false;
            this.textileViewer.Location = new System.Drawing.Point(11, 364);
            this.textileViewer.Name = "textileViewer";
            this.textileViewer.Size = new System.Drawing.Size(105, 100);
            this.textileViewer.TabIndex = 4;
            this.textileViewer.TabStop = false;
            this.textileViewer.Click += new System.EventHandler(this.textileViewer_Click);
            // 
            // resultsWindow
            // 
            this.resultsWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsWindow.Location = new System.Drawing.Point(133, 0);
            this.resultsWindow.Name = "resultsWindow";
            this.resultsWindow.Size = new System.Drawing.Size(716, 477);
            this.resultsWindow.TabIndex = 3;
            this.resultsWindow.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.resultsWindow);
            this.Controls.Add(this.textileModelControls);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.textileModelControls.ResumeLayout(false);
            this.textileModelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textileViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTextileButton;
        private System.Windows.Forms.Panel textileModelControls;
        private System.Windows.Forms.PictureBox textileViewer;
        private System.Windows.Forms.Label textileViewEditHintLabel;
        private System.Windows.Forms.PictureBox resultsWindow;
    }
}