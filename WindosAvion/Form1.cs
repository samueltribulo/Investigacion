using InvestigacionClases;

namespace WindosAvion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {

            AvionComercial avion = new AvionComercial("Samuel", "Juan", "Micaela", 20000, "SamuelAirline");

            MessageBox.Show(avion.ToString());

        }
    }
}