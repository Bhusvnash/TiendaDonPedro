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
    public partial class FrmLogin : Form
    {
				
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtContraseña.PasswordChar == '*')
            {
                TxtContraseña.PasswordChar = '\0';
            }
            else
            {
                TxtContraseña.PasswordChar = '*';
            }
            TxtContraseña.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {

						//logica para contraseña


            this.Hide();
            FrmMenuPrincipal f = new FrmMenuPrincipal();
            f.ShowDialog();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            TxtUsuario.Focus();
        }
    }
}
