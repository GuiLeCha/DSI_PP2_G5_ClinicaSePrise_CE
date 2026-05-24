using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        private UsuarioSistema usuarioActual;
        private System.Windows.Forms.Timer? timerReloj;

        public FrmMenuPrincipal(UsuarioSistema usuario)
        {
            InitializeComponent();

            usuarioActual = usuario;
            CargarDatosUsuario();
            ConfigurarReloj();
            AplicarPermisosPorRol();
        }

        private void CargarDatosUsuario()
        {
            lblUsuarioActual.Text = usuarioActual.NombreCompleto;
            lblRolActual.Text = "Rol: " + usuarioActual.Rol;
            ActualizarFechaHora();
        }

        private void ConfigurarReloj()
        {
            timerReloj = new System.Windows.Forms.Timer();
            timerReloj.Interval = 1000;
            timerReloj.Tick += timerReloj_Tick;
            timerReloj.Start();
        }

        private void timerReloj_Tick(object? sender, EventArgs e)
        {
            ActualizarFechaHora();
        }

        private void ActualizarFechaHora()
        {
            lblFechaActual.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            lblHoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AplicarPermisosPorRol()
        {
            string nombreUsuario = usuarioActual.Usuario.Trim().ToLower();
            string rol = usuarioActual.Rol.Trim().ToLower();

            bool esAdministrador = nombreUsuario == "admin" || rol.Contains("administrador");
            bool esRecepcion = nombreUsuario == "recepcion" || rol.Contains("administrativo");
            bool esMedico = nombreUsuario == "medico" || rol.Contains("medico") || rol.Contains("médico");
            bool esTest = nombreUsuario == "test" || rol.Contains("test");

            if (esAdministrador)
            {
                HabilitarModulo(btnPacientes, true);
                HabilitarModulo(btnAgenda, true);
                HabilitarModulo(btnTurnos, true);
                HabilitarModulo(btnRecepcion, true);
                HabilitarModulo(btnAtencion, true);
                HabilitarModulo(btnHistorial, true);
                HabilitarModulo(btnLiquidaciones, true);

                lblAccesosTexto.Text = "Perfil administrador: acceso completo.";
                return;
            }

            if (esTest)
            {
                HabilitarModulo(btnPacientes, true);
                HabilitarModulo(btnAgenda, true);
                HabilitarModulo(btnTurnos, true);
                HabilitarModulo(btnRecepcion, true);
                HabilitarModulo(btnAtencion, true);
                HabilitarModulo(btnHistorial, true);
                HabilitarModulo(btnLiquidaciones, true);

                lblAccesosTexto.Text = "Perfil de pruebas: acceso completo.";
                return;
            }

            if (esRecepcion)
            {
                HabilitarModulo(btnPacientes, true);
                HabilitarModulo(btnAgenda, true);
                HabilitarModulo(btnTurnos, true);
                HabilitarModulo(btnRecepcion, true);
                HabilitarModulo(btnAtencion, false);
                HabilitarModulo(btnHistorial, true);
                HabilitarModulo(btnLiquidaciones, true);

                lblAccesosTexto.Text = "Perfil recepción: acceso a gestión administrativa del circuito.";
                return;
            }

            if (esMedico)
            {
                HabilitarModulo(btnPacientes, false);
                HabilitarModulo(btnAgenda, false);
                HabilitarModulo(btnTurnos, false);
                HabilitarModulo(btnRecepcion, false);
                HabilitarModulo(btnAtencion, true);
                HabilitarModulo(btnHistorial, true);
                HabilitarModulo(btnLiquidaciones, false);

                lblAccesosTexto.Text = "Perfil médico: acceso a atención médica e historial.";
                return;
            }

            HabilitarModulo(btnPacientes, false);
            HabilitarModulo(btnAgenda, false);
            HabilitarModulo(btnTurnos, false);
            HabilitarModulo(btnRecepcion, false);
            HabilitarModulo(btnAtencion, false);
            HabilitarModulo(btnHistorial, false);
            HabilitarModulo(btnLiquidaciones, false);

            lblAccesosTexto.Text = "Rol no reconocido. No se habilitaron módulos.";
        }

        private void HabilitarModulo(Button boton, bool habilitado)
        {
            boton.Enabled = habilitado;

            if (habilitado)
            {
                boton.BackColor = Color.White;
                boton.ForeColor = Color.FromArgb(20, 36, 70);
                boton.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            }
            else
            {
                boton.BackColor = Color.FromArgb(235, 239, 245);
                boton.ForeColor = Color.FromArgb(145, 152, 165);
                boton.FlatAppearance.BorderColor = Color.FromArgb(215, 221, 230);
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            using (formulario)
            {
                formulario.ShowDialog(this);
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPacientes());
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgendaMedica());
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTurnos());
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRecepcion());
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAtencionMedica());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialAtenciones());
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLiquidaciones());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar la sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                timerReloj?.Stop();
                this.Close();
            }
        }
    }
}