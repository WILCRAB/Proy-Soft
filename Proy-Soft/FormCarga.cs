using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proy_Soft
{
    public partial class FormCarga : Form
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
        public FormCarga()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Anima.Start();

        }

        private void Anima_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            bar.Value += 1;
            lblVal.Text = $"{bar.Value.ToString()}%";
            lblVal.BackColor = Color.Transparent;

            if (bar.Value == 100)
            {
                Anima.Stop();
                HideAnima.Start();
            }
        }

        private void HideAnima_Tick(object sender, EventArgs e)
        {

            this.Opacity -= 0.2;
            if (this.Opacity == 0)
            {
                HideAnima.Stop();
                Login f = new Login();
                f.Show();
                this.Hide();
            }
        }
    }
}
