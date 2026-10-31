using System;
using System.Drawing;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory
{
    public partial class MainMenu : Form
    {
        private Weave Weave { get; set; }
        private WeaveDesigner weaveDesigner = new WeaveDesigner();

        public MainMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            textileViewer.Paint += textileViewer_Paint;
            resultsWindow.Paint += resultsWindow_Paint;
        }

        private void newWeaveButton_Click(object sender, EventArgs e)
        {
            if (Weave == null)
            {
                CreateOrEditTextile();
            }
            else
            {
                if (MessageBox.Show("Do you want to create a new textile?\nThe previous model will be discarded.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Weave = null;
                    weaveDesigner = new WeaveDesigner();

                    CreateOrEditTextile();
                }
            }
        }

        private void textileViewer_Click(object sender, EventArgs e)
        {
            CreateOrEditTextile();
        }

        private void CreateOrEditTextile()
        {
            if (weaveDesigner.ShowDialog() == DialogResult.OK)
            {
                Weave = weaveDesigner.DesignedWeave;

                textileViewEditHintLabel.Enabled = true;
                textileViewer.Enabled = true;
            }

            textileViewer.Invalidate();
            resultsWindow.Invalidate();
        }

        private void textileViewer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.TranslateTransform(10, 10);
            e.Graphics.ScaleTransform(10, 10);

            WeaveRenderer weaveRenderer = new WeaveRenderer();
            weaveRenderer.Draw(Weave, e.Graphics);
        }

        private void resultsWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.ScaleTransform(0.5f, 0.5f);

            if (Weave != null)
            {
                weaveDesigner.predictiveModel.CalculateCrimpInWarpsDirection();
                weaveDesigner.predictiveModel.CalculateCrimpInWeftsDirection();
                weaveDesigner.predictiveModel.CalculatePorosity();
                weaveDesigner.predictiveModel.CalculateCoverFactor();
                weaveDesigner.predictiveModel.CalculateArealWeight();
                weaveDesigner.predictiveModel.CalculateRequiredYarnLengthForFabric();

                AbstractRenderer resultWindowRenderer = new ResultWindowRenderer();
                resultWindowRenderer.Draw(Weave, e.Graphics);
            }
        }
    }
}
