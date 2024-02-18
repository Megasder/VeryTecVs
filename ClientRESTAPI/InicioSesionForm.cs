using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using ClientRESTAPI.Properties;

namespace ClientRESTAPI
{
    public partial class InicioSesionForm : Form
    {
        public InicioSesionForm()
        {
            InitializeComponent();
            registroPageButton.FlatStyle = FlatStyle.Flat;
            registroPageButton.FlatAppearance.BorderSize = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String dniUser = usucredentialsTextBox.Text;
            String urlUser = "http://localhost:8081/usuarioDni/" + dniUser;

            RestClient rUser = new RestClient(urlUser, "GET");

            String respuestaU = rUser.getItem();

            String dniClient = usucredentialsTextBox.Text;
            String urlClient = "http://localhost:8081/clienteDni/" + dniClient;

            RestClient rClient = new RestClient(urlClient, "GET");

            String respuestaC = rClient.getItem();


            if (String.IsNullOrEmpty(respuestaU) || String.IsNullOrWhiteSpace(respuestaU) || respuestaU.Equals("[]"))
            {
                if (String.IsNullOrEmpty(respuestaC) || String.IsNullOrWhiteSpace(respuestaC) || respuestaC.Equals("[]"))
                {
                    MessageBox.Show("No se ha encontrado el Usuario");
                }
                else
                {
                    var cli = JsonConvert.DeserializeObject<Cliente>(respuestaC);
                    String pass = cli.password;
                    //Encrypt start
                    var sha256 = SHA256.Create();
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passCrdentialsTextBox.Text));

                    var sb = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        sb.Append(bytes[i].ToString("x2"));
                    }
                    String EncryptPass = sb.ToString();
                    //Encrypt End

                    if (pass.Equals(EncryptPass))
                    {
                        
                        Settings.Default.tipo = 0;
                        Settings.Default.Dni = cli.dni;
                        Settings.Default.Dinero = cli.dinero;
                        Settings.Default.password = passCrdentialsTextBox.Text;

                        ClienteInicioForm sle = new ClienteInicioForm();

                        sle.Show();

                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
                
            }
            else if (String.IsNullOrEmpty(respuestaC) || String.IsNullOrWhiteSpace(respuestaC) || respuestaC.Equals("[]"))
                if (String.IsNullOrEmpty(respuestaU) || String.IsNullOrWhiteSpace(respuestaU) || respuestaU.Equals("[]"))
                {
                    MessageBox.Show("No se ha encontrado el Usuario");
                }
                else
                {
                    var usu = JsonConvert.DeserializeObject<Usuario>(respuestaU);
                    String pass = usu.password;
                    //Encrypt start
                    var sha256 = SHA256.Create();
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passCrdentialsTextBox.Text));

                    var sb = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        sb.Append(bytes[i].ToString("x2"));
                    }
                    String EncryptPass = sb.ToString();
                    //Encrypt End

                    if (pass.Equals(EncryptPass))
                    {
                        
                        Settings.Default.Rol = (int)usu.rol;
                        Settings.Default.tipo = 1;
                        Settings.Default.password = passCrdentialsTextBox.Text;

                        SeleccionarForm sle = new SeleccionarForm();

                        sle.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }


        }

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroForm reform = new RegistroForm();

            reform.Show();

            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            registroPageButton.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_MouseExit(object sender, EventArgs e)
        {
            registroPageButton.ForeColor = System.Drawing.Color.Black;
            registroPageButton.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            registroPageButton.BackColor = System.Drawing.Color.FromArgb(128, 188, 213);
        }


        private void usucredentialsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
