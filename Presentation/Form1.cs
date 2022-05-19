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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblID.Hide();
            txtId.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblID.Show();
            txtId.Show();






            lblID.Hide();
            txtId.Hide();
        }
    }
}
