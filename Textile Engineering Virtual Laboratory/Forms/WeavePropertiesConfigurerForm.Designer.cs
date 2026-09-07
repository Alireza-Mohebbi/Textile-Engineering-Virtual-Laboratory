namespace TextileEngineeringVirtualLaboratory.Forms
{
    partial class WeavePropertiesConfigurer
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
            this.weaveDesignerPanel = new System.Windows.Forms.Panel();
            this.inputsGroupBox = new System.Windows.Forms.GroupBox();
            this.arialDensityInput = new System.Windows.Forms.NumericUpDown();
            this.arialDensityLabel = new System.Windows.Forms.Label();
            this.youngsModulusYInput = new System.Windows.Forms.NumericUpDown();
            this.youngsModulusYLabel = new System.Windows.Forms.Label();
            this.youngsModulusXInput = new System.Windows.Forms.NumericUpDown();
            this.youngsModulusXLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.weaveDesignerPanel.SuspendLayout();
            this.inputsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arialDensityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngsModulusYInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngsModulusXInput)).BeginInit();
            this.SuspendLayout();
            // 
            // weaveDesignerPanel
            // 
            this.weaveDesignerPanel.AccessibleName = "";
            this.weaveDesignerPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.weaveDesignerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaveDesignerPanel.Controls.Add(this.inputsGroupBox);
            this.weaveDesignerPanel.Controls.Add(this.applyButton);
            this.weaveDesignerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weaveDesignerPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.weaveDesignerPanel.Location = new System.Drawing.Point(0, 0);
            this.weaveDesignerPanel.Name = "weaveDesignerPanel";
            this.weaveDesignerPanel.Size = new System.Drawing.Size(299, 267);
            this.weaveDesignerPanel.TabIndex = 1;
            // 
            // inputsGroupBox
            // 
            this.inputsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputsGroupBox.Controls.Add(this.arialDensityInput);
            this.inputsGroupBox.Controls.Add(this.arialDensityLabel);
            this.inputsGroupBox.Controls.Add(this.youngsModulusYInput);
            this.inputsGroupBox.Controls.Add(this.youngsModulusYLabel);
            this.inputsGroupBox.Controls.Add(this.youngsModulusXInput);
            this.inputsGroupBox.Controls.Add(this.youngsModulusXLabel);
            this.inputsGroupBox.Location = new System.Drawing.Point(7, 23);
            this.inputsGroupBox.Name = "inputsGroupBox";
            this.inputsGroupBox.Size = new System.Drawing.Size(284, 181);
            this.inputsGroupBox.TabIndex = 17;
            this.inputsGroupBox.TabStop = false;
            this.inputsGroupBox.Text = "Inputs";
            // 
            // arialDensityInput
            // 
            this.arialDensityInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arialDensityInput.DecimalPlaces = 5;
            this.arialDensityInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.arialDensityInput.Location = new System.Drawing.Point(158, 105);
            this.arialDensityInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.arialDensityInput.Name = "arialDensityInput";
            this.arialDensityInput.Size = new System.Drawing.Size(120, 20);
            this.arialDensityInput.TabIndex = 9;
            // 
            // arialDensityLabel
            // 
            this.arialDensityLabel.AutoSize = true;
            this.arialDensityLabel.Location = new System.Drawing.Point(6, 112);
            this.arialDensityLabel.Name = "arialDensityLabel";
            this.arialDensityLabel.Size = new System.Drawing.Size(120, 13);
            this.arialDensityLabel.TabIndex = 10;
            this.arialDensityLabel.Text = "Arial Density (Kg/mm^2)";
            // 
            // youngsModulusYInput
            // 
            this.youngsModulusYInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.youngsModulusYInput.DecimalPlaces = 5;
            this.youngsModulusYInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.youngsModulusYInput.Location = new System.Drawing.Point(158, 70);
            this.youngsModulusYInput.Name = "youngsModulusYInput";
            this.youngsModulusYInput.Size = new System.Drawing.Size(120, 20);
            this.youngsModulusYInput.TabIndex = 7;
            // 
            // youngsModulusYLabel
            // 
            this.youngsModulusYLabel.AutoSize = true;
            this.youngsModulusYLabel.Location = new System.Drawing.Point(6, 77);
            this.youngsModulusYLabel.Name = "youngsModulusYLabel";
            this.youngsModulusYLabel.Size = new System.Drawing.Size(129, 13);
            this.youngsModulusYLabel.TabIndex = 8;
            this.youngsModulusYLabel.Text = "Young\'s Modulus Y (MPa)";
            // 
            // youngsModulusXInput
            // 
            this.youngsModulusXInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.youngsModulusXInput.DecimalPlaces = 5;
            this.youngsModulusXInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.youngsModulusXInput.Location = new System.Drawing.Point(158, 34);
            this.youngsModulusXInput.Name = "youngsModulusXInput";
            this.youngsModulusXInput.Size = new System.Drawing.Size(120, 20);
            this.youngsModulusXInput.TabIndex = 1;
            // 
            // youngsModulusXLabel
            // 
            this.youngsModulusXLabel.AutoSize = true;
            this.youngsModulusXLabel.Location = new System.Drawing.Point(6, 41);
            this.youngsModulusXLabel.Name = "youngsModulusXLabel";
            this.youngsModulusXLabel.Size = new System.Drawing.Size(129, 13);
            this.youngsModulusXLabel.TabIndex = 6;
            this.youngsModulusXLabel.Text = "Young\'s Modulus X (MPa)";
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.applyButton.Location = new System.Drawing.Point(7, 220);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(284, 34);
            this.applyButton.TabIndex = 12;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // WeavePropertiesConfigurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 267);
            this.Controls.Add(this.weaveDesignerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "WeavePropertiesConfigurer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weave Properties";
            this.weaveDesignerPanel.ResumeLayout(false);
            this.inputsGroupBox.ResumeLayout(false);
            this.inputsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arialDensityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngsModulusYInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youngsModulusXInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weaveDesignerPanel;
        private System.Windows.Forms.GroupBox inputsGroupBox;
        private System.Windows.Forms.NumericUpDown youngsModulusXInput;
        private System.Windows.Forms.Label youngsModulusXLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.NumericUpDown youngsModulusYInput;
        private System.Windows.Forms.Label youngsModulusYLabel;
        private System.Windows.Forms.NumericUpDown arialDensityInput;
        private System.Windows.Forms.Label arialDensityLabel;
    }
}