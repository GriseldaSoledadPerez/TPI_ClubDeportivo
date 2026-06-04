namespace Proyecto
{
    partial class listarVenc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listarVenc));
            dtgvVencidos = new DataGridView();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            cliente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            vencimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvVencidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgvVencidos
            // 
            dtgvVencidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencidos.Columns.AddRange(new DataGridViewColumn[] { cliente, dni, vencimiento });
            dtgvVencidos.Location = new Point(49, 52);
            dtgvVencidos.Name = "dtgvVencidos";
            dtgvVencidos.Size = new Size(498, 297);
            dtgvVencidos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.GreenYellow;
            btnVolver.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(634, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(84, 34);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(571, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 339);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(49, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 20);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Listado de SOCIOS con cuota vencida:";
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
            // listarVenc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(dtgvVencidos);
            Name = "listarVenc";
            Text = "listarVenc";
            Load += listarVenc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVencidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvVencidos;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn vencimiento;
        private Label lblTitulo;
    }
}