using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    static class Conexao
    {
        private const string server = "localhost";
        private const string database = "controlefinanceiro";
        private const string user = "root";
        private const string senha = "admin123";

        static public string strConexao = $"server={server};database={database};User ID= {user};password={senha}"; 
    }
}
