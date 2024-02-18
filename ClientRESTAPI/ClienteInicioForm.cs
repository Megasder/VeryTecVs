using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRESTAPI
{
    public partial class ClienteInicioForm : Form
    {
        public ClienteInicioForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            InicioSesionForm isform = new InicioSesionForm();
            isform.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProductoForm proform = new ProductoForm();

            proform.Show();

            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ClienteForm cliform = new ClienteForm();

            cliform.Show();

            this.Hide();
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            CompraForm compform = new CompraForm();
            compform.Show();
            this.Hide();
        }
    }
}