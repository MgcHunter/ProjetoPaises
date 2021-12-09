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

namespace ProjetoPaises
{
    public partial class F_Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        string sql;
        public F_Cadastro()
        {
            InitializeComponent();

        }

        private void BT_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=paises;Uid=root;Pwd=admin;");

                sql = "INSERT INTO CAD_PAISES (NOME_PAIS,  AREA_TOTAL, POPULACAO) VALUES (@NOME_PAIS, @AREA_TOTAL, @POPULACAO)";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@NOME_PAIS", TX_Pais.Text);
                comando.Parameters.AddWithValue("@AREA_TOTAL", Convert.ToDecimal(TX_Area.Text));
                comando.Parameters.AddWithValue("@POPULACAO", Convert.ToDecimal(TX_Populacao.Text));

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=paises;Uid=root;Pwd=admin;");

                sql = "UPDATE CAD_PAISES SET NOME_PAIS = @NOME_PAIS, AREA_TOTAL = @AREA_TOTAL , POPULACAO = @POPULACAO WHERE ID = @ID";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@ID", Convert.ToInt16(TX_Cod.Text));
                comando.Parameters.AddWithValue("@NOME_PAIS", TX_Pais.Text);
                comando.Parameters.AddWithValue("@AREA_TOTAL", Convert.ToDecimal(TX_Area.Text));
                comando.Parameters.AddWithValue("@POPULACAO", Convert.ToDecimal(TX_Populacao.Text));

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Atualizado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BT_REMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=paises;Uid=root;Pwd=admin;");

                sql = "DELETE FROM CAD_PAISES WHERE ID = @ID";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@ID", TX_Cod.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Removido");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BT_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=paises;Uid=root;Pwd=admin;");

                sql = "SELECT * FROM CAD_PAISES WHERE ID = @ID";

                comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@ID", TX_Cod.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    TX_Pais.Text = Convert.ToString(dr["nome_pais"]);
                    TX_Area.Text = Convert.ToString(dr["area_total"]);
                    TX_Populacao.Text = Convert.ToString(dr["populacao"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BT_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=paises;Uid=root;Pwd=admin;");

                sql = "SELECT * FROM CAD_PAISES";

                da = new MySqlDataAdapter(sql, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DG_Lista.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
