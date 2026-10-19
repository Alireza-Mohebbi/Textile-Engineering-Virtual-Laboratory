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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fabricParametersTabPage = new System.Windows.Forms.TabPage();
            this.fabricParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.fabricParametersInput1 = new System.Windows.Forms.NumericUpDown();
            this.fabricParametersInput2 = new System.Windows.Forms.NumericUpDown();
            this.fabricParametersInputLabel1 = new System.Windows.Forms.Label();
            this.fabricParametersInputLabel2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.fabricParameterTypeLabel = new System.Windows.Forms.Label();
            this.fabricParameterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.textileModelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textileViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).BeginInit();
            this.tabControl.SuspendLayout();
            this.fabricParametersTabPage.SuspendLayout();
            this.fabricParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricParametersInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricParametersInput2)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.fabricParametersTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(532, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(317, 477);
            this.tabControl.TabIndex = 4;
            this.tabControl.Visible = false;
            // 
            // fabricParametersTabPage
            // 
            this.fabricParametersTabPage.Controls.Add(this.fabricParametersGroupBox);
            this.fabricParametersTabPage.Controls.Add(this.calculateButton);
            this.fabricParametersTabPage.Controls.Add(this.fabricParameterTypeLabel);
            this.fabricParametersTabPage.Controls.Add(this.fabricParameterTypeComboBox);
            this.fabricParametersTabPage.Location = new System.Drawing.Point(4, 22);
            this.fabricParametersTabPage.Name = "fabricParametersTabPage";
            this.fabricParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fabricParametersTabPage.Size = new System.Drawing.Size(309, 451);
            this.fabricParametersTabPage.TabIndex = 1;
            this.fabricParametersTabPage.Text = "Fabric Parameters";
            this.fabricParametersTabPage.UseVisualStyleBackColor = true;
            // 
            // fabricParametersGroupBox
            // 
            this.fabricParametersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fabricParametersGroupBox.Controls.Add(this.fabricParametersInput1);
            this.fabricParametersGroupBox.Controls.Add(this.fabricParametersInput2);
            this.fabricParametersGroupBox.Controls.Add(this.fabricParametersInputLabel1);
            this.fabricParametersGroupBox.Controls.Add(this.fabricParametersInputLabel2);
            this.fabricParametersGroupBox.Location = new System.Drawing.Point(6, 86);
            this.fabricParametersGroupBox.Name = "fabricParametersGroupBox";
            this.fabricParametersGroupBox.Size = new System.Drawing.Size(295, 321);
            this.fabricParametersGroupBox.TabIndex = 10;
            this.fabricParametersGroupBox.TabStop = false;
            this.fabricParametersGroupBox.Text = "Inputs";
            this.fabricParametersGroupBox.Visible = false;
            // 
            // fabricParametersInput1
            // 
            this.fabricParametersInput1.DecimalPlaces = 5;
            this.fabricParametersInput1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.fabricParametersInput1.Location = new System.Drawing.Point(209, 28);
            this.fabricParametersInput1.Name = "fabricParametersInput1";
            this.fabricParametersInput1.Size = new System.Drawing.Size(86, 20);
            this.fabricParametersInput1.TabIndex = 13;
            this.fabricParametersInput1.Visible = false;
            // 
            // fabricParametersInput2
            // 
            this.fabricParametersInput2.DecimalPlaces = 5;
            this.fabricParametersInput2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.fabricParametersInput2.Location = new System.Drawing.Point(209, 54);
            this.fabricParametersInput2.Name = "fabricParametersInput2";
            this.fabricParametersInput2.Size = new System.Drawing.Size(86, 20);
            this.fabricParametersInput2.TabIndex = 16;
            this.fabricParametersInput2.Visible = false;
            // 
            // fabricParametersInputLabel1
            // 
            this.fabricParametersInputLabel1.AutoSize = true;
            this.fabricParametersInputLabel1.Location = new System.Drawing.Point(0, 35);
            this.fabricParametersInputLabel1.Name = "fabricParametersInputLabel1";
            this.fabricParametersInputLabel1.Size = new System.Drawing.Size(40, 13);
            this.fabricParametersInputLabel1.TabIndex = 14;
            this.fabricParametersInputLabel1.Text = "Input 1";
            this.fabricParametersInputLabel1.Visible = false;
            // 
            // fabricParametersInputLabel2
            // 
            this.fabricParametersInputLabel2.AutoSize = true;
            this.fabricParametersInputLabel2.Location = new System.Drawing.Point(0, 61);
            this.fabricParametersInputLabel2.Name = "fabricParametersInputLabel2";
            this.fabricParametersInputLabel2.Size = new System.Drawing.Size(40, 13);
            this.fabricParametersInputLabel2.TabIndex = 18;
            this.fabricParametersInputLabel2.Text = "Input 2";
            this.fabricParametersInputLabel2.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.calculateButton.Location = new System.Drawing.Point(6, 413);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(295, 30);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // fabricParameterTypeLabel
            // 
            this.fabricParameterTypeLabel.AutoSize = true;
            this.fabricParameterTypeLabel.Location = new System.Drawing.Point(6, 33);
            this.fabricParameterTypeLabel.Name = "fabricParameterTypeLabel";
            this.fabricParameterTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.fabricParameterTypeLabel.TabIndex = 9;
            this.fabricParameterTypeLabel.Text = "Select a parameter";
            // 
            // fabricParameterTypeComboBox
            // 
            this.fabricParameterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricParameterTypeComboBox.FormattingEnabled = true;
            this.fabricParameterTypeComboBox.Items.AddRange(new object[] {
            "Fabric Thickness",
            "Crimp",
            "Porosity",
            "Cover Factor",
            "Areal Weight",
            "Required Yarn Length For Fabric"});
            this.fabricParameterTypeComboBox.Location = new System.Drawing.Point(6, 48);
            this.fabricParameterTypeComboBox.Name = "fabricParameterTypeComboBox";
            this.fabricParameterTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.fabricParameterTypeComboBox.TabIndex = 7;
            this.fabricParameterTypeComboBox.Tag = "";
            this.fabricParameterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fabricParameterTypeComboBox_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.tabControl);
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
            this.tabControl.ResumeLayout(false);
            this.fabricParametersTabPage.ResumeLayout(false);
            this.fabricParametersTabPage.PerformLayout();
            this.fabricParametersGroupBox.ResumeLayout(false);
            this.fabricParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fabricParametersInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricParametersInput2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTextileButton;
        private System.Windows.Forms.Panel textileModelControls;
        private System.Windows.Forms.PictureBox textileViewer;
        private System.Windows.Forms.Label textileViewEditHintLabel;
        private System.Windows.Forms.PictureBox resultsWindow;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fabricParametersTabPage;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label fabricParameterTypeLabel;
        private System.Windows.Forms.ComboBox fabricParameterTypeComboBox;
        private System.Windows.Forms.GroupBox fabricParametersGroupBox;
        private System.Windows.Forms.NumericUpDown fabricParametersInput1;
        private System.Windows.Forms.NumericUpDown fabricParametersInput2;
        private System.Windows.Forms.Label fabricParametersInputLabel1;
        private System.Windows.Forms.Label fabricParametersInputLabel2;
    }
}