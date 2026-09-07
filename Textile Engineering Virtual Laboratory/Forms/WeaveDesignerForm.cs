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
        private Rectangle[,] interactiveIntersectionsOfWeave;
        private const int marginFromScreenCoord = 50;
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
            DesignedWeave = new Weave((int)warpCountInput.Value, (int)weftCountInput.Value);
            DesignedWeave.YarnThickness = (float)yarnThicknessInput.Value;
            DesignedWeave.YarnWidth = (float)yarnWidthInput.Value;
            DesignedWeave.YarnSpacing = (float)yarnSpacingInput.Value;
            DesignedWeave.RepeatX = (int)repeatXInput.Value;
            DesignedWeave.RepeatY = (int)repeatYInput.Value;

            DefineInteractiveIntersectionsOfWeave();
            insertWeaveButton.Enabled = true;
            Invalidate();
        }

        private void DefineInteractiveIntersectionsOfWeave()
        {
            if (DesignedWeave == null)
            {
                return;
            }

            interactiveIntersectionsOfWeave = new Rectangle[DesignedWeave.WarpCount, DesignedWeave.WeftCount];
            int interactiveAreaSize = Math.Max(10, (int)(DesignedWeave.YarnWidth * displayScale));

            for (int i = 0; i < DesignedWeave.WarpCount; i++)
            {
                for (int j = 0; j < DesignedWeave.WeftCount; j++)
                {
                    int x = marginFromScreenCoord + (int)(i * DesignedWeave.YarnSpacing * displayScale);
                    int y = marginFromScreenCoord + (int)(j * DesignedWeave.YarnSpacing * displayScale);

                    interactiveIntersectionsOfWeave[i, j] = new Rectangle(x - interactiveAreaSize / 2, y - interactiveAreaSize / 2, interactiveAreaSize, interactiveAreaSize);
                }
            }
        }

        // Switch between warp-over-weft or vice versa by clicking on that intersection
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DesignedWeave == null || interactiveIntersectionsOfWeave == null)
            {
                return;
            }

            for (int x = 0; x < DesignedWeave.WarpCount; x++)
            {
                for (int y = 0; y < DesignedWeave.WeftCount; y++)
                {
                    if (interactiveIntersectionsOfWeave[x, y].Contains(e.Location))
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
            e.Graphics.TranslateTransform(marginFromScreenCoord, marginFromScreenCoord);
            e.Graphics.ScaleTransform(displayScale, displayScale);

            WeaveRenderer weaveRenderer = new WeaveRenderer();
            weaveRenderer.Draw(DesignedWeave, e.Graphics);
        }

        private void insertWeaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}