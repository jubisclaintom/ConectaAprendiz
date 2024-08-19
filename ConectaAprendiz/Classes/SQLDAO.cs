using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectaAprendiz.Classes
{
    class SQLDAO
    {
        public string caminho = @"SERVER=localhost; DATABASE=fornecedores; UID=root;PASSWORD=;";
        public MySqlConnection conexao = null;
        //MEODO INSERT/UPDATE/DELETE E SELECT NO BANCO DE DADOS
        public void ManipulaDados(String Query_DB)
        {
            try
            {
                //PEGANDO O INSERT (pelo parametro) E ATIVADO O BANCO DE DADOS
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                MySqlCommand Sql = new MySqlCommand(Query_DB, conexao);
                Sql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Funciona", "funfou");
            }
            catch (Exception Error)
            {
                throw Error;
            }

        }
        public DataTable CarregaDados(string Tabela)
        {
            conexao = new MySqlConnection(caminho);
            MySqlCommand SQL = new MySqlCommand(Tabela, conexao);
            MySqlDataAdapter valores = new MySqlDataAdapter();
            valores.SelectCommand = SQL;
            DataTable Resultado = new DataTable();
            valores.Fill(Resultado);
            return Resultado;
        }

    }
}
