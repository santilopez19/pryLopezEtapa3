namespace pryLopezEtapa3
{
    public partial class Form1 : Form
    {
        private clsVehiculo auto;
        private clsVehiculo barco;
        private clsVehiculo avion;

        public Form1()
        {
            InitializeComponent();
            auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);
        }
        private void MostrarVehiculo(clsVehiculo vehiculo)
        {
            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            MostrarVehiculo(avion);
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {

            MostrarVehiculo(barco);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

            MostrarVehiculo(auto);
        }
    }
}
