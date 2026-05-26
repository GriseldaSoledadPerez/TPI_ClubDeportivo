namespace Proyecto
{
    partial class frmCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrar));
            pnlSocio = new Panel();
            btnGenerarCarnet = new Button();
            btnCobrarCuota = new Button();
            lblSocio = new Label();
            pnlParticular = new Panel();
            btnCobrarActividades = new Button();
            btnAsignarActividad = new Button();
            lblParticular = new Label();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            pnlSocio.SuspendLayout();
            pnlParticular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSocio
            // 
            pnlSocio.BackColor = Color.DarkSeaGreen;
            pnlSocio.Controls.Add(btnGenerarCarnet);
            pnlSocio.Controls.Add(btnCobrarCuota);
            pnlSocio.Controls.Add(lblSocio);
            pnlSocio.Location = new Point(24, 25);
            pnlSocio.Name = "pnlSocio";
            pnlSocio.Size = new Size(533, 158);
            pnlSocio.TabIndex = 0;
            // 
            // btnGenerarCarnet
            // 
            btnGenerarCarnet.BackColor = Color.CadetBlue;
            btnGenerarCarnet.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerarCarnet.Location = new Point(307, 55);
            btnGenerarCarnet.Name = "btnGenerarCarnet";
            btnGenerarCarnet.Size = new Size(148, 56);
            btnGenerarCarnet.TabIndex = 3;
            btnGenerarCarnet.Text = "Generar Carnet";
            btnGenerarCarnet.UseVisualStyleBackColor = false;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackColor = Color.CadetBlue;
            btnCobrarCuota.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCobrarCuota.Location = new Point(111, 55);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(150, 56);
            btnCobrarCuota.TabIndex = 2;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = false;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(30, 17);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(44, 20);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "Socio";
            // 
            // pnlParticular
            // 
            pnlParticular.BackColor = Color.DarkSeaGreen;
            pnlParticular.Controls.Add(btnCobrarActividades);
            pnlParticular.Controls.Add(btnAsignarActividad);
            pnlParticular.Controls.Add(lblParticular);
            pnlParticular.Location = new Point(24, 200);
            pnlParticular.Name = "pnlParticular";
            pnlParticular.Size = new Size(533, 158);
            pnlParticular.TabIndex = 1;
            // 
            // btnCobrarActividades
            // 
            btnCobrarActividades.BackColor = Color.CadetBlue;
            btnCobrarActividades.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCobrarActividades.Location = new Point(307, 58);
            btnCobrarActividades.Name = "btnCobrarActividades";
            btnCobrarActividades.Size = new Size(148, 58);
            btnCobrarActividades.TabIndex = 5;
            btnCobrarActividades.Text = "Cobrar Actividades";
            btnCobrarActividades.UseVisualStyleBackColor = false;
            // 
            // btnAsignarActividad
            // 
            btnAsignarActividad.BackColor = Color.CadetBlue;
            btnAsignarActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAsignarActividad.Location = new Point(111, 58);
            btnAsignarActividad.Name = "btnAsignarActividad";
            btnAsignarActividad.Size = new Size(150, 58);
            btnAsignarActividad.TabIndex = 4;
            btnAsignarActividad.Text = "Asignar Actividad";
            btnAsignarActividad.UseVisualStyleBackColor = false;
            btnAsignarActividad.Click += btnAsignarActividad_Click;
            // 
            // lblParticular
            // 
            lblParticular.AutoSize = true;
            lblParticular.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblParticular.Location = new Point(30, 19);
            lblParticular.Name = "lblParticular";
            lblParticular.Size = new Size(77, 20);
            lblParticular.TabIndex = 1;
            lblParticular.Text = "Particular";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkCyan;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(607, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 46);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(563, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 333);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(pnlParticular);
            Controls.Add(pnlSocio);
            Name = "frmCobrar";
            Text = "frmCobrar";
            Load += frmCobrar_Load;
            pnlSocio.ResumeLayout(false);
            pnlSocio.PerformLayout();
            pnlParticular.ResumeLayout(false);
            pnlParticular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSocio;
        private Label lblSocio;
        private Panel pnlParticular;
        private Button btnCobrarCuota;
        private Label lblParticular;
        private Button btnGenerarCarnet;
        private Button btnCobrarActividades;
        private Button btnAsignarActividad;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}