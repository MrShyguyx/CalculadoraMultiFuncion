using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMultiFuncion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario y convertirlos a números
                double num1 = Convert.ToDouble(txtNumero1.Text);
                double num2 = Convert.ToDouble(txtNumero2.Text);

                // Calcular la suma, el producto y la potencia
                double suma = num1 + num2;
                double producto = num1 * num2;
                double potencia = Math.Pow(num1, num2);

                // Mostrar los resultados en los Labels
                lblSuma.Text = "Suma: " + suma.ToString();
                lblProducto.Text = "Producto: " + producto.ToString();
                lblPotencia.Text = "Potencia: " + potencia.ToString();

                // Borrar los valores ingresados en los TextBox
                txtNumero1.Clear();
                txtNumero2.Clear();

                // Enfocar el primer TextBox para facilitar la próxima entrada de datos
                txtNumero1.Focus();
            }
            catch (Exception ex)
            {
                // Manejo de errores: Mostrar un mensaje si ocurre un error en la conversión de datos
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos personales ingresados por el usuario
                string nombre = txtNombre.Text;
                string edad = txtEdad.Text;
                string direccion = txtDireccion.Text;

                // Mostrar los datos guardados en un MessageBox
                MessageBox.Show("Datos Guardados:\nNombre: " + nombre + "\nEdad: " + edad + "\nDirección: " + direccion, "Información Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de texto
                txtNombre.Clear();
                txtEdad.Clear();
                txtDireccion.Clear();

                // Enfocar el primer TextBox
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
