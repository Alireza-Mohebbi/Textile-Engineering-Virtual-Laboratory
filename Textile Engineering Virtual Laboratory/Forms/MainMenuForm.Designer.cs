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
            this.plotInputsPanel = new System.Windows.Forms.Panel();
            this.plotterHeader = new System.Windows.Forms.Label();
            this.plotTypeLabel = new System.Windows.Forms.Label();
            this.plotTypeComboBox = new System.Windows.Forms.ComboBox();
            this.plotInputsGroupBox = new System.Windows.Forms.GroupBox();
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            this.input3 = new System.Windows.Forms.NumericUpDown();
            this.input4 = new System.Windows.Forms.NumericUpDown();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputLabel4 = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.plotViewer = new System.Windows.Forms.PictureBox();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).BeginInit();
            this.plotInputsPanel.SuspendLayout();
            this.plotInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotViewer)).BeginInit();
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
            this.weavePropertiesButton.Text = "Weave Properties";
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
            // plotInputsPanel
            // 
            this.plotInputsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotInputsPanel.Controls.Add(this.plotterHeader);
            this.plotInputsPanel.Controls.Add(this.plotTypeLabel);
            this.plotInputsPanel.Controls.Add(this.plotTypeComboBox);
            this.plotInputsPanel.Controls.Add(this.plotInputsGroupBox);
            this.plotInputsPanel.Controls.Add(this.plotButton);
            this.plotInputsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.plotInputsPanel.Enabled = false;
            this.plotInputsPanel.Location = new System.Drawing.Point(568, 0);
            this.plotInputsPanel.Name = "plotInputsPanel";
            this.plotInputsPanel.Size = new System.Drawing.Size(281, 477);
            this.plotInputsPanel.TabIndex = 2;
            // 
            // plotterHeader
            // 
            this.plotterHeader.AutoSize = true;
            this.plotterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotterHeader.Location = new System.Drawing.Point(82, 12);
            this.plotterHeader.Name = "plotterHeader";
            this.plotterHeader.Size = new System.Drawing.Size(100, 31);
            this.plotterHeader.TabIndex = 12;
            this.plotterHeader.Text = "Plotter";
            // 
            // plotTypeLabel
            // 
            this.plotTypeLabel.AutoSize = true;
            this.plotTypeLabel.Location = new System.Drawing.Point(14, 76);
            this.plotTypeLabel.Name = "plotTypeLabel";
            this.plotTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.plotTypeLabel.TabIndex = 5;
            this.plotTypeLabel.Text = "Select a Plot";
            // 
            // plotTypeComboBox
            // 
            this.plotTypeComboBox.DisplayMember = "iii";
            this.plotTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plotTypeComboBox.FormattingEnabled = true;
            this.plotTypeComboBox.Items.AddRange(new object[] {
            "Stress-Strain Curve",
            "Bending Moment-Curvature Curve",
            "Shear Stiffness Curve",
            "Drape 2D"});
            this.plotTypeComboBox.Location = new System.Drawing.Point(17, 92);
            this.plotTypeComboBox.Name = "plotTypeComboBox";
            this.plotTypeComboBox.Size = new System.Drawing.Size(245, 21);
            this.plotTypeComboBox.TabIndex = 3;
            this.plotTypeComboBox.Tag = "";
            this.plotTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.plotInputsGroupBox.Location = new System.Drawing.Point(17, 129);
            this.plotInputsGroupBox.Name = "plotInputsGroupBox";
            this.plotInputsGroupBox.Size = new System.Drawing.Size(245, 299);
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
            this.input1.Location = new System.Drawing.Point(148, 28);
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
            this.input2.Location = new System.Drawing.Point(148, 54);
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
            this.input3.Location = new System.Drawing.Point(148, 80);
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
            this.input4.Location = new System.Drawing.Point(148, 106);
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
            // plotButton
            // 
            this.plotButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plotButton.Location = new System.Drawing.Point(21, 434);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(245, 30);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // plotViewer
            // 
            this.plotViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotViewer.Location = new System.Drawing.Point(133, 0);
            this.plotViewer.Name = "plotViewer";
            this.plotViewer.Size = new System.Drawing.Size(435, 477);
            this.plotViewer.TabIndex = 3;
            this.plotViewer.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.plotViewer);
            this.Controls.Add(this.plotInputsPanel);
            this.Controls.Add(this.controls);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).EndInit();
            this.plotInputsPanel.ResumeLayout(false);
            this.plotInputsPanel.PerformLayout();
            this.plotInputsGroupBox.ResumeLayout(false);
            this.plotInputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newWeaveButton;
        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Panel plotInputsPanel;
        private System.Windows.Forms.ComboBox plotTypeComboBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.PictureBox weaveViewer;
        private System.Windows.Forms.Label plotTypeLabel;
        private System.Windows.Forms.Label plotterHeader;
        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.NumericUpDown input4;
        private System.Windows.Forms.Label inputLabel4;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.NumericUpDown input3;
        private System.Windows.Forms.NumericUpDown input2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Button weavePropertiesButton;
        private System.Windows.Forms.GroupBox plotInputsGroupBox;
        private System.Windows.Forms.Label weaveViewLabel;
        private System.Windows.Forms.PictureBox plotViewer;
    }
}