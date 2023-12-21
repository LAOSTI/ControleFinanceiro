using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleFinanceiro.Properties
{
    public partial class Divida : Form
    {
        int ID = 0;
        MySqlConnection conexao;
        public Divida()
        {
            InitializeComponent();
        }

        private void Divida_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(Conexao.strConexao);
                //var entrada = dtEntrada.CustomFormat = "YYYY-MM-DD hh:mm:ss";
                var dataselecinada = dtEntrada.Value.ToString("yyy-MM-dd");
                /*var datenow = DateTime.Now;
                var date = datenow.Date.ToString("yyy-MM-dd");*/

                string sql = $"INSERT INTO DIVIDA(ID,CATEGORIA,DESCRICAO,VALOR,DTREGISTRO)" +
                             $"VALUES('{ID}', '{CBOXDivida.Text}', '{txtDescricao.Text}', '{txtValor.Text.Replace(",",".")}', '{dataselecinada}')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Falha na conexao{ex.Message}");
            }
            finally 
            {
                conexao.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtValor.Clear();
            dtEntrada.Value = DateTime.Now;
            CBOXDivida.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PGMain principal = new PGMain();
            this.Hide();
            this.Close();
            principal.ShowDialog();
        }
    }
}
