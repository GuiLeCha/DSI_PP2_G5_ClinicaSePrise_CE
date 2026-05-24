using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmRecepcion : Form
    {
        private int? nroTurnoSeleccionado = null;

        public FrmRecepcion()
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
                .Where(t =>
                    t.Estado != EstadoTurno.Cancelado &&
                    t.Estado != EstadoTurno.Atendido &&
                    t.Estado != EstadoTurno.Facturado &&
                    t.Estado != EstadoTurno.Liquidado &&
                    t.Estado != EstadoTurno.PresentadoObraSocial)
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
                    Sobreturno = t.EsSobreturno ? "Sí" : "No",
                    Estado = t.Estado.ToString(),
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

            lblCantidadTurnos.Text = "Turnos pendientes de recepción: " + lista.Count;
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
                    case "Presente":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(232, 243, 255);
                        break;
                    case "EnAtencion":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(243, 239, 255);
                        break;
                    case "Recordado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 232);
                        break;
                    case "Reprogramado":
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(243, 239, 255);
                        break;
                    default:
                        fila.DefaultCellStyle.BackColor = Color.White;
                        break;
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
            ObraSocialPrepaga? cobertura = DatosClinica.BuscarCoberturaPorId(paciente?.IdObraSocialPrepaga);

            lblPacienteDato.Text = paciente != null ? paciente.NombreCompleto : "-";
            lblDocumentoDato.Text = paciente != null ? paciente.TipoDocumento + " " + paciente.NroDocumento : "-";
            lblTelefonoDato.Text = paciente != null ? paciente.Telefono : "-";
            lblProfesionalDato.Text = profesional != null ? profesional.NombreCompleto : "-";
            lblEspecialidadDato.Text = especialidad != null ? especialidad.Nombre : "-";
            lblFechaHoraDato.Text = turno.FechaTurno.ToString("dd/MM/yyyy") + " " + turno.HoraTurno.ToString(@"hh\:mm");
            lblEstadoDato.Text = turno.Estado.ToString();

            lblEstadoDato.ForeColor = ObtenerColorEstado(turno.Estado);

            if (cobertura != null)
            {
                lblCoberturaDato.Text = cobertura.Nombre + " - " + cobertura.Tipo.ToString();
                lblConvenioDato.Text = cobertura.ConvenioVigente ? "Convenio vigente" : "Convenio no vigente";
                lblRequiereAutorizacionDato.Text = cobertura.RequiereAutorizacion ? "Requiere autorización" : "No requiere autorización";
            }
            else
            {
                lblCoberturaDato.Text = "Sin cobertura";
                lblConvenioDato.Text = "-";
                lblRequiereAutorizacionDato.Text = "-";
            }

            chkAutorizacionAprobada.Checked = turno.AutorizacionAprobada;

            if (turno.CoberturaVerificada)
            {
                lblResultadoVerificacion.Text = "Cobertura verificada.";
                lblResultadoVerificacion.ForeColor = Color.FromArgb(34, 122, 83);
            }
            else
            {
                lblResultadoVerificacion.Text = "Pendiente de verificación.";
                lblResultadoVerificacion.ForeColor = Color.FromArgb(147, 112, 31);
            }
        }

        private Color ObtenerColorEstado(EstadoTurno estado)
        {
            switch (estado)
            {
                case EstadoTurno.Confirmado:
                    return Color.FromArgb(34, 122, 83);
                case EstadoTurno.Presente:
                    return Color.FromArgb(26, 82, 150);
                case EstadoTurno.EnAtencion:
                    return Color.FromArgb(106, 78, 181);
                case EstadoTurno.Cancelado:
                    return Color.FromArgb(180, 70, 70);
                default:
                    return Color.FromArgb(26, 82, 150);
            }
        }

        private void LimpiarDetalle()
        {
            nroTurnoSeleccionado = null;

            lblPacienteDato.Text = "-";
            lblDocumentoDato.Text = "-";
            lblTelefonoDato.Text = "-";
            lblProfesionalDato.Text = "-";
            lblEspecialidadDato.Text = "-";
            lblFechaHoraDato.Text = "-";
            lblEstadoDato.Text = "-";
            lblEstadoDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblCoberturaDato.Text = "-";
            lblConvenioDato.Text = "-";
            lblRequiereAutorizacionDato.Text = "-";
            lblResultadoVerificacion.Text = "Seleccione un turno para verificar cobertura.";
            lblResultadoVerificacion.ForeColor = Color.FromArgb(90, 103, 130);

            chkAutorizacionAprobada.Checked = false;
            txtObservaciones.Clear();

            dgvTurnos.ClearSelection();
        }

        private TurnoConsultorio? ObtenerTurnoSeleccionado()
        {
            if (nroTurnoSeleccionado == null)
            {
                return null;
            }

            return DatosClinica.BuscarTurnoPorNumero(nroTurnoSeleccionado.Value);
        }

        private void btnVerificarCobertura_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente? paciente = DatosClinica.BuscarPacientePorId(turno.IdPaciente);
            Especialidad? especialidad = DatosClinica.BuscarEspecialidadPorId(turno.IdEspecialidad);

            if (paciente == null || especialidad == null)
            {
                MessageBox.Show("No se encontraron los datos completos del turno.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObraSocialPrepaga? cobertura = DatosClinica.BuscarCoberturaPorId(paciente.IdObraSocialPrepaga);

            if (cobertura == null || cobertura.Tipo == TipoCobertura.Particular)
            {
                turno.CoberturaVerificada = true;
                turno.AutorizacionAprobada = true;
                turno.MontoParticular = especialidad.CostoParticular;
                turno.MontoCoseguro = 0;

                lblResultadoVerificacion.Text = "Paciente particular. Abona el 100% de la consulta.";

                MessageBox.Show("El paciente será atendido como particular.\nMonto estimado: $" + turno.MontoParticular,
                    "Verificación de cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!cobertura.ConvenioVigente || cobertura.Estado != EstadoGeneral.Activo)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "La cobertura no posee convenio vigente o se encuentra inactiva.\n¿Desea continuar la atención como particular?",
                        "Cobertura no vigente",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        return;
                    }

                    turno.CoberturaVerificada = true;
                    turno.AutorizacionAprobada = true;
                    turno.MontoParticular = especialidad.CostoParticular;
                    turno.MontoCoseguro = 0;

                    lblResultadoVerificacion.Text = "Cobertura rechazada. Atención particular.";
                }
                else
                {
                    turno.CoberturaVerificada = true;

                    if (cobertura.RequiereAutorizacion)
                    {
                        turno.AutorizacionAprobada = chkAutorizacionAprobada.Checked;

                        if (!turno.AutorizacionAprobada)
                        {
                            MessageBox.Show("La cobertura está vigente, pero falta aprobar la autorización.",
                                "Verificación de cobertura", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            lblResultadoVerificacion.Text = "Cobertura vigente. Autorización pendiente.";
                            RefrescarGrilla();
                            MostrarDetalleTurno();
                            return;
                        }
                    }
                    else
                    {
                        turno.AutorizacionAprobada = true;
                    }

                    turno.MontoCoseguro = 2500m;
                    turno.MontoParticular = 0;

                    lblResultadoVerificacion.Text = "Cobertura vigente y autorización aprobada.";

                    MessageBox.Show("Cobertura verificada correctamente.\nCoseguro estimado: $" + turno.MontoCoseguro,
                        "Verificación de cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (txtObservaciones.Text.Trim() != "")
            {
                turno.Observaciones = txtObservaciones.Text.Trim();
            }

            RefrescarGrilla();
            MostrarDetalleTurno();
        }

        private void btnRegistrarLlegada_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado == EstadoTurno.Cancelado ||
                turno.Estado == EstadoTurno.Vencido ||
                turno.Estado == EstadoTurno.Atendido ||
                turno.Estado == EstadoTurno.Facturado ||
                turno.Estado == EstadoTurno.Liquidado ||
                turno.Estado == EstadoTurno.PresentadoObraSocial)
            {
                MessageBox.Show("No se puede registrar llegada para un turno en estado " + turno.Estado + ".",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado != EstadoTurno.Confirmado &&
                turno.Estado != EstadoTurno.Recordado &&
                turno.Estado != EstadoTurno.Reservado &&
                turno.Estado != EstadoTurno.Reprogramado &&
                !turno.EsSobreturno)
            {
                MessageBox.Show("El estado del turno no permite registrar la llegada.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!turno.CoberturaVerificada)
            {
                MessageBox.Show("Antes de registrar la llegada debe verificarse la cobertura del paciente.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!turno.AutorizacionAprobada)
            {
                MessageBox.Show("No se puede registrar la llegada porque la autorización está pendiente.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            turno.Estado = EstadoTurno.Presente;

            if (txtObservaciones.Text.Trim() != "")
            {
                turno.Observaciones = txtObservaciones.Text.Trim();
            }

            string tipoIngreso = turno.EsSobreturno ? "sobreturno / demanda espontánea" : "turno programado";

            MessageBox.Show("Llegada registrada correctamente como " + tipoIngreso + ".\nEl paciente queda en sala de espera.",
                "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarDetalleTurno();
        }

        private void btnHabilitarAtencion_Click(object sender, EventArgs e)
        {
            TurnoConsultorio? turno = ObtenerTurnoSeleccionado();

            if (turno == null)
            {
                MessageBox.Show("Debe seleccionar un turno de la grilla.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (turno.Estado != EstadoTurno.Presente)
            {
                MessageBox.Show("Para habilitar la atención, el paciente debe estar registrado como presente.",
                    "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            turno.Estado = EstadoTurno.EnAtencion;

            MessageBox.Show("El turno fue habilitado para atención médica.",
                "Recepción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarGrilla();
            MostrarDetalleTurno();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
