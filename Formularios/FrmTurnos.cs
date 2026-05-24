using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmTurnos : Form
    {
        private int? nroTurnoSeleccionado = null;

        public FrmTurnos()
        {
            InitializeComponent();

            cmbAgenda.SelectedIndexChanged += cmbAgenda_SelectedIndexChanged;

            ConfigurarGrilla();
            CargarCombos();
            RefrescarGrilla();
            LimpiarResumenSeleccion();
            ActualizarResumenAgenda();
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

        private void CargarCombos()
        {
            cmbPaciente.DataSource = null;
            cmbPaciente.DataSource = DatosClinica.Pacientes
                .Where(p => p.Estado == EstadoGeneral.Activo)
                .ToList();
            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "IdPaciente";

            CargarComboAgenda();

            cmbCanal.DataSource = null;
            cmbCanal.DataSource = Enum.GetValues(typeof(TipoCanalTurno));

            dtpHoraTurno.Value = DateTime.Today.AddHours(8);
        }

        private void CargarComboAgenda()
        {
            List<ItemAgenda> agendas = DatosClinica.Agendas
                .Where(a => a.Estado == EstadoAgenda.Disponible)
                .OrderBy(a => a.Fecha)
                .ThenBy(a => a.HoraInicio)
                .Select(a => new ItemAgenda
                {
                    IdAgenda = a.IdAgenda,
                    Descripcion = ArmarDescripcionAgenda(a)
                })
                .ToList();

            cmbAgenda.DataSource = null;
            cmbAgenda.DataSource = agendas;
            cmbAgenda.DisplayMember = "Descripcion";
            cmbAgenda.ValueMember = "IdAgenda";
        }

        private static string ArmarDescripcionAgenda(AgendaMedica agenda)
        {
            string profesional = DatosClinica.ObtenerNombreProfesional(agenda.IdProfesional);
            string especialidad = DatosClinica.ObtenerNombreEspecialidad(agenda.IdEspecialidad);

            return agenda.Fecha.ToString("dd/MM/yyyy") + " - " +
                   agenda.HoraInicio.ToString(@"hh\:mm") + " a " +
                   agenda.HoraFin.ToString(@"hh\:mm") + " - " +
                   profesional + " - " +
                   especialidad;
        }

        private void RefrescarGrilla()
        {
            dgvTurnos.DataSource = null;

            var lista = DatosClinica.Turnos
                .OrderBy(t => t.FechaTurno)
                .ThenBy(t => t.HoraTurno)
                .Select(t => new
                {
                    Nro = t.NroTurno,
                    Paciente = DatosClinica.ObtenerNombrePaciente(t.IdPaciente),
                    Profesional = DatosClinica.ObtenerNombreProfesional(t.IdProfesional),
                    Especialidad = DatosClinica.ObtenerNombreEspecialidad(t.IdEspecialidad),
                    Consultorio = DatosClinica.ObtenerNombreConsultorio(t.IdConsultorio),
                    Fecha = t.FechaTurno.ToString("dd/MM/yyyy"),
                    Hora = t.HoraTurno.ToString(@"hh\:mm"),
                    Canal = t.CanalSolicitud.ToString(),
                    Sobreturno = t.EsSobreturno ? "Sí" : "No",
                    Estado = t.Estado.ToString(),
                    Recordatorio = t.RecordatorioEnviado ? "Enviado" : "Pendiente",
                    Cobertura = t.CoberturaVerificada ? "Verificada" : "Pendiente",
                    Autorizacion = t.AutorizacionAprobada ? "Aprobada" : "Pendiente"
                })
                .ToList();

            dgvTurnos.DataSource = lista;

            if (dgvTurnos.Columns.Count > 0)
            {
                dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTurnos.ClearSelection();
                AplicarColoresEstadoEnGrilla();
            }

            lblCantidadTurnos.Text = "Total de turnos registrados: " + lista.Count;
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
                fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);

                switch (estado)
                {
                    case "Confirmado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(236, 248, 240);
                        break;
                    case "Recordado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 232);
                        break;
                    case "Reprogramado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(243, 239, 255);
                        break;
                    case "Cancelado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(252, 235, 235);
                        fila.DefaultCellStyle.ForeColor = Color.FromArgb(145, 72, 72);
                        break;
                    default:
                        fila.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosTurno(0))
            {
                return;
            }

            Paciente paciente = (Paciente)cmbPaciente.SelectedItem;
            AgendaMedica agenda = ObtenerAgendaSeleccionada();
            TimeSpan horaTurno = ObtenerHoraTurno();

            TurnoConsultorio nuevoTurno = new TurnoConsultorio(
                DatosClinica.ObtenerProximoNroTurno(),
                paciente.IdPaciente,
                agenda.IdProfesional,
                agenda.IdEspecialidad,
                agenda.IdConsultorio,
                agenda.Fecha,
                horaTurno,
                (TipoCanalTurno)cmbCanal.SelectedItem,
                chkSobreturno.Checked,
                EstadoTurno.Reservado);

            nuevoTurno.Observaciones = txtObservaciones.Text.Trim();

            DatosClinica.Turnos.Add(nuevoTurno);

            MessageBox.Show("Turno registrado correctamente.",
                "Gestión de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            RefrescarGrilla();
        }

        private void btnRecordar_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.Cancelado ||
                turno.Estado == EstadoTurno.Atendido ||
                turno.Estado == EstadoTurno.Facturado ||
                turno.Estado == EstadoTurno.Liquidado ||
                turno.Estado == EstadoTurno.PresentadoObraSocial)
            {
                MessageBox.Show("No se puede enviar recordatorio para un turno en estado " + turno.Estado + ".",
                    "Recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            turno.RecordatorioEnviado = true;

            if (turno.Estado == EstadoTurno.Reservado)
            {
                turno.Estado = EstadoTurno.Recordado;
            }

            string paciente = DatosClinica.ObtenerNombrePaciente(turno.IdPaciente);
            string profesional = DatosClinica.ObtenerNombreProfesional(turno.IdProfesional);

            MessageBox.Show(
                "Recordatorio simulado enviado al paciente.\n\n" +
                "Paciente: " + paciente + "\n" +
                "Fecha: " + turno.FechaTurno.ToString("dd/MM/yyyy") + "\n" +
                "Hora: " + turno.HoraTurno.ToString(@"hh\:mm") + "\n" +
                "Profesional: " + profesional + "\n" +
                "Dirección: 25 de Mayo 444, CABA - Sede Consultorios Externos SePrise",
                "Recordatorio de turno",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarResumenTurno(turno);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Confirmar asistencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.Cancelado ||
                turno.Estado == EstadoTurno.Atendido ||
                turno.Estado == EstadoTurno.Facturado ||
                turno.Estado == EstadoTurno.Liquidado ||
                turno.Estado == EstadoTurno.PresentadoObraSocial)
            {
                MessageBox.Show("No se puede confirmar un turno en estado " + turno.Estado + ".",
                    "Confirmar asistencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.Confirmado)
            {
                MessageBox.Show("El turno ya se encuentra confirmado.",
                    "Confirmar asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            turno.Estado = EstadoTurno.Confirmado;

            MessageBox.Show("Asistencia confirmada correctamente.",
                "Confirmar asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarResumenTurno(turno);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Cancelar turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.EnAtencion ||
                turno.Estado == EstadoTurno.Atendido ||
                turno.Estado == EstadoTurno.Facturado ||
                turno.Estado == EstadoTurno.Liquidado ||
                turno.Estado == EstadoTurno.PresentadoObraSocial)
            {
                MessageBox.Show("No se puede cancelar un turno en estado " + turno.Estado + ".",
                    "Cancelar turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea cancelar el turno seleccionado?",
                "Cancelar turno",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            turno.Estado = EstadoTurno.Cancelado;

            MessageBox.Show("Turno cancelado correctamente.",
                "Cancelar turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            RefrescarGrilla();
        }

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Reprogramar turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.EnAtencion ||
                turno.Estado == EstadoTurno.Atendido ||
                turno.Estado == EstadoTurno.Facturado ||
                turno.Estado == EstadoTurno.Liquidado ||
                turno.Estado == EstadoTurno.PresentadoObraSocial)
            {
                MessageBox.Show("No se puede reprogramar un turno en estado " + turno.Estado + ".",
                    "Reprogramar turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDatosTurno(turno.NroTurno))
            {
                return;
            }

            Paciente paciente = (Paciente)cmbPaciente.SelectedItem;
            AgendaMedica agenda = ObtenerAgendaSeleccionada();

            turno.IdPaciente = paciente.IdPaciente;
            turno.IdProfesional = agenda.IdProfesional;
            turno.IdEspecialidad = agenda.IdEspecialidad;
            turno.IdConsultorio = agenda.IdConsultorio;
            turno.FechaTurno = agenda.Fecha;
            turno.HoraTurno = ObtenerHoraTurno();
            turno.CanalSolicitud = (TipoCanalTurno)cmbCanal.SelectedItem;
            turno.EsSobreturno = chkSobreturno.Checked;
            turno.Estado = EstadoTurno.Reprogramado;
            turno.RecordatorioEnviado = false;
            turno.Observaciones = txtObservaciones.Text.Trim();

            MessageBox.Show("Turno reprogramado correctamente.",
                "Reprogramar turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            RefrescarGrilla();
        }

        // Valida las reglas principales para asignar o reprogramar turnos:
        // agenda disponible, horario dentro del rango, duración por especialidad,
        // superposición de turnos y límite de sobreturnos.
        private bool ValidarDatosTurno(int nroTurnoExcluir)
        {
            if (cmbPaciente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaciente.Focus();
                return false;
            }

            if (cmbAgenda.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una agenda médica.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAgenda.Focus();
                return false;
            }

            if (cmbCanal.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un canal de solicitud.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCanal.Focus();
                return false;
            }

            AgendaMedica agenda = ObtenerAgendaSeleccionada();

            if (agenda.Fecha.Date < DateTime.Today)
            {
                MessageBox.Show("No se puede asignar un turno en una fecha vencida.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            TimeSpan horaTurno = ObtenerHoraTurno();

            if (horaTurno < agenda.HoraInicio || horaTurno >= agenda.HoraFin)
            {
                MessageBox.Show("La hora del turno debe estar dentro del rango horario de la agenda seleccionada.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHoraTurno.Focus();
                return false;
            }

            int duracionTurno = DatosClinica.ObtenerDuracionTurnoPorEspecialidad(agenda.IdEspecialidad);
            TimeSpan horaFinTurno = horaTurno.Add(TimeSpan.FromMinutes(duracionTurno));

            if (horaFinTurno > agenda.HoraFin)
            {
                MessageBox.Show(
                    "El turno no respeta la duración mínima configurada para la especialidad.\n\n" +
                    "Duración requerida: " + duracionTurno + " minutos.\n" +
                    "Hora de finalización del turno: " + horaFinTurno.ToString(@"hh\:mm") + ".",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool existeSuperposicion = DatosClinica.ExisteTurnoSuperpuesto(
                agenda.IdProfesional,
                agenda.Fecha,
                horaTurno,
                horaFinTurno,
                nroTurnoExcluir);

            if (existeSuperposicion && !chkSobreturno.Checked)
            {
                MessageBox.Show(
                    "No se puede asignar el turno porque el horario seleccionado se superpone con otro turno del mismo profesional.\n\n" +
                    "Horario solicitado: " + horaTurno.ToString(@"hh\:mm") + " a " + horaFinTurno.ToString(@"hh\:mm") + ".\n" +
                    "Duración mínima de la especialidad: " + duracionTurno + " minutos.\n\n" +
                    "Seleccione otro horario disponible o marque la opción Sobreturno si corresponde registrarlo como excepción.",
                    "Validación de superposición",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (chkSobreturno.Checked)
            {
                bool existeSobreturnoEnHora = DatosClinica.ExisteSobreturnoEnMismaHora(
                    agenda.IdProfesional,
                    agenda.Fecha,
                    horaTurno,
                    nroTurnoExcluir);

                if (existeSobreturnoEnHora)
                {
                    MessageBox.Show(
                        "Ya existe un sobreturno para ese profesional dentro de la misma hora.\n\n" +
                        "Regla aplicada: solo se permite un sobreturno por hora.",
                        "Validación de sobreturno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (existeSuperposicion && chkSobreturno.Checked)
            {
                DialogResult respuesta = MessageBox.Show(
                    "El horario seleccionado se superpone con otro turno del profesional.\n" +
                    "Como está marcado como sobreturno, el sistema puede registrarlo como excepción.\n\n" +
                    "¿Desea continuar?",
                    "Confirmar sobreturno",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        private AgendaMedica ObtenerAgendaSeleccionada()
        {
            int idAgenda;

            if (cmbAgenda.SelectedItem is ItemAgenda itemAgenda)
            {
                idAgenda = itemAgenda.IdAgenda;
            }
            else
            {
                idAgenda = Convert.ToInt32(cmbAgenda.SelectedValue);
            }

            AgendaMedica? agenda = DatosClinica.BuscarAgendaPorId(idAgenda);

            if (agenda == null)
            {
                throw new Exception("No se encontró la agenda seleccionada.");
            }

            return agenda;
        }

        private TimeSpan ObtenerHoraTurno()
        {
            return new TimeSpan(dtpHoraTurno.Value.Hour, dtpHoraTurno.Value.Minute, 0);
        }

        private TurnoConsultorio? ObtenerTurnoSeleccionado()
        {
            if (nroTurnoSeleccionado == null)
            {
                return null;
            }

            return DatosClinica.BuscarTurnoPorNumero(nroTurnoSeleccionado.Value);
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? valorNroTurno = dgvTurnos.Rows[e.RowIndex].Cells["Nro"].Value;

            if (valorNroTurno == null)
            {
                return;
            }

            int nroTurno = Convert.ToInt32(valorNroTurno);
            TurnoConsultorio? turno = DatosClinica.BuscarTurnoPorNumero(nroTurno);

            if (turno == null)
            {
                return;
            }

            nroTurnoSeleccionado = turno.NroTurno;

            cmbPaciente.SelectedValue = turno.IdPaciente;

            AgendaMedica? agenda = DatosClinica.Agendas.FirstOrDefault(a =>
                a.IdProfesional == turno.IdProfesional
                && a.IdEspecialidad == turno.IdEspecialidad
                && a.IdConsultorio == turno.IdConsultorio
                && a.Fecha.Date == turno.FechaTurno.Date);

            if (agenda != null)
            {
                cmbAgenda.SelectedValue = agenda.IdAgenda;
            }

            dtpHoraTurno.Value = DateTime.Today
                .AddHours(turno.HoraTurno.Hours)
                .AddMinutes(turno.HoraTurno.Minutes);

            cmbCanal.SelectedItem = turno.CanalSolicitud;
            chkSobreturno.Checked = turno.EsSobreturno;
            txtObservaciones.Text = turno.Observaciones;

            MostrarResumenTurno(turno);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            nroTurnoSeleccionado = null;

            if (cmbPaciente.Items.Count > 0)
            {
                cmbPaciente.SelectedIndex = 0;
            }

            if (cmbAgenda.Items.Count > 0)
            {
                cmbAgenda.SelectedIndex = 0;
            }

            if (cmbCanal.Items.Count > 0)
            {
                cmbCanal.SelectedIndex = 0;
            }

            chkSobreturno.Checked = false;
            txtObservaciones.Clear();
            dtpHoraTurno.Value = DateTime.Today.AddHours(8);
            dgvTurnos.ClearSelection();
            LimpiarResumenSeleccion();
            ActualizarResumenAgenda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAgenda_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ActualizarResumenAgenda();
        }

        private void ActualizarResumenAgenda()
        {
            if (cmbAgenda.SelectedItem == null)
            {
                lblAgendaDetalle.Text = "Sin agenda seleccionada";
                return;
            }

            try
            {
                AgendaMedica agenda = ObtenerAgendaSeleccionada();

                string profesional = DatosClinica.ObtenerNombreProfesional(agenda.IdProfesional);
                string especialidad = DatosClinica.ObtenerNombreEspecialidad(agenda.IdEspecialidad);
                string consultorio = DatosClinica.ObtenerNombreConsultorio(agenda.IdConsultorio);

                int duracion = DatosClinica.ObtenerDuracionTurnoPorEspecialidad(agenda.IdEspecialidad);

                lblAgendaDetalle.Text =
                    agenda.Fecha.ToString("dd/MM/yyyy") + " | " +
                    agenda.HoraInicio.ToString(@"hh\:mm") + " a " +
                    agenda.HoraFin.ToString(@"hh\:mm") + "\n" +
                    profesional + "\n" +
                    especialidad + " | " + consultorio + " | " + duracion + " min";

                dtpHoraTurno.Value = DateTime.Today
                    .AddHours(agenda.HoraInicio.Hours)
                    .AddMinutes(agenda.HoraInicio.Minutes);
            }
            catch
            {
                lblAgendaDetalle.Text = "Sin agenda seleccionada";
            }
        }

        private void MostrarResumenTurno(TurnoConsultorio turno)
        {
            lblTurnoNumeroValor.Text = "N° " + turno.NroTurno;
            lblTurnoPacienteValor.Text = DatosClinica.ObtenerNombrePaciente(turno.IdPaciente);
            lblTurnoFechaValor.Text = turno.FechaTurno.ToString("dd/MM/yyyy") + " - " + turno.HoraTurno.ToString(@"hh\:mm");
            lblTurnoEstadoValor.Text = turno.Estado.ToString();
            lblTurnoCanalValor.Text = turno.CanalSolicitud.ToString() + (turno.EsSobreturno ? " | Sobreturno" : "");

            switch (turno.Estado)
            {
                case EstadoTurno.Confirmado:
                    lblTurnoEstadoValor.ForeColor = Color.FromArgb(34, 122, 83);
                    break;
                case EstadoTurno.Cancelado:
                    lblTurnoEstadoValor.ForeColor = Color.FromArgb(180, 70, 70);
                    break;
                case EstadoTurno.Reprogramado:
                    lblTurnoEstadoValor.ForeColor = Color.FromArgb(106, 78, 181);
                    break;
                default:
                    lblTurnoEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
                    break;
            }
        }

        private void LimpiarResumenSeleccion()
        {
            lblTurnoNumeroValor.Text = "Sin selección";
            lblTurnoPacienteValor.Text = "-";
            lblTurnoFechaValor.Text = "-";
            lblTurnoEstadoValor.Text = "-";
            lblTurnoEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoCanalValor.Text = "-";
        }

        private class ItemAgenda
        {
            public int IdAgenda { get; set; }
            public string Descripcion { get; set; } = "";
        }
    }
}
