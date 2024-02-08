
namespace ClientRESTAPI
{
    partial class EmpresaForm
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
            this.modEmpresaButton = new System.Windows.Forms.Button();
            this.delEmpresaButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getActividad = new System.Windows.Forms.Button();
            this.getDireccion = new System.Windows.Forms.Button();
            this.getEmail = new System.Windows.Forms.Button();
            this.getTelefono = new System.Windows.Forms.Button();
            this.getWeb = new System.Windows.Forms.Button();
            this.getNombre = new System.Windows.Forms.Button();
            this.getCif = new System.Windows.Forms.Button();
            this.campo1 = new System.Windows.Forms.TextBox();
            this.getNombreDireccion = new System.Windows.Forms.Button();
            this.getNombreEmail = new System.Windows.Forms.Button();
            this.getNombreTelefono = new System.Windows.Forms.Button();
            this.campo2 = new System.Windows.Forms.TextBox();
            this.campo3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.actividad = new System.Windows.Forms.RichTextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.labelEmpresas = new System.Windows.Forms.Label();
            this.buttonAtras = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modEmpresaButton
            // 
            this.modEmpresaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.modEmpresaButton.FlatAppearance.BorderSize = 0;
            this.modEmpresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modEmpresaButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modEmpresaButton.ForeColor = System.Drawing.Color.White;
            this.modEmpresaButton.Location = new System.Drawing.Point(508, 398);
            this.modEmpresaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modEmpresaButton.Name = "modEmpresaButton";
            this.modEmpresaButton.Size = new System.Drawing.Size(112, 38);
            this.modEmpresaButton.TabIndex = 9;
            this.modEmpresaButton.Text = "Modificar";
            this.modEmpresaButton.UseVisualStyleBackColor = false;
            this.modEmpresaButton.Click += new System.EventHandler(this.modEmpresaButton_Click_1);
            // 
            // delEmpresaButton
            // 
            this.delEmpresaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.delEmpresaButton.FlatAppearance.BorderSize = 0;
            this.delEmpresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delEmpresaButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEmpresaButton.ForeColor = System.Drawing.Color.White;
            this.delEmpresaButton.Location = new System.Drawing.Point(664, 398);
            this.delEmpresaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delEmpresaButton.Name = "delEmpresaButton";
            this.delEmpresaButton.Size = new System.Drawing.Size(112, 38);
            this.delEmpresaButton.TabIndex = 10;
            this.delEmpresaButton.Text = "Eliminar";
            this.delEmpresaButton.UseVisualStyleBackColor = false;
            this.delEmpresaButton.Click += new System.EventHandler(this.delEmpresaButton_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getActividad);
            this.groupBox3.Controls.Add(this.getDireccion);
            this.groupBox3.Controls.Add(this.getEmail);
            this.groupBox3.Controls.Add(this.getTelefono);
            this.groupBox3.Controls.Add(this.getWeb);
            this.groupBox3.Controls.Add(this.getNombre);
            this.groupBox3.Controls.Add(this.getCif);
            this.groupBox3.Controls.Add(this.campo1);
            this.groupBox3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 466);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(602, 245);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador simple";
            // 
            // getActividad
            // 
            this.getActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getActividad.FlatAppearance.BorderSize = 0;
            this.getActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getActividad.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getActividad.ForeColor = System.Drawing.Color.White;
            this.getActividad.Location = new System.Drawing.Point(171, 115);
            this.getActividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getActividad.Name = "getActividad";
            this.getActividad.Size = new System.Drawing.Size(112, 38);
            this.getActividad.TabIndex = 13;
            this.getActividad.TabStop = false;
            this.getActividad.Text = "Actividad";
            this.getActividad.UseVisualStyleBackColor = false;
            this.getActividad.Click += new System.EventHandler(this.getActividad_Click_1);
            // 
            // getDireccion
            // 
            this.getDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getDireccion.FlatAppearance.BorderSize = 0;
            this.getDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDireccion.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDireccion.ForeColor = System.Drawing.Color.White;
            this.getDireccion.Location = new System.Drawing.Point(380, 178);
            this.getDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getDireccion.Name = "getDireccion";
            this.getDireccion.Size = new System.Drawing.Size(112, 38);
            this.getDireccion.TabIndex = 18;
            this.getDireccion.TabStop = false;
            this.getDireccion.Text = "Dirección";
            this.getDireccion.UseVisualStyleBackColor = false;
            this.getDireccion.Click += new System.EventHandler(this.getDireccion_Click_1);
            // 
            // getEmail
            // 
            this.getEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getEmail.FlatAppearance.BorderSize = 0;
            this.getEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEmail.ForeColor = System.Drawing.Color.White;
            this.getEmail.Location = new System.Drawing.Point(244, 178);
            this.getEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getEmail.Name = "getEmail";
            this.getEmail.Size = new System.Drawing.Size(112, 38);
            this.getEmail.TabIndex = 17;
            this.getEmail.TabStop = false;
            this.getEmail.Text = "Email";
            this.getEmail.UseVisualStyleBackColor = false;
            this.getEmail.Click += new System.EventHandler(this.getEmail_Click_1);
            // 
            // getTelefono
            // 
            this.getTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getTelefono.FlatAppearance.BorderSize = 0;
            this.getTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTelefono.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getTelefono.ForeColor = System.Drawing.Color.White;
            this.getTelefono.Location = new System.Drawing.Point(108, 178);
            this.getTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getTelefono.Name = "getTelefono";
            this.getTelefono.Size = new System.Drawing.Size(112, 38);
            this.getTelefono.TabIndex = 16;
            this.getTelefono.TabStop = false;
            this.getTelefono.Text = "Teléfono";
            this.getTelefono.UseVisualStyleBackColor = false;
            this.getTelefono.Click += new System.EventHandler(this.getTelefono_Click_1);
            // 
            // getWeb
            // 
            this.getWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getWeb.FlatAppearance.BorderSize = 0;
            this.getWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getWeb.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getWeb.ForeColor = System.Drawing.Color.White;
            this.getWeb.Location = new System.Drawing.Point(456, 115);
            this.getWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getWeb.Name = "getWeb";
            this.getWeb.Size = new System.Drawing.Size(112, 38);
            this.getWeb.TabIndex = 15;
            this.getWeb.TabStop = false;
            this.getWeb.Text = "Web";
            this.getWeb.UseVisualStyleBackColor = false;
            this.getWeb.Click += new System.EventHandler(this.getWeb_Click_1);
            // 
            // getNombre
            // 
            this.getNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getNombre.FlatAppearance.BorderSize = 0;
            this.getNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNombre.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNombre.ForeColor = System.Drawing.Color.White;
            this.getNombre.Location = new System.Drawing.Point(310, 115);
            this.getNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getNombre.Name = "getNombre";
            this.getNombre.Size = new System.Drawing.Size(112, 38);
            this.getNombre.TabIndex = 14;
            this.getNombre.TabStop = false;
            this.getNombre.Text = "Nombre";
            this.getNombre.UseVisualStyleBackColor = false;
            this.getNombre.Click += new System.EventHandler(this.getNombre_Click_1);
            // 
            // getCif
            // 
            this.getCif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getCif.FlatAppearance.BorderSize = 0;
            this.getCif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCif.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCif.ForeColor = System.Drawing.Color.White;
            this.getCif.Location = new System.Drawing.Point(30, 115);
            this.getCif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getCif.Name = "getCif";
            this.getCif.Size = new System.Drawing.Size(112, 38);
            this.getCif.TabIndex = 12;
            this.getCif.TabStop = false;
            this.getCif.Text = "CIF";
            this.getCif.UseVisualStyleBackColor = false;
            this.getCif.Click += new System.EventHandler(this.getCif_Click_1);
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(120, 49);
            this.campo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(344, 34);
            this.campo1.TabIndex = 11;
            this.campo1.TabStop = false;
            // 
            // getNombreDireccion
            // 
            this.getNombreDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getNombreDireccion.FlatAppearance.BorderSize = 0;
            this.getNombreDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNombreDireccion.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNombreDireccion.ForeColor = System.Drawing.Color.White;
            this.getNombreDireccion.Location = new System.Drawing.Point(416, 129);
            this.getNombreDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getNombreDireccion.Name = "getNombreDireccion";
            this.getNombreDireccion.Size = new System.Drawing.Size(153, 77);
            this.getNombreDireccion.TabIndex = 23;
            this.getNombreDireccion.TabStop = false;
            this.getNombreDireccion.Text = "Nombre y dirección";
            this.getNombreDireccion.UseVisualStyleBackColor = false;
            this.getNombreDireccion.Click += new System.EventHandler(this.getNombreDireccion_Click_1);
            // 
            // getNombreEmail
            // 
            this.getNombreEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getNombreEmail.FlatAppearance.BorderSize = 0;
            this.getNombreEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNombreEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNombreEmail.ForeColor = System.Drawing.Color.White;
            this.getNombreEmail.Location = new System.Drawing.Point(219, 129);
            this.getNombreEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getNombreEmail.Name = "getNombreEmail";
            this.getNombreEmail.Size = new System.Drawing.Size(153, 77);
            this.getNombreEmail.TabIndex = 22;
            this.getNombreEmail.TabStop = false;
            this.getNombreEmail.Text = "Nombre y email";
            this.getNombreEmail.UseVisualStyleBackColor = false;
            this.getNombreEmail.Click += new System.EventHandler(this.getNombreEmail_Click_1);
            // 
            // getNombreTelefono
            // 
            this.getNombreTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.getNombreTelefono.FlatAppearance.BorderSize = 0;
            this.getNombreTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNombreTelefono.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNombreTelefono.ForeColor = System.Drawing.Color.White;
            this.getNombreTelefono.Location = new System.Drawing.Point(30, 129);
            this.getNombreTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getNombreTelefono.Name = "getNombreTelefono";
            this.getNombreTelefono.Size = new System.Drawing.Size(153, 77);
            this.getNombreTelefono.TabIndex = 21;
            this.getNombreTelefono.TabStop = false;
            this.getNombreTelefono.Text = "Nombre y teléfono";
            this.getNombreTelefono.UseVisualStyleBackColor = false;
            this.getNombreTelefono.Click += new System.EventHandler(this.getNombreTelefono_Click_1);
            // 
            // campo2
            // 
            this.campo2.Location = new System.Drawing.Point(98, 57);
            this.campo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campo2.Name = "campo2";
            this.campo2.Size = new System.Drawing.Size(148, 34);
            this.campo2.TabIndex = 19;
            this.campo2.TabStop = false;
            // 
            // campo3
            // 
            this.campo3.Location = new System.Drawing.Point(340, 57);
            this.campo3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campo3.Name = "campo3";
            this.campo3.Size = new System.Drawing.Size(148, 34);
            this.campo3.TabIndex = 20;
            this.campo3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.actividad);
            this.groupBox1.Controls.Add(this.delEmpresaButton);
            this.groupBox1.Controls.Add(this.direccion);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.web);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modEmpresaButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(162, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(801, 989);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getNombreDireccion);
            this.groupBox2.Controls.Add(this.campo2);
            this.groupBox2.Controls.Add(this.campo3);
            this.groupBox2.Controls.Add(this.getNombreEmail);
            this.groupBox2.Controls.Add(this.getNombreTelefono);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 720);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(602, 245);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador avanzado";
            // 
            // actividad
            // 
            this.actividad.Location = new System.Drawing.Point(514, 222);
            this.actividad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actividad.Name = "actividad";
            this.actividad.Size = new System.Drawing.Size(262, 146);
            this.actividad.TabIndex = 7;
            this.actividad.Text = "";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(514, 145);
            this.direccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(262, 34);
            this.direccion.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(514, 72);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(262, 34);
            this.email.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Actividad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(134, 288);
            this.telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefono.MaxLength = 9;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(168, 34);
            this.telefono.TabIndex = 4;
            this.telefono.TextChanged += new System.EventHandler(this.telefono_TextChanged);
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Teléfono:";
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(134, 217);
            this.web.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(168, 34);
            this.web.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Web: ";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(134, 145);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(168, 34);
            this.nombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre: ";
            // 
            // cif
            // 
            this.cif.Location = new System.Drawing.Point(134, 77);
            this.cif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cif.Name = "cif";
            this.cif.Size = new System.Drawing.Size(168, 34);
            this.cif.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "CIF:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(356, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.toolStrip1.Size = new System.Drawing.Size(108, 1157);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel1.Text = " Clientes";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel2.Text = "Productos";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel3.Text = "Usuarios";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel4.Text = "Compras";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 25);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel5.Text = "Reservas";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // labelEmpresas
            // 
            this.labelEmpresas.AutoSize = true;
            this.labelEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.labelEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmpresas.Font = new System.Drawing.Font("Gadugi", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresas.ForeColor = System.Drawing.Color.White;
            this.labelEmpresas.Location = new System.Drawing.Point(423, 48);
            this.labelEmpresas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpresas.Name = "labelEmpresas";
            this.labelEmpresas.Size = new System.Drawing.Size(266, 65);
            this.labelEmpresas.TabIndex = 40;
            this.labelEmpresas.Text = "Empresas";
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
            this.buttonAtras.Location = new System.Drawing.Point(162, 58);
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
            this.dataGridView1.Location = new System.Drawing.Point(990, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 532);
            this.dataGridView1.TabIndex = 59;
            // 
            // EmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1674, 1157);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelEmpresas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmpresaForm";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.EmpresaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modEmpresaButton;
        private System.Windows.Forms.Button delEmpresaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button getNombreDireccion;
        private System.Windows.Forms.Button getNombreEmail;
        private System.Windows.Forms.Button getNombreTelefono;
        private System.Windows.Forms.Button getActividad;
        private System.Windows.Forms.Button getDireccion;
        private System.Windows.Forms.Button getEmail;
        private System.Windows.Forms.Button getTelefono;
        private System.Windows.Forms.Button getWeb;
        private System.Windows.Forms.Button getNombre;
        private System.Windows.Forms.Button getCif;
        private System.Windows.Forms.TextBox campo2;
        private System.Windows.Forms.TextBox campo3;
        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox actividad;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox web;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEmpresas;
        private FontAwesome.Sharp.IconButton buttonAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}