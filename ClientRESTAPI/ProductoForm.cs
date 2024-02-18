using ClientRESTAPI.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ClientRESTAPI
{
    
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            
            InitializeComponent();
            if (Settings.Default.tipo == 0)
            {
                actualizar();
                groupBox2.Left = 100; //X
                groupBox2.Top = 100; //Y
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                groupBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                toolStripLabel2.Visible = false;
                toolStripLabel3.Visible = false;

            } else
            {
                actualizar();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.ReadOnly = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;


                button3.Visible = false;
                cantidadComprar.Visible = false;
            }

        if (Settings.Default.Rol == 0 && Settings.Default.tipo == 1)
            {
                toolStripLabel2.Visible = false;
                toolStripLabel3.Visible = false;
                toolStripLabel4.Visible = false;
                addButon.Visible = false;
                eliminarButton.Visible = false;
                button2.Visible = false;
            }
            
            BuscadorAvanzado.Hide();
            iconButtonAvanzado.Enabled = false;

            


        }

        private void actualizar()
        {
            String urlU = "http://localhost:8081/productoCategoria/";
            RestClient rU = new RestClient(urlU, "GET");

            var respuestaU = rU.getItem();

            var listprodU = JsonConvert.DeserializeObject<List<Producto>>(respuestaU);
            dataGridView1.DataSource = listprodU;
        }

        private void addButon_Click(object sender, EventArgs e)
        {
            String nombre = nombreTextBox.Text;
            String categoria = "";
            float precio = float.Parse(precioTextBox.Text);
            int iva = Int32.Parse(ivaTextBox.Text);
            int descuento = Int32.Parse(descuentoTextBox.Text);
            int cantidad = Int32.Parse(cantidadTextBox.Text);

            String url = "http://localhost:8081/productoAdd/";

            RestClient r = new RestClient(url, "POST");

            if (categoriaTextBox != null && datosCategoria.SelectedIndex == 0)
            {
                categoria = categoriaTextBox.Text;
                
            }
            else if ((categoriaTextBox == null || categoriaTextBox.Text.Equals("")) && datosCategoria.SelectedIndex != 0)
            {
                categoria = this.datosCategoria.GetItemText(this.datosCategoria.SelectedItem);
            } 
            else
            {
                MessageBox.Show("Error, debes elegir solo una de las dos opciones de busqueda de categoria (la parte escrita debe quedar blanca o la parte de seleccion debe ser la primera)");
            }



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
                CleanForm();
                actualizar();

            }

            
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            String nombre = nombreTextBox.Text;

            String urlNombre = "http://localhost:8081/productoNombre/?nombre=" + nombre;
            RestClient rNombre = new RestClient(urlNombre, "GET");
            String respuestaNombre = rNombre.getItem();
            var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuestaNombre);
            var prod = listprod[0];

            long id = prod.idProducto;
            String categoria = "";
            float precio = float.Parse(precioTextBox.Text);
            int iva = Int32.Parse(ivaTextBox.Text);
            int descuento = Int32.Parse(descuentoTextBox.Text);
            int cantidad = Int32.Parse(cantidadTextBox.Text);

            String url = "http://localhost:8081/productoMod/" + id;

            RestClient r = new RestClient(url, "PUT");

            if (categoriaTextBox != null && datosCategoria.SelectedIndex == 0)
            {
                categoria = categoriaTextBox.Text;

            }
            else if ((categoriaTextBox == null || categoriaTextBox.Text.Equals("")) && datosCategoria.SelectedIndex != 0)
            {
                categoria = this.datosCategoria.GetItemText(this.datosCategoria.SelectedItem);
            }
            else
            {
                MessageBox.Show("Error, debes elegir solo una de las dos opciones de busqueda de categoria (la parte escrita debe quedar blanca o la parte de seleccion debe ser la primera)");
            }

            String datosPost = "{" +
                "\"nombre\" : \"" + nombre + "\", " +
                "\"categoria\" : \"" + categoria + "\"," +
                "\"precio\" : \"" + precio + "\"," +
                "\"iva\" : \"" + iva + "\"," +
                "\"descuento\" : \"" + descuento + "\"," +
                "\"cantidad\" : \"" + cantidad + "\"" +
                "}";


            var confirmResult = MessageBox.Show("Estás seguro de que deseas modificar este producto",
                                      "Diálogo de confirmación",
                                      MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {

                String resPut = r.putItem(datosPost);


                MessageBox.Show("Producto modificado con éxito");

                CleanForm();
                actualizar();

            }

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {

            String nombre = nombreTextBox.Text;
            String urlNombre = "http://localhost:8081/productoNombre/?nombre=" + nombre;
            RestClient rNombre = new RestClient(urlNombre, "GET");
            String respuestaNombre = rNombre.getItem();
            var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuestaNombre);
            var prod = listprod[0];

            long idProd = prod.idProducto;

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

                actualizar();

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
                    url = "http://localhost:8081/productoCategoria/?categoria=" + categoria;
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
                Producto prod = new Producto();
                if (BuscarComboBox.SelectedIndex == 0)
                {
                    prod = JsonConvert.DeserializeObject<Producto>(respuesta);
                    List<Producto> lista = new List<Producto>();
                    lista.Add(prod);
                    
                    dataGridView1.DataSource = lista;
                }
                else
                {
                    var listprod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                    if (listprod.Count > 1)
                    {
                        dataGridView1.DataSource = listprod;
                    }
                    else
                    {
                        dataGridView1.DataSource = listprod;
     
                        prod = listprod[0];
                    }
                }

                nombreTextBox.Text = prod.nombre;
                precioTextBox.Text = prod.precio.ToString();
                ivaTextBox.Text = prod.iva.ToString();
                descuentoTextBox.Text = prod.descuento.ToString();
                cantidadTextBox.Text = prod.cantidad.ToString();
                int index = 0;

                for (int i = 0; i < datosCategoria.Items.Count; i++)
                {
                    datosCategoria.SelectedIndex = i;
                    string categoria = this.datosCategoria.GetItemText(this.datosCategoria.SelectedItem);
                    if (categoria.Equals(prod.categoria))
                    {
                        index = i;
                        categoriaTextBox.Clear();
                        break;
                    } else
                    {
                        categoriaTextBox.Text = prod.categoria;
                    }
                }

                datosCategoria.SelectedIndex = index;

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
                    cantidadTextBox.Text = prod.cantidad.ToString();
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
                cantidadTextBox.Text = prod.cantidad.ToString();
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
                cantidadTextBox.Text = prod.cantidad.ToString();
            }
        }

        private void nomyCatBuscaButton_Click(object sender, EventArgs e)
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClienteForm sfEmp = new ClienteForm();

            sfEmp.Show();

            this.Hide();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            UsuarioForm sfEmp = new UsuarioForm();

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

        private void BuscadorAvanzado_Enter(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count-1; ++i)
            {
                long id = (long)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                String nombre = (string)dataGridView1.Rows[i].Cells[1].Value;
                String categoria = (string)dataGridView1.Rows[i].Cells[2].Value;
                float precio = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                int iva = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                int descuento = Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                int cantidad = Int32.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());

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
                String resPut = r.putItem(datosPost);
               
            }

            MessageBox.Show("Productos modificado con éxito");
            actualizar();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            actualizar();

        }

        private void BuscadorSimple_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            String idProd = dataGridView1.Rows[row].Cells[0].Value.ToString();
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
                actualizar();


            }
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {

        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = dataGridView1.SelectedCells[0].Value.ToString();
            int cantComprada = Int32.Parse(cantidadComprar.Text);
            

            String url = "http://localhost:8081/productoID/" + id;

            RestClient r = new RestClient(url, "GET");

            String respuesta = r.getItem();

            var prod = JsonConvert.DeserializeObject<Producto>(respuesta);

            if (prod.cantidad < Int32.Parse(cantidadComprar.Text))
            {
                MessageBox.Show("No hay suficiente Stock");
            }
            else
            {

                String dni = Settings.Default.Dni;
                String urlCli = "http://localhost:8081/clienteDni/" + dni;

                RestClient rCli = new RestClient(urlCli, "GET");

                String respuestaCli = rCli.getItem();

                var cli = JsonConvert.DeserializeObject<Cliente>(respuestaCli);

                float cliDinero = cli.dinero;

                float descuento = float.Parse(prod.descuento.ToString());
                float iva = float.Parse(prod.iva.ToString());

                float precioDescuento = 0;
                float precioIva = 0;

                if (prod.descuento > 0)
                {
                    precioDescuento = prod.precio * (descuento / 100);
                }

                if (prod.iva > 0)
                {
                    precioIva = prod.precio * (iva / 100);
                }

                float precioTotal = (prod.precio - precioDescuento) + precioIva;

                float dineroTotalGastado = precioTotal * float.Parse(cantidadComprar.Text);

                float resultadoDin = cliDinero - dineroTotalGastado;


                if (resultadoDin < 0)
                {
                    MessageBox.Show("No tienes fondos suficientes");
                }
                else if (precioTotal <= 0)
                {
                    MessageBox.Show("El producto no puede ser gratuito, contacte con un administrador");
                }
                else
                {
                    int cant = prod.cantidad;
                    int resultado = cant - cantComprada;


                    String url2 = "http://localhost:8081/productoMod/" + id;

                    RestClient r2 = new RestClient(url2, "PUT");


                    String datosPost = "{" +
                        "\"nombre\" : \"" + prod.nombre.ToString() + "\", " +
                        "\"categoria\" : \"" + prod.categoria.ToString() + "\"," +
                        "\"precio\" : \"" + prod.precio.ToString() + "\"," +
                        "\"iva\" : \"" + prod.iva.ToString() + "\"," +
                        "\"descuento\" : \"" + prod.descuento.ToString() + "\"," +
                        "\"cantidad\" : \"" + resultado.ToString() + "\"" +
                        "}";

                    String resPut = r2.putItem(datosPost);



                    String url3 = "http://localhost:8081/clienteMod/" + dni;

                    RestClient r3 = new RestClient(url3, "PUT");

                    String datosPost2 = "{" +
                        "\"nombre\" : \"" + cli.nombre.ToString() + "\"," +
                        "\"apellidos\" : \"" + cli.apellidos.ToString() + "\"," +
                        "\"dni\" : \"" + dni.ToString() + "\"," +
                        "\"telefono\" : \"" + cli.telefono.ToString() + "\"," +
                        "\"email\" : \"" + cli.email.ToString() + "\"," +
                        "\"password\" : \"" + Settings.Default.password.ToString() + "\"," +
                        "\"historial\" : \"" + cli.historial.ToString() + "\", " +
                        "\"dinero\" : \"" + resultadoDin.ToString() + "\" " +
                        "}";

                    String resPut2 = r3.putItem(datosPost2);

                    if (cantComprada == 1)
                    {
                        MessageBox.Show("Has comprado " + cantComprada + " producto");
                    }
                    else if (cantComprada == 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Has comprado " + cantComprada + " productos");
                    }

                    actualizar();

                    String fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    String hora = DateTime.Now.ToString("HH:mm:ss");
                    int cantidad = Int32.Parse(cantidadComprar.Text);

                    

                    String url5 = "http://localhost:8081/compraAdd/";

                    RestClient r5 = new RestClient(url5, "POST");

                    String datos = "{" +
                        "\"fecha\" : \"" + fecha + "T23:00:00.000+00:00\", " +
                        "\"hora\" : \"" + hora + "\"," +
                        "\"cantidad\" : \"" + cantidad + "\"," +
                        "\"cliente\" : {" +
                        "\"dni\" : \"" + Settings.Default.Dni + "\"" +
                        "},\"producto\" : {\"idProducto\":\"" + id+"\"}}"
                        ;


                    String respuesta5 = r5.postItem(datos);




                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (categoriaTextBox2 != null && buscarCategoria.SelectedIndex == 0)
            {
                String categoria = categoriaTextBox2.Text;
                String url = "http://localhost:8081/productoCategoria/?categoria=" + categoria;
                RestClient r = new RestClient(url, "GET");
                String respuesta = r.getItem();
                if (String.IsNullOrEmpty(respuesta) || String.IsNullOrWhiteSpace(respuesta) || respuesta.Equals("[]"))
                {
                    MessageBox.Show("La categoria escrita no existe");
                    categoriaTextBox2.Clear();
                }
                else
                {

                    var prod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);

                    dataGridView1.DataSource = prod;

                  
                }
            } else if ((categoriaTextBox2 == null || categoriaTextBox2.Text.Equals("")) && buscarCategoria.SelectedIndex != 0)
            {
                string categoria = this.buscarCategoria.GetItemText(this.buscarCategoria.SelectedItem);
                String url = "http://localhost:8081/productoCategoria/?categoria=" + categoria;
                RestClient r = new RestClient(url, "GET");
                String respuesta = r.getItem();
                var prod = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                dataGridView1.DataSource = prod;
            } else
            {
                MessageBox.Show("Error, debes elegir solo una de las dos opciones de busqueda de categoria (la parte escrita debe quedar blanca o la parte de seleccion debe ser la primera)");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
