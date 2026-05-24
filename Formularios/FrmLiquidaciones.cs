using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmLiquidaciones : Form
    {
        public FrmLiquidaciones()
        {
            InitializeComponent();

            ConfigurarPeriodos();
            CargarCombos();
            RefrescarListados();
        }

        private void ConfigurarPeriodos()
        {
            dtpPeriodoHonorarios.Format = DateTimePickerFormat.Custom;
            dtpPeriodoHonorarios.CustomFormat = "MM/yyyy";
            dtpPeriodoHonorarios.ShowUpDown = true;

            dtpPeriodoObraSocial.Format = DateTimePickerFormat.Custom;
            dtpPeriodoObraSocial.CustomFormat = "MM/yyyy";
            dtpPeriodoObraSocial.ShowUpDown = true;
        }

        private void CargarCombos()
        {
            CargarTurnosParaComprobante();
            CargarProfesionales();
            CargarObrasSociales();
        }

        private void CargarTurnosParaComprobante()
        {
            cmbTurnoComprobante.DataSource = null;

            var turnos = DatosClinica.Turnos
                .Where(t => t.Estado == EstadoTurno.Atendido)
                .OrderBy(t => t.FechaTurno)
                .ThenBy(t => t.HoraTurno)
                .Select(t => new ItemTurnoComprobante
                {
                    NroTurno = t.NroTurno,
                    Descripcion = "Turno " + t.NroTurno +
                                  " - " + DatosClinica.ObtenerNombrePaciente(t.IdPaciente) +
                                  " - " + DatosClinica.ObtenerNombreProfesional(t.IdProfesional) +
                                  " - " + t.FechaTurno.ToString("dd/MM/yyyy")
                })
                .ToList();

            cmbTurnoComprobante.DataSource = turnos;
            cmbTurnoComprobante.DisplayMember = "Descripcion";
            cmbTurnoComprobante.ValueMember = "NroTurno";
        }

        private void CargarProfesionales()
        {
            cmbProfesional.DataSource = null;

            cmbProfesional.DataSource = DatosClinica.Profesionales
                .Where(p => p.Estado == EstadoGeneral.Activo)
                .OrderBy(p => p.Apellido)
                .ThenBy(p => p.Nombre)
                .ToList();

            cmbProfesional.DisplayMember = "NombreCompleto";
            cmbProfesional.ValueMember = "IdProfesional";
        }

        private void CargarObrasSociales()
        {
            cmbObraSocial.DataSource = null;

            cmbObraSocial.DataSource = DatosClinica.ObrasSocialesPrepagas
                .Where(o => o.Estado == EstadoGeneral.Activo && o.Tipo != TipoCobertura.Particular)
                .OrderBy(o => o.Nombre)
                .ToList();

            cmbObraSocial.DisplayMember = "Nombre";
            cmbObraSocial.ValueMember = "IdCobertura";
        }

        private void RefrescarListados()
        {
            CargarTurnosParaComprobante();
            RefrescarComprobantes();
            RefrescarHonorarios();
            RefrescarLotesObraSocial();
            ActualizarResumenPanel();
        }

        private void RefrescarComprobantes()
        {
            dgvComprobantes.DataSource = null;

            var lista = DatosClinica.ComprobantesPago
                .OrderByDescending(c => c.FechaEmision)
                .Select(c => new
                {
                    Nro = c.NroComprobante,
                    Turno = c.NroTurno,
                    Paciente = DatosClinica.ObtenerNombrePaciente(c.IdPaciente),
                    Fecha = c.FechaEmision.ToString("dd/MM/yyyy HH:mm"),
                    Concepto = c.Concepto,
                    TipoPago = c.TipoPago,
                    Monto = "$ " + c.Monto.ToString("N2"),
                    Estado = c.Estado.ToString()
                })
                .ToList();

            dgvComprobantes.DataSource = lista;
            ConfigurarGrilla(dgvComprobantes);
            lblCantidadComprobantes.Text = "Comprobantes emitidos: " + lista.Count;
        }

        private void RefrescarHonorarios()
        {
            dgvHonorarios.DataSource = null;

            var lista = DatosClinica.Honorarios
                .OrderByDescending(h => h.FechaGeneracion)
                .Select(h => new
                {
                    Nro = h.NroLiquidacion,
                    Profesional = DatosClinica.ObtenerNombreProfesional(h.IdProfesional),
                    Periodo = h.Periodo,
                    Fecha = h.FechaGeneracion.ToString("dd/MM/yyyy"),
                    Atenciones = h.CantidadAtenciones,
                    Monto = "$ " + h.MontoTotal.ToString("N2"),
                    Estado = h.Estado.ToString(),
                    Observaciones = h.Observaciones
                })
                .ToList();

            dgvHonorarios.DataSource = lista;
            ConfigurarGrilla(dgvHonorarios);
            lblCantidadHonorarios.Text = "Liquidaciones generadas: " + lista.Count;
        }

        private void RefrescarLotesObraSocial()
        {
            dgvLotes.DataSource = null;

            var lista = DatosClinica.LotesObraSocial
                .OrderByDescending(l => l.FechaPresentacion)
                .Select(l => new
                {
                    Nro = l.NroLote,
                    Financiador = DatosClinica.ObtenerNombreCobertura(l.IdObraSocialPrepaga),
                    Periodo = l.Periodo,
                    Fecha = l.FechaPresentacion.ToString("dd/MM/yyyy"),
                    Prestaciones = l.CantidadPrestaciones,
                    Monto = "$ " + l.MontoTotal.ToString("N2"),
                    Estado = l.Estado.ToString(),
                    Observaciones = l.Observaciones
                })
                .ToList();

            dgvLotes.DataSource = lista;
            ConfigurarGrilla(dgvLotes);
            lblCantidadLotes.Text = "Presentaciones realizadas: " + lista.Count;
        }

        private void ConfigurarGrilla(DataGridView grilla)
        {
            grilla.ReadOnly = true;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeRows = false;
            grilla.MultiSelect = false;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.BackgroundColor = Color.White;
            grilla.BorderStyle = BorderStyle.None;
            grilla.RowHeadersVisible = false;
            grilla.EnableHeadersVisualStyles = false;
            grilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 235, 248);
            grilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(20, 36, 70);
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 250);
            grilla.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 36, 70);
            grilla.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
            grilla.DefaultCellStyle.BackColor = Color.White;
            grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
            grilla.GridColor = Color.FromArgb(220, 228, 238);

            if (grilla.Columns.Count > 0)
            {
                grilla.ClearSelection();
            }
        }

        private void ActualizarResumenPanel()
        {
            lblComprobantesValor.Text = DatosClinica.ComprobantesPago.Count.ToString();
            lblHonorariosValor.Text = DatosClinica.Honorarios.Count.ToString();
            lblLotesValor.Text = DatosClinica.LotesObraSocial.Count.ToString();

            int pendientes = DatosClinica.Turnos.Count(t => t.Estado == EstadoTurno.Atendido);
            lblPendientesValor.Text = pendientes.ToString();
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            if (cmbTurnoComprobante.SelectedItem == null)
            {
                MessageBox.Show("No hay turnos atendidos pendientes de comprobante.",
                    "Comprobante de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int nroTurno = Convert.ToInt32(cmbTurnoComprobante.SelectedValue);
            TurnoConsultorio? turno = DatosClinica.BuscarTurnoPorNumero(nroTurno);

            if (turno == null)
            {
                MessageBox.Show("No se encontró el turno seleccionado.",
                    "Comprobante de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool yaExiste = DatosClinica.ComprobantesPago.Any(c => c.NroTurno == turno.NroTurno);

            if (yaExiste)
            {
                MessageBox.Show("El turno seleccionado ya tiene comprobante generado.",
                    "Comprobante de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Paciente? paciente = DatosClinica.BuscarPacientePorId(turno.IdPaciente);
            Especialidad? especialidad = DatosClinica.BuscarEspecialidadPorId(turno.IdEspecialidad);

            if (paciente == null || especialidad == null)
            {
                MessageBox.Show("Faltan datos del paciente o de la especialidad.",
                    "Comprobante de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto = CalcularMontoComprobante(turno, paciente, especialidad);
            string tipoPago = ObtenerTipoPago(turno, paciente);
            string concepto = "Consulta médica - " + especialidad.Nombre;

            ComprobantePago comprobante = new ComprobantePago(
                DatosClinica.ObtenerProximoNroComprobante(),
                turno.NroTurno,
                turno.IdPaciente,
                DateTime.Now,
                concepto,
                tipoPago,
                monto,
                EstadoComprobante.Emitido);

            DatosClinica.ComprobantesPago.Add(comprobante);

            turno.Estado = EstadoTurno.Facturado;

            MessageBox.Show("Comprobante generado correctamente.\nMonto: $ " + monto.ToString("N2"),
                "Comprobante de pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarListados();
        }

        private decimal CalcularMontoComprobante(TurnoConsultorio turno, Paciente paciente, Especialidad especialidad)
        {
            ObraSocialPrepaga? cobertura = DatosClinica.BuscarCoberturaPorId(paciente.IdObraSocialPrepaga);

            if (cobertura == null || cobertura.Tipo == TipoCobertura.Particular)
            {
                return especialidad.CostoParticular;
            }

            if (turno.MontoParticular > 0)
            {
                return turno.MontoParticular;
            }

            if (turno.MontoCoseguro > 0)
            {
                return turno.MontoCoseguro;
            }

            return 2500m;
        }

        private string ObtenerTipoPago(TurnoConsultorio turno, Paciente paciente)
        {
            ObraSocialPrepaga? cobertura = DatosClinica.BuscarCoberturaPorId(paciente.IdObraSocialPrepaga);

            if (cobertura == null || cobertura.Tipo == TipoCobertura.Particular || turno.MontoParticular > 0)
            {
                return "Pago particular";
            }

            return "Coseguro";
        }

        private void btnLiquidarHonorarios_Click(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un profesional.",
                    "Liquidación de honorarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Profesional profesional = (Profesional)cmbProfesional.SelectedItem;
            string periodo = dtpPeriodoHonorarios.Value.ToString("MM/yyyy");

            bool yaExiste = DatosClinica.Honorarios.Any(h =>
                h.IdProfesional == profesional.IdProfesional &&
                h.Periodo == periodo);

            if (yaExiste)
            {
                MessageBox.Show("Ya existe una liquidación para ese profesional y período.",
                    "Liquidación de honorarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<AtencionMedica> atenciones = ObtenerAtencionesFacturadasDelPeriodo(
                profesional.IdProfesional,
                periodo);

            if (atenciones.Count == 0)
            {
                MessageBox.Show("No hay atenciones facturadas para liquidar en el período seleccionado.",
                    "Liquidación de honorarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal valorPorAtencion = 7000m;
            decimal montoTotal = atenciones.Count * valorPorAtencion;

            Honorario honorario = new Honorario(
                DatosClinica.ObtenerProximoNroLiquidacion(),
                profesional.IdProfesional,
                periodo,
                DateTime.Today,
                atenciones.Count,
                montoTotal,
                EstadoHonorario.Liquidado,
                null,
                "Liquidación generada por atenciones cerradas y facturadas.");

            DatosClinica.Honorarios.Add(honorario);

            foreach (AtencionMedica atencion in atenciones)
            {
                TurnoConsultorio? turno = DatosClinica.BuscarTurnoPorNumero(atencion.NroTurno);

                if (turno != null)
                {
                    turno.Estado = EstadoTurno.Liquidado;
                }
            }

            MessageBox.Show("Liquidación de honorarios generada correctamente.\nMonto total: $ " + montoTotal.ToString("N2"),
                "Liquidación de honorarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarListados();
        }

        private List<AtencionMedica> ObtenerAtencionesFacturadasDelPeriodo(int idProfesional, string periodo)
        {
            return DatosClinica.AtencionesMedicas
                .Where(a =>
                    a.IdProfesional == idProfesional &&
                    a.Cerrada &&
                    a.FechaAtencion.ToString("MM/yyyy") == periodo)
                .Where(a =>
                {
                    TurnoConsultorio? turno = DatosClinica.BuscarTurnoPorNumero(a.NroTurno);

                    if (turno == null)
                    {
                        return false;
                    }

                    return turno.Estado == EstadoTurno.Facturado;
                })
                .ToList();
        }

        private void btnPresentarObraSocial_Click(object sender, EventArgs e)
        {
            if (cmbObraSocial.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una obra social o prepaga.",
                    "Presentación a obra social", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObraSocialPrepaga cobertura = (ObraSocialPrepaga)cmbObraSocial.SelectedItem;
            string periodo = dtpPeriodoObraSocial.Value.ToString("MM/yyyy");

            List<TurnoConsultorio> turnos = ObtenerTurnosLiquidadosParaObraSocial(
                cobertura.IdCobertura,
                periodo);

            if (turnos.Count == 0)
            {
                MessageBox.Show("No hay prestaciones liquidadas para presentar en el período seleccionado.",
                    "Presentación a obra social", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal montoTotal = CalcularMontoPresentacionObraSocial(turnos);

            LoteObraSocial lote = new LoteObraSocial(
                DatosClinica.ObtenerProximoNroLote(),
                cobertura.IdCobertura,
                periodo,
                DateTime.Today,
                turnos.Count,
                montoTotal,
                EstadoLoteObraSocial.Presentado,
                "Lote simulado presentado a obra social/prepaga.");

            DatosClinica.LotesObraSocial.Add(lote);

            foreach (TurnoConsultorio turno in turnos)
            {
                turno.Estado = EstadoTurno.PresentadoObraSocial;
            }

            MessageBox.Show("Presentación realizada correctamente a " + cobertura.Nombre +
                ".\nMonto total: $ " + montoTotal.ToString("N2"),
                "Presentación a obra social", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefrescarListados();
        }

        private List<TurnoConsultorio> ObtenerTurnosLiquidadosParaObraSocial(int idCobertura, string periodo)
        {
            return DatosClinica.Turnos
                .Where(t => t.Estado == EstadoTurno.Liquidado)
                .Where(t =>
                {
                    Paciente? paciente = DatosClinica.BuscarPacientePorId(t.IdPaciente);

                    if (paciente == null)
                    {
                        return false;
                    }

                    return paciente.IdObraSocialPrepaga == idCobertura;
                })
                .Where(t =>
                {
                    AtencionMedica? atencion = DatosClinica.BuscarAtencionPorTurno(t.NroTurno);

                    if (atencion == null)
                    {
                        return false;
                    }

                    return atencion.Cerrada && atencion.FechaAtencion.ToString("MM/yyyy") == periodo;
                })
                .ToList();
        }

        private decimal CalcularMontoPresentacionObraSocial(List<TurnoConsultorio> turnos)
        {
            decimal total = 0;

            foreach (TurnoConsultorio turno in turnos)
            {
                Especialidad? especialidad = DatosClinica.BuscarEspecialidadPorId(turno.IdEspecialidad);

                if (especialidad != null)
                {
                    decimal montoFinanciador = especialidad.CostoParticular - turno.MontoCoseguro;

                    if (montoFinanciador < 0)
                    {
                        montoFinanciador = 0;
                    }

                    total += montoFinanciador;
                }
            }

            return total;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarListados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class ItemTurnoComprobante
        {
            public int NroTurno { get; set; }
            public string Descripcion { get; set; } = "";
        }
    }
}
