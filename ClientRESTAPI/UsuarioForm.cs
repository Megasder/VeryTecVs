using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using ClientRESTAPI.Properties;
using System.Text.RegularExpressions;
using System.Linq;
using System.Drawing.Text; //permite usar el any y el all para comprobar las letras de los Strings


namespace ClientRESTAPI
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
            actualizar();
            if (Settings.Default.Rol != 2)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            if (Settings.Default.Rol == 1)
            {
                var Tasks = new List<string>
                {
                "Normal",
                "Admin"
                };
                RolBox.DataSource = Tasks;
                rolComboBox.DataSource = Tasks;
            } else
            {
                var Tasks = new List<string>
                {
                "Normal",
                "Admin",
                "SuperAdmin"
                };
                RolBox.DataSource = Tasks;
                rolComboBox.DataSource = Tasks;
            }
                
        }

        private void actualizar()
        {
            String url = "http://localhost:8081/usuarioApellidos/";
            RestClient r = new RestClient(url, "GET");

            var respuesta = r.getItem();

            var listuser = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);
            var list = new List<Usuario>();
            if (Settings.Default.Rol == 1)
            {
                for (int i = 0; i < listuser.Count; i++)
                {
                    Usuario usuario = new Usuario();
                    usuario.password = listuser[i].password;
                    usuario.rol = listuser[i].rol;
                    usuario.descripcion = listuser[i].descripcion;
                    usuario.nombre = listuser[i].nombre;
                    usuario.apellidos = listuser[i].apellidos;
                    usuario.dni = listuser[i].dni;
                    usuario.telefono = listuser[i].telefono;
                    usuario.email = listuser[i].email;
                    usuario.direccion = listuser[i].direccion;
                    usuario.numidentificacion = listuser[i].numidentificacion;
                    if (usuario.rol != 2)
                    {
                        list.Add(usuario);
                    }
                    
                }
                dataGridView1.DataSource = list;
            } else
            {
                dataGridView1.DataSource = listuser;
            }
                     
            
        }

        private bool comprobarUsuario()
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
                MessageBox.Show("La contraseña debe ser mas grande que 6 caracteres y menor de 20");
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
                MessageBox.Show("El DNI no es valido, debe ser de 8 numeros y 1 letra");
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

            String pass = passwordTextBox.Text;
            int rol = rolComboBox.SelectedIndex;
            String descrip = descripcionTextBox.Text;
            String nombre = nombreTextBox.Text;
            String apellidos = apellidosTextBox.Text;
            String dni = dniTextBox.Text;
            int telefono = Int32.Parse(telefonoTextBox.Text);
            String email = EmailTextBox.Text;
            String dir = direccionTextBox.Text;
            String numidCol = "0";


            String url = "http://localhost:8081/usuarioAdd/";
            String urlCli = "http://localhost:8081/clienteDni/" + dni;
            String urlUser = "http://localhost:8081/usuarioDni/" + dni;

            RestClient r = new RestClient(url, "POST");
            RestClient cli = new RestClient(urlCli, "GET");
            RestClient usu = new RestClient(urlUser, "GET");

            String datos = "{" +
                "\"password\" : \"" + pass + "\", " +
                "\"rol\" : \"" + rol + "\"," +
                "\"descripcion\" : \"" + descrip + "\"," +
                "\"nombre\" : \"" + nombre + "\"," +
                "\"apellidos\" : \"" + apellidos + "\"," +
                "\"dni\" : \"" + dni + "\"," +
                "\"telefono\" : \"" + telefono + "\"," +
                "\"email\" : \"" + email + "\"," +
                "\"direccion\" : \"" + dir + "\"," +
                "\"numidentificacion\" : \"" + numidCol + "\" " +
                "}";
            String getCli = cli.getItem();
            String getUsu = usu.getItem();
            if (getCli is null)
            {
                if (getUsu is null)
                {
                    if (comprobarUsuario() == true)
                    {
                        String res = r.postItem(datos);
                        MessageBox.Show("Usuario creado con exito");
                        actualizar();
                    }
                    
                }
                else
                {
                    var desUsu = JsonConvert.DeserializeObject<Usuario>(getUsu);

                    if (desUsu.dni.Equals(dni))
                    {
                        MessageBox.Show("No se ha podido crear el Usuario, Un usuario esta usando el DNI");
                    }
                }
            }
            else
            {
                var desCli = JsonConvert.DeserializeObject<Cliente>(getCli);

                if (desCli.dni.Equals(dni))
                {
                        MessageBox.Show("No se ha podido crear el Usuario, Un cliente esta usando el DNI");
                }
                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text.Equals(null) || passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar tu contraseña vacia");
            }
            else if (passwordTextBox.Text.Equals(Settings.Default.password))
            {
                String pass = passwordTextBox.Text;
                int rol = rolComboBox.SelectedIndex;
                String descrip = descripcionTextBox.Text;
                String nombre = nombreTextBox.Text;
                String apellidos = apellidosTextBox.Text;
                String dni = dniTextBox.Text;
                int telefono = Int32.Parse(telefonoTextBox.Text);
                String email = EmailTextBox.Text;
                String dir = direccionTextBox.Text;
                String numidCol = "0";

                String url = "";
                if (pass.Length > 30)
                {
                    url = "http://localhost:8081/usuarioUpdateNormal/" + dni;
                } else
                {
                    url = "http://localhost:8081/usuarioUpdate/" + dni;
                }

                RestClient r = new RestClient(url, "PUT");

                String datosPost = "{" +
                    "\"password\" : \"" + pass + "\", " +
                    "\"rol\" : \"" + rol + "\"," +
                    "\"descripcion\" : \"" + descrip + "\"," +
                    "\"nombre\" : \"" + nombre + "\"," +
                    "\"apellidos\" : \"" + apellidos + "\"," +
                    "\"dni\" : \"" + dni + "\"," +
                    "\"telefono\" : \"" + telefono + "\"," +
                    "\"email\" : \"" + email + "\"," +
                    "\"direccion\" : \"" + dir + "\"," +
                    "\"numidentificacion\" : \"" + numidCol + "\" " +
                    "}";
                if (comprobarUsuario() == true)
                {
                    var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este usuario",
                                              "Diálogo de confirmación",
                                              MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {

                        String resPut = r.putItem(datosPost);
                        rolComboBox.SelectedIndex = 0;


                        MessageBox.Show("Usuario modificado con éxito");

                        CleanForm();
                        passwordTextBox.Clear();
                        actualizar();

                    }
                }

            }
            else
            {
                MessageBox.Show("La contraseña no coincide");
                passwordTextBox.Clear();
            }


        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {

                String dni = dniTextBox.Text;

                String url = "http://localhost:8081/usuarioDel/" + dni;

                RestClient r = new RestClient(url, "DELETE");

                var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar este usuario",
                                          "Diálogo de confirmación",
                                          MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {

                    String resDel = r.deleteItem();

                    MessageBox.Show("Usuario eliminado con éxito");

                    CleanForm();
                    actualizar();
                }
            

        }

        private void dniBuscarButton_Click(object sender, EventArgs e)
        {
            String dni = campo1.Text;
            String url = "http://localhost:8081/usuarioDni/" + dni;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var usu = JsonConvert.DeserializeObject<Usuario>(respuesta);
                List<Usuario> lista = new List<Usuario>();
                lista.Add(usu);
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {

                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = lista;                               
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
                       
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre = campo1.Text;
            String url = "http://localhost:8081/usuarioNombre/?nombre=" + nombre;


            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;

                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            String apellidos = campo1.Text;
            String url = "http://localhost:8081/usuarioApellidos/?apellidos=" + apellidos;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void direccionBuscarButton_Click(object sender, EventArgs e)
        {
            String tel = campo1.Text;
            String url = "http://localhost:8081/usuariobydireccionortelefono/?telefono=" + tel;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String email = campo1.Text;
            String url = "http://localhost:8081/usuarioEmail/?email=" + email;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;

                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void numIdColBuscarButton_Click(object sender, EventArgs e)
        {
            String numIdCol = campo1.Text;
            String url = "http://localhost:8081/usuarioNumId/?numidentificacion=" + numIdCol;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String nombre = campo2.Text;
            int rol = Int32.Parse(campo3.Text);
            String url = "http://localhost:8081/usuariobynombreandrol/?nombre=" + nombre + "&rol=" + rol;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String nombre_get = campo2.Text;
            int telefono_get = Int32.Parse(campo3.Text);
            String url = "http://localhost:8081/usuariobynombreandtelefono/?nombre=" + nombre_get + "&telefono=" + telefono_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String nombre_get = campo2.Text;
            String apellidos = campo3.Text;
            String url = "http://localhost:8081/usuariobynombreandapellidos/?nombre=" + nombre_get + "&apellidos=" + apellidos;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
            else
            {
                var listusu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);

                var usu = listusu[0];
                if (Settings.Default.Rol == 1 && usu.rol == 2)
                {
                    MessageBox.Show("El Dni que has buscado es de una cuenta superAdmin, no tienes acceso a sus datos");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listusu;

                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void dniTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClienteForm sfEmp = new ClienteForm();

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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            CompraForm sfEmp = new CompraForm();
            sfEmp.Show();
            this.Hide();
        }

        private void apellidosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ReservaForm sfEmp = new ReservaForm();
            sfEmp.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonAtras_Click(object sender, EventArgs e)
        {
            SeleccionarForm selform = new SeleccionarForm();
            selform.Show();
            this.Hide();
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

        private void RolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                
                String rol = RolBox.SelectedIndex.ToString();
                String url = "http://localhost:8081/usuarioRol/?rol=" + rol;

                RestClient r = new RestClient(url, "GET");

                String respuesta = r.getItem();


                if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
                {
                    MessageBox.Show("No se ha encontrado el usuario");
                }
                else
                {
                    
                    var listUsu = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);
                    var usu = listUsu[0];


                    MessageBox.Show("Usuario encontrado");
                    dataGridView1.DataSource = listUsu;


                    passwordTextBox.Text = usu.password;
                    switch (usu.rol)
                    {
                        case 0:
                            rolComboBox.SelectedIndex = 0;
                            break;

                        case 1:
                            rolComboBox.SelectedIndex = 1;
                            break;

                        case 2:
                            rolComboBox.SelectedIndex = 2;
                            break;
                    }
                    descripcionTextBox.Text = usu.descripcion;
                    nombreTextBox.Text = usu.nombre;
                    apellidosTextBox.Text = usu.apellidos;
                    dniTextBox.Text = usu.dni;
                    telefonoTextBox.Text = usu.telefono.ToString();
                    EmailTextBox.Text = usu.email;
                    direccionTextBox.Text = usu.direccion;
   
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            actualizar();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool errorMod = true;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; ++i)
            {

                String pass = dataGridView1.Rows[i].Cells[0].Value.ToString();
                int rol = Int32.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                String descrip = dataGridView1.Rows[i].Cells[2].Value.ToString();
                String nombre = dataGridView1.Rows[i].Cells[3].Value.ToString();
                String apellidos = dataGridView1.Rows[i].Cells[4].Value.ToString();
                String dni = dataGridView1.Rows[i].Cells[5].Value.ToString();
                int telefono = Int32.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                String email = dataGridView1.Rows[i].Cells[7].Value.ToString(); ;
                String dir = dataGridView1.Rows[i].Cells[8].Value.ToString(); ;
                String numidCol = dataGridView1.Rows[i].Cells[9].Value.ToString(); ;

                String url = "";
                if (pass.Length > 30)
                {
                    url = "http://localhost:8081/usuarioUpdateNormal/" + dni;
                }
                else
                {
                    url = "http://localhost:8081/usuarioUpdate/" + dni;
                }

                RestClient r = new RestClient(url, "PUT");

                String datosPost = "{" +
                   "\"password\" : \"" + pass + "\", " +
                   "\"rol\" : \"" + rol + "\"," +
                   "\"descripcion\" : \"" + descrip + "\"," +
                   "\"nombre\" : \"" + nombre + "\"," +
                   "\"apellidos\" : \"" + apellidos + "\"," +
                   "\"dni\" : \"" + dni + "\"," +
                   "\"telefono\" : \"" + telefono + "\"," +
                   "\"email\" : \"" + email + "\"," +
                   "\"direccion\" : \"" + dir + "\"," +
                   "\"numidentificacion\" : \"" + numidCol + "\" " +
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
            }
            else
            {
                MessageBox.Show("Algun cliente no se ha modificado debido a algun error encontrado");
                actualizar();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            String dni = dataGridView1.Rows[row].Cells[5].Value.ToString();

            String url = "http://localhost:8081/usuarioDel/" + dni;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar este usuario?",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resDel = r.deleteItem();

                MessageBox.Show("Usuario eliminado con éxito");

                CleanForm();
                actualizar();


            }
        }
    }
}
