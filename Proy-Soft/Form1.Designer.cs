namespace Proy_Soft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnprod = new Button();
            btnlogoInicio = new PictureBox();
            BarraTitulo = new Panel();
            iconrestaurar = new PictureBox();
            iconminimizar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 122, 204);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(button5);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(btnprod);
            MenuVertical.Controls.Add(btnlogoInicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(333, 700);
            MenuVertical.TabIndex = 0;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 189);
            label1.Name = "label1";
            label1.Size = new Size(325, 33);
            label1.TabIndex = 6;
            label1.Text = "Nombre del Administrador";
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 639);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(333, 61);
            button5.TabIndex = 5;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(4, 484);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(333, 61);
            button4.TabIndex = 4;
            button4.Text = "Bonos y Descuentos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(4, 413);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(333, 61);
            button3.TabIndex = 3;
            button3.Text = "Planilla de Sueldos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(4, 343);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(333, 61);
            button2.TabIndex = 2;
            button2.Text = "Administradores";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnprod
            // 
            btnprod.BackgroundImageLayout = ImageLayout.Zoom;
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnprod.ForeColor = Color.White;
            btnprod.Image = (Image)resources.GetObject("btnprod.Image");
            btnprod.ImageAlign = ContentAlignment.MiddleLeft;
            btnprod.Location = new Point(4, 272);
            btnprod.Margin = new Padding(4, 5, 4, 5);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(333, 61);
            btnprod.TabIndex = 1;
            btnprod.Text = "Personal";
            btnprod.UseVisualStyleBackColor = true;
            btnprod.Click += btnprod_Click;
            // 
            // btnlogoInicio
            // 
            btnlogoInicio.Cursor = Cursors.Hand;
            btnlogoInicio.Image = (Image)resources.GetObject("btnlogoInicio.Image");
            btnlogoInicio.Location = new Point(4, 9);
            btnlogoInicio.Margin = new Padding(4, 5, 4, 5);
            btnlogoInicio.Name = "btnlogoInicio";
            btnlogoInicio.Size = new Size(321, 175);
            btnlogoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnlogoInicio.TabIndex = 0;
            btnlogoInicio.TabStop = false;
            btnlogoInicio.Click += btnlogoInicio_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 130, 180);
            BarraTitulo.Controls.Add(iconrestaurar);
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(333, 0);
            BarraTitulo.Margin = new Padding(4, 5, 4, 5);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(867, 69);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Cursor = Cursors.Hand;
            iconrestaurar.Image = (Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new Point(795, 9);
            iconrestaurar.Margin = new Padding(4, 5, 4, 5);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(24, 28);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 3;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Image = (Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new Point(759, 8);
            iconminimizar.Margin = new Padding(4, 5, 4, 5);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(24, 28);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 4;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Image = (Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new Point(794, 8);
            iconmaximizar.Margin = new Padding(4, 5, 4, 5);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(24, 28);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Image = (Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new Point(828, 8);
            iconcerrar.Margin = new Padding(4, 5, 4, 5);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(24, 28);
            iconcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 1;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(333, 69);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(867, 631);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private PictureBox btnlogoInicio;
        private Panel BarraTitulo;
        private PictureBox iconminimizar;
        private PictureBox iconrestaurar;
        private PictureBox iconmaximizar;
        private PictureBox iconcerrar;
        private Button btnprod;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panelContenedor;
    }
}

