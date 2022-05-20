using Appcore.Interfaces;
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
    public partial class Form1 : Form
    {

        private IEstudianteService estudianteService;

        public Form1(IEstudianteService estudianteService)
        {
            this.estudianteService = estudianteService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id");
                return;
            }
            if (estudianteService.Delete(estudianteService.FindById(Int32.Parse(txtId.Text))) == true)
            {
                MessageBox.Show("Se ha eliminado el estudiante");
                LoadDataGridView();
            }
            else 
            {
                MessageBox.Show("No se ha podido eliminar al estudiante");
                   
            }
                

        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregaActualiza frmAgregaActualiza = new FrmAgregaActualiza(estudianteService);
            this.Hide();
            frmAgregaActualiza.ShowDialog();
            LoadDataGridView();
            this.Show();
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            FrmAgregaActualiza frmAgregaActualiza = new FrmAgregaActualiza(estudianteService);
            frmAgregaActualiza.Opcion = 2;
            this.Hide();
            frmAgregaActualiza.Show();
            LoadDataGridView();
            this.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id");
                return;
            }

            int ID = Int32.Parse(txtId.Text);
            int temp = estudianteService.CalculoPromedio(ID);
            if(temp == 0)
            {
                MessageBox.Show("Error de Sintáxis");
                return;
            }
            MessageBox.Show($"El promedio del estudiante es de {temp}");


        }
        #region metodos pequeños
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede poner LETRAS");
            }
        }

        private void LoadDataGridView()
        {
            dtgvEstudiantes.DataSource = estudianteService.GetAll();
        }

        #endregion

    }
}
