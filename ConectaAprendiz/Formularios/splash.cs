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
            if(progressBar1.Value >= 45 && progressBar1.Value < 90)
            {
                label69.Text = "Conecta";
            }
            else if (progressBar1.Value >= 90)
            {
                label70.Text = "Aprendiz";
            }

            
            //if (progressBar1.Value == 45)
            //{
            //    label69.Text = "Conecta ";
            //}
            //if (progressBar1.Value == 90)
            //{
            //    label70.Text = "Aprendiz";
            //}

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

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label69_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
 