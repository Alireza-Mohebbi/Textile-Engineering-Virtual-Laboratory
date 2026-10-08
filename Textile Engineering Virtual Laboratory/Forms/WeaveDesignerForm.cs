using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.PredictiveModel;
using TextileEngineeringVirtualLaboratory.Textiles;
using TextileEngineeringVirtualLaboratory.Materials;

namespace TextileEngineeringVirtualLaboratory
{
    public partial class WeaveDesigner : Form
    {
        public Weave DesignedWeave { get; set; }
        private IMaterials material;
        private Rectangle[,] interactiveInterlacementsOfWeave;

        private const int displayMargin = 25;
        private const float displayScale = 80;

        public WeaveDesigner()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            Invalidate();
        }

        private void weaveButton_Click(object sender, EventArgs e)
        {
            if (peircePredictiveMethodRadioButton.Checked && yarnMaterialInput.SelectedIndex >= 0 && weavePatternComboBox.SelectedIndex >= 0 && warpCountInput != null && weftCountInput != null && warpCompactnessInput != null && weftCompactnessInput != null)
            {
                DesignedWeave = new Weave(
                    weavePatternComboBox.Items[weavePatternComboBox.SelectedIndex].ToString(),
                    (float)warpCountInput.Value,
                    (float)weftCountInput.Value,
                    (float)warpCompactnessInput.Value,
                    (float)weftCompactnessInput.Value,
                    material);

                if (peircePredictiveMethodRadioButton.Checked)
                {
                    IPredictiveModel peircePredictiveModel = new PeircePredictiveModel();
                    DesignedWeave = peircePredictiveModel.CalculateTheGetWeaveParameters(DesignedWeave);
                }

                DefineInteractiveInterlacementsOfWeave();
                insertWeaveButton.Enabled = true;
                Invalidate();
            }
            else
            {
                MessageBox.Show("Please fill all inputs.", "Message");
            }
        }

        private void DefineInteractiveInterlacementsOfWeave()
        {
            if (DesignedWeave == null)
            {
                return;
            }

            interactiveInterlacementsOfWeave = new Rectangle[DesignedWeave.NumberOfWarps, DesignedWeave.NumberOfWefts];
            int interactiveAreaSize = Math.Max(10, (int)(Math.Min(DesignedWeave.WarpDiameter, DesignedWeave.WeftDiameter) * displayScale));

            for (int i = 0; i < DesignedWeave.NumberOfWarps; i++)
            {
                for (int j = 0; j < DesignedWeave.NumberOfWefts; j++)
                {
                    int InterlacementCenterX = displayMargin + (int)((i * DesignedWeave.WarpSpacing + DesignedWeave.WarpSpacing / 2f) * displayScale);
                    int InterlacementCenterY = displayMargin + (int)((j * DesignedWeave.WeftSpacing + DesignedWeave.WeftSpacing / 2f) * displayScale);
                    interactiveInterlacementsOfWeave[i, j] = new Rectangle( InterlacementCenterX - interactiveAreaSize / 2, InterlacementCenterY - interactiveAreaSize / 2, interactiveAreaSize, interactiveAreaSize);
                }
            }
        }

        // Switch between warp-over-weft or vice versa by clicking on an interlacement
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DesignedWeave == null || interactiveInterlacementsOfWeave == null)
            {
                return;
            }

            for (int x = 0; x < DesignedWeave.NumberOfWarps; x++)
            {
                for (int y = 0; y < DesignedWeave.NumberOfWefts; y++)
                {
                    if (interactiveInterlacementsOfWeave[x, y].Contains(e.Location))
                    {
                        DesignedWeave.IsWarpOverWeft[x, y] = !DesignedWeave.IsWarpOverWeft[x, y];
                        Invalidate();
                        return;
                    }
                }
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