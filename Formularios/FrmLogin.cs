using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnIngresar;
            this.Shown += FrmLogin_Shown;
        }

        private void FrmLogin_Shown(object? sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (usuario == "")
            {
                MessageBox.Show("Debe ingresar el usuario.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (clave == "")
            {
                MessageBox.Show("Debe ingresar la contraseña.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            UsuarioSistema? usuarioValidado = DatosClinica.ValidarUsuario(usuario, clave);

            if (usuarioValidado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtClave.Clear();
                txtClave.Focus();
                return;
            }

            MessageBox.Show("Ingreso correcto.",
                "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(usuarioValidado);
            frmMenu.ShowDialog();

            txtUsuario.Clear();
            txtClave.Clear();
            txtUsuario.Focus();

            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
