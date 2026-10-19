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
                tabControl.Visible = true;
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            resultsWindow.Invalidate();
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
                weaveDesigner.predictiveModel.CalculateRequiredYarnLengthForFabric((float)fabricParametersInput1.Value, (float)fabricParametersInput2.Value);
            }


            if (tabControl.SelectedTab == fabricParametersTabPage)
            {
                switch (fabricParameterTypeComboBox.SelectedIndex)
                {
                    // Fabric thickness
                    case 0:
                        AbstractRenderer fabricThicknessResultRenderer = new FabricThicknessResultRenderer();
                        fabricThicknessResultRenderer.Draw(Weave, e.Graphics);
                        break;

                    // Crmip
                    case 1:
                        AbstractRenderer crimpResultRenderer = new CrimpResultRenderer();
                        crimpResultRenderer.Draw(Weave, e.Graphics);

                        break;

                    // Porosity
                    case 2:


                        AbstractRenderer porosityResultRenderer = new PorosityResultCalculator();
                        porosityResultRenderer.Draw(Weave, e.Graphics);

                        break;

                    // Cover Factor
                    case 3:


                        AbstractRenderer coverFactorResultRenderer = new CoverFactorResultRenderer();
                        coverFactorResultRenderer.Draw(Weave, e.Graphics);

                        break;

                    // Areal Weight
                    case 4:


                        AbstractRenderer arealWeightResultRenderer = new ArealWeightResultRenderer();
                        arealWeightResultRenderer.Draw(Weave, e.Graphics);

                        break;

                    // Required Yarn Length For Fabric
                    case 5:

                        AbstractRenderer requiredYarnLengthForFabricResultRenderer = new RequiredYarnLengthForFabricResultRenderer();
                        requiredYarnLengthForFabricResultRenderer.Draw(Weave, e.Graphics);

                        break;

                    default:
                        break;
                }
            }
        }

        private void fabricParameterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fabricParameterTypeComboBox.SelectedIndex == 5)
            {
                fabricParametersGroupBox.Visible = true;

                fabricParametersInputLabel1.Visible = true;
                fabricParametersInputLabel2.Visible = true;

                fabricParametersInput1.Visible = true;
                fabricParametersInput1.DecimalPlaces = 1;
                fabricParametersInput1.Increment = 0.1m;
                fabricParametersInput1.Minimum = 0.1m;
                fabricParametersInput1.Maximum = 1000;

                fabricParametersInput2.Visible = true;
                fabricParametersInput2.DecimalPlaces = 1;
                fabricParametersInput2.Increment = 0.1m;
                fabricParametersInput2.Minimum = 0.1m;
                fabricParametersInput2.Maximum = 1000;

                fabricParametersInputLabel1.Text = "Fabric Length in Warp Direction (m)";
                fabricParametersInputLabel2.Text = "Fabric Length in Weft Direction (m)";
            }
            else
            {
                fabricParametersGroupBox.Visible = false;

                fabricParametersInputLabel1.Visible = false;
                fabricParametersInputLabel2.Visible = false;

                fabricParametersInput1.Visible = false;
                fabricParametersInput1.DecimalPlaces = 1;
                fabricParametersInput1.Increment = 1;
                fabricParametersInput1.Minimum = 1;
                fabricParametersInput1.Maximum = 100;

                fabricParametersInput2.Visible = false;
                fabricParametersInput2.DecimalPlaces = 1;
                fabricParametersInput2.Increment = 1;
                fabricParametersInput2.Minimum = 1;
                fabricParametersInput2.Maximum = 100;

                fabricParametersInputLabel1.Text = "";
                fabricParametersInputLabel2.Text = "";
            }
        }
    }
}
