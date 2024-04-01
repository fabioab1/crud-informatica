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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        SqlConnection? conexaoBanco = null;

        private string chaveConexao = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Dev;Data Source=DESKTOP-MBURD53\\SQLEXPRESS";
        private string sqlConexao = string.Empty;

        SqlDataAdapter? da = null;
        DataTable? dataTable = null;

        private void Carregar(string inventario)
        {
            try
            {
                conexaoBanco = new SqlConnection(chaveConexao);

                da = new SqlDataAdapter(inventario, conexaoBanco);
                dataTable = new DataTable();

                da.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "ID";
                dataTable.Columns[1].ColumnName = "Item";
                dataTable.Columns[2].ColumnName = "Marca";
                dataTable.Columns[3].ColumnName = "Modelo";
                dataTable.Columns[4].ColumnName = "Quantidade";

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            sqlConexao = "select iditem, item, marca, modelo, quantidade from dbo.Inventario where iditem = @iditem";

            conexaoBanco = new SqlConnection(chaveConexao);
            SqlCommand com = new SqlCommand(sqlConexao, conexaoBanco);

            com.Parameters.Add("@iditem", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            try
            {
                conexaoBanco.Open();
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();

                lbl_nome.Text = Convert.ToString(dr["item"]);
                lbl_marca.Text = Convert.ToString(dr["marca"]);
                lbl_modelo.Text = Convert.ToString(dr["modelo"]);
                lbl_quantidade.Text = Convert.ToString(dr["quantidade"]);
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

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_item_KeyUp(object sender, KeyEventArgs e)
        {
            sqlConexao = "select * from dbo.Inventario where item like'" + txt_item.Text + "'";
            Carregar(sqlConexao);
        }
    }
}
