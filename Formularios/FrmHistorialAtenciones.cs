using System.Text;
using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmHistorialAtenciones : Form
    {
        private int? nroAtencionSeleccionada = null;

        public FrmHistorialAtenciones()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarPacientes();
            RefrescarGrilla();
            LimpiarDetalle();
        }

        private void ConfigurarGrilla()
        {
            dgvHistorial.AutoGenerateColumns = true;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 235, 248);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(20, 36, 70);
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 250);
            dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 36, 70);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
            dgvHistorial.DefaultCellStyle.BackColor = Color.White;
            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvHistorial.GridColor = Color.FromArgb(220, 228, 238);
        }

        private void CargarPacientes()
        {
            cmbPaciente.DataSource = null;

            cmbPaciente.DataSource = DatosClinica.Pacientes
                .Where(p => p.Estado == EstadoGeneral.Activo)
                .OrderBy(p => p.Apellido)
                .ThenBy(p => p.Nombre)
                .ToList();

            cmbPaciente.DisplayMember = "NombreCompleto";
            cmbPaciente.ValueMember = "IdPaciente";
        }

        private void RefrescarGrilla()
        {
            dgvHistorial.DataSource = null;

            if (cmbPaciente.SelectedItem == null)
            {
                lblCantidadDato.Text = "0";
                LimpiarDetalle();
                return;
            }

            Paciente paciente = (Paciente)cmbPaciente.SelectedItem;

            var lista = DatosClinica.BuscarAtencionesPorPaciente(paciente.IdPaciente)
                .OrderByDescending(a => a.FechaAtencion)
                .Select(a => new
                {
                    Nro = a.NroAtencion,
                    Fecha = a.FechaAtencion.ToString("dd/MM/yyyy HH:mm"),
                    Profesional = DatosClinica.ObtenerNombreProfesional(a.IdProfesional),
                    Turno = a.NroTurno,
                    Diagnostico = a.Diagnostico,
                    Indicaciones = a.Indicaciones,
                    NuevoTurno = a.RequiereNuevoTurno ? "Sí" : "No",
                    DerivacionEstudio = a.DerivacionAEstudio ? "Sí" : "No",
                    Estado = a.Cerrada ? "Cerrada" : "Sin cerrar"
                })
                .ToList();

            dgvHistorial.DataSource = lista;

            if (dgvHistorial.Columns.Count > 0)
            {
                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistorial.ClearSelection();

                if (dgvHistorial.Columns.Contains("Nro"))
                {
                    dgvHistorial.Columns["Nro"].FillWeight = 45;
                }

                if (dgvHistorial.Columns.Contains("Fecha"))
                {
                    dgvHistorial.Columns["Fecha"].FillWeight = 85;
                }

                if (dgvHistorial.Columns.Contains("Profesional"))
                {
                    dgvHistorial.Columns["Profesional"].FillWeight = 110;
                }

                if (dgvHistorial.Columns.Contains("Turno"))
                {
                    dgvHistorial.Columns["Turno"].FillWeight = 50;
                }

                if (dgvHistorial.Columns.Contains("Diagnostico"))
                {
                    dgvHistorial.Columns["Diagnostico"].FillWeight = 120;
                }

                if (dgvHistorial.Columns.Contains("Indicaciones"))
                {
                    dgvHistorial.Columns["Indicaciones"].Visible = false;
                }

                if (dgvHistorial.Columns.Contains("NuevoTurno"))
                {
                    dgvHistorial.Columns["NuevoTurno"].HeaderText = "Nuevo turno";
                    dgvHistorial.Columns["NuevoTurno"].FillWeight = 60;
                }

                if (dgvHistorial.Columns.Contains("DerivacionEstudio"))
                {
                    dgvHistorial.Columns["DerivacionEstudio"].HeaderText = "Derivación";
                    dgvHistorial.Columns["DerivacionEstudio"].FillWeight = 60;
                }

                if (dgvHistorial.Columns.Contains("Estado"))
                {
                    dgvHistorial.Columns["Estado"].FillWeight = 65;
                }

                AplicarColoresEstadoEnGrilla();
            }

            lblCantidadDato.Text = lista.Count.ToString();
            LimpiarDetalle();
        }

        private void AplicarColoresEstadoEnGrilla()
        {
            foreach (DataGridViewRow fila in dgvHistorial.Rows)
            {
                if (fila.Cells["Estado"].Value == null)
                {
                    continue;
                }

                string estado = fila.Cells["Estado"].Value.ToString() ?? string.Empty;

                if (estado == "Cerrada")
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(236, 248, 240);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 232);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(147, 112, 31);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefrescarGrilla();

            if (dgvHistorial.Rows.Count == 0)
            {
                MessageBox.Show("El paciente seleccionado no posee atenciones registradas.",
                    "Historial de atenciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? valor = dgvHistorial.Rows[e.RowIndex].Cells["Nro"].Value;

            if (valor == null)
            {
                return;
            }

            nroAtencionSeleccionada = Convert.ToInt32(valor);
            MostrarDetalleAtencion();
        }

        private void MostrarDetalleAtencion()
        {
            if (nroAtencionSeleccionada == null)
            {
                LimpiarDetalle();
                return;
            }

            AtencionMedica? atencion = DatosClinica.AtencionesMedicas
                .FirstOrDefault(a => a.NroAtencion == nroAtencionSeleccionada.Value);

            if (atencion == null)
            {
                LimpiarDetalle();
                return;
            }

            Paciente? paciente = DatosClinica.BuscarPacientePorId(atencion.IdPaciente);
            Profesional? profesional = DatosClinica.BuscarProfesionalPorId(atencion.IdProfesional);
            TurnoConsultorio? turno = DatosClinica.BuscarTurnoPorNumero(atencion.NroTurno);
            HistoriaClinica? historia = DatosClinica.HistoriasClinicas
                .FirstOrDefault(h => h.IdHistoriaClinica == atencion.IdHistoriaClinica);

            string especialidad = "-";
            if (turno != null)
            {
                especialidad = DatosClinica.ObtenerNombreEspecialidad(turno.IdEspecialidad);
            }

            lblAtencionNumeroValor.Text = "N° " + atencion.NroAtencion;
            lblAtencionPacienteValor.Text = paciente != null ? paciente.NombreCompleto : "-";
            lblAtencionFechaValor.Text = atencion.FechaAtencion.ToString("dd/MM/yyyy HH:mm");
            lblAtencionProfesionalValor.Text = profesional != null ? profesional.NombreCompleto : "-";
            lblAtencionEstadoValor.Text = atencion.Cerrada ? "Cerrada" : "Sin cerrar";
            lblAtencionEstadoValor.ForeColor = atencion.Cerrada
                ? Color.FromArgb(34, 122, 83)
                : Color.FromArgb(147, 112, 31);

            StringBuilder detalle = new StringBuilder();
            detalle.AppendLine("DATOS DE LA ATENCIÓN");
            detalle.AppendLine("----------------------------------------");
            detalle.AppendLine("Paciente: " + (paciente != null ? paciente.NombreCompleto : "-"));
            detalle.AppendLine("Documento: " + (paciente != null ? paciente.TipoDocumento + " " + paciente.NroDocumento : "-"));
            detalle.AppendLine("Profesional: " + (profesional != null ? profesional.NombreCompleto : "-"));
            detalle.AppendLine("Especialidad: " + especialidad);
            detalle.AppendLine("Fecha: " + atencion.FechaAtencion.ToString("dd/MM/yyyy HH:mm"));
            detalle.AppendLine("Turno: " + atencion.NroTurno);
            detalle.AppendLine("Historia clínica: " + (historia != null ? historia.IdHistoriaClinica.ToString() : "-"));
            detalle.AppendLine("Estado: " + (atencion.Cerrada ? "Cerrada" : "Sin cerrar"));
            detalle.AppendLine();
            detalle.AppendLine("DIAGNÓSTICO");
            detalle.AppendLine(atencion.Diagnostico);
            detalle.AppendLine();
            detalle.AppendLine("INDICACIONES");
            detalle.AppendLine(atencion.Indicaciones);
            detalle.AppendLine();
            detalle.AppendLine("OBSERVACIONES");
            detalle.AppendLine(atencion.ObservacionesClinicas);
            detalle.AppendLine();
            detalle.AppendLine("Requiere nuevo turno: " + (atencion.RequiereNuevoTurno ? "Sí" : "No"));
            detalle.AppendLine("Derivación a estudio: " + (atencion.DerivacionAEstudio ? "Sí" : "No"));

            txtDetalleAtencion.Text = detalle.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            nroAtencionSeleccionada = null;
            txtDetalleAtencion.Clear();

            lblAtencionNumeroValor.Text = "Sin selección";
            lblAtencionPacienteValor.Text = "-";
            lblAtencionFechaValor.Text = "-";
            lblAtencionProfesionalValor.Text = "-";
            lblAtencionEstadoValor.Text = "-";
            lblAtencionEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);

            if (dgvHistorial != null)
            {
                dgvHistorial.ClearSelection();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
