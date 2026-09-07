using System.Windows.Forms;
using TextileEngineeringVirtualLaboratory.Textiles;

namespace TextileEngineeringVirtualLaboratory.Forms
{
    public partial class WeavePropertiesConfigurer : Form
    {
        public Weave Weave { get; private set; }

        public WeavePropertiesConfigurer(Weave weave)
        {
            InitializeComponent();
            Weave = weave;
        }

        private void applyButton_Click(object sender, System.EventArgs e)
        {
            if (youngsModulusXInput.Value != 0 && youngsModulusYInput.Value != 0 && arialDensityInput.Value != 0)
            {
                Weave.YoungsModulusX = (float)youngsModulusXInput.Value;
                Weave.YoungsModulusY = (float)youngsModulusYInput.Value;
                Weave.FabricArialDensity = (float)arialDensityInput.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please fill all inputs.");
            }
        }
    }
}
