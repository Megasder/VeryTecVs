
namespace ClientRESTAPI
{
    partial class RegistroForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registroButton = new System.Windows.Forms.Button();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoDNI = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "fisioRedimensionado.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(474, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 235);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // registroButton
            // 
            this.registroButton.AutoSize = true;
            this.registroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.registroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registroButton.FlatAppearance.BorderSize = 2;
            this.registroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registroButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroButton.ForeColor = System.Drawing.Color.White;
            this.registroButton.Location = new System.Drawing.Point(463, 674);
            this.registroButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registroButton.Name = "registroButton";
            this.registroButton.Size = new System.Drawing.Size(218, 48);
            this.registroButton.TabIndex = 6;
            this.registroButton.Text = "Registrarse";
            this.registroButton.UseVisualStyleBackColor = false;
            this.registroButton.Click += new System.EventHandler(this.registroButton_Click);
            // 
            // loginPageButton
            // 
            this.loginPageButton.AutoSize = true;
            this.loginPageButton.BackColor = System.Drawing.Color.Transparent;
            this.loginPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPageButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.loginPageButton.FlatAppearance.BorderSize = 0;
            this.loginPageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginPageButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPageButton.Location = new System.Drawing.Point(403, 744);
            this.loginPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(332, 46);
            this.loginPageButton.TabIndex = 7;
            this.loginPageButton.TabStop = false;
            this.loginPageButton.Text = "Ya eres usuario? Inicia sesión";
            this.loginPageButton.UseVisualStyleBackColor = false;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            this.loginPageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.loginPageButton.MouseEnter += new System.EventHandler(this.loginPageButton_MouseHover);
            this.loginPageButton.MouseLeave += new System.EventHandler(this.loginPageButton_MouseExit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(398, 434);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(398, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña:";
            // 
            // campoNombre
            // 
            this.campoNombre.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNombre.Location = new System.Drawing.Point(558, 282);
            this.campoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(205, 31);
            this.campoNombre.TabIndex = 1;
            // 
            // campoApellidos
            // 
            this.campoApellidos.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoApellidos.Location = new System.Drawing.Point(560, 331);
            this.campoApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(205, 31);
            this.campoApellidos.TabIndex = 2;
            // 
            // campoDNI
            // 
            this.campoDNI.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDNI.Location = new System.Drawing.Point(558, 379);
            this.campoDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoDNI.Name = "campoDNI";
            this.campoDNI.Size = new System.Drawing.Size(205, 31);
            this.campoDNI.TabIndex = 3;
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(558, 430);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(205, 31);
            this.campoEmail.TabIndex = 4;
            // 
            // campoPassword
            // 
            this.campoPassword.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPassword.Location = new System.Drawing.Point(558, 482);
            this.campoPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoPassword.Name = "campoPassword";
            this.campoPassword.Size = new System.Drawing.Size(205, 31);
            this.campoPassword.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(398, 538);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefono:";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefono.Location = new System.Drawing.Point(558, 534);
            this.campoTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(205, 31);
            this.campoTelefono.TabIndex = 15;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1200, 953);
            this.Controls.Add(this.campoTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoPassword);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoDNI);
            this.Controls.Add(this.campoApellidos);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPageButton);
            this.Controls.Add(this.registroButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistroForm";
            this.ShowIcon = false;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registroButton;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoDNI;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoTelefono;
    }
}