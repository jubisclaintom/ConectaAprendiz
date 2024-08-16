using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
             
            
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label56.Text = "Carregando";
            if (progressBar1.Value == 10)
            {
                label56.Text = "Conecta Aprendiz: Transformando Conhecimento em Oportunidades";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }
    }
}
 