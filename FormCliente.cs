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
    public partial class FormCliente : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public FormCliente()
        {
            InitializeComponent();
        }
        private void GuardarCliente()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var cliente in clientes)
            {
                writer.WriteLine(cliente.nit);
                writer.WriteLine(cliente.nombre);
                writer.WriteLine(cliente.direccion);
                
            }
            writer.Close();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nit = textBoxNit.Text;
            cliente.nombre = textBoxNombre.Text;
            cliente.direccion = textBoxDireccion.Text;

            clientes.Add(cliente);
            GuardarCliente();

            textBoxNit.Clear();          //RESETEA LOS TEXBOX
            textBoxNombre.Clear();          //RESETEA LOS TEXBOX
            textBoxDireccion.Clear();          //RESETEA LOS TEXBOX

        }
    }
}
