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
    public partial class FormIngresoAlquiler : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        public FormIngresoAlquiler()
        {
            InitializeComponent();
        }
        private void GuardarAlquiler()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var alquiler in alquileres)
            {
                writer.WriteLine(alquiler.nit);
                writer.WriteLine(alquiler.placa);
                writer.WriteLine(alquiler.fechaAlquiler);
                writer.WriteLine(alquiler.fechaDevolucion);
                writer.WriteLine(alquiler.kilometros);

            }
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.nit = textBoxNit.Text;
            alquiler.placa = textBoxPlaca.Text;
            alquiler.fechaAlquiler = dateTimePickerAlquiler.Value;
            alquiler.fechaDevolucion = dateTimePickerDevolucion.Value;
            alquiler.kilometros = Convert.ToInt16(textBoxKilometros.Text);

            alquileres.Add(alquiler);
            GuardarAlquiler();

            textBoxNit.Clear();          //RESETEA LOS TEXBOX
            textBoxPlaca.Clear();          //RESETEA LOS TEXBOX
            dateTimePickerAlquiler.ResetText(); //RESETEA LOS dateTimePicker
            dateTimePickerDevolucion.ResetText(); //RESETEA LOS dateTimePicker
            textBoxKilometros.Clear();          //RESETEA LOS TEXBOX
            



        }
    }
}
