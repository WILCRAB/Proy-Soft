namespace Proy_Soft
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Animalog = new System.Windows.Forms.Timer(components);
            Animalog2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel1 = new Panel();
            panelCont = new Panel();
            cboxMostrar = new CheckBox();
            btnAceptar = new Button();
            label2 = new Label();
            lblnom = new Label();
            txtContra = new TextBox();
            pictureBox5 = new PictureBox();
            txtUsua = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbNombre = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panelCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNombre).BeginInit();
            SuspendLayout();
            // 
            // Animalog
            // 
            Animalog.Interval = 20;
            Animalog.Tick += Animalog_Tick;
            // 
            // Animalog2
            // 
            Animalog2.Interval = 30;
            Animalog2.Tick += Animalog2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(56, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 49);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 60);
            panel1.TabIndex = 2;
            // 
            // panelCont
            // 
            panelCont.BackColor = Color.WhiteSmoke;
            panelCont.Controls.Add(button1);
            panelCont.Controls.Add(cboxMostrar);
            panelCont.Controls.Add(btnAceptar);
            panelCont.Controls.Add(label2);
            panelCont.Controls.Add(lblnom);
            panelCont.Controls.Add(txtContra);
            panelCont.Controls.Add(pictureBox5);
            panelCont.Controls.Add(txtUsua);
            panelCont.Controls.Add(pictureBox3);
            panelCont.Controls.Add(pictureBox2);
            panelCont.Controls.Add(pictureBox4);
            panelCont.Controls.Add(pictureBox1);
            panelCont.Controls.Add(pbNombre);
            panelCont.Dock = DockStyle.Bottom;
            panelCont.Location = new Point(0, 60);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(357, 332);
            panelCont.TabIndex = 3;
            // 
            // cboxMostrar
            // 
            cboxMostrar.AutoSize = true;
            cboxMostrar.Location = new Point(85, 152);
            cboxMostrar.Name = "cboxMostrar";
            cboxMostrar.Size = new Size(160, 24);
            cboxMostrar.TabIndex = 8;
            cboxMostrar.Text = "Mostrar Contraseña";
            cboxMostrar.UseVisualStyleBackColor = true;
            cboxMostrar.CheckedChanged += cboxMostrar_CheckedChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 122, 204);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Transparent;
            btnAceptar.Location = new Point(26, 229);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(141, 45);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 90);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 6;
            label2.Text = "Contraseña:";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Font = new Font("Lato Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblnom.Location = new Point(92, 15);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(75, 21);
            lblnom.TabIndex = 6;
            lblnom.Text = "Usuario:";
            // 
            // txtContra
            // 
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContra.Location = new Point(98, 112);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '•';
            txtContra.Size = new Size(208, 28);
            txtContra.TabIndex = 4;
            txtContra.Tag = "Nombre";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(86, 104);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(230, 40);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // txtUsua
            // 
            txtUsua.BorderStyle = BorderStyle.None;
            txtUsua.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsua.Location = new Point(98, 37);
            txtUsua.Name = "txtUsua";
            txtUsua.Size = new Size(208, 28);
            txtUsua.TabIndex = 4;
            txtUsua.Tag = "Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(86, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(230, 40);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.Location = new Point(84, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(234, 44);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pbNombre
            // 
            pbNombre.BackColor = Color.Black;
            pbNombre.Location = new Point(84, 27);
            pbNombre.Name = "pbNombre";
            pbNombre.Size = new Size(234, 44);
            pbNombre.TabIndex = 5;
            pbNombre.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(192, 229);
            button1.Name = "button1";
            button1.Size = new Size(141, 45);
            button1.TabIndex = 9;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(357, 392);
            Controls.Add(panel1);
            Controls.Add(panelCont);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCont.ResumeLayout(false);
            panelCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNombre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Animalog;
        private System.Windows.Forms.Timer Animalog2;
        private Label label1;
        private Panel panel1;
        private Panel panelCont;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtUsua;
        private PictureBox pbNombre;
        private PictureBox pictureBox3;
        private Label lblnom;
        private Label label2;
        private TextBox txtContra;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btnAceptar;
        private CheckBox cboxMostrar;
        private Button button1;
    }
}