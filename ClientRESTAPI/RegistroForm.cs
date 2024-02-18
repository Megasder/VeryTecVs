using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRESTAPI
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
            loginPageButton.FlatStyle = FlatStyle.Flat;
            loginPageButton.FlatAppearance.BorderSize = 0;
        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            InicioSesionForm loginform = new InicioSesionForm();

            loginform.Show();

            this.Hide();
        }

        private void loginPageButton_MouseHover(object sender, EventArgs e)
        {
            loginPageButton.ForeColor = System.Drawing.Color.Green;
        }

        private void loginPageButton_MouseExit(object sender, EventArgs e)
        {
            loginPageButton.ForeColor = System.Drawing.Color.Black;
            loginPageButton.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            loginPageButton.BackColor = System.Drawing.Color.FromArgb(128, 188, 213);
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            String dni = campoDNI.Text;
            String nombre = campoNombre.Text;
            String apellidos = campoApellidos.Text;
            int telefono = Int32.Parse(campoTelefono.Text);
            String email = campoEmail.Text;
            String password = campoPassword.Text;
            String password2 = campoPassword2.Text;
            String historial = campoHistorial.Text;


            String url = "http://localhost:8081/clienteAdd/";
            String url2 = "http://localhost:8081/clienteDni/" + dni;
            String url3 = "http://localhost:8081/usuarioDni/" + dni;

            RestClient r = new RestClient(url, "POST");
            RestClient c = new RestClient(url2, "GET");
            RestClient u = new RestClient(url3, "GET");

            String datos = "{" +
                "\"dni\" : \"" + dni + "\", " +
                "\"nombre\" : \"" + nombre + "\"," +
                "\"apellidos\" : \"" + apellidos + "\"," +
                "\"telefono\" : \"" + telefono + "\"," +
                "\"email\" : \"" + email + "\"," +
                "\"password\" : \"" + password + "\"," +
                "\"historial\" : \"" + historial + "\" " +
                "}";


            bool IsValidEmail(string strMail)
            {
                return Regex.IsMatch(strMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }

            bool IsValidDni(string strDni)
            {
                return Regex.IsMatch(strDni, "^(([A-Z]\\d{8})|(\\d{8}[A-Z]))$");
            }

            String cliGet = c.getItem();
            String usuGet = u.getItem();
            if (cliGet is null && usuGet is null)
            {
                if (campoPassword.TextLength < 6)
                {
                    MessageBox.Show("No se ha podido crear el usuario, la contraseña debe ser mas grande que 6 caracteres");
                }
                else if (IsValidEmail(campoEmail.Text) == false)
                {
                    MessageBox.Show("No se ha podido crear el usuario, el email no es valido.");
                }
                else if (campoNombre.Text.Any(char.IsDigit) == true || campoApellidos.Text.Any(char.IsDigit) == true)
                {
                    MessageBox.Show("No se ha podido crear el usuario, el nombre o apellido tiene algun numero");
                }
                else if (IsValidDni(campoDNI.Text) == false)
                {
                    MessageBox.Show("No se ha podido crear el usuario, el DNI no es valido");
                }
                else if (campoTelefono.TextLength < 9 || campoTelefono.TextLength > 11 || campoTelefono.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("No se ha podido crear el usuario, el telefono debe ser de tamaño entre 9 y 11 y solo contener numeros ");
                }
                else if (!campoPassword.Text.Equals(campoPassword2.Text))
                {
                    MessageBox.Show("No se ha podido crear el usuario, las contraseñas que has escrito no coinciden");
                    campoPassword.Clear();
                    campoPassword2.Clear();
                }
                else if (campoDNI == null || campoNombre == null || campoApellidos == null || campoTelefono == null || campoEmail == null || campoPassword == null || campoPassword2 == null ||
                    campoDNI.Text.Equals("") || campoNombre.Text.Equals("") || campoApellidos.Text.Equals("") || campoTelefono.Text.Equals("") || campoEmail.Text.Equals("") || campoPassword.Text.Equals("") || campoPassword2.Text.Equals(""))
                {
                    MessageBox.Show("Falta algun dato, comprueba que has completado todos los campos obligatorios");
                }
                else
                {
                    String res = r.postItem(datos);

                    MessageBox.Show("Usuario creado correctamente");
                    InicioSesionForm loginform = new InicioSesionForm();

                    loginform.Show();

                    this.Hide();
                }
            }
            else
            {
                if (cliGet is null)
                {
                 MessageBox.Show("No se ha podido crear el cliente, un Usuario ya usa el DNI");

                } else
                {
                 MessageBox.Show("No se ha podido crear el cliente, un Cliente ya usa el DNI");
                }

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
