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
            this.weftCountInput = new System.Windows.Forms.NumericUpDown();
            this.repeatYLabel = new System.Windows.Forms.Label();
            this.warpCountInput = new System.Windows.Forms.NumericUpDown();
            this.repeatXLabel = new System.Windows.Forms.Label();
            this.warpCountLabel = new System.Windows.Forms.Label();
            this.repeatYInput = new System.Windows.Forms.NumericUpDown();
            this.weftCountLabel = new System.Windows.Forms.Label();
            this.repeatXInput = new System.Windows.Forms.NumericUpDown();
            this.yarnWidthInput = new System.Windows.Forms.NumericUpDown();
            this.yarnThicknessInput = new System.Windows.Forms.NumericUpDown();
            this.yarnSpacingLabel = new System.Windows.Forms.Label();
            this.yarnSpacingInput = new System.Windows.Forms.NumericUpDown();
            this.yarnThicknessLabel = new System.Windows.Forms.Label();
            this.yarnWidthLabel = new System.Windows.Forms.Label();
            this.insertWeaveButton = new System.Windows.Forms.Button();
            this.weaveDesignerHeader = new System.Windows.Forms.Label();
            this.weaveButton = new System.Windows.Forms.Button();
            this.weaveDesignerPanel.SuspendLayout();
            this.weaveInputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatYInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnThicknessInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnSpacingInput)).BeginInit();
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
            this.weaveInputsGroupBox.Controls.Add(this.weftCountInput);
            this.weaveInputsGroupBox.Controls.Add(this.repeatYLabel);
            this.weaveInputsGroupBox.Controls.Add(this.warpCountInput);
            this.weaveInputsGroupBox.Controls.Add(this.repeatXLabel);
            this.weaveInputsGroupBox.Controls.Add(this.warpCountLabel);
            this.weaveInputsGroupBox.Controls.Add(this.repeatYInput);
            this.weaveInputsGroupBox.Controls.Add(this.weftCountLabel);
            this.weaveInputsGroupBox.Controls.Add(this.repeatXInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnWidthInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnThicknessInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnSpacingLabel);
            this.weaveInputsGroupBox.Controls.Add(this.yarnSpacingInput);
            this.weaveInputsGroupBox.Controls.Add(this.yarnThicknessLabel);
            this.weaveInputsGroupBox.Controls.Add(this.yarnWidthLabel);
            this.weaveInputsGroupBox.Location = new System.Drawing.Point(16, 64);
            this.weaveInputsGroupBox.Name = "weaveInputsGroupBox";
            this.weaveInputsGroupBox.Size = new System.Drawing.Size(287, 320);
            this.weaveInputsGroupBox.TabIndex = 17;
            this.weaveInputsGroupBox.TabStop = false;
            this.weaveInputsGroupBox.Text = "Weave Inputs";
            // 
            // weftCountInput
            // 
            this.weftCountInput.Location = new System.Drawing.Point(157, 69);
            this.weftCountInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weftCountInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.weftCountInput.Name = "weftCountInput";
            this.weftCountInput.Size = new System.Drawing.Size(120, 20);
            this.weftCountInput.TabIndex = 2;
            this.weftCountInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // repeatYLabel
            // 
            this.repeatYLabel.AutoSize = true;
            this.repeatYLabel.Location = new System.Drawing.Point(13, 263);
            this.repeatYLabel.Name = "repeatYLabel";
            this.repeatYLabel.Size = new System.Drawing.Size(52, 13);
            this.repeatYLabel.TabIndex = 16;
            this.repeatYLabel.Text = "Repeat Y";
            // 
            // warpCountInput
            // 
            this.warpCountInput.Location = new System.Drawing.Point(157, 32);
            this.warpCountInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.warpCountInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.warpCountInput.Name = "warpCountInput";
            this.warpCountInput.Size = new System.Drawing.Size(120, 20);
            this.warpCountInput.TabIndex = 1;
            this.warpCountInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // repeatXLabel
            // 
            this.repeatXLabel.AutoSize = true;
            this.repeatXLabel.Location = new System.Drawing.Point(14, 227);
            this.repeatXLabel.Name = "repeatXLabel";
            this.repeatXLabel.Size = new System.Drawing.Size(52, 13);
            this.repeatXLabel.TabIndex = 15;
            this.repeatXLabel.Text = "Repeat X";
            // 
            // warpCountLabel
            // 
            this.warpCountLabel.AutoSize = true;
            this.warpCountLabel.Location = new System.Drawing.Point(14, 39);
            this.warpCountLabel.Name = "warpCountLabel";
            this.warpCountLabel.Size = new System.Drawing.Size(63, 13);
            this.warpCountLabel.TabIndex = 6;
            this.warpCountLabel.Text = "Warp count";
            // 
            // repeatYInput
            // 
            this.repeatYInput.Location = new System.Drawing.Point(157, 256);
            this.repeatYInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatYInput.Name = "repeatYInput";
            this.repeatYInput.Size = new System.Drawing.Size(120, 20);
            this.repeatYInput.TabIndex = 14;
            this.repeatYInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // weftCountLabel
            // 
            this.weftCountLabel.AutoSize = true;
            this.weftCountLabel.Location = new System.Drawing.Point(14, 76);
            this.weftCountLabel.Name = "weftCountLabel";
            this.weftCountLabel.Size = new System.Drawing.Size(60, 13);
            this.weftCountLabel.TabIndex = 7;
            this.weftCountLabel.Text = "Weft count";
            // 
            // repeatXInput
            // 
            this.repeatXInput.Location = new System.Drawing.Point(157, 220);
            this.repeatXInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatXInput.Name = "repeatXInput";
            this.repeatXInput.Size = new System.Drawing.Size(120, 20);
            this.repeatXInput.TabIndex = 13;
            this.repeatXInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yarnWidthInput
            // 
            this.yarnWidthInput.DecimalPlaces = 1;
            this.yarnWidthInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnWidthInput.Location = new System.Drawing.Point(157, 108);
            this.yarnWidthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnWidthInput.Name = "yarnWidthInput";
            this.yarnWidthInput.Size = new System.Drawing.Size(120, 20);
            this.yarnWidthInput.TabIndex = 3;
            this.yarnWidthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yarnThicknessInput
            // 
            this.yarnThicknessInput.DecimalPlaces = 1;
            this.yarnThicknessInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnThicknessInput.Location = new System.Drawing.Point(157, 145);
            this.yarnThicknessInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnThicknessInput.Name = "yarnThicknessInput";
            this.yarnThicknessInput.Size = new System.Drawing.Size(120, 20);
            this.yarnThicknessInput.TabIndex = 4;
            this.yarnThicknessInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yarnSpacingLabel
            // 
            this.yarnSpacingLabel.AutoSize = true;
            this.yarnSpacingLabel.Location = new System.Drawing.Point(14, 188);
            this.yarnSpacingLabel.Name = "yarnSpacingLabel";
            this.yarnSpacingLabel.Size = new System.Drawing.Size(94, 13);
            this.yarnSpacingLabel.TabIndex = 10;
            this.yarnSpacingLabel.Text = "Yarn spacing (mm)";
            // 
            // yarnSpacingInput
            // 
            this.yarnSpacingInput.DecimalPlaces = 1;
            this.yarnSpacingInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnSpacingInput.Location = new System.Drawing.Point(157, 181);
            this.yarnSpacingInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnSpacingInput.Name = "yarnSpacingInput";
            this.yarnSpacingInput.Size = new System.Drawing.Size(120, 20);
            this.yarnSpacingInput.TabIndex = 5;
            this.yarnSpacingInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // yarnThicknessLabel
            // 
            this.yarnThicknessLabel.AutoSize = true;
            this.yarnThicknessLabel.Location = new System.Drawing.Point(14, 152);
            this.yarnThicknessLabel.Name = "yarnThicknessLabel";
            this.yarnThicknessLabel.Size = new System.Drawing.Size(102, 13);
            this.yarnThicknessLabel.TabIndex = 9;
            this.yarnThicknessLabel.Text = "Yarn thickness (mm)";
            // 
            // yarnWidthLabel
            // 
            this.yarnWidthLabel.AutoSize = true;
            this.yarnWidthLabel.Location = new System.Drawing.Point(14, 115);
            this.yarnWidthLabel.Name = "yarnWidthLabel";
            this.yarnWidthLabel.Size = new System.Drawing.Size(82, 13);
            this.yarnWidthLabel.TabIndex = 8;
            this.yarnWidthLabel.Text = "Yarn width (mm)";
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
            this.Text = "Weave Designer";
            this.weaveDesignerPanel.ResumeLayout(false);
            this.weaveDesignerPanel.PerformLayout();
            this.weaveInputsGroupBox.ResumeLayout(false);
            this.weaveInputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatYInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnThicknessInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnSpacingInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weaveDesignerPanel;
        private System.Windows.Forms.NumericUpDown yarnWidthInput;
        private System.Windows.Forms.NumericUpDown weftCountInput;
        private System.Windows.Forms.NumericUpDown warpCountInput;
        private System.Windows.Forms.Button weaveButton;
        private System.Windows.Forms.NumericUpDown yarnSpacingInput;
        private System.Windows.Forms.NumericUpDown yarnThicknessInput;
        private System.Windows.Forms.Label weaveDesignerHeader;
        private System.Windows.Forms.Label yarnSpacingLabel;
        private System.Windows.Forms.Label yarnThicknessLabel;
        private System.Windows.Forms.Label yarnWidthLabel;
        private System.Windows.Forms.Label weftCountLabel;
        private System.Windows.Forms.Label warpCountLabel;
        private System.Windows.Forms.Button insertWeaveButton;
        private System.Windows.Forms.Label repeatYLabel;
        private System.Windows.Forms.Label repeatXLabel;
        private System.Windows.Forms.NumericUpDown repeatYInput;
        private System.Windows.Forms.NumericUpDown repeatXInput;
        private System.Windows.Forms.GroupBox weaveInputsGroupBox;
    }
}

