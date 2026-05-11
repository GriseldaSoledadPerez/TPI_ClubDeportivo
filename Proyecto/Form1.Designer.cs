namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Noto Serif", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(384, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA CLUB DEPORTIVO";
            lblTitulo.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Noto Serif", 11.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(444, 241);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(148, 49);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(402, 115);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(402, 167);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(239, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
    }
}
