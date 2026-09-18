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
            this.newWeaveButton = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Panel();
            this.weavePropertiesButton = new System.Windows.Forms.Button();
            this.weaveViewLabel = new System.Windows.Forms.Label();
            this.weaveViewer = new System.Windows.Forms.PictureBox();
            this.resultsWindow = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.calculateTabPage = new System.Windows.Forms.TabPage();
            this.calculateButton = new System.Windows.Forms.Button();
            this.simulateTabPage = new System.Windows.Forms.TabPage();
            this.simulateButton = new System.Windows.Forms.Button();
            this.simulationParameterTypeLabel = new System.Windows.Forms.Label();
            this.simulationParameterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculationParameterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculationParameterTypeLabel = new System.Windows.Forms.Label();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).BeginInit();
            this.tabControl.SuspendLayout();
            this.plotTabPage.SuspendLayout();
            this.plotInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
            this.calculateTabPage.SuspendLayout();
            this.simulateTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // newWeaveButton
            // 
            this.newWeaveButton.Location = new System.Drawing.Point(11, 12);
            this.newWeaveButton.Name = "newWeaveButton";
            this.newWeaveButton.Size = new System.Drawing.Size(105, 23);
            this.newWeaveButton.TabIndex = 0;
            this.newWeaveButton.Text = "New Weave";
            this.newWeaveButton.UseVisualStyleBackColor = true;
            this.newWeaveButton.Click += new System.EventHandler(this.newWeaveButton_Click);
            // 
            // controls
            // 
            this.controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controls.Controls.Add(this.newWeaveButton);
            this.controls.Controls.Add(this.weavePropertiesButton);
            this.controls.Controls.Add(this.weaveViewLabel);
            this.controls.Controls.Add(this.weaveViewer);
            this.controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.controls.Location = new System.Drawing.Point(0, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(133, 477);
            this.controls.TabIndex = 1;
            // 
            // weavePropertiesButton
            // 
            this.weavePropertiesButton.Enabled = false;
            this.weavePropertiesButton.Location = new System.Drawing.Point(11, 41);
            this.weavePropertiesButton.Name = "weavePropertiesButton";
            this.weavePropertiesButton.Size = new System.Drawing.Size(105, 23);
            this.weavePropertiesButton.TabIndex = 2;
            this.weavePropertiesButton.Text = "Properties";
            this.weavePropertiesButton.UseVisualStyleBackColor = true;
            this.weavePropertiesButton.Click += new System.EventHandler(this.weavePropertiesButton_Click);
            // 
            // weaveViewLabel
            // 
            this.weaveViewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weaveViewLabel.AutoSize = true;
            this.weaveViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaveViewLabel.Location = new System.Drawing.Point(24, 348);
            this.weaveViewLabel.Name = "weaveViewLabel";
            this.weaveViewLabel.Size = new System.Drawing.Size(77, 13);
            this.weaveViewLabel.TabIndex = 13;
            this.weaveViewLabel.Text = "Weave Viewer";
            // 
            // weaveViewer
            // 
            this.weaveViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weaveViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaveViewer.Location = new System.Drawing.Point(11, 364);
            this.weaveViewer.Name = "weaveViewer";
            this.weaveViewer.Size = new System.Drawing.Size(105, 100);
            this.weaveViewer.TabIndex = 4;
            this.weaveViewer.TabStop = false;
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
            this.tabControl.Controls.Add(this.calculateTabPage);
            this.tabControl.Controls.Add(this.simulateTabPage);
            this.tabControl.Controls.Add(this.plotTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(532, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(317, 477);
            this.tabControl.TabIndex = 4;
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
            this.inputLabel1.Location = new System.Drawing.Point(10, 35);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(40, 13);
            this.inputLabel1.TabIndex = 14;
            this.inputLabel1.Text = "Input 1";
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(10, 61);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(40, 13);
            this.inputLabel2.TabIndex = 18;
            this.inputLabel2.Text = "Input 2";
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(10, 87);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(40, 13);
            this.inputLabel3.TabIndex = 15;
            this.inputLabel3.Text = "Input 3";
            // 
            // inputLabel4
            // 
            this.inputLabel4.AutoSize = true;
            this.inputLabel4.Location = new System.Drawing.Point(10, 113);
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
            // calculateTabPage
            // 
            this.calculateTabPage.Controls.Add(this.calculateButton);
            this.calculateTabPage.Controls.Add(this.calculationParameterTypeLabel);
            this.calculateTabPage.Controls.Add(this.calculationParameterTypeComboBox);
            this.calculateTabPage.Location = new System.Drawing.Point(4, 22);
            this.calculateTabPage.Name = "calculateTabPage";
            this.calculateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.calculateTabPage.Size = new System.Drawing.Size(309, 451);
            this.calculateTabPage.TabIndex = 1;
            this.calculateTabPage.Text = "Calculate";
            this.calculateTabPage.UseVisualStyleBackColor = true;
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
            // simulateTabPage
            // 
            this.simulateTabPage.Controls.Add(this.simulateButton);
            this.simulateTabPage.Controls.Add(this.simulationParameterTypeLabel);
            this.simulateTabPage.Controls.Add(this.simulationParameterTypeComboBox);
            this.simulateTabPage.Location = new System.Drawing.Point(4, 22);
            this.simulateTabPage.Name = "simulateTabPage";
            this.simulateTabPage.Size = new System.Drawing.Size(309, 451);
            this.simulateTabPage.TabIndex = 2;
            this.simulateTabPage.Text = "Simulate";
            this.simulateTabPage.UseVisualStyleBackColor = true;
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
            // simulationParameterTypeLabel
            // 
            this.simulationParameterTypeLabel.AutoSize = true;
            this.simulationParameterTypeLabel.Location = new System.Drawing.Point(6, 33);
            this.simulationParameterTypeLabel.Name = "simulationParameterTypeLabel";
            this.simulationParameterTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.simulationParameterTypeLabel.TabIndex = 9;
            this.simulationParameterTypeLabel.Text = "Select a parameter";
            // 
            // simulationParameterTypeComboBox
            // 
            this.simulationParameterTypeComboBox.DisplayMember = "iii";
            this.simulationParameterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.simulationParameterTypeComboBox.FormattingEnabled = true;
            this.simulationParameterTypeComboBox.Items.AddRange(new object[] {
            "Drape 2D"});
            this.simulationParameterTypeComboBox.Location = new System.Drawing.Point(6, 48);
            this.simulationParameterTypeComboBox.Name = "simulationParameterTypeComboBox";
            this.simulationParameterTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.simulationParameterTypeComboBox.TabIndex = 7;
            this.simulationParameterTypeComboBox.Tag = "";
            // 
            // calculationParameterTypeComboBox
            // 
            this.calculationParameterTypeComboBox.DisplayMember = "iii";
            this.calculationParameterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculationParameterTypeComboBox.FormattingEnabled = true;
            this.calculationParameterTypeComboBox.Items.AddRange(new object[] {
            "Crimp"});
            this.calculationParameterTypeComboBox.Location = new System.Drawing.Point(6, 48);
            this.calculationParameterTypeComboBox.Name = "calculationParameterTypeComboBox";
            this.calculationParameterTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.calculationParameterTypeComboBox.TabIndex = 7;
            this.calculationParameterTypeComboBox.Tag = "";
            // 
            // calculationParameterTypeLabel
            // 
            this.calculationParameterTypeLabel.AutoSize = true;
            this.calculationParameterTypeLabel.Location = new System.Drawing.Point(6, 33);
            this.calculationParameterTypeLabel.Name = "calculationParameterTypeLabel";
            this.calculationParameterTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.calculationParameterTypeLabel.TabIndex = 9;
            this.calculationParameterTypeLabel.Text = "Select a parameter";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.resultsWindow);
            this.Controls.Add(this.controls);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsWindow)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.plotTabPage.ResumeLayout(false);
            this.plotTabPage.PerformLayout();
            this.plotInputsGroupBox.ResumeLayout(false);
            this.plotInputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
            this.calculateTabPage.ResumeLayout(false);
            this.calculateTabPage.PerformLayout();
            this.simulateTabPage.ResumeLayout(false);
            this.simulateTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newWeaveButton;
        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.PictureBox weaveViewer;
        private System.Windows.Forms.Button weavePropertiesButton;
        private System.Windows.Forms.Label weaveViewLabel;
        private System.Windows.Forms.PictureBox resultsWindow;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage calculateTabPage;
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
        private System.Windows.Forms.TabPage simulateTabPage;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.Label simulationParameterTypeLabel;
        private System.Windows.Forms.ComboBox simulationParameterTypeComboBox;
        private System.Windows.Forms.Label calculationParameterTypeLabel;
        private System.Windows.Forms.ComboBox calculationParameterTypeComboBox;
    }
}