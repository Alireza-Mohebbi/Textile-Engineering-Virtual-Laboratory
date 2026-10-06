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
            this.yarnMaterialLabel = new System.Windows.Forms.Label();
            this.yarnMaterialInput = new System.Windows.Forms.ComboBox();
            this.weftCountInput = new System.Windows.Forms.NumericUpDown();
            this.warpCountInput = new System.Windows.Forms.NumericUpDown();
            this.warpCountLabel = new System.Windows.Forms.Label();
            this.weftCountLabel = new System.Windows.Forms.Label();
            this.warpCompactnessInput = new System.Windows.Forms.NumericUpDown();
            this.weftCompactnessInput = new System.Windows.Forms.NumericUpDown();
            this.weftCompactnessLabel = new System.Windows.Forms.Label();
            this.warpCompactnessLabel = new System.Windows.Forms.Label();
            this.insertWeaveButton = new System.Windows.Forms.Button();
            this.weaveDesignerHeader = new System.Windows.Forms.Label();
            this.weaveButton = new System.Windows.Forms.Button();
            this.weaveDesignerPanel.SuspendLayout();
            this.weaveInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCompactnessInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftCompactnessInput)).BeginInit();
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
            this.weaveInputsGroupBox.Controls.Add(this.yarnMaterialLabel);
            this.weaveInputsGroupBox.Controls.Add(this.yarnMaterialInput);
            this.weaveInputsGroupBox.Controls.Add(this.weftCountInput);
            this.weaveInputsGroupBox.Controls.Add(this.warpCountInput);
            this.weaveInputsGroupBox.Controls.Add(this.warpCountLabel);
            this.weaveInputsGroupBox.Controls.Add(this.weftCountLabel);
            this.weaveInputsGroupBox.Controls.Add(this.warpCompactnessInput);
            this.weaveInputsGroupBox.Controls.Add(this.weftCompactnessInput);
            this.weaveInputsGroupBox.Controls.Add(this.weftCompactnessLabel);
            this.weaveInputsGroupBox.Controls.Add(this.warpCompactnessLabel);
            this.weaveInputsGroupBox.Location = new System.Drawing.Point(16, 64);
            this.weaveInputsGroupBox.Name = "weaveInputsGroupBox";
            this.weaveInputsGroupBox.Size = new System.Drawing.Size(287, 320);
            this.weaveInputsGroupBox.TabIndex = 17;
            this.weaveInputsGroupBox.TabStop = false;
            this.weaveInputsGroupBox.Text = "Weave Inputs";
            // 
            // yarnMaterialLabel
            // 
            this.yarnMaterialLabel.AutoSize = true;
            this.yarnMaterialLabel.Location = new System.Drawing.Point(14, 191);
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
            this.yarnMaterialInput.Location = new System.Drawing.Point(14, 207);
            this.yarnMaterialInput.Name = "yarnMaterialInput";
            this.yarnMaterialInput.Size = new System.Drawing.Size(260, 21);
            this.yarnMaterialInput.TabIndex = 11;
            this.yarnMaterialInput.Tag = "";
            this.yarnMaterialInput.SelectedIndexChanged += new System.EventHandler(this.yarnMaterialInput_SelectedIndexChanged);
            // 
            // weftCountInput
            // 
            this.weftCountInput.DecimalPlaces = 1;
            this.weftCountInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weftCountInput.Location = new System.Drawing.Point(157, 69);
            this.weftCountInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.weftCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weftCountInput.Name = "weftCountInput";
            this.weftCountInput.Size = new System.Drawing.Size(120, 20);
            this.weftCountInput.TabIndex = 2;
            this.weftCountInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // warpCountInput
            // 
            this.warpCountInput.DecimalPlaces = 1;
            this.warpCountInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.warpCountInput.Location = new System.Drawing.Point(157, 32);
            this.warpCountInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.warpCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.warpCountInput.Name = "warpCountInput";
            this.warpCountInput.Size = new System.Drawing.Size(120, 20);
            this.warpCountInput.TabIndex = 1;
            this.warpCountInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // warpCountLabel
            // 
            this.warpCountLabel.AutoSize = true;
            this.warpCountLabel.Location = new System.Drawing.Point(14, 39);
            this.warpCountLabel.Name = "warpCountLabel";
            this.warpCountLabel.Size = new System.Drawing.Size(87, 13);
            this.warpCountLabel.TabIndex = 6;
            this.warpCountLabel.Text = "Warp Count (Ne)";
            // 
            // weftCountLabel
            // 
            this.weftCountLabel.AutoSize = true;
            this.weftCountLabel.Location = new System.Drawing.Point(14, 76);
            this.weftCountLabel.Name = "weftCountLabel";
            this.weftCountLabel.Size = new System.Drawing.Size(84, 13);
            this.weftCountLabel.TabIndex = 7;
            this.weftCountLabel.Text = "Weft Count (Ne)";
            // 
            // warpCompactnessInput
            // 
            this.warpCompactnessInput.Location = new System.Drawing.Point(157, 108);
            this.warpCompactnessInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.warpCompactnessInput.Name = "warpCompactnessInput";
            this.warpCompactnessInput.Size = new System.Drawing.Size(120, 20);
            this.warpCompactnessInput.TabIndex = 3;
            this.warpCompactnessInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // weftCompactnessInput
            // 
            this.weftCompactnessInput.Location = new System.Drawing.Point(157, 145);
            this.weftCompactnessInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weftCompactnessInput.Name = "weftCompactnessInput";
            this.weftCompactnessInput.Size = new System.Drawing.Size(120, 20);
            this.weftCompactnessInput.TabIndex = 4;
            this.weftCompactnessInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // weftCompactnessLabel
            // 
            this.weftCompactnessLabel.AutoSize = true;
            this.weftCompactnessLabel.Location = new System.Drawing.Point(14, 152);
            this.weftCompactnessLabel.Name = "weftCompactnessLabel";
            this.weftCompactnessLabel.Size = new System.Drawing.Size(131, 13);
            this.weftCompactnessLabel.TabIndex = 9;
            this.weftCompactnessLabel.Text = "Weft Compactness (1/cm)";
            // 
            // warpCompactnessLabel
            // 
            this.warpCompactnessLabel.AutoSize = true;
            this.warpCompactnessLabel.Location = new System.Drawing.Point(14, 115);
            this.warpCompactnessLabel.Name = "warpCompactnessLabel";
            this.warpCompactnessLabel.Size = new System.Drawing.Size(134, 13);
            this.warpCompactnessLabel.TabIndex = 8;
            this.warpCompactnessLabel.Text = "Warp Compactness (1/cm)";
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
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCompactnessInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftCompactnessInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weaveDesignerPanel;
        private System.Windows.Forms.NumericUpDown weftCountInput;
        private System.Windows.Forms.NumericUpDown warpCountInput;
        private System.Windows.Forms.Button weaveButton;
        private System.Windows.Forms.Label weaveDesignerHeader;
        private System.Windows.Forms.Label weftCountLabel;
        private System.Windows.Forms.Label warpCountLabel;
        private System.Windows.Forms.Button insertWeaveButton;
        private System.Windows.Forms.GroupBox weaveInputsGroupBox;
        private System.Windows.Forms.NumericUpDown warpCompactnessInput;
        private System.Windows.Forms.NumericUpDown weftCompactnessInput;
        private System.Windows.Forms.Label weftCompactnessLabel;
        private System.Windows.Forms.Label warpCompactnessLabel;
        private System.Windows.Forms.ComboBox yarnMaterialInput;
        private System.Windows.Forms.Label yarnMaterialLabel;
    }
}

