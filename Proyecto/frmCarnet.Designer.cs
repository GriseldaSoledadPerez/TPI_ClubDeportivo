namespace Proyecto
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            lblTitulo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblClub = new Label();
            panel3 = new Panel();
            lblFecha = new Label();
            lblFec = new Label();
            panel4 = new Panel();
            lblVencimiento = new Label();
            lblEstado = new Label();
            lblDoc = new Label();
            lblCliente = new Label();
            lblAfiliado = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(136, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carnet de Socio";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(152, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 51);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblClub);
            panel2.Location = new Point(152, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 51);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClub.Location = new Point(31, 16);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(113, 20);
            lblClub.TabIndex = 0;
            lblClub.Text = "Club Deportivo";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblFecha);
            panel3.Controls.Add(lblFec);
            panel3.Location = new Point(353, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 51);
            panel3.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(79, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 1;
            // 
            // lblFec
            // 
            lblFec.AutoSize = true;
            lblFec.Location = new Point(22, 20);
            lblFec.Name = "lblFec";
            lblFec.Size = new Size(44, 15);
            lblFec.TabIndex = 0;
            lblFec.Text = "Fecha: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblVencimiento);
            panel4.Controls.Add(lblEstado);
            panel4.Controls.Add(lblDoc);
            panel4.Controls.Add(lblCliente);
            panel4.Controls.Add(lblAfiliado);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(152, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 172);
            panel4.TabIndex = 4;
            // 
            // lblVencimiento
            // 
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(265, 124);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(54, 15);
            lblVencimiento.TabIndex = 9;
            lblVencimiento.Text = "fechavec";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(95, 112);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 17);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "estado";
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(135, 72);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(69, 15);
            lblDoc.TabIndex = 7;
            lblDoc.Text = "documento";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(135, 44);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(49, 15);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "nombre";
            // 
            // lblAfiliado
            // 
            lblAfiliado.AutoSize = true;
            lblAfiliado.Location = new Point(135, 16);
            lblAfiliado.Name = "lblAfiliado";
            lblAfiliado.Size = new Size(53, 15);
            lblAfiliado.TabIndex = 5;
            lblAfiliado.Text = "nafiliado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 100);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Vencimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 114);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 72);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "N° Afiliado: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.PaleGreen;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnImprimir.Location = new Point(247, 306);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(147, 36);
            btnImprimir.TabIndex = 9;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(572, 365);
            Controls.Add(btnImprimir);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCarnet";
            Text = "frmCarnet";
            Load += frmCarnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblClub;
        private Label lblFec;
        private Button btnImprimir;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblFecha;
        private Label label5;
        private Label label4;
        private Label lblCliente;
        private Label lblAfiliado;
        private Label lblVencimiento;
        private Label lblEstado;
        private Label lblDoc;
    }
}