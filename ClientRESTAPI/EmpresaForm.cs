using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;



namespace ClientRESTAPI
{
    public partial class EmpresaForm : Form
    {
        public EmpresaForm()
        {
            InitializeComponent();

        }

        private void EmpresaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cif_cat = cif.Text;
            String nombre_cat = nombre.Text;
            String web_cat = web.Text;
            int telefono_cat = Int32.Parse(telefono.Text);
            String email_cat = email.Text;
            String direccion_cat = direccion.Text;
            String actividad_cat = actividad.Text;



            String url = "http://localhost:8081/empresaAdd/";
            String url2 = "http://localhost:8081/empresaCif/" + cif_cat;


            RestClient r = new RestClient(url, "POST");
            RestClient g = new RestClient(url2, "GET");

            String datos = "{" +
                "\"cif\" : \"" + cif_cat + "\", " +
                "\"nombre\" : \"" + nombre_cat + "\", " +
                "\"web\" : \"" + web_cat + "\", " +
                "\"telefono\" : \"" + telefono_cat + "\", " +
                "\"email\" : \"" + email_cat + "\", " +
                "\"direccion\" : \"" + direccion_cat + "\", " +
                "\"actividad\" : \"" + actividad_cat + "\" " +
                "}";

            String geto = g.getItem();


            if (geto is null)
            {
                String res = r.postItem(datos);
                MessageBox.Show("Empresa creada con exito");
            }
            else
            {
                var emp = JsonConvert.DeserializeObject<Empresa>(geto);

                if (emp.cif.Equals(cif_cat))
                {
                    MessageBox.Show("No se ha podido crear la empresa, CIF en uso");
                }
            }
        }

        private void modEmpresaButton_Click_1(object sender, EventArgs e)
        {
            string cif_put = cif.Text;
            String nombre_put = nombre.Text;
            String web_put = web.Text;
            int telefono_put = Int32.Parse(telefono.Text);
            String email_put = email.Text;
            String direccion_put = direccion.Text;
            String actividad_put = actividad.Text;

            String url = "http://localhost:8081/empresaMod/" + cif_put;

            RestClient r = new RestClient(url, "PUT");

            String datosPost = "{" +
                "\"cif\" : \"" + cif_put + "\", " +
                "\"nombre\" : \"" + nombre_put + "\", " +
                "\"web\" : \"" + web_put + "\", " +
                "\"telefono\" : \"" + telefono_put + "\", " +
                "\"email\" : \"" + email_put + "\", " +
                "\"direccion\" : \"" + direccion_put + "\", " +
                "\"actividad\" : \"" + actividad_put + "\" " +
                "}";

            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar esta empresa",
                                       "Diálogo de confirmación",
                                       MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);


                MessageBox.Show("Empresa modificada con éxito");

                CleanForm();

            }
            else
            {
            }
        }

        private void delEmpresaButton_Click_1(object sender, EventArgs e)
        {
            String id_del = cif.Text;

            String url = "http://localhost:8081/empresaDel/" + id_del;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar esta empresa",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resDel = r.deleteItem();

                MessageBox.Show("Empresa eliminada con éxito");

                CleanForm();


            }
            else
            {
            }
        }
        private void getCif_Click_1(object sender, EventArgs e)
        {
            String cif_get = campo1.Text;
            /* No se comprueban errores */
            String url = "http://localhost:8081/empresaCif/" + cif_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var emp = JsonConvert.DeserializeObject<Empresa>(respuesta);
                List<Empresa> lista = new List<Empresa>();
                lista.Add(emp);

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = lista;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }
        private void getActividad_Click_1(object sender, EventArgs e)
        {
            String actividad_get = campo1.Text;
            String url = "http://localhost:8081/empresaActividad/?actividad=" + actividad_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getNombre_Click_1(object sender, EventArgs e)
        {
            String nombre_get = campo1.Text;
            String url = "http://localhost:8081/empresaNombre/?nombre=" + nombre_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {

                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getWeb_Click_1(object sender, EventArgs e)
        {
            String web_get = campo1.Text;
            String url = "http://localhost:8081/empresabyweboremail/?web=" + web_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getTelefono_Click_1(object sender, EventArgs e)
        {
            int telefono_get = Int32.Parse(campo1.Text);
            //String telefono_get = telefonoGet.Text;
            String url = "http://localhost:8081/empresabydireccionortelefono/?telefono=" + telefono_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getEmail_Click_1(object sender, EventArgs e)
        {
            String email_get = campo1.Text;
            String url = "http://localhost:8081/empresabyweboremail/?email=" + email_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getDireccion_Click_1(object sender, EventArgs e)
        {
            String direccion_get = campo1.Text;
            String url = "http://localhost:8081/empresabydireccionortelefono/?direccion=" + direccion_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getNombreTelefono_Click_1(object sender, EventArgs e)
        {
            String nombre_get = campo2.Text;
            int telefono_get = Int32.Parse(campo3.Text);
            String url = "http://localhost:8081/empresabynombreandtelefono/?nombre=" + nombre_get + "&telefono=" + telefono_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getNombreEmail_Click_1(object sender, EventArgs e)
        {
            String nombre_get = campo2.Text;
            String email_get = campo3.Text;

            String url = "http://localhost:8081/empresabynombreandemail/?nombre=" + nombre_get + "&email=" + email_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
        }

        private void getNombreDireccion_Click_1(object sender, EventArgs e)
        {
            String nombre_get = campo2.Text;
            String direccion_get = campo3.Text;
            String url = "http://localhost:8081/empresabynombreanddireccion/?nombre=" + nombre_get + "&direccion=" + direccion_get;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la empresa");
            }
            else
            {
                var listCli = JsonConvert.DeserializeObject<List<Empresa>>(respuesta);

                var emp = listCli[0];

                MessageBox.Show("Empresa encontrada");
                dataGridView1.DataSource = listCli;

                cif.Text = emp.cif;
                nombre.Text = emp.nombre;
                web.Text = emp.web;
                telefono.Text = emp.telefono.ToString();
                email.Text = emp.email;
                direccion.Text = emp.direccion;
                actividad.Text = emp.actividad;
            }
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
            UsuarioForm sfEmp = new UsuarioForm();

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

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
