using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2
{
    public partial class FormAlquiler : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List <Cliente> clientes = new List<Cliente>();
        List <Alquiler>alquileres = new List<Alquiler>();
        List <Mostrar> datos = new List<Mostrar>();
        public FormAlquiler()
        {
            InitializeComponent();
        }
        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
            dataGridView1.DataSource = vehiculos;
            dataGridView1.Refresh();

            CargarClientes();
            dataGridView2.DataSource = clientes;
            dataGridView2.Refresh();
        }
        private void CargarVehiculos()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.placa = reader.ReadLine();
                vehiculo.marca = reader.ReadLine();
                vehiculo.modelo = Convert.ToInt16(reader.ReadLine());
                vehiculo.color = reader.ReadLine();
                vehiculo.precioKilometro = Convert.ToDecimal(reader.ReadLine());
                vehiculos.Add(vehiculo);
            }
        }
        private void CargarClientes()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.nit = reader.ReadLine();
                cliente.nombre = reader.ReadLine();
                cliente.direccion = reader.ReadLine();
                clientes.Add(cliente);
            }
        }
        private void CargarAlquileres()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Alquiler alquiler = new Alquiler();
                alquiler.nit = reader.ReadLine();
                alquiler.placa = reader.ReadLine();
              //  alquiler.fechaAlquiler = reader.ReadLine();
               // alquiler.fechaDevolucion = Convert.ToString(reader.ReadLine());
               // alquiler.kilometros = Convert.ToInt16(reader.ReadLine());
                alquileres.Add(alquiler);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            CargarAlquileres();
            for (int i = 0; i < alquileres.Count; i++ )
            {
                Mostrar dato = new Mostrar();
                for (int j = 0; j < clientes.Count; j++)
                {
                    if (alquileres[i].nit == clientes[j].nit)
                    {
                        dato.nombre = clientes[j].nombre;
                    }
                }
                for (int k = 0; k < vehiculos.Count; k++)
                {
                    if (alquileres[i].placa == vehiculos[k].placa)
                    {
                        dato.placa = vehiculos[k].placa;
                        dato.marca = vehiculos[k].marca;
                        dato.total = vehiculos[k].precioKilometro * alquileres[i].kilometros;
                    }
                }
                datos.Add(dato);
            }
            dataGridView3.DataSource = datos;
            dataGridView3.Refresh();
        }

       
    }
}
