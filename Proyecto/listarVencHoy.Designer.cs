namespace Proyecto
{
    partial class listarVencHoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listarVencHoy));
            dtgvVencidos = new DataGridView();
            cliente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            vencimiento = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvVencidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgvVencidos
            // 
            dtgvVencidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencidos.Columns.AddRange(new DataGridViewColumn[] { cliente, dni, vencimiento });
            dtgvVencidos.Location = new Point(31, 69);
            dtgvVencidos.Name = "dtgvVencidos";
            dtgvVencidos.Size = new Size(497, 297);
            dtgvVencidos.TabIndex = 1;
            // 
            // cliente
            // 
            cliente.HeaderText = "CLIENTE";
            cliente.Name = "cliente";
            cliente.Width = 250;
            // 
            // dni
            // 
            dni.HeaderText = "Documento";
            dni.Name = "dni";
            // 
            // vencimiento
            // 
            vencimiento.HeaderText = "VENCIMIENTO";
            vencimiento.Name = "vencimiento";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Cyan;
            btnVolver.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(625, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(84, 34);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(58, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 20);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Listado de SOCIOS con cuota vencida el dia de HOY:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SkyBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listarVencHoy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(dtgvVencidos);
            Name = "listarVencHoy";
            Text = "listarVencHoy";
            Load += listarVencHoy_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVencidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvVencidos;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn vencimiento;
        private Button btnVolver;
        private Label lblTitulo;
        private PictureBox pictureBox1;
    }
}