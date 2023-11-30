using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proy_Soft
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Animalog.Start();
        }

        private void Animalog_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;

            if (this.Opacity == 100)
            {
                Animalog.Stop();
                Animalog2.Start();
            }
        }

        private void Animalog2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                Animalog2.Stop();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void cboxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxMostrar.Checked == true)
            {
                txtContra.PasswordChar = '•';
            }
            else
            {
                txtContra.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}