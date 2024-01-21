
namespace ClientRESTAPI
{
    partial class InicioSesionForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.passCrdentialsTextBox = new System.Windows.Forms.TextBox();
            this.usucredentialsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registroPageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(315, 366);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(145, 31);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Iniciar sesión";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // passCrdentialsTextBox
            // 
            this.passCrdentialsTextBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCrdentialsTextBox.Location = new System.Drawing.Point(384, 317);
            this.passCrdentialsTextBox.Name = "passCrdentialsTextBox";
            this.passCrdentialsTextBox.Size = new System.Drawing.Size(138, 23);
            this.passCrdentialsTextBox.TabIndex = 2;
            // 
            // usucredentialsTextBox
            // 
            this.usucredentialsTextBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usucredentialsTextBox.Location = new System.Drawing.Point(384, 275);
            this.usucredentialsTextBox.Name = "usucredentialsTextBox";
            this.usucredentialsTextBox.Size = new System.Drawing.Size(138, 23);
            this.usucredentialsTextBox.TabIndex = 1;
            this.usucredentialsTextBox.TextChanged += new System.EventHandler(this.usucredentialsTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(138)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ClientRESTAPI.Properties.Resources.fisio;
            this.pictureBox1.ImageLocation = "fisio.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 238);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // registroPageButton
            // 
            this.registroPageButton.AutoSize = true;
            this.registroPageButton.BackColor = System.Drawing.Color.Transparent;
            this.registroPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registroPageButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.registroPageButton.FlatAppearance.BorderSize = 0;
            this.registroPageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registroPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registroPageButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroPageButton.Location = new System.Drawing.Point(304, 411);
            this.registroPageButton.Name = "registroPageButton";
            this.registroPageButton.Size = new System.Drawing.Size(168, 30);
            this.registroPageButton.TabIndex = 4;
            this.registroPageButton.TabStop = false;
            this.registroPageButton.Text = "Eres nuevo? Regístrate";
            this.registroPageButton.UseVisualStyleBackColor = false;
            this.registroPageButton.Click += new System.EventHandler(this.button2_Click);
            this.registroPageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.registroPageButton.MouseEnter += new System.EventHandler(this.button2_MouseHover);
            this.registroPageButton.MouseLeave += new System.EventHandler(this.button2_MouseExit);
            // 
            // InicioSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registroPageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usucredentialsTextBox);
            this.Controls.Add(this.passCrdentialsTextBox);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InicioSesionForm";
            this.Text = "Inicio sesión";
            this.Load += new System.EventHandler(this.InicioSesionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passCrdentialsTextBox;
        private System.Windows.Forms.TextBox usucredentialsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registroPageButton;
    }
}