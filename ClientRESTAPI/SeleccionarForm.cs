using ClientRESTAPI.Properties;
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
    public partial class SeleccionarForm : Form
    {
        public SeleccionarForm()
        {
            InitializeComponent();
            if (Settings.Default.Rol == 0)
            {
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                iconButton5.Visible = false;
            }
        }

        private void adminUsuButton_Click(object sender, EventArgs e)
        {
            UsuarioForm usuform = new UsuarioForm();

            usuform.Show();

            this.Hide();
        }

        private void adminiEmpresaButton_Click(object sender, EventArgs e)
        {
            EmpresaForm empform = new EmpresaForm();

            empform.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClienteForm cliform = new ClienteForm();

            cliform.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoForm proform = new ProductoForm();

            proform.Show();

            this.Hide();
        }

        private void adminComprasButton_Click(object sender, EventArgs e)
        {
            CompraForm compform = new CompraForm();
            compform.Show();
            this.Hide();
        }

        private void SeleccionarForm_Load(object sender, EventArgs e)
        {

        }

        private void reserva_buttonClick(object sender, EventArgs e)
        {
            ReservaForm resform = new ReservaForm();
            resform.Show();
            this.Hide();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            InicioSesionForm isform = new InicioSesionForm();
            isform.Show();
            this.Hide();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            CompraForm compform = new CompraForm();
            compform.Show();
            this.Hide();
        }
    }
}
