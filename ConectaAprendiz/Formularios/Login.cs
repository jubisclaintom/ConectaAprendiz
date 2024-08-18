using ConectaAprendiz.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectaAprendiz
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
          
        }
        

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnentrar_Click_1(object sender, EventArgs e)
        {
           Principal principal = new Principal();
            principal.Show();
            
        }
    }
}
