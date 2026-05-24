using DSI_PP2_G5_ClinicaSePrise_CE.Datos;
using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    public partial class FrmAgendaMedica : Form
    {
        private Label? lblAgendaEquipamiento;
        private Label? lblAgendaEquipamientoValor;

        public FrmAgendaMedica()
        {
            InitializeComponent();
            ConfigurarPanelEquipamiento();
            ConfigurarGrilla();
            CargarCombos();
            RefrescarGrilla();
            LimpiarResumenSeleccion();
            ActualizarResumenProfesional();
        }

        private void ConfigurarPanelEquipamiento()
        {
            // Se agregan estos controles desde código para no modificar manualmente el Designer.
            lblAgendaConsultorio.Location = new Point(31, 384);
            lblAgendaConsultorioValor.Location = new Point(31, 402);
            lblAgendaConsultorioValor.Size = new Size(216, 30);

            lblAgendaFecha.Location = new Point(31, 501);
            lblAgendaFechaValor.Location = new Point(31, 519);
            lblAgendaFechaValor.Size = new Size(220, 30);

            lblAgendaEstado.Location = new Point(31, 552);
            lblAgendaEstadoValor.Location = new Point(31, 570);

            lblAgendaEquipamiento = new Label();
            lblAgendaEquipamiento.AutoSize = true;
            lblAgendaEquipamiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaEquipamiento.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaEquipamiento.Location = new Point(31, 437);
            lblAgendaEquipamiento.Name = "lblAgendaEquipamiento";
            lblAgendaEquipamiento.Size = new Size(150, 15);
            lblAgendaEquipamiento.TabIndex = 16;
            lblAgendaEquipamiento.Text = "Equipamiento disponible";

            lblAgendaEquipamientoValor = new Label();
            lblAgendaEquipamientoValor.Font = new Font("Segoe UI", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaEquipamientoValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaEquipamientoValor.Location = new Point(31, 455);
            lblAgendaEquipamientoValor.Name = "lblAgendaEquipamientoValor";
            lblAgendaEquipamientoValor.Size = new Size(216, 43);
            lblAgendaEquipamientoValor.TabIndex = 17;
            lblAgendaEquipamientoValor.Text = "-";

            pnlLateral.Controls.Add(lblAgendaEquipamiento);
            pnlLateral.Controls.Add(lblAgendaEquipamientoValor);
        }
        private void ConfigurarGrilla()
        {
            dgvAgenda.AutoGenerateColumns = true;
            dgvAgenda.ReadOnly = true;
            dgvAgenda.AllowUserToAddRows = false;
            dgvAgenda.AllowUserToDeleteRows = false;
            dgvAgenda.AllowUserToResizeRows = false;
            dgvAgenda.MultiSelect = false;
            dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgenda.BackgroundColor = Color.White;
            dgvAgenda.BorderStyle = BorderStyle.None;
            dgvAgenda.RowHeadersVisible = false;
            dgvAgenda.EnableHeadersVisualStyles = false;
            dgvAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 235, 248);
            dgvAgenda.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(20, 36, 70);
            dgvAgenda.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAgenda.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 250);
            dgvAgenda.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 36, 70);
            dgvAgenda.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
            dgvAgenda.DefaultCellStyle.BackColor = Color.White;
            dgvAgenda.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
            dgvAgenda.GridColor = Color.FromArgb(220, 228, 238);
        }

        private void CargarCombos()
        {
            cmbProfesional.DataSource = null;
            cmbProfesional.DataSource = DatosClinica.Profesionales
                .Where(p => p.Estado == EstadoGeneral.Activo)
                .ToList();
            cmbProfesional.DisplayMember = "NombreCompleto";
            cmbProfesional.ValueMember = "IdProfesional";

            cmbEspecialidad.DataSource = null;
            cmbEspecialidad.DataSource = DatosClinica.Especialidades.ToList();
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "IdEspecialidad";

            cmbConsultorio.DataSource = null;
            cmbConsultorio.DataSource = DatosClinica.Consultorios
                .Where(c => c.Estado == EstadoConsultorio.Disponible)
                .ToList();
            cmbConsultorio.DisplayMember = "Numero";
            cmbConsultorio.ValueMember = "IdConsultorio";

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(EstadoAgenda.Disponible);
            cmbEstado.Items.Add(EstadoAgenda.Bloqueada);
            cmbEstado.SelectedIndex = 0;

            dtpFecha.Value = DateTime.Today.AddDays(1);

            dtpHoraInicio.Value = DateTime.Today.AddHours(8);
            dtpHoraFin.Value = DateTime.Today.AddHours(12);
        }

        private void RefrescarGrilla()
        {
            dgvAgenda.DataSource = null;

            var lista = DatosClinica.Agendas
                .OrderBy(a => a.Fecha)
                .ThenBy(a => a.HoraInicio)
                .Select(a => new
                {
                    ID = a.IdAgenda,
                    Profesional = DatosClinica.ObtenerNombreProfesional(a.IdProfesional),
                    Especialidad = DatosClinica.ObtenerNombreEspecialidad(a.IdEspecialidad),
                    Consultorio = DatosClinica.ObtenerNombreConsultorio(a.IdConsultorio),
                    Fecha = a.Fecha.ToString("dd/MM/yyyy"),
                    Inicio = a.HoraInicio.ToString(@"hh\:mm"),
                    Fin = a.HoraFin.ToString(@"hh\:mm"),
                    Estado = a.Estado.ToString()
                })
                .ToList();

            dgvAgenda.DataSource = lista;

            if (dgvAgenda.Columns.Count > 0)
            {
                dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAgenda.ClearSelection();
                AplicarColoresEstadoEnGrilla();
            }

            lblCantidadAgendas.Text = "Total de agendas cargadas: " + lista.Count;
        }

        private void AplicarColoresEstadoEnGrilla()
        {
            foreach (DataGridViewRow fila in dgvAgenda.Rows)
            {
                if (fila.Cells["Estado"].Value == null)
                {
                    continue;
                }

                string estado = fila.Cells["Estado"].Value.ToString() ?? string.Empty;

                if (estado == "Disponible")
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(236, 248, 240);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
                else if (estado == "Bloqueada")
                {
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(252, 235, 235);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(145, 72, 72);
                }
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.White;
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(42, 58, 92);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            int idProfesional = Convert.ToInt32(cmbProfesional.SelectedValue);
            int idEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            int idConsultorio = Convert.ToInt32(cmbConsultorio.SelectedValue);

            DateTime fecha = dtpFecha.Value.Date;

            TimeSpan horaInicio = new TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0);
            TimeSpan horaFin = new TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0);

            bool existeSuperposicion = DatosClinica.ExisteSuperposicionAgenda(
                idProfesional,
                idConsultorio,
                fecha,
                horaInicio,
                horaFin);

            if (existeSuperposicion)
            {
                MessageBox.Show("No se puede cargar la agenda porque existe una superposición de horario para el profesional o el consultorio.",
                    "Validación de agenda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AgendaMedica nuevaAgenda = new AgendaMedica(
                DatosClinica.ObtenerProximoIdAgenda(),
                idProfesional,
                idEspecialidad,
                idConsultorio,
                fecha,
                horaInicio,
                horaFin,
                (EstadoAgenda)cmbEstado.SelectedItem);

            DatosClinica.Agendas.Add(nuevaAgenda);

            MessageBox.Show("Agenda médica registrada correctamente.",
                "Agenda médica", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            RefrescarGrilla();
        }

        private bool ValidarDatos()
        {
            if (cmbProfesional.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un profesional.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProfesional.Focus();
                return false;
            }

            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEspecialidad.Focus();
                return false;
            }

            if (cmbConsultorio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un consultorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbConsultorio.Focus();
                return false;
            }

            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de agenda no puede ser anterior al día actual.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Focus();
                return false;
            }

            TimeSpan horaInicio = new TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0);
            TimeSpan horaFin = new TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0);

            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHoraFin.Focus();
                return false;
            }

            Profesional? profesional = cmbProfesional.SelectedItem as Profesional;
            Especialidad? especialidad = cmbEspecialidad.SelectedItem as Especialidad;

            if (profesional != null && especialidad != null)
            {
                if (profesional.IdEspecialidad != especialidad.IdEspecialidad)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "La especialidad seleccionada no coincide con la especialidad principal del profesional.\n¿Desea continuar igualmente?",
                        "Confirmar especialidad",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            if (cmbProfesional.Items.Count > 0)
            {
                cmbProfesional.SelectedIndex = 0;
            }

            if (cmbEspecialidad.Items.Count > 0)
            {
                cmbEspecialidad.SelectedIndex = 0;
            }

            if (cmbConsultorio.Items.Count > 0)
            {
                cmbConsultorio.SelectedIndex = 0;
            }

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            dtpFecha.Value = DateTime.Today.AddDays(1);
            dtpHoraInicio.Value = DateTime.Today.AddHours(8);
            dtpHoraFin.Value = DateTime.Today.AddHours(12);
            dgvAgenda.ClearSelection();
            LimpiarResumenSeleccion();
            ActualizarResumenProfesional();
            cmbProfesional.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profesional? profesional = cmbProfesional.SelectedItem as Profesional;

            if (profesional == null)
            {
                return;
            }

            Especialidad? especialidad = DatosClinica.BuscarEspecialidadPorId(profesional.IdEspecialidad);

            if (especialidad != null)
            {
                cmbEspecialidad.SelectedValue = especialidad.IdEspecialidad;
            }

            ActualizarResumenProfesional();
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? valorId = dgvAgenda.Rows[e.RowIndex].Cells["ID"].Value;

            if (valorId == null)
            {
                return;
            }

            int idAgenda = Convert.ToInt32(valorId);
            AgendaMedica? agenda = DatosClinica.BuscarAgendaPorId(idAgenda);

            if (agenda == null)
            {
                return;
            }

            MostrarResumenAgenda(agenda);
        }

        private void MostrarResumenAgenda(AgendaMedica agenda)
        {
            lblAgendaIdValor.Text = "ID " + agenda.IdAgenda;
            lblAgendaProfesionalValor.Text = DatosClinica.ObtenerNombreProfesional(agenda.IdProfesional);
            lblAgendaEspecialidadValor.Text = DatosClinica.ObtenerNombreEspecialidad(agenda.IdEspecialidad);

            Consultorio? consultorio = DatosClinica.BuscarConsultorioPorId(agenda.IdConsultorio);

            if (consultorio != null)
            {
                lblAgendaConsultorioValor.Text = consultorio.ToString();

                if (lblAgendaEquipamientoValor != null)
                {
                    lblAgendaEquipamientoValor.Text = consultorio.Equipamiento;
                }
            }
            else
            {
                lblAgendaConsultorioValor.Text = DatosClinica.ObtenerNombreConsultorio(agenda.IdConsultorio);

                if (lblAgendaEquipamientoValor != null)
                {
                    lblAgendaEquipamientoValor.Text = "-";
                }
            }

            lblAgendaFechaValor.Text = agenda.Fecha.ToString("dd/MM/yyyy") + " - " +
                agenda.HoraInicio.ToString(@"hh\:mm") + " a " + agenda.HoraFin.ToString(@"hh\:mm");

            lblAgendaEstadoValor.Text = agenda.Estado.ToString();

            if (agenda.Estado == EstadoAgenda.Disponible)
            {
                lblAgendaEstadoValor.ForeColor = Color.FromArgb(34, 122, 83);
            }
            else
            {
                lblAgendaEstadoValor.ForeColor = Color.FromArgb(180, 70, 70);
            }
        }

        private void LimpiarResumenSeleccion()
        {
            lblAgendaIdValor.Text = "Sin selección";
            lblAgendaProfesionalValor.Text = "-";
            lblAgendaEspecialidadValor.Text = "-";
            lblAgendaConsultorioValor.Text = "-";

            if (lblAgendaEquipamientoValor != null)
            {
                lblAgendaEquipamientoValor.Text = "-";
            }

            lblAgendaFechaValor.Text = "-";
            lblAgendaEstadoValor.Text = "-";
            lblAgendaEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
        }

        private void ActualizarResumenProfesional()
        {
            Profesional? profesional = cmbProfesional.SelectedItem as Profesional;

            if (profesional == null)
            {
                lblProfesionalDetalle.Text = "Seleccione un profesional para ver su disponibilidad.";
                return;
            }

            string especialidad = DatosClinica.ObtenerNombreEspecialidad(profesional.IdEspecialidad);

            lblProfesionalDetalle.Text =
                profesional.NombreCompleto + "\n" +
                "Especialidad: " + especialidad + "\n" +
                "Matrícula: " + profesional.Matricula + "\n" +
                "Disponibilidad: " + profesional.DisponibilidadHoraria;
        }
    }
}
