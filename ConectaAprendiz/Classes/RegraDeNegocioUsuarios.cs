using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaAprendiz.Classes
{
    internal class RegraDeNegocioUsuarios
    {
        public SQLDAO Sql = new SQLDAO();
        public void Cadastrar(ModeloUsuarios modelo)
        {
            String Query = "INSERT INTO login (BDnome, BDsenha, BDperfil)" +
                "VALUES ('"
                + modelo.NomeLogin + "','"
                + modelo.Senha + "','"
                + modelo.Perfil + "')";
            Sql.ManipulaDados(Query);
        }
        public void Alterar(ModeloUsuarios modelo)
        {
            String Query = "UPDATE login SET BDnome = '"
                + modelo.NomeLogin + "','"
                + modelo.Senha + "','"
                + modelo.Perfil + "'";
            Sql.ManipulaDados(Query);
        }
        public void Excluir(ModeloUsuarios modelo)
        {
            string Query = "DELETE FROM login WHERE BDID_user = '"
                + modelo.NomeLogin + "','"
                + modelo.Senha + "','"
                + modelo.Perfil + "'";
            Sql.CarregaDados(Query);
        }
        public DataTable carregaInformacao()
        {
            DataTable dt = new DataTable();
            dt = Sql.CarregaDados("SELET * FROM login");
            return dt;
        }
    }
}
