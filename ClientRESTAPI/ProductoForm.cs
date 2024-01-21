using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClientRESTAPI
{
    
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
            BuscadorAvanzado.Hide();
            iconButtonAvanzado.Enabled = false;
        }

        private void addButon_Click(object sender, EventArgs e)
        {

            String nombre = nombreTextBox.Text;
            String categoria = categoriaTextBox.Text;
            float precio = float.Parse(precioTextBox.Text);
            int iva = Int32.Parse(ivaTextBox.Text);
            int descuento = Int32.Parse(descuentoTextBox.Text);
            int cantidad = Int32.Parse(cantidadTextBox.Text);

            String url = "http://localhost:8081/productoAdd/";

            RestClient r = new RestClient(url, "POST");

            String datos = "{" +
                "\"nombre\" : \"" + nombre + "\", " +
                "\"categoria\" : \"" + categoria + "\"," +
                "\"precio\" : \"" + precio + "\"," +
                "\"iva\" : \"" + iva + "\"," +
                "\"descuento\" : \"" + descuento + "\"," +
                "\"cantidad\" : \"" + cantidad + "\"" +
                "}";
            String respuesta = r.postItem(datos);

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha podido crear el producto");
            }
            else
            {

                MessageBox.Show("El producto se ha creado con éxito");

            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            long id = (long)Convert.ToDouble(campoBuscarTextBox.Text);
            String nombre = nombreTextBox.Text;
            String categoria = categoriaTextBox.Text;
            float precio = float.Parse(precioTextBox.Text);
            int iva = Int32.Parse(ivaTextBox.Text);
            int descuento = Int32.Parse(descuentoTextBox.Text);
            int cantidad = Int32.Parse(cantidadTextBox.Text);

            String url = "http://localhost:8081/productoMod/" + id;

            RestClient r = new RestClient(url, "PUT");

            String datosPost = "{" +
                "\"nombre\" : \"" + nombre + "\", " +
                "\"categoria\" : \"" + categoria + "\"," +
                "\"precio\" : \"" + precio + "\"," +
                "\"iva\" : \"" + iva + "\"," +
                "\"descuento\" : \"" + descuento + "\"," +
                "\"cantidad\" : \"" + cantidad + "\"" +
                "}";

            MessageBox.Show(datosPost);

            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este producto",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);


                MessageBox.Show("Producto modificado con éxito");

                CleanForm();

            }
            else
            {
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            String idProd = campoBuscarTextBox.Text;

            String url = "http://localhost:8081/productoDel/" + idProd;

            RestClient r = new RestClient(url, "DELETE");

            var confirmResult = MessageBox.Show("Estás seguro de que deseas eliminar este producto",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resDel = r.deleteItem();

                MessageBox.Show("Producto eliminado con éxito");

                CleanForm();


            }
            else
            {
            }
        }

        private void buscarIDButton_Click(object sender, EventArgs e)
        {
            String url = "";


            switch (BuscarComboBox.SelectedIndex)
            {
                case 0:
                    String id = campoBuscarTextBox.Text;
                    url = "http://localhost:8081/productoID/" + id;
                    break;

                case 1:
                    String nombre = campoBuscarTextBox.Text;
                    url = "http://localhost:8081/productoNombre/?nombre=" + nombre;
                    break;

                case 2:
                    String categoria = campoBuscarTextBox.Text;
                    url = "http://localhost:8081/productobycategoriaorprecio/?categoria=" + categoria;
                    break;
            }

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {

                if (BuscarComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Se ha encontrado el producto");

                    var prod = JsonConvert.DeserializeObject<Producto>(respuesta);
                    List<Producto> lista = new List<Producto>();
                    lista.Add(prod);

                    dataGridView1.DataSource = lista;

                    dataGridView1.Rows[0].Cells[0].Value = campoBuscarTextBox.Text;

                    nombreTextBox.Text = prod.nombre;
                    categoriaTextBox.Text = prod.categoria;
                    precioTextBox.Text = prod.precio.ToString();
                    ivaTextBox.Text = prod.iva.ToString();
                    descuentoTextBox.Text = prod.descuento.ToString();
                    cantidadTextBox.Text = prod.cantidad.ToString();
                }
                else if (BuscarComboBox.SelectedIndex == 1)
                {
                    var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                    MessageBox.Show(listprod.ToString());

                    if (listprod.Count > 1)
                    {
                        MessageBox.Show("Se ha encontrado mas de un producto");
                        dataGridView1.DataSource = listprod;
                    }
                    else
                    {

                        MessageBox.Show("Se ha encontrado el producto");
                        dataGridView1.DataSource = listprod;

                        var prod = listprod[0];
                        nombreTextBox.Text = prod.nombre;
                        categoriaTextBox.Text = prod.categoria;
                        precioTextBox.Text = prod.precio.ToString();
                        ivaTextBox.Text = prod.iva.ToString();
                        descuentoTextBox.Text = prod.descuento.ToString();
                    }
                }
                else if (BuscarComboBox.SelectedIndex == 2)
                {
                    MessageBox.Show("Se ha encontrado el producto");

                    var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                    dataGridView1.DataSource = listprod;

                    var prod = listprod[0];

                    nombreTextBox.Text = prod.nombre;
                    categoriaTextBox.Text = prod.categoria;
                    precioTextBox.Text = prod.precio.ToString();
                    ivaTextBox.Text = prod.iva.ToString();
                    descuentoTextBox.Text = prod.descuento.ToString();
                }
            }
        }

        private void buscaNombreButton_Click(object sender, EventArgs e)
        {
            String nombre = campoBuscarTextBox.Text;
            String url = "http://localhost:8081/productoNombre/?nombre=" + nombre;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                

                var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);

                if (listprod.Count > 1)
                {
                    MessageBox.Show("Se ha encontrado mas de un producto");
                    dataGridView1.DataSource = listprod;
                }
                else {

                    MessageBox.Show("Se ha encontrado el producto");

                    var prod = listprod[0];


                    nombreTextBox.Text = prod.nombre;
                    categoriaTextBox.Text = prod.categoria;
                    precioTextBox.Text = prod.precio.ToString();
                    ivaTextBox.Text = prod.iva.ToString();
                    descuentoTextBox.Text = prod.descuento.ToString();
                }

            }
        }

        private void BuscarDescuentoButton_Click(object sender, EventArgs e)
        {
            String categoria = campoBuscarTextBox.Text;
            String url = "http://localhost:8081/productobycategoriaorprecio/?categoria=" + categoria;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                MessageBox.Show("Se ha encontrado el producto");

                var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);


                var prod = listprod[0];

                nombreTextBox.Text = prod.nombre;
                categoriaTextBox.Text = prod.categoria;
                precioTextBox.Text = prod.precio.ToString();
                ivaTextBox.Text = prod.iva.ToString();
                descuentoTextBox.Text = prod.descuento.ToString();
            }
        }

        private void nomyPrecioBuscaButton_Click(object sender, EventArgs e)
        {
            String url = "";
            String nombre = "";
            switch (BuscarComboBox2.SelectedIndex)
            {
                case 0:
                    nombre = campoBuscarTextBox1.Text;
                    float precio = float.Parse(campoBuscarTextBox2.Text);
                    url = "http://localhost:8081/productobynombreandprecio/?nombre=" + nombre + "&precio=" + precio;
                    break;

                case 1:
                    nombre = campoBuscarTextBox1.Text;
                    String categoria = campoBuscarTextBox2.Text;
                    url = "http://localhost:8081/productobynombreandcategoria/?nombre=" + nombre + "&categoria=" + categoria;
                    break;

            }

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                MessageBox.Show("Se ha encontrado el producto");

                var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);


                var prod = listprod[0];

                nombreTextBox.Text = prod.nombre;
                categoriaTextBox.Text = prod.categoria;
                precioTextBox.Text = prod.precio.ToString();
                ivaTextBox.Text = prod.iva.ToString();
                descuentoTextBox.Text = prod.descuento.ToString();
            }
        }

        private void nomyCatBuscaButton_Click(object sender, EventArgs e)
        {
            String nombre = campoBuscarTextBox1.Text;
            String categoria = campoBuscarTextBox2.Text;
            String url = "http://localhost:8081/productobynombreandcategoria/?nombre=" + nombre + "&categoria=" + categoria;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();


            if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
            {
                MessageBox.Show("No se ha encontrado el producto");
            }
            else
            {
                MessageBox.Show("Se ha encontrado el producto");

                var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);


                var prod = listprod[0];

                nombreTextBox.Text = prod.nombre;
                categoriaTextBox.Text = prod.categoria;
                precioTextBox.Text = prod.precio.ToString();
                ivaTextBox.Text = prod.iva.ToString();
                descuentoTextBox.Text = prod.descuento.ToString();
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

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ivaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void descuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void iconButtonSimple_Click(object sender, EventArgs e)
        {
            BuscadorSimple.Hide();
            BuscadorAvanzado.Show();
            campoBuscarTextBox.Text = null;
            iconButtonAvanzado.Enabled = true;
            iconButtonSimple.Enabled = false;

        }

        private void iconButtonAvanzado_Click(object sender, EventArgs e)
        {
            BuscadorAvanzado.Hide();
            BuscadorSimple.Show();
            campoBuscarTextBox1.Text = null;
            campoBuscarTextBox2.Text = null;
            iconButtonAvanzado.Enabled = false;
            iconButtonSimple.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
