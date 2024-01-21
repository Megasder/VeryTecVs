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

namespace ClientRESTAPI
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            String pass = passwordTextBox.Text;
            int rol = 0;
            String descrip = descripcionTextBox.Text;
            String nombre = nombreTextBox.Text;
            String apellidos = apellidosTextBox.Text;
            String dni = dniTextBox.Text;
            int telefono = Int32.Parse(telefonoTextBox.Text);
            String email = EmailTextBox.Text;
            String dir = direccionTextBox.Text;
            String numidCol = numIdColTextBox.Text;


            String url = "http://localhost:8081/usuarioAdd/";
            String url2 = "http://localhost:8081/usuarioDni/" + dni;

            RestClient r = new RestClient(url, "POST");
            RestClient g = new RestClient(url2, "GET");

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
            String geto = g.getItem();
            if (geto is null)
            {
                String res = r.postItem(datos);
                MessageBox.Show("Usuario creado con exito");
            }
            else
            {
                var usu = JsonConvert.DeserializeObject<Cliente>(geto);

                if (usu.dni.Equals(dni))
                {
                    MessageBox.Show("No se ha podido crear el usuario, DNI en uso");
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
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
            String numidCol = numIdColTextBox.Text;

            String url = "http://localhost:8081/usuarioUpdate/" + dni;

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
            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este usuario",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);
                rolComboBox.SelectedIndex = 0;


                MessageBox.Show("Usuario modificado con éxito");

                CleanForm();

            }
            else
            {
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
            }
            else
            {
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


                MessageBox.Show("Usuario encontrado");
                dataGridView1.DataSource = lista;


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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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

                MessageBox.Show("Usuario encontrado");
                dataGridView1.DataSource = listusu;


                passwordTextBox.Text = usu.password;
                switch (usu.rol)
                {
                    case 0:
                        rolComboBox.SelectedIndex= 0; 
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
                numIdColTextBox.Text = usu.numidentificacion;
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
                numIdColTextBox.Text = usu.numidentificacion;
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
            EmpresaForm sfEmp = new EmpresaForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            ProductoForm sfEmp = new ProductoForm();

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
    }
}
