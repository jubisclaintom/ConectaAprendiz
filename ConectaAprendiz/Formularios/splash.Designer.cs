using ConectaAprendiz.Classes;
using System.Drawing;
namespace ConectaAprendiz.Formularios
{
    partial class frm_splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label56 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.progressBar1 = new ConectaAprendiz.Classes.Customprogressbar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label56.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(184, 371);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(252, 21);
            this.label56.TabIndex = 1;
            this.label56.Text = " Aprenda, Cresça, Conquiste";
            // 
            // label69
            // 
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label69.Location = new System.Drawing.Point(173, 321);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(106, 36);
            this.label69.TabIndex = 2;
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label70.Location = new System.Drawing.Point(304, 321);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(132, 36);
            this.label70.TabIndex = 3;
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 396);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(591, 30);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(590, 423);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.progressBar1);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_splash";
            this.Text = "splash";
            this.Load += new System.EventHandler(this.frm_splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Customprogressbar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
    }
}