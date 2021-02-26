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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            categoria.DataSource = CategoriaBL.ListarCategorias();
            categoria.DisplayMember = "Descripcion";
            categoria.ValueMember = "IdCategoria";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntidades oProducto = new ProductoEntidades();
                oProducto.Detalle = detalle.Text;
                oProducto.IdCategoria = Convert.ToInt32(categoria.SelectedValue.ToString());
                oProducto.Nombre = nombre.Text;
                oProducto.Precio = float.Parse(precio.Text.ToString());
                oProducto.Stock = float.Parse(stock.Text.ToString());
                if (ProductoBL.AgregarProducto(oProducto) > 0)
                {
                    MessageBox.Show("Producto Agregado con exito");
                    Principal catalogo = new Principal();
                    this.Dispose(false);
                    catalogo.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto, valide los datos ingresados");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Datos Erroneos");
            }
        }
    }
}
