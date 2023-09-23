using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ControleFinanceiro.Properties
{
    public partial class Entrada : Form
    {
        int ID = 0;
        MySqlConnection conexao;

        public Entrada()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PGMain principal= new PGMain();
            this.Hide();
            this.Close();
            principal.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            CBOXCategoria.SelectedIndex = -1;
            dtEntrada.Value = DateTime.Now;
            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(Conexao.strConexao);

                /*var datenow = DateTime.Now;
                var date = datenow.ToString("yyy-MM-dd");*/
                var dataselecionada = dtEntrada.Value.ToString("yyy-MM-dd");

                string sql = $"INSERT INTO ENTRADA(ID,CATEGORIA,DESCRICAO,VALOR,DTREGISTRO)" + 
                             $"VALUES('{ID}', '{CBOXCategoria.Text}', '{txtDescricao.Text}', '{txtValor.Text.Replace(",",".")}', '{dataselecionada}')";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha na conexao!{ex.Message}");
            }
            finally 
            {
                conexao.Close();
            }

        }
    }
}
