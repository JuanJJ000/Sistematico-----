using Appcore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmAgregaActualiza : Form
    {
   

        public int Opcion;
        private IEstudianteService estudianteService;

        public FrmAgregaActualiza(IEstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
            InitializeComponent();
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            if (Opcion == 2)
            {

                lblCarnet.Hide();
                txtCarnet.Hide();
                btnAgrega.Hide(); ;
                this.BackColor = Color.Green;


            }
            else
            {
                btnActualizar.Hide();
            }


        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            emptytext();
            if (string.IsNullOrWhiteSpace(txtCarnet.Text))
            {
                MessageBox.Show("Por favor Ingresar todos los datos");
            }
            Estudiante estudiante = new Estudiante()
            {
               
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Phone = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text,
                Carnet = txtCarnet.Text,
                Matematica = (int)nudMatematicas.Value,
                Contabilidad = (int)nudContabilidad.Value,
                Programación = (int)nudProgramación.Value,
                Estadistica = (int)nudEstadisticas.Value

            };

            estudianteService.Create(estudiante);

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            emptytext();

            Estudiante estudiante = new Estudiante()
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Phone = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text,
                Matematica = (int)nudMatematicas.Value,
                Contabilidad = (int)nudContabilidad.Value,
                Programación = (int)nudProgramación.Value,
                Estadistica = (int)nudEstadisticas.Value

            };

            estudianteService.Update(estudiante);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region text

    
        private void emptytext()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text)
               || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)
                )
            {
                MessageBox.Show("Por favor Ingresar todos los datos");
                return;
            }
            if (nudMatematicas.Value == 0 || nudContabilidad.Value == 0 || nudProgramación.Value == 0 || nudEstadisticas.Value == 0)
            {
                DialogResult a = MessageBox.Show("¿Una nota tiene valor de 0, esta seguro de continuar?", "Verificando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden escribir numeros");
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden escribir numeros");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede poner LETRAS");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            nudMatematicas.Value = 0;
            nudContabilidad.Value = 0;
            nudEstadisticas.Value = 0;
            nudProgramación.Value = 0;
        }

        #endregion

    }
}
