using System;
using System.Drawing;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Forms;
using TextileEngineeringVirtualLaboratory.Plotter;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Simulator;
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

                textilePropertiesButton.Enabled = true;
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
    
        private void weavePropertiesButton_Click(object sender, EventArgs e)
        {
            WeavePropertiesConfigurer weavePropertiesConfigurer = new WeavePropertiesConfigurer(Weave);
            if (weavePropertiesConfigurer.ShowDialog() == DialogResult.OK)
            {
                Weave = weavePropertiesConfigurer.Weave;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            resultsWindow.Invalidate();
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            resultsWindow.Invalidate();
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            resultsWindow.Invalidate();
        }

        private void resultsWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.ScaleTransform(0.5f, 0.5f);

            if (tabControl.SelectedTab == fabricParametersTabPage)
            {
                switch (fabricParameterTypeComboBox.SelectedIndex)
                {
                    // Fabric thickness
                    case 0:
                        IRenderer fabricThicknessResultRenderer = new FabricThicknessResultRenderer();
                        fabricThicknessResultRenderer.Draw(Weave, e.Graphics);
                        break;

                    // Crmip
                    case 1:
                        IRenderer crimpResultRenderer = new CrimpResultRenderer();
                        crimpResultRenderer.Draw(Weave, e.Graphics);
                        break;

                    // Porosity
                    case 2:
                        IRenderer porosityResultRenderer = new PorosityResultCalculator();
                        porosityResultRenderer.Draw(Weave, e.Graphics);
                        break;

                    // Arial Weight
                    case 3:
                        IRenderer arialWeightRenderer = new ArialWeightRenderer();
                        arialWeightRenderer.Draw(Weave, e.Graphics);
                        break;

                    default: break;
                }
            }

            else if (tabControl.SelectedTab == simulationTabPage)
            {
                switch (simulationTypeComboBox.SelectedIndex)
                {
                    // Drape 2D
                    case 0:
                        AbstractSimulator drapeSimulator = new DrapeSimulator(Weave);
                        drapeSimulator.Simulate(e.Graphics); break;

                    default: break;
                }
            }

            else if (tabControl.SelectedTab == plotTabPage)
            {
                switch (plotTypeComboBox.SelectedIndex)
                {
                    //Stress-Strain Curve
                    case 0: break;

                    // Bending Moment-Curvature Curve
                    case 1:
                        AbstractPlotter bendingMomentCurvaturePlotter = new BendingMomentCurvaturePlotter(
                            (float)input1.Value,
                            (float)input2.Value,
                            (float)input3.Value,
                            (float)input4.Value);
                        bendingMomentCurvaturePlotter.Plot(e.Graphics, "Curvature (mm^-1)", "Bending Moment (N.mm)"); break;

                    // Shear Stiffness Curve
                    case 2:
                        AbstractPlotter shearStiffnessPlotter = new ShearStiffnessPlotter(
                            (float)input1.Value,
                            (float)input2.Value,
                            (float)input3.Value,
                            (float)input4.Value);
                        shearStiffnessPlotter.Plot(e.Graphics, "Shear Strain", "Shear Stress (MPa)"); break;

                    default: break;
                }
            }
        }

        private void plotTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (plotTypeComboBox.SelectedIndex)
            {
                // Stress-Strain Curve
                case 0:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Stress 1 (MPa)";
                    inputLabel2.Text = "Strain 1";
                    inputLabel3.Text = "Stress 2 (MPa)";
                    inputLabel4.Text = "Strain 2"; break;

                // Bending Moment-Curvature Curve
                case 1:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Bending Moment 1 (N.mm)";
                    inputLabel2.Text = "Curvature 1 (mm^-1)";
                    inputLabel3.Text = "Bending Moment 2 (N.mm)";
                    inputLabel4.Text = "Curvature 2 (mm^-1)"; break;

                // Shear Stiffness Curve
                case 2:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Shear Stress 1 (MPa)";
                    inputLabel2.Text = "Shear Strain 1";
                    inputLabel3.Text = "Shear Stress 2 (MPa)";
                    inputLabel4.Text = "Shear Strain 2"; break;

                // default
                default:
                    input1.Visible = false;
                    input2.Visible = false;
                    input3.Visible = false;
                    input4.Visible = false;
                    inputLabel1.Text = "";
                    inputLabel2.Text = "";
                    inputLabel3.Text = "";
                    inputLabel4.Text = ""; break;
            }
        }
    }
}
