namespace Repaso2
{
    public partial class Form1 : Form
    {
        List <Vehiculo> vehiculos = new List <Vehiculo> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlquiler formularioAlquiler = new FormAlquiler ();
            formularioAlquiler.Show();
        }

        private void datosVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.placa);
                writer.WriteLine(vehiculo.marca);
                writer.WriteLine(vehiculo.modelo);
                writer.WriteLine(vehiculo.color);
                writer.WriteLine(vehiculo.precioKilometro);
            }
            writer.Close();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.placa = textBoxplaca.Text;
            vehiculo.marca = textBoxmarca.Text;
            vehiculo.modelo = Convert.ToInt16(textBoxmodelo.Text);
            vehiculo.color = textBoxcolor.Text;
            vehiculo.precioKilometro = Convert.ToDecimal(textBoxprecio.Text);

            int posicion = vehiculos.FindIndex(x => x.placa == textBoxplaca.Text);
                if  (posicion == -1)
            {
                vehiculos.Add(vehiculo);
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("EL VEHÍCULO YA ESTA INGRESADO.");
            }


        }

       
    }
}