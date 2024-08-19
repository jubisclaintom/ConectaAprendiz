using ConectaAprendiz.Classes;
using ConectaAprendiz.Formularios;
using MySql.Data.MySqlClient;
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
        SQLDAO sql = new SQLDAO();
        ModeloUsuarios Modelo = new ModeloUsuarios();
        public static string nome, PerfilUsuario;

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
            if (ValidaCampos() == true)
            {
                string Query = "SELECT * FROM login WHERE BDnome= '" + logintext.Text + "' AND BDsenha='" + pswdtext.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, sql.caminho);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    nome = logintext.Text;
                    PerfilUsuario = dt.Rows[0]["BDperfil"].ToString();
                    Principal frm = new Principal();
                    frm.Show();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha i´nválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logintext.Clear();
                    pswdtext.Clear();
                    logintext.Focus();
                }

            }
        }
        public Boolean ValidaCampos()
        {
            if (logintext.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo de Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logintext.Focus();
                return false;
            }
            if (pswdtext.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo de Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pswdtext.Focus();
                return false;
            }
            return true;
        }
    }
}
