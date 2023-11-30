namespace Proy_Soft
{
    partial class FormCarga
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
            label1 = new Label();
            bar = new ProgressBar();
            Anima = new System.Windows.Forms.Timer(components);
            HideAnima = new System.Windows.Forms.Timer(components);
            lblVal = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Zilla Slab SemiBold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(230, 25);
            label1.Name = "label1";
            label1.Size = new Size(370, 41);
            label1.TabIndex = 0;
            label1.Text = "PLANILLA DE SUELDOS";
            // 
            // bar
            // 
            bar.Location = new Point(68, 383);
            bar.Name = "bar";
            bar.Size = new Size(665, 29);
            bar.TabIndex = 1;
            // 
            // Anima
            // 
            Anima.Interval = 40;
            Anima.Tick += Anima_Tick;
            // 
            // HideAnima
            // 
            HideAnima.Interval = 30;
            HideAnima.Tick += HideAnima_Tick;
            // 
            // lblVal
            // 
            lblVal.AutoSize = true;
            lblVal.BackColor = Color.WhiteSmoke;
            lblVal.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblVal.ForeColor = Color.Black;
            lblVal.Location = new Point(380, 345);
            lblVal.Name = "lblVal";
            lblVal.Size = new Size(54, 35);
            lblVal.TabIndex = 2;
            lblVal.Text = "0%";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 96);
            panel1.TabIndex = 3;
            // 
            // FormCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblVal);
            Controls.Add(bar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarga";
            Load += FormCarga_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar bar;
        private System.Windows.Forms.Timer Anima;
        private System.Windows.Forms.Timer HideAnima;
        private Label lblVal;
        private Panel panel1;
    }
}