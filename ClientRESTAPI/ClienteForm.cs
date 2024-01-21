using Newtonsoft.Json;
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
    public partial class ClienteForm : Form
    {
       
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dni = dniTextBox.Text;
            String nombre = nombreTextBox.Text;
            String apellidos = apellidosTextBox.Text;
            int telefono = Int32.Parse(telefonoTextBox.Text);
            String email = EmailTextBox.Text;
            String password = passwordTextBox.Text;
            String historial = historialTextBox.Text;
            

            String url = "http://localhost:8081/clienteAdd/";
            String url2 = "http://localhost:8081/clienteDni/" + dni;

            RestClient r = new RestClient(url, "POST");
            RestClient g = new RestClient(url2, "GET");

            String datos = "{" +
                "\"dni\" : \"" + dni + "\", " +
                "\"nombre\" : \"" + nombre + "\"," +
                "\"apellidos\" : \"" + apellidos + "\"," +
                "\"telefono\" : \"" + telefono + "\"," +
                "\"email\" : \"" + email + "\"," +
                "\"password\" : \"" + password + "\"," +
                "\"historial\" : \"" + historial + "\" " +
                "}";

            String geto = g.getItem();
            if (geto is null)
            {
                String res = r.postItem(datos);
                MessageBox.Show("Cliente creado con exito");
            }
            else
            {
                var usu = JsonConvert.DeserializeObject<Cliente>(geto);

                if (usu.dni.Equals(dni))
                {
                    MessageBox.Show("No se ha podido crear el cliente, DNI en uso");
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            String dni = dniTextBox.Text;
            String nombre = nombreTextBox.Text;
            String apellidos = apellidosTextBox.Text;
            int telefono = Int32.Parse(telefonoTextBox.Text);
            String email = EmailTextBox.Text;
            String password = passwordTextBox.Text;
            String historial = historialTextBox.Text;

            String url = "http://localhost:8081/clienteMod/" + dni;

            RestClient r = new RestClient(url, "PUT");

            String datosPost = "{" +
                "\"nombre\" : \"" + nombre + "\"," +
                "\"apellidos\" : \"" + apellidos + "\"," +
                "\"dni\" : \"" + dni + "\"," +
                "\"telefono\" : \"" + telefono + "\"," +
                "\"email\" : \"" + email + "\"," +
                "\"password\" : \"" + password + "\"," +
                "\"historial\" : \"" + historial + "\" " +
                "}";
            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este cliente",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);


                MessageBox.Show("Cliente modificado con éxito");

                CleanForm();

            }
            else
            {
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            String dni = dniTextBox.Text;

            String url = "http://localhost:8081/clienteDel/" + dni;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar este cliente",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                
                    String resDel = r.deleteItem();

                    MessageBox.Show("Cliente eliminado con éxito");

                CleanForm();
            }
            else
            {
            }
        }

        private void buscarDNIButton_Click(object sender, EventArgs e)
        {
            String dni = campo1.Text;
            String url = "http://localhost:8081/clienteDni/" + dni;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el cliente");
            }
            else
            {
                var usu = JsonConvert.DeserializeObject<Cliente>(respuesta);
                List<Cliente> lista = new List<Cliente>();
                lista.Add(usu);

                MessageBox.Show("Cliente encontrado");
                dataGridView1.DataSource = lista;

                dniTextBox.Text = usu.dni;
                nombreTextBox.Text = usu.nombre;
                apellidosTextBox.Text = usu.apellidos;
                telefonoTextBox.Text = usu.telefono.ToString();
                EmailTextBox.Text = usu.email;
                historialTextBox.Text = usu.historial;
                passwordTextBox.Text = usu.password;

            }
        }

        private void buscaNombreButton_Click(object sender, EventArgs e)
        {
            String nombre = campo1.Text;
            String url = "http://localhost:8081/clienteNombre/?nombre=" + nombre;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el cliente");
            }
            else
            {
                //Otra solucion al error de Json DeserializeObject que salta cuando el Json esta entre corchetas de array
                //MyStok myobj = JSON.Deserialize<MyStok>(sc.Substring(1, sc.Length - 2));

                var listCli = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

                var usu = listCli[0];


                MessageBox.Show("Cliente encontrado");
                dataGridView1.DataSource = listCli;

                dniTextBox.Text = usu.dni;
                nombreTextBox.Text = usu.nombre;
                apellidosTextBox.Text = usu.apellidos;
                telefonoTextBox.Text = usu.telefono.ToString();
                EmailTextBox.Text = usu.email;
                historialTextBox.Text = usu.historial;

            }
        }

        private void historialBuscarButton_Click(object sender, EventArgs e)
        {
            String email = campo1.Text;
            String url = "http://localhost:8081/clientebyemailortelefono/?email=" + email;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el cliente");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

                var usu = listCli[0];

                MessageBox.Show("Cliente encontrado");
                dataGridView1.DataSource = listCli;

                dniTextBox.Text = usu.dni;
                nombreTextBox.Text = usu.nombre;
                apellidosTextBox.Text = usu.apellidos;
                telefonoTextBox.Text = usu.telefono.ToString();
                EmailTextBox.Text = usu.email;
                historialTextBox.Text = usu.historial;
            }

        }

        private void nomyTelfBuscaButton_Click(object sender, EventArgs e)
        {
            String nombre = campo2.Text;
            int telf = Int32.Parse(campo3.Text);
            String url = "http://localhost:8081/clientebynombreandtelefono/?nombre=" + nombre + "&telefono=" + telf;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado al cliente");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

                var usu = listCli[0];


                MessageBox.Show("Cliente encontrado");
                dataGridView1.DataSource = listCli;

                dniTextBox.Text = usu.dni;
                nombreTextBox.Text = usu.nombre;
                apellidosTextBox.Text = usu.apellidos;
                telefonoTextBox.Text = usu.telefono.ToString();
                EmailTextBox.Text = usu.email;
                historialTextBox.Text = usu.historial;
            }
        }

        private void nomyApeBuscaButton_Click(object sender, EventArgs e)
        {
            String nombre = campo2.Text;
            String apellidos = campo3.Text;
            String url = "http://localhost:8081/clientebynombreandapellidos/?nombre=" + nombre + "&apellidos=" + apellidos;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado al cliente");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

                var usu = listCli[0];


                MessageBox.Show("Cliente encontrado");
                dataGridView1.DataSource = listCli;


                dniTextBox.Text = usu.dni;
                nombreTextBox.Text = usu.nombre;
                apellidosTextBox.Text = usu.apellidos;
                telefonoTextBox.Text = usu.telefono.ToString();
                EmailTextBox.Text = usu.email;
                historialTextBox.Text = usu.historial;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            EmpresaForm sfEmp = new EmpresaForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ProductoForm sfEmp = new ProductoForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            UsuarioForm sfEmp = new UsuarioForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            CompraForm sfEmp = new CompraForm();
            sfEmp.Show();
            this.Hide();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ReservaForm sfEmp = new ReservaForm();
            sfEmp.Show();
            this.Hide();
        }
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            SeleccionarForm selform = new SeleccionarForm();
            selform.Show();
            this.Hide();
        }

        private void notepadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p1;
            p1 = System.Diagnostics.Process.Start(Botones.path1);
        }

        private void adobeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p2;
            p2 = System.Diagnostics.Process.Start(Botones.path2);
        }

        private void NavegadorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p3;
            p3 = System.Diagnostics.Process.Start(Botones.path3);
        }


        private void campo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notepadButton_Click_1(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void CleanForm()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
