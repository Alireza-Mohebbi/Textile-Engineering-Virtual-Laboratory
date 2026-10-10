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
            this.textilePropertiesButton = new System.Windows.Forms.Button();
            this.textileViewEditHintLabel = new System.Windows.Forms.Label();
            this.textileViewer = new System.Windows.Forms.PictureBox();
            this.resultsWindow = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fabricParametersTabPage = new System.Windows.Forms.TabPage();
            this.calculateButton = new System.Windows.Forms.Button();
            this.fabricParameterTypeLabel = new System.Windows.Forms.Label();
            this.fabricParameterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.simulationTabPage = new System.Windows.Forms.TabPage();
            this.simulateButton = new System.Windows.Forms.Button();
            this.simulationTypeLabel = new System.Windows.Forms.Label();
            this.simulationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.plotTabPage = new System.Windows.Forms.TabPage();
            this.plotButton = new System.Windows.Forms.Button();
            this.plotTypeLabel = new System.Windows.Forms.Label();
            this.plotInputsGroupBox = new System.Windows.Forms.GroupBox();
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            this.input3 = new System.Windows.Forms.NumericUpDown();
            this.input4 = new System.Windows.Forms.NumericUpDown();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputLabel4 = new System.Windows.Forms.Label();
            this.plotTypeComboBox = new System.Windows.Forms.ComboBox();
            this.textileModelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textileViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).BeginInit();
            this.tabControl.SuspendLayout();
            this.fabricParametersTabPage.SuspendLayout();
            this.simulationTabPage.SuspendLayout();
            this.plotTabPage.SuspendLayout();
            this.plotInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
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
            this.textileModelControls.Controls.Add(this.textilePropertiesButton);
            this.textileModelControls.Controls.Add(this.textileViewEditHintLabel);
            this.textileModelControls.Controls.Add(this.textileViewer);
            this.textileModelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.textileModelControls.Location = new System.Drawing.Point(0, 0);
            this.textileModelControls.Name = "textileModelControls";
            this.textileModelControls.Size = new System.Drawing.Size(133, 477);
            this.textileModelControls.TabIndex = 1;
            // 
            // textilePropertiesButton
            // 
            this.textilePropertiesButton.Enabled = false;
            this.textilePropertiesButton.Location = new System.Drawing.Point(11, 41);
            this.textilePropertiesButton.Name = "textilePropertiesButton";
            this.textilePropertiesButton.Size = new System.Drawing.Size(105, 23);
            this.textilePropertiesButton.TabIndex = 2;
            this.textilePropertiesButton.Text = "Properties";
            this.textilePropertiesButton.UseVisualStyleBackColor = true;
            this.textilePropertiesButton.Click += new System.EventHandler(this.weavePropertiesButton_Click);
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
            this.tabControl.Controls.Add(this.simulationTabPage);
            this.tabControl.Controls.Add(this.plotTabPage);
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
            "Areal Weight"});
            this.fabricParameterTypeComboBox.Location = new System.Drawing.Point(6, 48);
            this.fabricParameterTypeComboBox.Name = "fabricParameterTypeComboBox";
            this.fabricParameterTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.fabricParameterTypeComboBox.TabIndex = 7;
            this.fabricParameterTypeComboBox.Tag = "";
            // 
            // simulationTabPage
            // 
            this.simulationTabPage.Controls.Add(this.simulateButton);
            this.simulationTabPage.Controls.Add(this.simulationTypeLabel);
            this.simulationTabPage.Controls.Add(this.simulationTypeComboBox);
            this.simulationTabPage.Location = new System.Drawing.Point(4, 22);
            this.simulationTabPage.Name = "simulationTabPage";
            this.simulationTabPage.Size = new System.Drawing.Size(309, 451);
            this.simulationTabPage.TabIndex = 2;
            this.simulationTabPage.Text = "Simulation";
            this.simulationTabPage.UseVisualStyleBackColor = true;
            // 
            // simulateButton
            // 
            this.simulateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simulateButton.Location = new System.Drawing.Point(6, 413);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(295, 30);
            this.simulateButton.TabIndex = 8;
            this.simulateButton.Text = "Simulate";
            this.simulateButton.UseVisualStyleBackColor = true;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // simulationTypeLabel
            // 
            this.simulationTypeLabel.AutoSize = true;
            this.simulationTypeLabel.Location = new System.Drawing.Point(6, 33);
            this.simulationTypeLabel.Name = "simulationTypeLabel";
            this.simulationTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.simulationTypeLabel.TabIndex = 9;
            this.simulationTypeLabel.Text = "Select a parameter";
            // 
            // simulationTypeComboBox
            // 
            this.simulationTypeComboBox.DisplayMember = "iii";
            this.simulationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.simulationTypeComboBox.FormattingEnabled = true;
            this.simulationTypeComboBox.Items.AddRange(new object[] {
            "Drape 2D"});
            this.simulationTypeComboBox.Location = new System.Drawing.Point(6, 48);
            this.simulationTypeComboBox.Name = "simulationTypeComboBox";
            this.simulationTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.simulationTypeComboBox.TabIndex = 7;
            this.simulationTypeComboBox.Tag = "";
            // 
            // plotTabPage
            // 
            this.plotTabPage.Controls.Add(this.plotButton);
            this.plotTabPage.Controls.Add(this.plotTypeLabel);
            this.plotTabPage.Controls.Add(this.plotInputsGroupBox);
            this.plotTabPage.Controls.Add(this.plotTypeComboBox);
            this.plotTabPage.Location = new System.Drawing.Point(4, 22);
            this.plotTabPage.Name = "plotTabPage";
            this.plotTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.plotTabPage.Size = new System.Drawing.Size(309, 451);
            this.plotTabPage.TabIndex = 0;
            this.plotTabPage.Text = "Plot";
            this.plotTabPage.UseVisualStyleBackColor = true;
            // 
            // plotButton
            // 
            this.plotButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plotButton.Location = new System.Drawing.Point(6, 413);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(295, 30);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // plotTypeLabel
            // 
            this.plotTypeLabel.AutoSize = true;
            this.plotTypeLabel.Location = new System.Drawing.Point(6, 33);
            this.plotTypeLabel.Name = "plotTypeLabel";
            this.plotTypeLabel.Size = new System.Drawing.Size(66, 13);
            this.plotTypeLabel.TabIndex = 5;
            this.plotTypeLabel.Text = "Select a plot";
            // 
            // plotInputsGroupBox
            // 
            this.plotInputsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.plotInputsGroupBox.Controls.Add(this.input1);
            this.plotInputsGroupBox.Controls.Add(this.input2);
            this.plotInputsGroupBox.Controls.Add(this.input3);
            this.plotInputsGroupBox.Controls.Add(this.input4);
            this.plotInputsGroupBox.Controls.Add(this.inputLabel1);
            this.plotInputsGroupBox.Controls.Add(this.inputLabel2);
            this.plotInputsGroupBox.Controls.Add(this.inputLabel3);
            this.plotInputsGroupBox.Controls.Add(this.inputLabel4);
            this.plotInputsGroupBox.Location = new System.Drawing.Point(6, 86);
            this.plotInputsGroupBox.Name = "plotInputsGroupBox";
            this.plotInputsGroupBox.Size = new System.Drawing.Size(295, 321);
            this.plotInputsGroupBox.TabIndex = 6;
            this.plotInputsGroupBox.TabStop = false;
            this.plotInputsGroupBox.Text = "Inputs";
            // 
            // input1
            // 
            this.input1.DecimalPlaces = 5;
            this.input1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input1.Location = new System.Drawing.Point(209, 28);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(86, 20);
            this.input1.TabIndex = 13;
            // 
            // input2
            // 
            this.input2.DecimalPlaces = 5;
            this.input2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input2.Location = new System.Drawing.Point(209, 54);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(86, 20);
            this.input2.TabIndex = 16;
            // 
            // input3
            // 
            this.input3.DecimalPlaces = 5;
            this.input3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input3.Location = new System.Drawing.Point(209, 80);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(86, 20);
            this.input3.TabIndex = 17;
            // 
            // input4
            // 
            this.input4.DecimalPlaces = 5;
            this.input4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input4.Location = new System.Drawing.Point(209, 106);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(86, 20);
            this.input4.TabIndex = 20;
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(0, 35);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(40, 13);
            this.inputLabel1.TabIndex = 14;
            this.inputLabel1.Text = "Input 1";
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(0, 61);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(40, 13);
            this.inputLabel2.TabIndex = 18;
            this.inputLabel2.Text = "Input 2";
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(0, 87);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(40, 13);
            this.inputLabel3.TabIndex = 15;
            this.inputLabel3.Text = "Input 3";
            // 
            // inputLabel4
            // 
            this.inputLabel4.AutoSize = true;
            this.inputLabel4.Location = new System.Drawing.Point(0, 113);
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Size = new System.Drawing.Size(40, 13);
            this.inputLabel4.TabIndex = 19;
            this.inputLabel4.Text = "Input 4";
            // 
            // plotTypeComboBox
            // 
            this.plotTypeComboBox.DisplayMember = "iii";
            this.plotTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plotTypeComboBox.FormattingEnabled = true;
            this.plotTypeComboBox.Items.AddRange(new object[] {
            "Stress-Strain Curve",
            "Bending Moment-Curvature Curve",
            "Shear Stiffness Curve"});
            this.plotTypeComboBox.Location = new System.Drawing.Point(6, 49);
            this.plotTypeComboBox.Name = "plotTypeComboBox";
            this.plotTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.plotTypeComboBox.TabIndex = 3;
            this.plotTypeComboBox.Tag = "";
            this.plotTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.plotTypeComboBox_SelectedIndexChanged);
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
            this.simulationTabPage.ResumeLayout(false);
            this.simulationTabPage.PerformLayout();
            this.plotTabPage.ResumeLayout(false);
            this.plotTabPage.PerformLayout();
            this.plotInputsGroupBox.ResumeLayout(false);
            this.plotInputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newTextileButton;
        private System.Windows.Forms.Panel textileModelControls;
        private System.Windows.Forms.PictureBox textileViewer;
        private System.Windows.Forms.Button textilePropertiesButton;
        private System.Windows.Forms.Label textileViewEditHintLabel;
        private System.Windows.Forms.PictureBox resultsWindow;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fabricParametersTabPage;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TabPage plotTabPage;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label plotTypeLabel;
        private System.Windows.Forms.GroupBox plotInputsGroupBox;
        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.NumericUpDown input2;
        private System.Windows.Forms.NumericUpDown input3;
        private System.Windows.Forms.NumericUpDown input4;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.Label inputLabel4;
        private System.Windows.Forms.ComboBox plotTypeComboBox;
        private System.Windows.Forms.TabPage simulationTabPage;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.Label simulationTypeLabel;
        private System.Windows.Forms.ComboBox simulationTypeComboBox;
        private System.Windows.Forms.Label fabricParameterTypeLabel;
        private System.Windows.Forms.ComboBox fabricParameterTypeComboBox;
    }
}