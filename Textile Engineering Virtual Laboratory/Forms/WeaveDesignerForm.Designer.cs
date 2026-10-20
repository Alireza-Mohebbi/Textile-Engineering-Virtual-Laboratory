namespace TextileEngineeringVirtualLaboratory
{
    partial class WeaveDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaveDesigner));
            this.weaveDesignerPanel = new System.Windows.Forms.Panel();
            this.weaveInputsGroupBox = new System.Windows.Forms.GroupBox();
            this.weavePatternLabel = new System.Windows.Forms.Label();
            this.weavePatternComboBox = new System.Windows.Forms.ComboBox();
            this.peircePredictiveMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.predictiveModelLabel = new System.Windows.Forms.Label();
            this.yarnMaterialLabel = new System.Windows.Forms.Label();
            this.yarnMaterialInput = new System.Windows.Forms.ComboBox();
            this.yarnCountInput = new System.Windows.Forms.NumericUpDown();
            this.yarnCountLabel = new System.Windows.Forms.Label();
            this.warpDensityInput = new System.Windows.Forms.NumericUpDown();
            this.warpDensityLabel = new System.Windows.Forms.Label();
            this.insertWeaveButton = new System.Windows.Forms.Button();
            this.weaveDesignerHeader = new System.Windows.Forms.Label();
            this.weaveButton = new System.Windows.Forms.Button();
            this.weftDensityInput = new System.Windows.Forms.NumericUpDown();
            this.weftDensityLabel = new System.Windows.Forms.Label();
            this.weaveDesignerPanel.SuspendLayout();
            this.weaveInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yarnCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpDensityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftDensityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // weaveDesignerPanel
            // 
            this.weaveDesignerPanel.AccessibleName = "";
            this.weaveDesignerPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.weaveDesignerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaveDesignerPanel.Controls.Add(this.weaveInputsGroupBox);
            this.weaveDesignerPanel.Controls.Add(this.insertWeaveButton);
            this.weaveDesignerPanel.Controls.Add(this.weaveDesignerHeader);
            this.weaveDesignerPanel.Controls.Add(this.weaveButton);
            this.weaveDesignerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.weaveDesignerPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.weaveDesignerPanel.Location = new System.Drawing.Point(446, 0);
            this.weaveDesignerPanel.Name = "weaveDesignerPanel";
            this.weaveDesignerPanel.Size = new System.Drawing.Size(316, 477);
            this.weaveDesignerPanel.TabIndex = 0;
            // 
            // weaveInputsGroupBox
            // 
            this.weaveInputsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.weaveInputsGroupBox.Controls.Add(this.weftDensityInput);
            this.weaveInputsGroupBox.Controls.Add(this.weftDensityLabel);
            this.weaveInputsGroupBox.Controls.Add(this.weavePatternLabel);
            this.weaveInputsGroupBox.Controls.Add(this.weavePatternComboBox);
            this.weaveInputsGroupBox.Controls.Add(this.peircePredictiveMethodRadioButton);
            this.weaveInputsGroupBox.Controls.Add(this.predictiveModelLabel);
            this.weaveInputsGroupBox.Controls.Add(this.yarnMaterialLabel);
            this.weaveInputsGroupBox.Controls.Add(this.yarnMaterialInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnCountInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnCountLabel);
            this.weaveInputsGroupBox.Controls.Add(this.warpDensityInput);
            this.weaveInputsGroupBox.Controls.Add(this.warpDensityLabel);
            this.weaveInputsGroupBox.Location = new System.Drawing.Point(16, 57);
            this.weaveInputsGroupBox.Name = "weaveInputsGroupBox";
            this.weaveInputsGroupBox.Size = new System.Drawing.Size(287, 327);
            this.weaveInputsGroupBox.TabIndex = 17;
            this.weaveInputsGroupBox.TabStop = false;
            this.weaveInputsGroupBox.Text = "Weave Inputs";
            // 
            // weavePatternLabel
            // 
            this.weavePatternLabel.AutoSize = true;
            this.weavePatternLabel.Location = new System.Drawing.Point(14, 124);
            this.weavePatternLabel.Name = "weavePatternLabel";
            this.weavePatternLabel.Size = new System.Drawing.Size(79, 13);
            this.weavePatternLabel.TabIndex = 17;
            this.weavePatternLabel.Text = "Weave Pattern";
            // 
            // weavePatternComboBox
            // 
            this.weavePatternComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weavePatternComboBox.FormattingEnabled = true;
            this.weavePatternComboBox.Items.AddRange(new object[] {
            "Plain 1/1",
            "Basket 2/2",
            "Twill 2/1",
            "Twill 1/2",
            "Twill 2/2",
            "Twill 3/1",
            "Twill 3/2"});
            this.weavePatternComboBox.Location = new System.Drawing.Point(14, 140);
            this.weavePatternComboBox.Name = "weavePatternComboBox";
            this.weavePatternComboBox.Size = new System.Drawing.Size(260, 21);
            this.weavePatternComboBox.TabIndex = 16;
            this.weavePatternComboBox.Tag = "";
            // 
            // peircePredictiveMethodRadioButton
            // 
            this.peircePredictiveMethodRadioButton.AutoSize = true;
            this.peircePredictiveMethodRadioButton.Checked = true;
            this.peircePredictiveMethodRadioButton.Location = new System.Drawing.Point(14, 43);
            this.peircePredictiveMethodRadioButton.Name = "peircePredictiveMethodRadioButton";
            this.peircePredictiveMethodRadioButton.Size = new System.Drawing.Size(55, 17);
            this.peircePredictiveMethodRadioButton.TabIndex = 15;
            this.peircePredictiveMethodRadioButton.TabStop = true;
            this.peircePredictiveMethodRadioButton.Text = "Peirce";
            this.peircePredictiveMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // predictiveModelLabel
            // 
            this.predictiveModelLabel.AutoSize = true;
            this.predictiveModelLabel.Location = new System.Drawing.Point(14, 27);
            this.predictiveModelLabel.Name = "predictiveModelLabel";
            this.predictiveModelLabel.Size = new System.Drawing.Size(86, 13);
            this.predictiveModelLabel.TabIndex = 14;
            this.predictiveModelLabel.Text = "Predictive Model";
            // 
            // yarnMaterialLabel
            // 
            this.yarnMaterialLabel.AutoSize = true;
            this.yarnMaterialLabel.Location = new System.Drawing.Point(14, 76);
            this.yarnMaterialLabel.Name = "yarnMaterialLabel";
            this.yarnMaterialLabel.Size = new System.Drawing.Size(69, 13);
            this.yarnMaterialLabel.TabIndex = 12;
            this.yarnMaterialLabel.Text = "Yarn Material";
            // 
            // yarnMaterialInput
            // 
            this.yarnMaterialInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yarnMaterialInput.FormattingEnabled = true;
            this.yarnMaterialInput.Items.AddRange(new object[] {
            "Cotton"});
            this.yarnMaterialInput.Location = new System.Drawing.Point(14, 92);
            this.yarnMaterialInput.Name = "yarnMaterialInput";
            this.yarnMaterialInput.Size = new System.Drawing.Size(260, 21);
            this.yarnMaterialInput.TabIndex = 11;
            this.yarnMaterialInput.Tag = "";
            this.yarnMaterialInput.SelectedIndexChanged += new System.EventHandler(this.yarnMaterialInput_SelectedIndexChanged);
            // 
            // yarnCountInput
            // 
            this.yarnCountInput.DecimalPlaces = 1;
            this.yarnCountInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnCountInput.Location = new System.Drawing.Point(183, 181);
            this.yarnCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnCountInput.Name = "yarnCountInput";
            this.yarnCountInput.Size = new System.Drawing.Size(91, 20);
            this.yarnCountInput.TabIndex = 1;
            this.yarnCountInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // yarnCountLabel
            // 
            this.yarnCountLabel.AutoSize = true;
            this.yarnCountLabel.Location = new System.Drawing.Point(11, 188);
            this.yarnCountLabel.Name = "yarnCountLabel";
            this.yarnCountLabel.Size = new System.Drawing.Size(83, 13);
            this.yarnCountLabel.TabIndex = 6;
            this.yarnCountLabel.Text = "Yarn Count (Ne)";
            // 
            // warpDensityInput
            // 
            this.warpDensityInput.Location = new System.Drawing.Point(183, 207);
            this.warpDensityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.warpDensityInput.Name = "warpDensityInput";
            this.warpDensityInput.Size = new System.Drawing.Size(91, 20);
            this.warpDensityInput.TabIndex = 3;
            this.warpDensityInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // warpDensityLabel
            // 
            this.warpDensityLabel.AutoSize = true;
            this.warpDensityLabel.Location = new System.Drawing.Point(11, 214);
            this.warpDensityLabel.Name = "warpDensityLabel";
            this.warpDensityLabel.Size = new System.Drawing.Size(122, 13);
            this.warpDensityLabel.TabIndex = 8;
            this.warpDensityLabel.Text = "Warp Density (ends/cm)";
            // 
            // insertWeaveButton
            // 
            this.insertWeaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertWeaveButton.Enabled = false;
            this.insertWeaveButton.Location = new System.Drawing.Point(16, 430);
            this.insertWeaveButton.Name = "insertWeaveButton";
            this.insertWeaveButton.Size = new System.Drawing.Size(287, 34);
            this.insertWeaveButton.TabIndex = 12;
            this.insertWeaveButton.Text = "Insert";
            this.insertWeaveButton.UseVisualStyleBackColor = true;
            this.insertWeaveButton.Click += new System.EventHandler(this.insertWeaveButton_Click);
            // 
            // weaveDesignerHeader
            // 
            this.weaveDesignerHeader.AutoSize = true;
            this.weaveDesignerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaveDesignerHeader.Location = new System.Drawing.Point(42, 8);
            this.weaveDesignerHeader.Name = "weaveDesignerHeader";
            this.weaveDesignerHeader.Size = new System.Drawing.Size(228, 31);
            this.weaveDesignerHeader.TabIndex = 11;
            this.weaveDesignerHeader.Text = "Weave Designer";
            // 
            // weaveButton
            // 
            this.weaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.weaveButton.Location = new System.Drawing.Point(16, 390);
            this.weaveButton.Name = "weaveButton";
            this.weaveButton.Size = new System.Drawing.Size(287, 34);
            this.weaveButton.TabIndex = 0;
            this.weaveButton.Text = "Weave";
            this.weaveButton.UseVisualStyleBackColor = true;
            this.weaveButton.Click += new System.EventHandler(this.weaveButton_Click);
            // 
            // weftDensityInput
            // 
            this.weftDensityInput.Location = new System.Drawing.Point(183, 233);
            this.weftDensityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weftDensityInput.Name = "weftDensityInput";
            this.weftDensityInput.Size = new System.Drawing.Size(91, 20);
            this.weftDensityInput.TabIndex = 18;
            this.weftDensityInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // weftDensityLabel
            // 
            this.weftDensityLabel.AutoSize = true;
            this.weftDensityLabel.Location = new System.Drawing.Point(11, 240);
            this.weftDensityLabel.Name = "weftDensityLabel";
            this.weftDensityLabel.Size = new System.Drawing.Size(121, 13);
            this.weftDensityLabel.TabIndex = 19;
            this.weftDensityLabel.Text = "Weft Density (picks/cm)";
            // 
            // WeaveDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.weaveDesignerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeaveDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weave Designer";
            this.weaveDesignerPanel.ResumeLayout(false);
            this.weaveDesignerPanel.PerformLayout();
            this.weaveInputsGroupBox.ResumeLayout(false);
            this.weaveInputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yarnCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpDensityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftDensityInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weaveDesignerPanel;
        private System.Windows.Forms.NumericUpDown yarnCountInput;
        private System.Windows.Forms.Button weaveButton;
        private System.Windows.Forms.Label weaveDesignerHeader;
        private System.Windows.Forms.Label yarnCountLabel;
        private System.Windows.Forms.Button insertWeaveButton;
        private System.Windows.Forms.GroupBox weaveInputsGroupBox;
        private System.Windows.Forms.NumericUpDown warpDensityInput;
        private System.Windows.Forms.Label warpDensityLabel;
        private System.Windows.Forms.ComboBox yarnMaterialInput;
        private System.Windows.Forms.Label yarnMaterialLabel;
        private System.Windows.Forms.Label predictiveModelLabel;
        private System.Windows.Forms.RadioButton peircePredictiveMethodRadioButton;
        private System.Windows.Forms.Label weavePatternLabel;
        private System.Windows.Forms.ComboBox weavePatternComboBox;
        private System.Windows.Forms.NumericUpDown weftDensityInput;
        private System.Windows.Forms.Label weftDensityLabel;
    }
}

