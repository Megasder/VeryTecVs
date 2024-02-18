using ClientRESTAPI.Properties;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ClientRESTAPI
{
    public partial class CompraForm : Form
    {
        public CompraForm()
        {          
            InitializeComponent();
            if (Settings.Default.tipo == 0)
            {
                toolStripLabel2.Visible = false;
                toolStripLabel4.Visible = false;
                groupBox1.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
                this.Height = 507;
                actualizar();
                dataGridView1.ReadOnly = true;
            }
            else
            {
                actualizar();
                dataGridView1.Columns["clienteDni"].ReadOnly = true;
                dataGridView1.Columns["productoNom"].ReadOnly = true;
                dataGridView1.Columns["productoCat"].ReadOnly = true;
            }
            dataGridView1.Columns[0].Visible = false;
        }

        private void actualizar()
        {
            if (Settings.Default.tipo == 0)
            {
                String url = "http://localhost:8081/compraDniCliente/" + Settings.Default.Dni;
                RestClient r = new RestClient(url, "GET");
                String respuesta = r.getItem();
                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
                var list = new List<CompraDataGridModel>();
                for (int i = 0; i < listcomp.Count; i++)
                {
                    var modelGrid = new CompraDataGridModel();
                    modelGrid.id = listcomp[i].id_compra;
                    modelGrid.fecha = listcomp[i].fecha;
                    modelGrid.hora = listcomp[i].hora;
                    modelGrid.cantidad = listcomp[i].cantidad;
                    modelGrid.clienteDni = listcomp[i].cliente.dni;
                    modelGrid.productoNom = listcomp[i].producto.nombre;
                    modelGrid.productoCat = listcomp[i].producto.categoria;
                    list.Add(modelGrid);
                }
                dataGridView1.DataSource = list;
            }
            else
            {
                String url = "http://localhost:8081/comprabyfechaorhora/";
                RestClient r = new RestClient(url, "GET");
                String respuesta = r.getItem();
                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);
                var list = new List<CompraDataGridModel>();
                for (int i = 0; i < listcomp.Count; i++)
                {
                    var modelGrid = new CompraDataGridModel();
                    modelGrid.id = listcomp[i].id_compra;
                    modelGrid.fecha = listcomp[i].fecha;
                    modelGrid.hora = listcomp[i].hora;
                    modelGrid.cantidad = listcomp[i].cantidad;
                    modelGrid.clienteDni = listcomp[i].cliente.dni;
                    modelGrid.productoNom = listcomp[i].producto.nombre;
                    modelGrid.productoCat = listcomp[i].producto.categoria;
                    list.Add(modelGrid);
                }
                dataGridView1.DataSource = list;

            }
        }

        private void anyadirCompraButton_Click(object sender, EventArgs e)   
        {
            String fecha = fechaAnyadirTextBox.Text;
            String hora = horaAnyadirTextBox.Text;
            int cantidad = Int32.Parse(cantidadAnyadirTextBox.Text);

            String url = "http://localhost:8081/compraAdd/";

            RestClient r = new RestClient(url, "POST");

            String datos = "{" +
                "\"fecha\" : \"" + fecha + "\", " +
                "\"hora\" : \"" + hora + "\"," +
                "\"cantidad\" : \"" + cantidad + "\"" +
                "}";
            String respuesta = r.postItem(datos);

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha podido registrar la compra");
            }
            else
            {

                MessageBox.Show("La compra se ha registrado con éxito");

            }
        }

        private void modCompraButton_Click(object sender, EventArgs e)
        {
            String fecha = fechaAnyadirTextBox.Text;
            String hora = horaAnyadirTextBox.Text;
            int cantidad = Int32.Parse(cantidadAnyadirTextBox.Text);
            String id_compra = Settings.Default.compraId;

            String url = "http://localhost:8081/compraMod/" + id_compra;

            RestClient r = new RestClient(url, "PUT");

            String datosPost = "{" +
                        "\"fecha\" : \"" + fecha + "\", " +
                        "\"hora\" : \"" + hora + "\"," +
                        "\"cantidad\" : \"" + cantidad + "\"," +
                        "\"cliente\" : {" +
                        "\"dni\" : \"" + Settings.Default.compraClienteDni + "\"" +
                        "},\"producto\" : {\"idProducto\":\"" + Settings.Default.compraProductoId + "\"}}"
                        ;
            MessageBox.Show(datosPost);
            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar esta compra",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);


                MessageBox.Show("Compra modificada con éxito");

                CleanForm();
                actualizar();

            }


        }

        private void eliminarCompraButton_Click(object sender, EventArgs e)
        {
            String id_compra = Settings.Default.compraId;

            String url = "http://localhost:8081/compraDel/" + id_compra;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar esta compra",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resDel = r.deleteItem();

                MessageBox.Show("Compra eliminada con éxito");

                CleanForm();
                actualizar();


            }
        }

        private void buscarIdCompra_Click(object sender, EventArgs e)
        {
            String id_compra = textBox1.Text;
            String url = "http://localhost:8081/compraID/" + id_compra;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la compra");
            }
            else
            {
                MessageBox.Show("Se ha encontrado la compra");

                var comp = JsonConvert.DeserializeObject<Compra>(respuesta);
                List<Compra> lista = new List<Compra>();
                lista.Add(comp);
                dataGridView1.DataSource = lista;

                fechaAnyadirTextBox.Text = comp.fecha;
                horaAnyadirTextBox.Text = comp.hora;
                cantidadAnyadirTextBox.Text = comp.cantidad.ToString();
                Settings.Default.compraClienteDni = comp.cliente.dni.ToString();
                Settings.Default.compraProductoId = comp.producto.idProducto.ToString();
                Settings.Default.compraId = comp.id_compra.ToString();
            }
        }

        private void buscarHoraButton_Click(object sender, EventArgs e)
        {
            String hora = textBox1.Text;
            String url = "http://localhost:8081/comprabyfechaorhora/?hora=" + hora;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la compra");
            }
            else
            {
                MessageBox.Show("Se ha encontrado la compra");

                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);


                var comp = listcomp[0];
                dataGridView1.DataSource = listcomp;

                fechaAnyadirTextBox.Text = comp.fecha;
                horaAnyadirTextBox.Text = comp.hora;
                cantidadAnyadirTextBox.Text = comp.cantidad.ToString();
                Settings.Default.compraClienteDni = comp.cliente.dni.ToString();
                Settings.Default.compraProductoId = comp.producto.idProducto.ToString();
                Settings.Default.compraId = comp.id_compra.ToString();
            }
        }

        private void fechaBuscarButton_Click(object sender, EventArgs e)
        {
            String fecha = textBox1.Text;
            String url = "http://localhost:8081/comprabyfechaorhora/?fecha=" + fecha;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado la compra");
            }
            else
            {
                MessageBox.Show("Se ha encontrado la compra");

                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);


                var comp = listcomp[0];
                dataGridView1.DataSource = listcomp;

                fechaAnyadirTextBox.Text = comp.fecha;
                horaAnyadirTextBox.Text = comp.hora;
                cantidadAnyadirTextBox.Text = comp.cantidad.ToString();
                Settings.Default.compraClienteDni = comp.cliente.dni.ToString();
                Settings.Default.compraProductoId = comp.producto.idProducto.ToString();
                Settings.Default.compraId = comp.id_compra.ToString();
            }
        }

        private void cantidadBuscarButton_Click(object sender, EventArgs e)
        {
            String cantidad = textBox1.Text;
            String url = "http://localhost:8081/compraCantidad/?cantidad=" + cantidad;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                MessageBox.Show("Se ha encontrado el producto");

                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);


                var comp = listcomp[0];
                dataGridView1.DataSource = listcomp;

                fechaAnyadirTextBox.Text = comp.fecha;
                horaAnyadirTextBox.Text = comp.hora;
                cantidadAnyadirTextBox.Text = comp.cantidad.ToString();
                Settings.Default.compraClienteDni = comp.cliente.dni.ToString();
                Settings.Default.compraProductoId = comp.producto.idProducto.ToString();
                Settings.Default.compraId = comp.id_compra.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fecha = campoBuscar1.Text;
            String hora = campoBuscar2.Text;
           
            String url = "http://localhost:8081/comprabyfechaandhora/?fecha=" + fecha + "&hora=" + hora;
            
            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                MessageBox.Show("Se ha encontrado el producto");

                var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuesta);


                var comp = listcomp[0];
                dataGridView1.DataSource = listcomp;

                fechaAnyadirTextBox.Text = comp.fecha;
                horaAnyadirTextBox.Text = comp.hora;
                cantidadAnyadirTextBox.Text = comp.cantidad.ToString();
                Settings.Default.compraClienteDni = comp.cliente.dni.ToString();
                Settings.Default.compraProductoId = comp.producto.idProducto.ToString();
                Settings.Default.compraId = comp.id_compra.ToString();
            }

        }

        private void CompraForm_Load(object sender, EventArgs e)
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
            UsuarioForm sdf = new UsuarioForm();

            sdf.Show();

            this.Hide();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            ProductoForm sfEmp = new ProductoForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            EmpresaForm sfEmp = new EmpresaForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ReservaForm sfEmp = new ReservaForm();
            sfEmp.Show();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void cantidadAnyadirTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String urlC = "http://localhost:8081/comprabyfechaorhora/";
            RestClient rC = new RestClient(urlC, "GET");
            String respuestaC = rC.getItem();
            var listcomp = JsonConvert.DeserializeObject<List<Compra>>(respuestaC);

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; ++i)
            {
                string id_compra = dataGridView1.Rows[i].Cells[0].Value.ToString();
                String fecha = dataGridView1.Rows[i].Cells[1].Value.ToString();
                String hora = dataGridView1.Rows[i].Cells[2].Value.ToString();
                int cantidad = Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                String clienteDni = dataGridView1.Rows[i].Cells[4].Value.ToString();
                String productoId = listcomp[i].producto.idProducto.ToString();


                String url = "http://localhost:8081/compraMod/" + id_compra;

                RestClient r = new RestClient(url, "PUT");

                String datosPost = "{" +
                            "\"fecha\" : \"" + fecha + "\", " +
                            "\"hora\" : \"" + hora + "\"," +
                            "\"cantidad\" : \"" + cantidad + "\"," +
                            "\"cliente\" : {" +
                            "\"dni\" : \"" + clienteDni + "\"" +
                            "},\"producto\" : {\"idProducto\":\"" + productoId + "\"}}"
                            ;
                String resPut = r.putItem(datosPost);

            }

            MessageBox.Show("Productos modificado con éxito");
            actualizar();     
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
