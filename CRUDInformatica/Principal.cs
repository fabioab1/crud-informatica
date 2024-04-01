namespace CRUDInformatica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Itens itens = new Itens();
            itens.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }
    }
}
