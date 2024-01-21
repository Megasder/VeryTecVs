using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            bool inicio = false;

            String dni = usucredentialsTextBox.Text;
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

                String usupass = usu.password;

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

                if (usupass.Equals(EncryptPass))
                {
                    SeleccionarForm sle = new SeleccionarForm();

                    sle.Show();

                    this.Hide();
                }
                else {
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
            registroPageButton.BackColor = System.Drawing.Color.FromArgb(146, 211, 239);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            registroPageButton.BackColor = System.Drawing.Color.FromArgb(128, 188, 213);
        }


        private void usucredentialsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
