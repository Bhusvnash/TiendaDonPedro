using COMPLETE_FLAT_UI.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

				public bool editando = false;

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void TxtCorreo_Validated(object sender, EventArgs e)
        {
            if (!email_bien_escrito(TxtCorreo.Text))
            {
                MessageBox.Show("Verifique Correo Electronico", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCorreo.Focus();
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
						if (string.IsNullOrWhiteSpace(TxtCorreo.Text))
						{
								MessageBox.Show("Falta el campo Correo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtCorreo.Focus();
								return;
						}
						if (string.IsNullOrWhiteSpace(TxtNombre.Text))
						{
								MessageBox.Show("Falta el campo Nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtNombre.Focus();
								return;
						}
						if (string.IsNullOrWhiteSpace(TxtDireccion.Text))
						{
								MessageBox.Show("Falta el campo Direccion", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TxtDireccion.Focus();
								return;
						}
						//si no esta editando editando
						if (!editando)
						{
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtNombre.Text}, {TxtCorreo.Text}, {TxtDireccion.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
								Cliente cliente = new Cliente(-1, TxtNombre.Text, TxtDireccion.Text, TxtCorreo.Text);

								if (Func_Clientes.NewCliente(cliente))
								{
										MessageBox.Show("Usuario registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										//limpiamos los campos
										TxtNombre.Clear(); TxtCorreo.Clear(); TxtDireccion.Clear();
								}
								else
								{
										MessageBox.Show("Error: No se pudo registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtNombre.Focus();
								}
						}
						
						//esta editando
						if (editando)
						{								
								//preguntamos si quiera continuar con los datos que tiene
								DialogResult result = MessageBox.Show($"¿Desea continuar con los siguientes datos: {TxtNombre.Text}, {TxtDireccion.Text}, {TxtCorreo.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
								if (result != DialogResult.Yes)
								{
										MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
										return;
								}
								Cliente cliente = new Cliente(Convert.ToInt64(id_cliente.Text), TxtNombre.Text, TxtDireccion.Text, TxtCorreo.Text);
								if (Func_Clientes.UpdateCliente(cliente))
								{
										MessageBox.Show("Usuario actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
										TxtNombre.Clear(); TxtDireccion.Clear(); TxtCorreo.Clear();
										return;
								}
								else
								{
										MessageBox.Show("Error: No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										TxtNombre.Focus();
								}
								
						}
						
				}
		}
}
