namespace Proy_Soft
{
    partial class Personal
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            lblFecha = new Label();
            lblhora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            TablaProductos = new DataGridView();
            label15 = new Label();
            btnReload = new Button();
            btnMas = new Button();
            btnImp = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TablaProductos).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(0, 122, 204);
            lblFecha.Location = new Point(463, 139);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(321, 27);
            lblFecha.TabIndex = 29;
            lblFecha.Text = "Sabado, 2  diciembre  2023";
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.BackColor = Color.Transparent;
            lblhora.Font = new Font("Century Gothic", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            lblhora.ForeColor = Color.FromArgb(64, 64, 64);
            lblhora.Location = new Point(432, 31);
            lblhora.Margin = new Padding(4, 0, 4, 0);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(370, 99);
            lblhora.TabIndex = 28;
            lblhora.Text = "10:59:58";
            lblhora.Click += lblhora_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // TablaProductos
            // 
            TablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TablaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TablaProductos.BackgroundColor = Color.WhiteSmoke;
            TablaProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            TablaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaProductos.ColumnHeadersHeight = 30;
            TablaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TablaProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Correo, Telefono, Cargo, Salario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            TablaProductos.EnableHeadersVisualStyles = false;
            TablaProductos.GridColor = Color.FromArgb(64, 64, 64);
            TablaProductos.Location = new Point(35, 187);
            TablaProductos.Margin = new Padding(4, 5, 4, 5);
            TablaProductos.Name = "TablaProductos";
            TablaProductos.RowHeadersVisible = false;
            TablaProductos.RowHeadersWidth = 51;
            TablaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaProductos.Size = new Size(749, 382);
            TablaProductos.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Constantia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(13, 9);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(188, 49);
            label15.TabIndex = 37;
            label15.Text = "Personal";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Transparent;
            btnReload.BackgroundImage = (Image)resources.GetObject("btnReload.BackgroundImage");
            btnReload.BackgroundImageLayout = ImageLayout.Zoom;
            btnReload.Cursor = Cursors.Hand;
            btnReload.ForeColor = Color.Transparent;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.Location = new Point(35, 61);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(50, 50);
            btnReload.TabIndex = 40;
            btnReload.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            btnMas.BackColor = Color.Transparent;
            btnMas.BackgroundImage = (Image)resources.GetObject("btnMas.BackgroundImage");
            btnMas.BackgroundImageLayout = ImageLayout.Zoom;
            btnMas.Cursor = Cursors.Hand;
            btnMas.ForeColor = Color.Transparent;
            btnMas.Location = new Point(91, 61);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(50, 50);
            btnMas.TabIndex = 41;
            btnMas.UseVisualStyleBackColor = false;
            // 
            // btnImp
            // 
            btnImp.BackColor = Color.Transparent;
            btnImp.BackgroundImage = (Image)resources.GetObject("btnImp.BackgroundImage");
            btnImp.BackgroundImageLayout = ImageLayout.Zoom;
            btnImp.Cursor = Cursors.Hand;
            btnImp.ForeColor = Color.Transparent;
            btnImp.Location = new Point(151, 61);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(50, 50);
            btnImp.TabIndex = 42;
            btnImp.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.ForeColor = Color.Transparent;
            btnBuscar.Location = new Point(385, 139);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(40, 40);
            btnBuscar.TabIndex = 43;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 44;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Completo";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 193;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo Electronico";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 191;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 107;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 90;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario (MES)";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.Width = 142;
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(815, 600);
            Controls.Add(textBox1);
            Controls.Add(btnBuscar);
            Controls.Add(btnImp);
            Controls.Add(btnMas);
            Controls.Add(btnReload);
            Controls.Add(lblFecha);
            Controls.Add(lblhora);
            Controls.Add(TablaProductos);
            Controls.Add(label15);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Personal";
            Text = "InicioResumen";
            Load += Personal_Load;
            ((System.ComponentModel.ISupportInitialize)TablaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFecha;
        private Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private DataGridView TablaProductos;
        private Label label15;
        private Button btnReload;
        private Button btnMas;
        private Button btnImp;
        private Button btnBuscar;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Salario;
    }
}