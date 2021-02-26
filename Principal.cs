using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarInterfaz();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AgregarProducto ap = new AgregarProducto();
            ap.Visible = true;
            this.Dispose(false);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arbol_DoubleClick(object sender, EventArgs e)
        {
            if (!arbol.SelectedNode.Name.Equals(""))
            {
                categoria.DataSource = CategoriaBL.ListarCategorias();
                categoria.DisplayMember = "Descripcion";
                categoria.ValueMember = "IdCategoria";
                ProductoEntidades oProducto = ProductoBL.buscarProducto(Convert.ToInt32(arbol.SelectedNode.Name));
                nombre.Text = oProducto.Nombre;
                detalle.Text = oProducto.Detalle;
                precio.Text = oProducto.Precio.ToString();
                stock.Text = oProducto.Stock.ToString();
                categoria.SelectedValue = oProducto.IdCategoria;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoEntidades oProducto = new ProductoEntidades();
            try
            {
                oProducto.Detalle = detalle.Text;
                oProducto.IdCategoria = Convert.ToInt32(categoria.SelectedValue.ToString());
                oProducto.IdProducto = Convert.ToInt32(arbol.SelectedNode.Name.ToString());
                oProducto.Nombre = nombre.Text;
                oProducto.Precio = float.Parse(precio.Text);
                oProducto.Stock = float.Parse(stock.Text);

                if (ProductoBL.ModificarProducto(oProducto) > 0)
                {
                    MessageBox.Show("Modificado con Exito");
                    arbol.Nodes.Clear();
                    InicializarInterfaz();
                }
                else MessageBox.Show("Error al Modificar");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en el ingreso de datos");
            }
        }

        private void InicializarInterfaz()
        {
            List<CategoriaEntidades> listaCategoria = CategoriaBL.ListarCategorias();
            foreach (CategoriaEntidades c in listaCategoria)
            {
                TreeNode padre = new TreeNode(c.Descripcion);
                List<ProductoEntidades> listaProducto = ProductoBL.ListarProductoPorCategoria(c.IdCategoria);
                foreach (ProductoEntidades p in listaProducto)
                {
                    TreeNode hijo = new TreeNode(p.Nombre);
                    hijo.Name = p.IdProducto.ToString();
                    padre.Nodes.Add(hijo);
                }
                arbol.Nodes.Add(padre);
            }
        }
    }
}
