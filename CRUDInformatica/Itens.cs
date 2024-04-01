using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDInformatica
{
    public partial class Itens : Form
    {
        public Itens()
        {
            InitializeComponent();

            // Desabilita as caixas de texto na inicialização do formulário.
            txt_id.Enabled = false;
            txt_item.Enabled = false;
            txt_marca.Enabled = false;
            txt_modelo.Enabled = false;
            num_quantidade.Enabled = false;

            // Desabilita os botões na inicialização do formulário.
            btn_salvar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_editar.Enabled = false;
            btn_apagar.Enabled = false;
        }

        // Conexão com o banco de dados.
        SqlConnection? conexaoBanco = null;

        private string chaveConexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Dev;Data Source=DESKTOP-MBURD53\\SQLEXPRESS";
        private string sqlConexao = string.Empty;

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Habilita as caixas de texto quando o botão "Adicionar" é selecionado.
            txt_id.Enabled = true;
            txt_item.Enabled = true;
            txt_marca.Enabled = true;
            txt_modelo.Enabled = true;
            num_quantidade.Enabled = true;

            // Habiilita os botões quando o bbotão "Adicionar" é selecionado.
            btn_salvar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_editar.Enabled = true;
            btn_apagar.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados.
            sqlConexao = "Insert into dbo.Inventario(iditem, item, marca, modelo, quantidade) values (@iditem, @item, @marca, @modelo, @quantidade)";
            conexaoBanco = new SqlConnection(chaveConexao);
            SqlCommand comando = new SqlCommand(sqlConexao, conexaoBanco);

            // Passagem dos valores das caixas de texto para o banco como parâmetro.
            comando.Parameters.Add("@iditem", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@item", SqlDbType.VarChar).Value = txt_item.Text;
            comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = txt_marca.Text;
            comando.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txt_modelo.Text;
            comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = num_quantidade.Value;

            // Tenta abrir o banco por uma estrutura try, catch, finally e o fecha no final.
            try
            {
                conexaoBanco.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Item cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }

            // Limpa os campos após realizar um cadastro.
            txt_id.Clear();
            txt_item.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            num_quantidade.Value = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sqlConexao = "select * from dbo.Inventario where iditem = @iditem";
            conexaoBanco = new SqlConnection(chaveConexao);
            SqlCommand comando = new SqlCommand(sqlConexao, conexaoBanco);

            comando.Parameters.Add("@iditem", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            try
            {
                conexaoBanco.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este item não está cadastrado.");
                }
                dr.Read();

                txt_id.Text = Convert.ToString(dr["iditem"]);
                txt_item.Text = Convert.ToString(dr["item"]);
                txt_marca.Text = Convert.ToString(dr["marca"]);
                txt_modelo.Text = Convert.ToString(dr["modelo"]);
                num_quantidade.Value = Convert.ToInt32(dr["quantidade"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            sqlConexao = "update dbo.Inventario set iditem = @iditem, item = @item, marca = @marca, modelo = @modelo, quantidade = @quantidade";
            conexaoBanco = new SqlConnection(chaveConexao);
            SqlCommand comando = new SqlCommand(sqlConexao, conexaoBanco);

            comando.Parameters.Add("@iditem", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@item", SqlDbType.VarChar).Value = txt_item.Text;
            comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = txt_marca.Text;
            comando.Parameters.Add("@modelo", SqlDbType.VarChar).Value = txt_modelo.Text;
            comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = num_quantidade.Value;

            try
            {
                conexaoBanco.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }

            txt_id.Clear();
            txt_item.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            num_quantidade.Value = 0;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este item?",
                    "Perigo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                
            }

            sqlConexao = "DELETE FROM DBO.INVENTARIO WHERE iditem = @iditem";
            conexaoBanco = new SqlConnection(chaveConexao);
            SqlCommand comando = new SqlCommand(sqlConexao, conexaoBanco);

            comando.Parameters.Add("@iditem", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            try
            {
                conexaoBanco.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Item excluído com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }

            txt_id.Clear();
            txt_item.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            num_quantidade.Value = 0;
        }
    }
}
