using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.PredictiveModel;
using TextileEngineeringVirtualLaboratory.Textiles;
using TextileEngineeringVirtualLaboratory.Materials;

namespace TextileEngineeringVirtualLaboratory
{
    public partial class WeaveDesigner : Form
    {
        public Weave DesignedWeave { get; set; }
        public IPredictiveModel predictiveModel;
        private IMaterials material;

        private const int displayMargin = 25;
        private const float displayScale = 80;

        public WeaveDesigner()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += Form1_Paint;
            Invalidate();
        }

        private void weaveButton_Click(object sender, EventArgs e)
        {
            if (peircePredictiveMethodRadioButton.Checked && yarnMaterialInput.SelectedIndex >= 0 && weavePatternComboBox.SelectedIndex >= 0 && yarnCountInput != null && warpDensityInput != null)
            {
                DesignedWeave = new Weave(
                    material,
                    weavePatternComboBox.Items[weavePatternComboBox.SelectedIndex].ToString(),
                    (float)yarnCountInput.Value,
                    (float)yarnCountInput.Value,
                    (float)warpDensityInput.Value,
                    (float)weftDensityInput.Value,
                    (float)fabricLengthInWarpDirectionInput.Value,
                    (float)fabricLengthInWeftDirectionInput.Value);

                if (peircePredictiveMethodRadioButton.Checked)
                {
                    predictiveModel = new PeircePredictiveModel(DesignedWeave);
                }

                insertWeaveButton.Enabled = true;
                Invalidate();
            }
            else
            {
                MessageBox.Show("Please fill all inputs.", "Message");
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (DesignedWeave == null)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(displayMargin, displayMargin);
            e.Graphics.ScaleTransform(displayScale, displayScale);

            WeaveRenderer weaveRenderer = new WeaveRenderer();
            weaveRenderer.Draw(DesignedWeave, e.Graphics);
        }

        private void insertWeaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void yarnMaterialInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (yarnMaterialInput.SelectedIndex)
            {
                // Cotton
                case 0:
                    material = new CottonMaterial(); break;
            }
        }
    }
}