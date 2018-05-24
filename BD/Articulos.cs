using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class FrmArticulos : Form
    {
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void articulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventario);

        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventario.Clientes' Puede moverla o quitarla según sea necesario.
        //    this.clientesTableAdapter.Fill(this.inventario.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'inventario.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.inventario.Articulos);

        }

        private void articulosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
