using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarCombos();
            RefrescarGrilla();
            LimpiarResumenPaciente();
        }

        private void ConfigurarGrilla()
        {
            dgvPacientes.AutoGenerateColumns = true;
            dgvPacientes.ReadOnly = true;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeRows = false;
            dgvPacientes.MultiSelect = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 235, 248);
            dgvPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(20, 36, 70);
            dgvPacientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPacientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 250);
            dgvPacientes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 36, 70);
            dgvPacientes.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
            dgvPacientes.DefaultCellStyle.BackColor = Color.White;
            dgvPacientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvPacientes.GridColor = Color.FromArgb(220, 228, 238);
        }

        private void CargarCombos()
        {
            cmbTipoDocumento.Items.Clear();
            cmbTipoDocumento.Items.Add("DNI");
            cmbTipoDocumento.Items.Add("PAS");
            cmbTipoDocumento.Items.Add("LC");
            cmbTipoDocumento.Items.Add("LE");
            cmbTipoDocumento.SelectedIndex = 0;

            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Otro");
            cmbSexo.Items.Add("No informa");
            cmbSexo.SelectedIndex = 0;

            cmbCobertura.DataSource = null;
            cmbCobertura.DataSource = DatosClinica.ObrasSocialesPrepagas;
            cmbCobertura.DisplayMember = "Nombre";
            cmbCobertura.ValueMember = "IdCobertura";

            if (cmbCobertura.Items.Count > 0)
            {
                cmbCobertura.SelectedIndex = 0;
            }
        }

        private void RefrescarGrilla()
        {
            dgvPacientes.DataSource = null;

            var lista = DatosClinica.Pacientes
                .Select(p => new
                {
                    ID = p.IdPaciente,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Documento = p.TipoDocumento + " " + p.NroDocumento,
                    FechaNacimiento = p.FechaNacimiento.ToString("dd/MM/yyyy"),
                    Sexo = p.Sexo,
                    Telefono = p.Telefono,
                    Email = p.Email,
                    Cobertura = DatosClinica.ObtenerNombreCobertura(p.IdObraSocialPrepaga),
                    NroAfiliado = p.NroAfiliado,
                    Estado = p.Estado.ToString()
                })
                .ToList();

            dgvPacientes.DataSource = lista;

            if (dgvPacientes.Columns.Count > 0)
            {
                dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPacientes.ClearSelection();
                AplicarColoresEstadoEnGrilla();
            }

            lblCantidadPacientes.Text = "Pacientes registrados: " + lista.Count;
        }

        private void AplicarColoresEstadoEnGrilla()
        {
            foreach (DataGridViewRow fila in dgvPacientes.Rows)
            {
                if (fila.Cells["Estado"].Value == null)
                {
                    continue;
                }

                string estado = fila.Cells["Estado"].Value.ToString() ?? string.Empty;

                if (estado == "Activo")
                {
                    fila.DefaultCellStyle.BackColor = Color.White;
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(252, 235, 235);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(145, 72, 72);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            string nroDocumento = txtNroDocumento.Text.Trim();

            if (DatosClinica.ExistePacienteConDocumento(nroDocumento))
            {
                MessageBox.Show("Ya existe un paciente registrado con ese número de documento.",
                    "Paciente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtNroDocumento.Focus();
                return;
            }

            int idCobertura = Convert.ToInt32(cmbCobertura.SelectedValue);

            Paciente nuevoPaciente = new Paciente(
                DatosClinica.ObtenerProximoIdPaciente(),
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                cmbTipoDocumento.Text,
                nroDocumento,
                dtpFechaNacimiento.Value.Date,
                cmbSexo.Text,
                txtTelefono.Text.Trim(),
                txtDomicilio.Text.Trim(),
                txtEmail.Text.Trim(),
                idCobertura,
                txtNroAfiliado.Text.Trim(),
                EstadoGeneral.Activo);

            DatosClinica.Pacientes.Add(nuevoPaciente);

            MessageBox.Show("Paciente registrado correctamente.",
                "Alta de paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            RefrescarGrilla();
            MostrarResumenPaciente(nuevoPaciente);
        }

        private bool ValidarDatos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del paciente.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el apellido del paciente.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (txtNroDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de documento.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDocumento.Focus();
                return false;
            }

            if (!txtNroDocumento.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show("El número de documento debe contener solo números.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroDocumento.Focus();
                return false;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un teléfono de contacto.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (cmbCobertura.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una cobertura.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCobertura.Focus();
                return false;
            }

            ObraSocialPrepaga? cobertura = cmbCobertura.SelectedItem as ObraSocialPrepaga;

            if (cobertura != null && cobertura.Tipo != TipoCobertura.Particular)
            {
                if (txtNroAfiliado.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el número de afiliado para la cobertura seleccionada.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNroAfiliado.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbTipoDocumento.SelectedIndex = 0;
            txtNroDocumento.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbSexo.SelectedIndex = 0;
            txtTelefono.Clear();
            txtDomicilio.Clear();
            txtEmail.Clear();

            if (cmbCobertura.Items.Count > 0)
            {
                cmbCobertura.SelectedIndex = 0;
            }

            txtNroAfiliado.Clear();
            dgvPacientes.ClearSelection();
            LimpiarResumenPaciente();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObraSocialPrepaga? cobertura = cmbCobertura.SelectedItem as ObraSocialPrepaga;

            if (cobertura != null && cobertura.Tipo == TipoCobertura.Particular)
            {
                txtNroAfiliado.Clear();
                txtNroAfiliado.Enabled = false;
            }
            else
            {
                txtNroAfiliado.Enabled = true;
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? valorId = dgvPacientes.Rows[e.RowIndex].Cells["ID"].Value;

            if (valorId == null)
            {
                return;
            }

            int idPaciente = Convert.ToInt32(valorId);
            Paciente? paciente = DatosClinica.BuscarPacientePorId(idPaciente);

            if (paciente == null)
            {
                return;
            }

            MostrarResumenPaciente(paciente);
        }

        private void MostrarResumenPaciente(Paciente paciente)
        {
            lblPacienteNombreValor.Text = paciente.NombreCompleto;
            lblPacienteDocumentoValor.Text = paciente.TipoDocumento + " " + paciente.NroDocumento;
            lblPacienteTelefonoValor.Text = paciente.Telefono;
            lblPacienteCoberturaValor.Text = DatosClinica.ObtenerNombreCobertura(paciente.IdObraSocialPrepaga);
            lblPacienteEstadoValor.Text = paciente.Estado.ToString();

            if (paciente.Estado == EstadoGeneral.Activo)
            {
                lblPacienteEstadoValor.ForeColor = Color.FromArgb(34, 122, 83);
            }
            else
            {
                lblPacienteEstadoValor.ForeColor = Color.FromArgb(180, 70, 70);
            }
        }

        private void LimpiarResumenPaciente()
        {
            lblPacienteNombreValor.Text = "Sin selección";
            lblPacienteDocumentoValor.Text = "-";
            lblPacienteTelefonoValor.Text = "-";
            lblPacienteCoberturaValor.Text = "-";
            lblPacienteEstadoValor.Text = "-";
            lblPacienteEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
        }
    }
}
