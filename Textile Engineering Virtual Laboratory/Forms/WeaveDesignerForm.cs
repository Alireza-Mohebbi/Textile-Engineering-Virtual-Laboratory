using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory
{
    public partial class WeaveDesigner : Form
    {
        public Weave DesignedWeave { get; set; }
        private Rectangle[,] interactiveInterlacementsOfWeave;
        private const int displayMargin = 50;
        private const float displayScale = 50;

        public WeaveDesigner()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
        }

        private void weaveButton_Click(object sender, EventArgs e)
        {
            DesignedWeave = new Weave(
                (int)numberOfWarpsInput.Value,
                (int)numberOfWeftsInput.Value,
                (float)yarnWidthInput.Value,
                (float)yarnThicknessInput.Value,
                (float)yarnSpacingInput.Value,
                (int)repeatXInput.Value,
                (int)repeatYInput.Value);

            DefineInteractiveInterlacementsOfWeave();
            insertWeaveButton.Enabled = true;
            Invalidate();
        }

        private void DefineInteractiveInterlacementsOfWeave()
        {
            if (DesignedWeave == null)
            {
                return;
            }

            interactiveInterlacementsOfWeave = new Rectangle[DesignedWeave.NumberOfWarps, DesignedWeave.NumberOfWefts];
            int interactiveAreaSize = Math.Max(10, (int)(Math.Min(DesignedWeave.WarpWidth, DesignedWeave.WeftWidth) * displayScale));

            for (int i = 0; i < DesignedWeave.NumberOfWarps; i++)
            {
                for (int j = 0; j < DesignedWeave.NumberOfWefts; j++)
                {
                    // Center of the warp/weft intersection.
                    // X is determined by WarpSpacing, Y by WeftSpacing.
                    int centerX = displayMargin + (int)((i * DesignedWeave.WarpSpacing + DesignedWeave.WarpSpacing / 2f) * displayScale);
                    int centerY = displayMargin + (int)((j * DesignedWeave.WeftSpacing + DesignedWeave.WeftSpacing / 2f) * displayScale);
                    interactiveInterlacementsOfWeave[i, j] = new Rectangle( centerX - interactiveAreaSize / 2, centerY - interactiveAreaSize / 2, interactiveAreaSize, interactiveAreaSize);
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
            DesignedWeave.CalculateYarnsPathPointsAndLengths();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}