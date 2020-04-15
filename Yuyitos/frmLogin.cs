using slnAlmacenLosYuyitos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnAlmacenLosYuyitos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtNombreUsuario.Text == "Admin" && txtContrasena.Text == "Admin")
            {
                frmMenuAdmin frmAdministrador = new frmMenuAdmin();
                frmAdministrador.Show();
            }else if (txtNombreUsuario.Text == "Vendedor" && txtContrasena.Text == "Vendedor")
            {
                frmMenuVendedor frmVendedor = new frmMenuVendedor();
                frmVendedor.Show();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
