using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmAtencionMedica : Form
    {
        private int? nroTurnoSeleccionado = null;

        public FrmAtencionMedica()
        {
            InitializeComponent();
            ConfigurarGrilla();
            RefrescarGrilla();
            LimpiarDetalle();
        }

        private void ConfigurarGrilla()
        {
            dgvTurnos.AutoGenerateColumns = true;
            dgvTurnos.ReadOnly = true;
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.MultiSelect = false;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.BackgroundColor = Color.White;
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.EnableHeadersVisualStyles = false;
            dgvTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 235, 248);
            dgvTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(20, 36, 70);
            dgvTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvTurnos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 250);
            dgvTurnos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 36, 70);
            dgvTurnos.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
            dgvTurnos.DefaultCellStyle.BackColor = Color.White;
            dgvTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvTurnos.GridColor = Color.FromArgb(220, 228, 238);
        }

        private void RefrescarGrilla()
        {
            dgvTurnos.DataSource = null;

            var lista = DatosClinica.Turnos
                .Where(t => t.Estado == EstadoTurno.EnAtencion || t.Estado == EstadoTurno.Atendido)
                .OrderBy(t => t.FechaTurno)
                .ThenBy(t => t.HoraTurno)
                .Select(t => new
                {
                    Nro = t.NroTurno,
                    Paciente = DatosClinica.ObtenerNombrePaciente(t.IdPaciente),
                    Profesional = DatosClinica.ObtenerNombreProfesional(t.IdProfesional),
                    Especialidad = DatosClinica.ObtenerNombreEspecialidad(t.IdEspecialidad),
                    Fecha = t.FechaTurno.ToString("dd/MM/yyyy"),
                    Hora = t.HoraTurno.ToString(@"hh\:mm"),
                    Estado = t.Estado.ToString()
                })
                .ToList();

            dgvTurnos.DataSource = lista;

            if (dgvTurnos.Columns.Count > 0)
            {
                dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AplicarColoresEstadoEnGrilla();
            }

            lblCantidadTurnos.Text = "Turnos habilitados para atención: " + lista.Count;
        }

        private void AplicarColoresEstadoEnGrilla()
        {
            foreach (DataGridViewRow fila in dgvTurnos.Rows)
            {
                if (fila.Cells["Estado"].Value == null)
                {
                    continue;
                }

                string estado = fila.Cells["Estado"].Value.ToString() ?? string.Empty;

                if (estado == "EnAtencion")
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(236, 248, 240);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
                else if (estado == "Atendido")
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(238, 246, 255);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.White;
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
            }
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? valor = dgvTurnos.Rows[e.RowIndex].Cells["Nro"].Value;

            if (valor == null)
            {
                return;
            }

            nroTurnoSeleccionado = Convert.ToInt32(valor);
            MostrarDetalleTurno();
        }

        private void MostrarDetalleTurno()
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                LimpiarDetalle();
                return;
            }

            Paciente? paciente = DatosClinica.BuscarPacientePorId(turno.IdPaciente);
            Profesional? profesional = DatosClinica.BuscarProfesionalPorId(turno.IdProfesional);
            Especialidad? especialidad = DatosClinica.BuscarEspecialidadPorId(turno.IdEspecialidad);
            HistoriaClinica historia = DatosClinica.CrearHistoriaClinicaSiNoExiste(turno.IdPaciente);

            lblPacienteDato.Text = paciente != null ? paciente.NombreCompleto : "-";
            lblDocumentoDato.Text = paciente != null ? paciente.TipoDocumento + " " + paciente.NroDocumento : "-";
            lblProfesionalDato.Text = profesional != null ? profesional.NombreCompleto : "-";
            lblEspecialidadDato.Text = especialidad != null ? especialidad.Nombre : "-";
            lblFechaHoraDato.Text = turno.FechaTurno.ToString("dd/MM/yyyy") + " " + turno.HoraTurno.ToString(@"hh\:mm");
            lblEstadoTurnoDato.Text = turno.Estado.ToString();
            lblHistoriaClinicaDato.Text = "HC N° " + historia.IdHistoriaClinica;

            if (turno.Estado == EstadoTurno.EnAtencion)
            {
                lblEstadoTurnoDato.ForeColor = Color.FromArgb(34, 122, 83);
            }
            else
            {
                lblEstadoTurnoDato.ForeColor = Color.FromArgb(26, 82, 150);
            }

            List<AtencionMedica> atencionesPrevias = DatosClinica.BuscarAtencionesPorPaciente(turno.IdPaciente)
                .Where(a => a.NroTurno != turno.NroTurno)
                .ToList();

            lblAtencionesPreviasDato.Text = atencionesPrevias.Count.ToString();

            AtencionMedica? atencion = DatosClinica.BuscarAtencionPorTurno(turno.NroTurno);

            if (atencion != null)
            {
                txtDiagnostico.Text = atencion.Diagnostico;
                txtIndicaciones.Text = atencion.Indicaciones;
                txtObservaciones.Text = atencion.ObservacionesClinicas;
                chkRequiereNuevoTurno.Checked = atencion.RequiereNuevoTurno;
                chkDerivacionAEstudio.Checked = atencion.DerivacionAEstudio;
                lblEstadoAtencionDato.Text = atencion.Cerrada ? "Cerrada" : "Registrada sin cerrar";
                lblEstadoAtencionDato.ForeColor = atencion.Cerrada
                    ? Color.FromArgb(34, 122, 83)
                    : Color.FromArgb(147, 112, 31);
            }
            else
            {
                txtDiagnostico.Clear();
                txtIndicaciones.Clear();
                txtObservaciones.Clear();
                chkRequiereNuevoTurno.Checked = false;
                chkDerivacionAEstudio.Checked = false;
                lblEstadoAtencionDato.Text = "Sin registrar";
                lblEstadoAtencionDato.ForeColor = Color.FromArgb(26, 82, 150);
            }
        }

        private TurnoConsultorio? ObtenerTurnoSeleccionado()
        {
            if (nroTurnoSeleccionado == null)
            {
                return null;
            }

            return DatosClinica.BuscarTurnoPorNumero(nroTurnoSeleccionado.Value);
        }

        private void btnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno en atención.",
                    "Atención médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado != EstadoTurno.EnAtencion)
            {
                MessageBox.Show("Solo se puede registrar atención sobre turnos en estado EnAtencion.",
                    "Atención médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDatosAtencion())
            {
                return;
            }

            HistoriaClinica historia = DatosClinica.CrearHistoriaClinicaSiNoExiste(turno.IdPaciente);

            AtencionMedica? atencionExistente = DatosClinica.BuscarAtencionPorTurno(turno.NroTurno);

            string diagnosticoFinal = txtDiagnostico.Text.Trim();
            string indicacionesFinales = txtIndicaciones.Text.Trim();
            string observacionesFinales = txtObservaciones.Text.Trim();

            if (atencionExistente == null)
            {
                AtencionMedica nuevaAtencion = new AtencionMedica(
                    DatosClinica.ObtenerProximoNroAtencion(),
                    historia.IdHistoriaClinica,
                    turno.NroTurno,
                    turno.IdPaciente,
                    turno.IdProfesional,
                    DateTime.Now,
                    diagnosticoFinal,
                    indicacionesFinales,
                    chkRequiereNuevoTurno.Checked,
                    chkDerivacionAEstudio.Checked,
                    observacionesFinales,
                    false);

                DatosClinica.AtencionesMedicas.Add(nuevaAtencion);
            }
            else
            {
                atencionExistente.Diagnostico = diagnosticoFinal;
                atencionExistente.Indicaciones = indicacionesFinales;
                atencionExistente.RequiereNuevoTurno = chkRequiereNuevoTurno.Checked;
                atencionExistente.DerivacionAEstudio = chkDerivacionAEstudio.Checked;
                atencionExistente.ObservacionesClinicas = observacionesFinales;
            }

            string mensaje = "Atención médica registrada correctamente.";

            if (chkRequiereNuevoTurno.Checked || chkDerivacionAEstudio.Checked)
            {
                mensaje += "\n\nSe registraron las siguientes condiciones:";

                if (chkRequiereNuevoTurno.Checked)
                {
                    mensaje += "\n- Requiere nuevo turno.";
                }

                if (chkDerivacionAEstudio.Checked)
                {
                    mensaje += "\n- Derivación a estudio.";
                }
            }

            MessageBox.Show(mensaje,
                "Atención médica", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarDetalleTurno();
        }

        private void btnCerrarConsulta_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno.",
                    "Cierre de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtencionMedica? atencion = DatosClinica.BuscarAtencionPorTurno(turno.NroTurno);

            if (atencion == null)
            {
                MessageBox.Show("Antes de cerrar la consulta debe registrar la atención médica.",
                    "Cierre de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (atencion.Diagnostico.Trim() == "")
            {
                MessageBox.Show("No se puede cerrar la consulta sin diagnóstico.",
                    "Cierre de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiagnostico.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Confirma el cierre de la consulta médica?",
                "Cierre de consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            atencion.Cerrada = true;
            turno.Estado = EstadoTurno.Atendido;

            MessageBox.Show("Consulta cerrada correctamente.",
                "Atención médica", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarDetalleTurno();
        }

        private bool ValidarDatosAtencion()
        {
            if (txtDiagnostico.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el diagnóstico.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiagnostico.Focus();
                return false;
            }

            if (txtIndicaciones.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar las indicaciones médicas.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIndicaciones.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            nroTurnoSeleccionado = null;

            lblPacienteDato.Text = "-";
            lblDocumentoDato.Text = "-";
            lblProfesionalDato.Text = "-";
            lblEspecialidadDato.Text = "-";
            lblFechaHoraDato.Text = "-";
            lblEstadoTurnoDato.Text = "-";
            lblEstadoTurnoDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblHistoriaClinicaDato.Text = "-";
            lblAtencionesPreviasDato.Text = "-";
            lblEstadoAtencionDato.Text = "-";
            lblEstadoAtencionDato.ForeColor = Color.FromArgb(26, 82, 150);

            txtDiagnostico.Clear();
            txtIndicaciones.Clear();
            txtObservaciones.Clear();

            chkRequiereNuevoTurno.Checked = false;
            chkDerivacionAEstudio.Checked = false;

            dgvTurnos.ClearSelection();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
