using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ControleFinanceiro.Properties
{
    public partial class Periodo : Form
    {
        MySqlConnection conexao;
        public Periodo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            PGMain principal = new PGMain();
            this.Hide();
            this.Close();
            principal.ShowDialog();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(Conexao.strConexao);
                var dataIselecionada = dtInicio.Value.ToString("yyy-MM-dd");
                var dataFselecionada = dtFinal.Value.ToString("yyy-MM-dd");
                var dataVerifica = DateTime.Now;
                var data = dataVerifica.ToString("yyy-MM-dd");
                string descricao = txtFiltroDivida.Text;

                var dt = new DataTable();
                decimal valor = 0;

                if (checkDiv.Checked)
                {
                    if (txtFiltroDivida.Text != "" && dataFselecionada == data && dataIselecionada == data)
                    {
                        var sql = $"SELECT * FROM DIVIDA WHERE DESCRICAO LIKE '{txtFiltroDivida.Text}%'";
                        var sqlVal = $"SELECT sum(VALOR) FROM DIVIDA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using(MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if(result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                    else if (dataFselecionada != default && dataIselecionada != default && txtFiltroDivida.Text != "")
                    {
                        var sql = $"SELECT * FROM DIVIDA WHERE DTREGISTRO BETWEEN '{dataIselecionada}' AND '{dataFselecionada}' " +
                        $"AND DESCRICAO = '{txtFiltroDivida.Text}'";
                        var sqlVal = $"SELECT sum(VALOR) FROM DIVIDA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        //var sql = $"select * from divida where DESCRICAO = '{txtFiltroDivida.Text}'";
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using (MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                    else
                    {
                        var sql = $"SELECT * FROM DIVIDA WHERE DTREGISTRO BETWEEN '{dataIselecionada}' AND '{dataFselecionada}'";
                        var sqlVal = $"SELECT sum(VALOR) FROM DIVIDA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using (MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                else if (checkEntrada.Checked)
                {
                    if (txtFiltroDivida.Text != "" && dataFselecionada == data && dataIselecionada == data)
                    {
                        var sql = $"SELECT * FROM ENTRADA WHERE DESCRICAO LIKE '{txtFiltroDivida.Text}%'";
                        var sqlVal = $"SELECT sum(VALOR) FROM ENTRADA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using (MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                    else if (dataFselecionada != default && dataIselecionada != default && txtFiltroDivida.Text != "")
                    {
                        var sql = $"SELECT * FROM ENTRADA WHERE DTREGISTRO BETWEEN '{dataIselecionada}' AND '{dataFselecionada}' " +
                        $"AND DESCRICAO = '{txtFiltroDivida.Text}'";
                        var sqlVal = $"SELECT sum(VALOR) FROM ENTRADA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        //var sql = $"select * from divida where DESCRICAO = '{txtFiltroDivida.Text}'";
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using (MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                    else
                    {
                        var sql = $"SELECT * FROM ENTRADA WHERE DTREGISTRO BETWEEN '{dataIselecionada}' AND '{dataFselecionada}'";
                        var sqlVal = $"SELECT sum(VALOR) FROM ENTRADA WHERE DTREGISTRO BETWEEN '{dataIselecionada}'and'{dataFselecionada}' ";
                        conexao.Open();
                        using (var da = new MySqlDataAdapter(sql, conexao))
                        {
                            da.Fill(dt);
                            tblPeriodo.DataSource = dt;
                        }
                        using (MySqlCommand command = new MySqlCommand(sqlVal, conexao))
                        {
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                valor = Convert.ToDecimal(result);
                                lblvalor.Text = valor.ToString("C2");
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha na conexao! {ex.Message}");
            }
            finally { conexao.Close(); }
            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            checkEntrada.Checked= false;
            checkDiv.Checked= false;
            dtInicio.Value = DateTime.Now;
            dtFinal.Value = DateTime.Now;
            txtFiltroDivida.Clear();
            tblPeriodo.DataSource = null;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Update mostrarupdate = new Update();
            mostrarupdate.ShowDialog();
        }
    }
}
