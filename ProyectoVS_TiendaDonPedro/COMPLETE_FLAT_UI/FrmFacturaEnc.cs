using COMPLETE_FLAT_UI.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FrmFacturaEnc : Form
    {
				List<Producto> productos = FuncProductos.GetProductos();
				Cliente cliente;
				
			
				public FrmFacturaEnc()
        {
            InitializeComponent();
			BtnGuardar.Enabled = false;
			BtnCancelar.Enabled = false;
			BtnSalir.Enabled = true;
			BtnNuevo.Enabled = true;
			BtnAddProd.Enabled = false;
			BtnDelProd.Enabled = false;
			
				}

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtIdent_Validated(object sender, EventArgs e)
        {
            
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

		

				private void textBox1_TextChanged(object sender, EventArgs e)
				{

				}

				private void BtnAddProd_Click(object sender, EventArgs e)
				{
					
				}

				private void BtnNuevo_Click(object sender, EventArgs e)
				{
					if (TxtIdent.Text == "")
					{
						MessageBox.Show("Debe ingresar un numero de identificacion","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					TxtIdent.Enabled = false;
					TxtNombreCliente.Enabled = false;
					TxtIdent.Enabled = false;
					TxtNombreCliente.Enabled = false;
					BtnSalir.Enabled = false;			
					//habilitamos los btns 
					BtnGuardar.Enabled = true;
					BtnCancelar.Enabled = true;
					BtnAddProd.Enabled = true;
					BtnDelProd.Enabled = true;
			

						CbxProductos.Items.Clear();
						foreach (var item in productos)
						{
								CbxProductos.Items.Add(item.nombre_producto);
						}
						//Convert.ToInt64(TxtIdent.Text)
						cliente = Func_Clientes.GetClientes().FirstOrDefault();
						TxtNombreCliente.Text = cliente.nombre_cliente;
				}

				private void TxtCantidad_Enter(object sender, EventArgs e)
				{
						string productoSeleccionado = CbxProductos.SelectedItem?.ToString();
						TxtPrecioProducto.Text = productos.FirstOrDefault(item
						=> item.nombre_producto
						== productoSeleccionado)?.precio_producto.ToString();
				}

		}
}
