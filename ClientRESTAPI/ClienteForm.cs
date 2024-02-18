using ClientRESTAPI.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRESTAPI
{
    public partial class ClienteForm : Form
    {
       
        public ClienteForm()
        {
            InitializeComponent();
            actualizar();

            dataGridView1.Columns[5].Visible = false;

            if (Settings.Default.tipo == 0)
            {
                this.Width = 700;
                this.Height = 461;
                toolStripLabel1.Visible = false;
                toolStripLabel3.Visible = false;
                button1.Visible = false;
                eliminarButton.Visible = false;
                BuscadorBox1.Visible = false;
                groupBox2.Visible = false;
                dataGridView1.Visible = false;
                String urlCli = "http://localhost:8081/clienteDni/" + Settings.Default.Dni;
                RestClient cli = new RestClient(urlCli, "GET");
                String getCli = cli.getItem();
                var cliConvert = JsonConvert.DeserializeObject<Cliente>(getCli);
                dniTextBox.Text = cliConvert.dni;
                nombreTextBox.Text = cliConvert.nombre;
                apellidosTextBox.Text = cliConvert.apellidos;
                telefonoTextBox.Text = cliConvert.telefono.ToString();
                EmailTextBox.Text = cliConvert.email;
                historialTextBox.Text = cliConvert.historial;
                dineroTextBox.Text = cliConvert.dinero.ToString();
            } else
            {
                dataGridView1.Columns[7].Visible = false;
                label5.Visible = false;
                dineroTextBox.Visible = false;

            }
            if (Settings.Default.Rol == 0 && Settings.Default.tipo == 1)
            {
                button1.Visible = false;
                eliminarButton.Visible = false;
                button4.Visible = false;
                toolStripLabel1.Visible = false;
                toolStripLabel3.Visible = false;
                toolStripLabel4.Visible = false;
            }

        }

        private void actualizar()
        {
            String url = "http://localhost:8081/clienteNombre/";
            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            var listprod = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

            dataGridView1.DataSource = listprod;
        }

        private bool comprobarCliente()
        {
            bool IsValidEmail(string strMail)
            {
                return Regex.IsMatch(strMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }

            bool IsValidDni(string strDni)
            {
                return Regex.IsMatch(strDni, "^(([A-Z]\\d{8})|(\\d{8}[A-Z]))$");
            }

            if (passwordTextBox.TextLength < 6)
            {
                MessageBox.Show("La contraseña debe ser mas grande que 6 caracteres");
                return false;
            }
            else if (IsValidEmail(EmailTextBox.Text) == false)
            {
                MessageBox.Show("El email no es valido, debes escribir mail@mail.com.");
                return false;
            }
            else if (nombreTextBox.Text.Any(char.IsDigit) == true || apellidosTextBox.Text.Any(char.IsDigit) == true)
            {
                MessageBox.Show("El nombre o apellido tiene algun numero");
                return false;
            }
            else if (IsValidDni(dniTextBox.Text) == false)
            {
                MessageBox.Show("El DNI no es valido, debe tener 8 numeros y 1 letra");
                return false;
            }
            else if (telefonoTextBox.TextLength < 9 || telefonoTextBox.TextLength > 11 || telefonoTextBox.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("El telefono debe ser de tamaño entre 9 y 11 y solo contener numeros ");
                return false;
            }
            else if (passwordTextBox.Text == null || passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar la contraseña en blanco");
                return false;
            }
            else
            {
                return true;
            }
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
            float dinero = float.Parse(dineroTextBox.Text);
            

            String url = "http://localhost:8081/clienteAdd/";
            String urlCli = "http://localhost:8081/clienteDni/" + dni;
            String urlUser = "http://localhost:8081/usuarioDni/" + dni;

            RestClient r = new RestClient(url, "POST");
            RestClient cli = new RestClient(urlCli, "GET");
            RestClient usu = new RestClient(urlUser, "GET");

            String datos = "{" +
                "\"dni\" : \"" + dni + "\", " +
                "\"nombre\" : \"" + nombre + "\"," +
                "\"apellidos\" : \"" + apellidos + "\"," +
                "\"telefono\" : \"" + telefono + "\"," +
                "\"email\" : \"" + email + "\"," +
                "\"password\" : \"" + password + "\"," +
                "\"historial\" : \"" + historial + "\", " +
                "\"dinero\" : \"" + dinero + "\" " +
                "}";

            String getCli = cli.getItem();
            String getUsu = usu.getItem();
            if (getCli is null)
            {
                if (getUsu is null)
                {
                    if(comprobarCliente() == true)
                    {
                        String res = r.postItem(datos);
                        MessageBox.Show("Cliente creado con exito");
                        actualizar();
                    }
                }
                else
                {
                    var desUsu = JsonConvert.DeserializeObject<Usuario>(getUsu);

                    if (desUsu.dni.Equals(dni))
                    {
                        MessageBox.Show("No se ha podido crear el cliente, Un usuario esta usando el DNI");
                    }
                }
            }
            else
            {

               var desCli = JsonConvert.DeserializeObject<Cliente>(getCli);

               if (desCli.dni.Equals(dni))
               {
                   MessageBox.Show("No se ha podido crear el cliente, Un cliente esta usando el DNI");
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
            float dinero = float.Parse(dineroTextBox.Text);

            if (Settings.Default.tipo == 0)
            {
                if (passwordTextBox.Text.Equals(null) || passwordTextBox.Text.Equals(""))
                {
                    MessageBox.Show("No puedes dejar tu contraseña vacia");
                }
                else if (passwordTextBox.Text.Equals(Settings.Default.password))
                {

                    String url = "http://localhost:8081/clienteMod/" + dni;

                    RestClient r = new RestClient(url, "PUT");

                    String datosPost = "{" +
                        "\"nombre\" : \"" + nombre + "\"," +
                        "\"apellidos\" : \"" + apellidos + "\"," +
                        "\"dni\" : \"" + dni + "\"," +
                        "\"telefono\" : \"" + telefono + "\"," +
                        "\"email\" : \"" + email + "\"," +
                        "\"password\" : \"" + password + "\"," +
                        "\"historial\" : \"" + historial + "\", " +
                        "\"dinero\" : \"" + dinero + "\" " +
                        "}";
                    if (comprobarCliente() == true)
                    {
                        var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este cliente",
                                              "Diálogo de confirmación",
                                              MessageBoxButtons.OKCancel);
                        if (confirmResult == DialogResult.OK)
                        {

                            String resPut = r.putItem(datosPost);


                            MessageBox.Show("Cliente modificado con éxito");
                            passwordTextBox.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide");
                    passwordTextBox.Clear();
                }
            } else
            {
                if (passwordTextBox.Text.Equals(null) || passwordTextBox.Text.Equals(""))
                {
                    MessageBox.Show("No puedes dejar tu contraseña vacia");
                }
                String url = "";
                if (password.Length > 30)
                {
                    url = "http://localhost:8081/clienteModNormal/" + dni;
                }
                else
                {
                    url = "http://localhost:8081/clienteMod/" + dni;
                }

                RestClient r = new RestClient(url, "PUT");

                    String datosPost = "{" +
                        "\"nombre\" : \"" + nombre + "\"," +
                        "\"apellidos\" : \"" + apellidos + "\"," +
                        "\"dni\" : \"" + dni + "\"," +
                        "\"telefono\" : \"" + telefono + "\"," +
                        "\"email\" : \"" + email + "\"," +
                        "\"password\" : \"" + password + "\"," +
                        "\"historial\" : \"" + historial + "\", " +
                        "\"dinero\" : \"" + dinero + "\" " +
                        "}";
                    if (comprobarCliente() == true)
                    {
                        var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este cliente",
                                              "Diálogo de confirmación",
                                              MessageBoxButtons.OKCancel);
                        if (confirmResult == DialogResult.OK)
                        {

                            String resPut = r.putItem(datosPost);


                            MessageBox.Show("Cliente modificado con éxito");
                            CleanForm();
                        }
                    }
                else
                {
                    MessageBox.Show("La contraseña no coincide");
                    passwordTextBox.Clear();
                }
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
                dineroTextBox.Text = usu.dinero.ToString();

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
                dineroTextBox.Text = usu.dinero.ToString();

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
                dineroTextBox.Text = usu.dinero.ToString();
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
                dineroTextBox.Text = usu.dinero.ToString();
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
                dineroTextBox.Text = usu.dinero.ToString();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            UsuarioForm sfEmp = new UsuarioForm();

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
            EmpresaForm sfEmp = new EmpresaForm();

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
            if (Settings.Default.tipo == 0)
            {
                ClienteInicioForm selform = new ClienteInicioForm();
                selform.Show();
                this.Hide();
            }
            else
            {
                SeleccionarForm selform = new SeleccionarForm();
                selform.Show();
                this.Hide();
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dineroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool errorMod = true;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; ++i)
            {

                String dni = dataGridView1.Rows[i].Cells[0].Value.ToString();
                String nombre = dataGridView1.Rows[i].Cells[1].Value.ToString();
                String apellidos = dataGridView1.Rows[i].Cells[2].Value.ToString();
                int telefono = Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                String email = dataGridView1.Rows[i].Cells[4].Value.ToString();
                String pass = dataGridView1.Rows[i].Cells[5].Value.ToString();
                String historial = dataGridView1.Rows[i].Cells[6].Value.ToString();
                float dinero = float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());

                String url = "";
                if (pass.Length > 30)
                {
                    url = "http://localhost:8081/clienteModNormal/" + dni;
                }
                else
                {
                    url = "http://localhost:8081/clienteMod/" + dni;
                }

                RestClient r = new RestClient(url, "PUT");

                String datosPost = "{" +
                    "\"nombre\" : \"" + nombre + "\"," +
                    "\"apellidos\" : \"" + apellidos + "\"," +
                    "\"dni\" : \"" + dni + "\"," +
                    "\"telefono\" : \"" + telefono + "\"," +
                    "\"email\" : \"" + email + "\"," +
                    "\"password\" : \"" + pass + "\"," +
                    "\"historial\" : \"" + historial + "\", " +
                    "\"dinero\" : \"" + dinero + "\" " +
                    "}";
                bool IsValidEmail(string strMail)
                {
                    return Regex.IsMatch(strMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                }
                bool IsValidDni(string strDni)
                {
                    return Regex.IsMatch(strDni, "^(([A-Z]\\d{8})|(\\d{8}[A-Z]))$");
                }
                
                if (pass.Length < 6)
                {
                    MessageBox.Show("La contraseña debe ser mas grande que 6 caracteres");
                    errorMod = true;
                }
                else if (IsValidEmail(email) == false)
                {
                    MessageBox.Show("El email no es valido, debes escribir mail@mail.com.");
                    errorMod = true;
                }
                else if (nombre.Any(char.IsDigit) == true || apellidos.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("El nombre o apellido tiene algun numero");
                    errorMod = true;
                }
                else if (IsValidDni(dni) == false)
                {
                    MessageBox.Show("El DNI no es valido, debe ser de 8 numeros y 1 letra");
                    errorMod = true;
                }
                else if (telefono.ToString().Length < 9 || telefono.ToString().Length > 11 || telefono.ToString().All(char.IsDigit) == false)
                {
                    MessageBox.Show("El telefono debe ser de tamaño entre 9 y 11 y solo contener numeros ");
                    errorMod = true;
                }
                else if (pass == null || pass.Equals(""))
                {
                    MessageBox.Show("No puedes dejar la contraseña en blanco");
                    errorMod = true;
                }
                else
                {
                    errorMod = false;
                    String resPut = r.putItem(datosPost);

                }

            }
            if (errorMod == false)
            {
                MessageBox.Show("Clientes modificado con éxito");
                actualizar();
            } else
            {
                MessageBox.Show("Algun cliente no se ha modificado debido a algun error encontrado");
                actualizar();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            String dni = dataGridView1.Rows[row].Cells[0].Value.ToString();

            String url = "http://localhost:8081/clienteDel/" + dni;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar este producto",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resDel = r.deleteItem();

                MessageBox.Show("Producto eliminado con éxito");

                CleanForm();
                actualizar();


            }
        }
    }
}
