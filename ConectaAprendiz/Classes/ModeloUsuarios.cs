using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaAprendiz.Classes
{
    internal class ModeloUsuarios
    {
        public int CodigoLogin { get; set; }
        public string NomeLogin { get; set; }
        public string Senha { get; set; }
        public int Perfil { get; set; }
    }
}
