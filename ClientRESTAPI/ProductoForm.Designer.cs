
namespace ClientRESTAPI
{
    partial class ProductoForm
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
            this.modButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.BuscadorSimple = new System.Windows.Forms.GroupBox();
            this.BuscarComboBox = new System.Windows.Forms.ComboBox();
            this.iconButtonSimple = new FontAwesome.Sharp.IconButton();
            this.buscarButton = new System.Windows.Forms.Button();
            this.campoBuscarTextBox = new System.Windows.Forms.TextBox();
            this.campoBuscarTextBox2 = new System.Windows.Forms.TextBox();
            this.nomyCatBuscaButton = new System.Windows.Forms.Button();
            this.nomyPrecioBuscaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.ivaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButon = new System.Windows.Forms.Button();
            this.BuscadorAvanzado = new System.Windows.Forms.GroupBox();
            this.iconButtonAvanzado = new FontAwesome.Sharp.IconButton();
            this.campoBuscarTextBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.labelProductos = new System.Windows.Forms.Label();
            this.buttonAtras = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuscarComboBox2 = new System.Windows.Forms.ComboBox();
            this.BuscadorSimple.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BuscadorAvanzado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modButton
            // 
            this.modButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.modButton.FlatAppearance.BorderSize = 0;
            this.modButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modButton.ForeColor = System.Drawing.Color.White;
            this.modButton.Location = new System.Drawing.Point(353, 143);
            this.modButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(112, 38);
            this.modButton.TabIndex = 9;
            this.modButton.Text = "Modificar";
            this.modButton.UseVisualStyleBackColor = false;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.White;
            this.eliminarButton.Location = new System.Drawing.Point(353, 214);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eliminarButton.Size = new System.Drawing.Size(112, 38);
            this.eliminarButton.TabIndex = 10;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // BuscadorSimple
            // 
            this.BuscadorSimple.Controls.Add(this.BuscarComboBox);
            this.BuscadorSimple.Controls.Add(this.iconButtonSimple);
            this.BuscadorSimple.Controls.Add(this.buscarButton);
            this.BuscadorSimple.Controls.Add(this.campoBuscarTextBox);
            this.BuscadorSimple.Location = new System.Drawing.Point(13, 438);
            this.BuscadorSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscadorSimple.Name = "BuscadorSimple";
            this.BuscadorSimple.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscadorSimple.Size = new System.Drawing.Size(526, 168);
            this.BuscadorSimple.TabIndex = 14;
            this.BuscadorSimple.TabStop = false;
            this.BuscadorSimple.Text = "Buscador Simple";
            // 
            // BuscarComboBox
            // 
            this.BuscarComboBox.FormattingEnabled = true;
            this.BuscarComboBox.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Categoria"});
            this.BuscarComboBox.Location = new System.Drawing.Point(153, 103);
            this.BuscarComboBox.Name = "BuscarComboBox";
            this.BuscarComboBox.Size = new System.Drawing.Size(121, 32);
            this.BuscarComboBox.TabIndex = 21;
            this.BuscarComboBox.Text = "ID";
            // 
            // iconButtonSimple
            // 
            this.iconButtonSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.iconButtonSimple.FlatAppearance.BorderSize = 0;
            this.iconButtonSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSimple.ForeColor = System.Drawing.Color.White;
            this.iconButtonSimple.IconChar = FontAwesome.Sharp.IconChar.ArrowsUpDown;
            this.iconButtonSimple.IconColor = System.Drawing.Color.White;
            this.iconButtonSimple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSimple.IconSize = 24;
            this.iconButtonSimple.Location = new System.Drawing.Point(479, 24);
            this.iconButtonSimple.Name = "iconButtonSimple";
            this.iconButtonSimple.Size = new System.Drawing.Size(32, 41);
            this.iconButtonSimple.TabIndex = 14;
            this.iconButtonSimple.UseVisualStyleBackColor = false;
            this.iconButtonSimple.Click += new System.EventHandler(this.iconButtonSimple_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.ForeColor = System.Drawing.Color.White;
            this.buscarButton.Location = new System.Drawing.Point(281, 103);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(112, 32);
            this.buscarButton.TabIndex = 12;
            this.buscarButton.TabStop = false;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarIDButton_Click);
            // 
            // campoBuscarTextBox
            // 
            this.campoBuscarTextBox.Location = new System.Drawing.Point(96, 45);
            this.campoBuscarTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoBuscarTextBox.Name = "campoBuscarTextBox";
            this.campoBuscarTextBox.Size = new System.Drawing.Size(334, 34);
            this.campoBuscarTextBox.TabIndex = 11;
            this.campoBuscarTextBox.TabStop = false;
            // 
            // campoBuscarTextBox2
            // 
            this.campoBuscarTextBox2.Location = new System.Drawing.Point(286, 37);
            this.campoBuscarTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoBuscarTextBox2.Name = "campoBuscarTextBox2";
            this.campoBuscarTextBox2.Size = new System.Drawing.Size(148, 34);
            this.campoBuscarTextBox2.TabIndex = 14;
            this.campoBuscarTextBox2.TabStop = false;
            // 
            // nomyCatBuscaButton
            // 
            this.nomyCatBuscaButton.AutoSize = true;
            this.nomyCatBuscaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.nomyCatBuscaButton.FlatAppearance.BorderSize = 0;
            this.nomyCatBuscaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomyCatBuscaButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomyCatBuscaButton.ForeColor = System.Drawing.Color.White;
            this.nomyCatBuscaButton.Location = new System.Drawing.Point(280, 98);
            this.nomyCatBuscaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomyCatBuscaButton.Name = "nomyCatBuscaButton";
            this.nomyCatBuscaButton.Size = new System.Drawing.Size(314, 52);
            this.nomyCatBuscaButton.TabIndex = 17;
            this.nomyCatBuscaButton.TabStop = false;
            this.nomyCatBuscaButton.Text = "Nombre y categoria";
            this.nomyCatBuscaButton.UseVisualStyleBackColor = false;
            this.nomyCatBuscaButton.Click += new System.EventHandler(this.nomyCatBuscaButton_Click);
            // 
            // nomyPrecioBuscaButton
            // 
            this.nomyPrecioBuscaButton.AutoSize = true;
            this.nomyPrecioBuscaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.nomyPrecioBuscaButton.FlatAppearance.BorderSize = 0;
            this.nomyPrecioBuscaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomyPrecioBuscaButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomyPrecioBuscaButton.ForeColor = System.Drawing.Color.White;
            this.nomyPrecioBuscaButton.Location = new System.Drawing.Point(34, 98);
            this.nomyPrecioBuscaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomyPrecioBuscaButton.Name = "nomyPrecioBuscaButton";
            this.nomyPrecioBuscaButton.Size = new System.Drawing.Size(268, 52);
            this.nomyPrecioBuscaButton.TabIndex = 15;
            this.nomyPrecioBuscaButton.TabStop = false;
            this.nomyPrecioBuscaButton.Text = "Nombre y precio";
            this.nomyPrecioBuscaButton.UseVisualStyleBackColor = false;
            this.nomyPrecioBuscaButton.Click += new System.EventHandler(this.nomyPrecioBuscaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cantidadTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.eliminarButton);
            this.groupBox1.Controls.Add(this.BuscadorSimple);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.descuentoTextBox);
            this.groupBox1.Controls.Add(this.ivaTextBox);
            this.groupBox1.Controls.Add(this.precioTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.categoriaTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addButon);
            this.groupBox1.Controls.Add(this.modButton);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(766, 616);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(117, 316);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(148, 34);
            this.cantidadTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(117, 46);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(148, 34);
            this.nombreTextBox.TabIndex = 1;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.Location = new System.Drawing.Point(117, 263);
            this.descuentoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(148, 34);
            this.descuentoTextBox.TabIndex = 6;
            this.descuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descuentoTextBox_KeyPress);
            // 
            // ivaTextBox
            // 
            this.ivaTextBox.Location = new System.Drawing.Point(117, 209);
            this.ivaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivaTextBox.Name = "ivaTextBox";
            this.ivaTextBox.Size = new System.Drawing.Size(148, 34);
            this.ivaTextBox.TabIndex = 5;
            this.ivaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ivaTextBox_KeyPress);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(117, 155);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(148, 34);
            this.precioTextBox.TabIndex = 4;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descuento:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(117, 103);
            this.categoriaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(148, 34);
            this.categoriaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // addButon
            // 
            this.addButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.addButon.FlatAppearance.BorderSize = 0;
            this.addButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButon.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButon.ForeColor = System.Drawing.Color.White;
            this.addButon.Location = new System.Drawing.Point(353, 75);
            this.addButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(112, 38);
            this.addButon.TabIndex = 8;
            this.addButon.Text = "Añadir";
            this.addButon.UseVisualStyleBackColor = false;
            this.addButon.Click += new System.EventHandler(this.addButon_Click);
            // 
            // BuscadorAvanzado
            // 
            this.BuscadorAvanzado.Controls.Add(this.iconButtonAvanzado);
            this.BuscadorAvanzado.Controls.Add(this.campoBuscarTextBox1);
            this.BuscadorAvanzado.Controls.Add(this.nomyCatBuscaButton);
            this.BuscadorAvanzado.Controls.Add(this.nomyPrecioBuscaButton);
            this.BuscadorAvanzado.Controls.Add(this.campoBuscarTextBox2);
            this.BuscadorAvanzado.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BuscadorAvanzado.Location = new System.Drawing.Point(138, 740);
            this.BuscadorAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscadorAvanzado.Name = "BuscadorAvanzado";
            this.BuscadorAvanzado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscadorAvanzado.Size = new System.Drawing.Size(531, 168);
            this.BuscadorAvanzado.TabIndex = 44;
            this.BuscadorAvanzado.TabStop = false;
            this.BuscadorAvanzado.Text = "Buscador avanzado";
            // 
            // iconButtonAvanzado
            // 
            this.iconButtonAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.iconButtonAvanzado.FlatAppearance.BorderSize = 0;
            this.iconButtonAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAvanzado.ForeColor = System.Drawing.Color.White;
            this.iconButtonAvanzado.IconChar = FontAwesome.Sharp.IconChar.ArrowsUpDown;
            this.iconButtonAvanzado.IconColor = System.Drawing.Color.White;
            this.iconButtonAvanzado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAvanzado.IconSize = 24;
            this.iconButtonAvanzado.Location = new System.Drawing.Point(479, 30);
            this.iconButtonAvanzado.Name = "iconButtonAvanzado";
            this.iconButtonAvanzado.Size = new System.Drawing.Size(32, 41);
            this.iconButtonAvanzado.TabIndex = 18;
            this.iconButtonAvanzado.UseVisualStyleBackColor = false;
            this.iconButtonAvanzado.Click += new System.EventHandler(this.iconButtonAvanzado_Click);
            // 
            // campoBuscarTextBox1
            // 
            this.campoBuscarTextBox1.Location = new System.Drawing.Point(68, 37);
            this.campoBuscarTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoBuscarTextBox1.Name = "campoBuscarTextBox1";
            this.campoBuscarTextBox1.Size = new System.Drawing.Size(148, 34);
            this.campoBuscarTextBox1.TabIndex = 13;
            this.campoBuscarTextBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(102, 1071);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel1.Text = "Clientes";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel2.Text = "Empresas";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel3.Text = "Usuarios";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel4.Text = "Compras";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(95, 24);
            this.toolStripLabel5.Text = "Reservas";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.labelProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProductos.Font = new System.Drawing.Font("Gadugi", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.White;
            this.labelProductos.Location = new System.Drawing.Point(378, 34);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(285, 65);
            this.labelProductos.TabIndex = 19;
            this.labelProductos.Text = "Productos";
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
            this.buttonAtras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.buttonAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAtras.Location = new System.Drawing.Point(130, 43);
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
            this.dataGridView1.Location = new System.Drawing.Point(906, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(657, 548);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuscarComboBox2
            // 
            this.BuscarComboBox2.FormattingEnabled = true;
            this.BuscarComboBox2.Items.AddRange(new object[] {
            "Nombre y Precio",
            "Nombre y Categoria"});
            this.BuscarComboBox2.Location = new System.Drawing.Point(319, 938);
            this.BuscarComboBox2.Name = "BuscarComboBox2";
            this.BuscarComboBox2.Size = new System.Drawing.Size(185, 28);
            this.BuscarComboBox2.TabIndex = 58;
            this.BuscarComboBox2.Text = "Nombre y Precio";
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1564, 1071);
            this.Controls.Add(this.BuscarComboBox2);
            this.Controls.Add(this.BuscadorAvanzado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductoForm";
            this.Text = "Productos";
            this.BuscadorSimple.ResumeLayout(false);
            this.BuscadorSimple.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BuscadorAvanzado.ResumeLayout(false);
            this.BuscadorAvanzado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.GroupBox BuscadorSimple;
        private System.Windows.Forms.Button nomyCatBuscaButton;
        private System.Windows.Forms.Button nomyPrecioBuscaButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox campoBuscarTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox ivaTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.TextBox campoBuscarTextBox2;
        private System.Windows.Forms.TextBox campoBuscarTextBox1;
        private System.Windows.Forms.GroupBox BuscadorAvanzado;
        private System.Windows.Forms.Label labelProductos;
        private FontAwesome.Sharp.IconButton buttonAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonSimple;
        private FontAwesome.Sharp.IconButton iconButtonAvanzado;
        private System.Windows.Forms.ComboBox BuscarComboBox;
        private System.Windows.Forms.ComboBox BuscarComboBox2;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label4;
    }
}