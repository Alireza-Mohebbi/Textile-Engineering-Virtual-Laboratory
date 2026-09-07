using System;
using System.Drawing;
using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Forms;
using TextileEngineeringVirtualLaboratory.Plotter;
using TextileEngineeringVirtualLaboratory.Renderer;
using TextileEngineeringVirtualLaboratory.Textiles;


namespace TextileEngineeringVirtualLaboratory
{
    public partial class MainMenu : Form
    {
        private Weave Weave { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            weaveViewer.Paint += weaveViewer_Paint;
            plotViewer.Paint += plotViewer_Paint;
        }

        private void newWeaveButton_Click(object sender, EventArgs e)
        {
            WeaveDesigner weaveDesigner = new WeaveDesigner();

            if (weaveDesigner.ShowDialog() == DialogResult.OK)
            {
                Weave = weaveDesigner.DesignedWeave;
                weavePropertiesButton.Enabled = true;
                weaveViewer.Invalidate();
            }
        }

        private void weaveViewer_Paint(object sender, PaintEventArgs e)
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
                plotInputsPanel.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (plotTypeComboBox.SelectedIndex)
            {
                // Stress-Strain inputs settings
                case 0:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Stress 1 (MPa)";
                    inputLabel2.Text = "Strain 1";
                    inputLabel3.Text = "Stress 2 (MPa)";
                    inputLabel4.Text = "Strain 2"; break;

                // Bending moment-Curvature inputs settings
                case 1:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Bending Moment 1 (N.mm)";
                    inputLabel2.Text = "Curvature 1 (mm^-1)";
                    inputLabel3.Text = "Bending Moment 2 (N.mm)";
                    inputLabel4.Text = "Curvature 2 (mm^-1)"; break;

                // Shear stiffness inputs settings
                case 2:
                    input1.Visible = true;
                    input2.Visible = true;
                    input3.Visible = true;
                    input4.Visible = true;
                    inputLabel1.Text = "Shear Stress 1 (MPa)";
                    inputLabel2.Text = "Shear Strain 1";
                    inputLabel3.Text = "Shear Stress 2 (MPa)";
                    inputLabel4.Text = "Shear Strain 2"; break;

                // Drape curve inputs settings
                case 3:
                    input1.Visible = false;
                    input2.Visible = false;
                    input3.Visible = false;
                    input4.Visible = false;
                    inputLabel1.Text = "";
                    inputLabel2.Text = "";
                    inputLabel3.Text = "";
                    inputLabel4.Text = ""; break;

                // Default implementation
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

        private void plotButton_Click(object sender, EventArgs e)
        {
            plotViewer.Invalidate();
        }

        private void plotViewer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.ScaleTransform(0.5f, 0.5f);

            switch (plotTypeComboBox.SelectedIndex)
            {
                // Stress-Strain plotter selected
                case 1:
                    PlotterTemplate bendingMomentCurvaturePlotter = new BendingMomentCurvaturePlotter(
                        (float)input1.Value,
                        (float)input2.Value,
                        (float)input3.Value,
                        (float)input4.Value);
                    bendingMomentCurvaturePlotter.Plot(e.Graphics, "Curvature (mm^-1)", "Bending Moment (N.mm)"); break;

                // Shear stiffness plotter selected
                case 2:
                    PlotterTemplate shearStiffnessPlotter = new ShearStiffnessPlotter(
                        (float)input1.Value,
                        (float)input2.Value,
                        (float)input3.Value,
                        (float)input4.Value);
                    shearStiffnessPlotter.Plot(e.Graphics, "Shear Strain", "Shear Stress (MPa)"); break;

                // Drape plotter selected
                case 3:
                    PlotterTemplate drapePlotter = new DrapePlotter(Weave);
                    drapePlotter.Plot(e.Graphics); break;

                // None selected
                default: break;
            }
        }
    }
}
