namespace Proyecto
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            cboTipo = new ComboBox();
            rbtAptoSi = new RadioButton();
            rbtAptoNo = new RadioButton();
            lblApto = new Label();
            label1 = new Label();
            rbSocio = new RadioButton();
            rbNoSocio = new RadioButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 16);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(423, 16);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro del Cliente";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(404, 419);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(91, 47);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(539, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 47);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(666, 419);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(91, 47);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(404, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 22);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(404, 110);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 22);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(404, 153);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(43, 22);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(610, 153);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(97, 22);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "Documento";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(404, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 22);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(404, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 22);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(539, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 28);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(539, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(392, 28);
            txtApellido.TabIndex = 12;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(713, 150);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(218, 28);
            txtDocumento.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(539, 196);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 28);
            txtTelefono.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(539, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 28);
            txtEmail.TabIndex = 15;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(474, 148);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 30);
            cboTipo.TabIndex = 16;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // rbtAptoSi
            // 
            rbtAptoSi.AutoSize = true;
            rbtAptoSi.Location = new Point(588, 365);
            rbtAptoSi.Name = "rbtAptoSi";
            rbtAptoSi.Size = new Size(42, 26);
            rbtAptoSi.TabIndex = 17;
            rbtAptoSi.TabStop = true;
            rbtAptoSi.Text = "Si";
            rbtAptoSi.UseVisualStyleBackColor = true;
            // 
            // rbtAptoNo
            // 
            rbtAptoNo.AutoSize = true;
            rbtAptoNo.Location = new Point(666, 365);
            rbtAptoNo.Name = "rbtAptoNo";
            rbtAptoNo.Size = new Size(49, 26);
            rbtAptoNo.TabIndex = 18;
            rbtAptoNo.TabStop = true;
            rbtAptoNo.Text = "No";
            rbtAptoNo.UseVisualStyleBackColor = true;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Location = new Point(423, 369);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(93, 22);
            lblApto.TabIndex = 19;
            lblApto.Text = "Apto Físico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 293);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 20;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Location = new Point(36, 17);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(68, 26);
            rbSocio.TabIndex = 21;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Location = new Point(147, 17);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(93, 26);
            rbNoSocio.TabIndex = 22;
            rbNoSocio.TabStop = true;
            rbNoSocio.Text = "No Socio";
            rbNoSocio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(rbSocio);
            panel1.Controls.Add(rbNoSocio);
            panel1.Location = new Point(447, 286);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 59);
            panel1.TabIndex = 23;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 660);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblApto);
            Controls.Add(rbtAptoNo);
            Controls.Add(rbtAptoSi);
            Controls.Add(cboTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Font = new Font("Noto Serif", 11.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistrar";
            Text = "frmRegistrar";
            Load += frmRegistrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox cboTipo;
        private RadioButton rbtAptoSi;
        private RadioButton rbtAptoNo;
        private Label lblApto;
        private Label label1;
        private RadioButton rbSocio;
        private RadioButton rbNoSocio;
        private Panel panel1;
    }
}