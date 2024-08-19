using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Windows.Forms; // Para Windows Forms
using System.Windows; // Para WPF

namespace ConectaAprendiz.Formularios
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        } 

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Delay(10000);
            progressBar1.PerformStep();
            if (progressBar1.Value >= 45 && progressBar1.Value < 90)
            {
                label69.Text = "Conecta";
            }
            else if (progressBar1.Value >= 90)
            {
                label70.ForeColor = Color.Red;
                label70.Text = "Aprendiz";
            }
            if(progressBar1.Value == progressBar1.Maximum)
            {
                frm_Login login = new frm_Login();
                login.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_splash_Load(object sender, EventArgs e)
        {

        }
    }
}
 