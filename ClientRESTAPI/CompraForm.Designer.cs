
namespace ClientRESTAPI
{
    partial class CompraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buscarFechaYhora = new System.Windows.Forms.Button();
            this.campoBuscar1 = new System.Windows.Forms.TextBox();
            this.campoBuscar2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cantidadBuscarButton = new System.Windows.Forms.Button();
            this.fechaBuscarButton = new System.Windows.Forms.Button();
            this.buscarHoraButton = new System.Windows.Forms.Button();
            this.buscarIdCompra = new System.Windows.Forms.Button();
            this.cantidadAnyadirTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eliminarCompraButton = new System.Windows.Forms.Button();
            this.horaAnyadirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaAnyadirTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modCompraButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.labelCompras = new System.Windows.Forms.Label();
            this.buttonAtras = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cantidadAnyadirTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.eliminarCompraButton);
            this.groupBox1.Controls.Add(this.horaAnyadirTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaAnyadirTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.modCompraButton);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(164, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(615, 843);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buscarFechaYhora);
            this.groupBox3.Controls.Add(this.campoBuscar1);
            this.groupBox3.Controls.Add(this.campoBuscar2);
            this.groupBox3.Location = new System.Drawing.Point(14, 588);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(418, 229);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador avanzado";
            // 
            // buscarFechaYhora
            // 
            this.buscarFechaYhora.AutoSize = true;
            this.buscarFechaYhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buscarFechaYhora.FlatAppearance.BorderSize = 0;
            this.buscarFechaYhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarFechaYhora.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarFechaYhora.ForeColor = System.Drawing.Color.White;
            this.buscarFechaYhora.Location = new System.Drawing.Point(135, 137);
            this.buscarFechaYhora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarFechaYhora.Name = "buscarFechaYhora";
            this.buscarFechaYhora.Size = new System.Drawing.Size(150, 74);
            this.buscarFechaYhora.TabIndex = 15;
            this.buscarFechaYhora.TabStop = false;
            this.buscarFechaYhora.Text = "Fecha y hora";
            this.buscarFechaYhora.UseVisualStyleBackColor = false;
            this.buscarFechaYhora.Click += new System.EventHandler(this.button1_Click);
            // 
            // campoBuscar1
            // 
            this.campoBuscar1.Location = new System.Drawing.Point(28, 57);
            this.campoBuscar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoBuscar1.Name = "campoBuscar1";
            this.campoBuscar1.Size = new System.Drawing.Size(148, 34);
            this.campoBuscar1.TabIndex = 13;
            this.campoBuscar1.TabStop = false;
            // 
            // campoBuscar2
            // 
            this.campoBuscar2.Location = new System.Drawing.Point(244, 57);
            this.campoBuscar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoBuscar2.Name = "campoBuscar2";
            this.campoBuscar2.Size = new System.Drawing.Size(148, 34);
            this.campoBuscar2.TabIndex = 14;
            this.campoBuscar2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cantidadBuscarButton);
            this.groupBox2.Controls.Add(this.fechaBuscarButton);
            this.groupBox2.Controls.Add(this.buscarHoraButton);
            this.groupBox2.Controls.Add(this.buscarIdCompra);
            this.groupBox2.Location = new System.Drawing.Point(14, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(418, 238);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador simple";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 34);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cantidadBuscarButton
            // 
            this.cantidadBuscarButton.AutoSize = true;
            this.cantidadBuscarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cantidadBuscarButton.FlatAppearance.BorderSize = 0;
            this.cantidadBuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cantidadBuscarButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadBuscarButton.ForeColor = System.Drawing.Color.White;
            this.cantidadBuscarButton.Location = new System.Drawing.Point(260, 118);
            this.cantidadBuscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadBuscarButton.Name = "cantidadBuscarButton";
            this.cantidadBuscarButton.Size = new System.Drawing.Size(112, 38);
            this.cantidadBuscarButton.TabIndex = 10;
            this.cantidadBuscarButton.TabStop = false;
            this.cantidadBuscarButton.Text = "Cantidad";
            this.cantidadBuscarButton.UseVisualStyleBackColor = false;
            this.cantidadBuscarButton.Click += new System.EventHandler(this.cantidadBuscarButton_Click);
            // 
            // fechaBuscarButton
            // 
            this.fechaBuscarButton.AutoSize = true;
            this.fechaBuscarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fechaBuscarButton.FlatAppearance.BorderSize = 0;
            this.fechaBuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechaBuscarButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaBuscarButton.ForeColor = System.Drawing.Color.White;
            this.fechaBuscarButton.Location = new System.Drawing.Point(32, 174);
            this.fechaBuscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaBuscarButton.Name = "fechaBuscarButton";
            this.fechaBuscarButton.Size = new System.Drawing.Size(112, 38);
            this.fechaBuscarButton.TabIndex = 11;
            this.fechaBuscarButton.TabStop = false;
            this.fechaBuscarButton.Text = "Fecha";
            this.fechaBuscarButton.UseVisualStyleBackColor = false;
            this.fechaBuscarButton.Click += new System.EventHandler(this.fechaBuscarButton_Click);
            // 
            // buscarHoraButton
            // 
            this.buscarHoraButton.AutoSize = true;
            this.buscarHoraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buscarHoraButton.FlatAppearance.BorderSize = 0;
            this.buscarHoraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarHoraButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarHoraButton.ForeColor = System.Drawing.Color.White;
            this.buscarHoraButton.Location = new System.Drawing.Point(260, 174);
            this.buscarHoraButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarHoraButton.Name = "buscarHoraButton";
            this.buscarHoraButton.Size = new System.Drawing.Size(112, 38);
            this.buscarHoraButton.TabIndex = 12;
            this.buscarHoraButton.TabStop = false;
            this.buscarHoraButton.Text = "Hora";
            this.buscarHoraButton.UseVisualStyleBackColor = false;
            this.buscarHoraButton.Click += new System.EventHandler(this.buscarHoraButton_Click);
            // 
            // buscarIdCompra
            // 
            this.buscarIdCompra.AutoSize = true;
            this.buscarIdCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buscarIdCompra.FlatAppearance.BorderSize = 0;
            this.buscarIdCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarIdCompra.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarIdCompra.ForeColor = System.Drawing.Color.White;
            this.buscarIdCompra.Location = new System.Drawing.Point(32, 118);
            this.buscarIdCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarIdCompra.Name = "buscarIdCompra";
            this.buscarIdCompra.Size = new System.Drawing.Size(112, 38);
            this.buscarIdCompra.TabIndex = 9;
            this.buscarIdCompra.TabStop = false;
            this.buscarIdCompra.Text = "ID";
            this.buscarIdCompra.UseVisualStyleBackColor = false;
            this.buscarIdCompra.Click += new System.EventHandler(this.buscarIdCompra_Click);
            // 
            // cantidadAnyadirTextBox
            // 
            this.cantidadAnyadirTextBox.Location = new System.Drawing.Point(174, 175);
            this.cantidadAnyadirTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadAnyadirTextBox.Name = "cantidadAnyadirTextBox";
            this.cantidadAnyadirTextBox.Size = new System.Drawing.Size(168, 34);
            this.cantidadAnyadirTextBox.TabIndex = 4;
            this.cantidadAnyadirTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadAnyadirTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad:";
            // 
            // eliminarCompraButton
            // 
            this.eliminarCompraButton.AutoSize = true;
            this.eliminarCompraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eliminarCompraButton.FlatAppearance.BorderSize = 0;
            this.eliminarCompraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarCompraButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCompraButton.ForeColor = System.Drawing.Color.White;
            this.eliminarCompraButton.Location = new System.Drawing.Point(474, 265);
            this.eliminarCompraButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarCompraButton.Name = "eliminarCompraButton";
            this.eliminarCompraButton.Size = new System.Drawing.Size(112, 38);
            this.eliminarCompraButton.TabIndex = 7;
            this.eliminarCompraButton.Text = "Eliminar";
            this.eliminarCompraButton.UseVisualStyleBackColor = false;
            this.eliminarCompraButton.Click += new System.EventHandler(this.eliminarCompraButton_Click);
            // 
            // horaAnyadirTextBox
            // 
            this.horaAnyadirTextBox.Location = new System.Drawing.Point(174, 111);
            this.horaAnyadirTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.horaAnyadirTextBox.Name = "horaAnyadirTextBox";
            this.horaAnyadirTextBox.Size = new System.Drawing.Size(168, 34);
            this.horaAnyadirTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hora:";
            // 
            // fechaAnyadirTextBox
            // 
            this.fechaAnyadirTextBox.Location = new System.Drawing.Point(174, 42);
            this.fechaAnyadirTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaAnyadirTextBox.Name = "fechaAnyadirTextBox";
            this.fechaAnyadirTextBox.Size = new System.Drawing.Size(168, 34);
            this.fechaAnyadirTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // modCompraButton
            // 
            this.modCompraButton.AutoSize = true;
            this.modCompraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modCompraButton.FlatAppearance.BorderSize = 0;
            this.modCompraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modCompraButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modCompraButton.ForeColor = System.Drawing.Color.White;
            this.modCompraButton.Location = new System.Drawing.Point(352, 265);
            this.modCompraButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modCompraButton.Name = "modCompraButton";
            this.modCompraButton.Size = new System.Drawing.Size(112, 38);
            this.modCompraButton.TabIndex = 6;
            this.modCompraButton.Text = "Modificar";
            this.modCompraButton.UseVisualStyleBackColor = false;
            this.modCompraButton.Click += new System.EventHandler(this.modCompraButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(108, 1005);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel1.Text = "Clientes";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel2.Text = "Usuarios";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel3.Text = "Productos";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel4.Text = "Empresas";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // labelCompras
            // 
            this.labelCompras.AutoSize = true;
            this.labelCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCompras.Font = new System.Drawing.Font("Gadugi", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompras.ForeColor = System.Drawing.Color.White;
            this.labelCompras.Location = new System.Drawing.Point(345, 43);
            this.labelCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompras.Name = "labelCompras";
            this.labelCompras.Size = new System.Drawing.Size(251, 65);
            this.labelCompras.TabIndex = 39;
            this.labelCompras.Text = "Compras";
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtras.FlatAppearance.BorderSize = 0;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.ForeColor = System.Drawing.Color.White;
            this.buttonAtras.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.buttonAtras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAtras.Location = new System.Drawing.Point(164, 54);
            this.buttonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(57, 62);
            this.buttonAtras.TabIndex = 56;
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(798, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 532);
            this.dataGridView1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1050, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 60;
            this.button1.TabStop = false;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(820, 572);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 50);
            this.button2.TabIndex = 61;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1264, 572);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(194, 50);
            this.button3.TabIndex = 62;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1500, 1005);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelCompras);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompraForm";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.CompraForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cantidadAnyadirTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox horaAnyadirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fechaAnyadirTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cantidadBuscarButton;
        private System.Windows.Forms.Button fechaBuscarButton;
        private System.Windows.Forms.Button buscarHoraButton;
        private System.Windows.Forms.Button buscarIdCompra;
        private System.Windows.Forms.TextBox campoBuscar2;
        private System.Windows.Forms.TextBox campoBuscar1;
        private System.Windows.Forms.Button modCompraButton;
        private System.Windows.Forms.Button eliminarCompraButton;
        private System.Windows.Forms.Button buscarFechaYhora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCompras;
        private FontAwesome.Sharp.IconButton buttonAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}