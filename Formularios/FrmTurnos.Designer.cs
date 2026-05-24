namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmTurnos
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel gbDatosTurno;
        private Panel pnlAccionesSeleccionado;
        private Panel gbListado;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblSeleccionTitulo;
        private Label lblTurnoNumero;
        private Label lblTurnoPaciente;
        private Label lblTurnoFecha;
        private Label lblTurnoEstado;
        private Label lblTurnoCanal;
        private Label lblTurnoNumeroValor;
        private Label lblTurnoPacienteValor;
        private Label lblTurnoFechaValor;
        private Label lblTurnoEstadoValor;
        private Label lblTurnoCanalValor;
        private Label lblPaciente;
        private Label lblAgenda;
        private Label lblHoraTurno;
        private Label lblCanal;
        private Label lblObservaciones;
        private Label lblAgendaResumenTitulo;
        private Label lblAgendaDetalle;
        private Label lblListadoTitulo;
        private Label lblCantidadTurnos;
        private ComboBox cmbPaciente;
        private ComboBox cmbAgenda;
        private DateTimePicker dtpHoraTurno;
        private ComboBox cmbCanal;
        private CheckBox chkSobreturno;
        private TextBox txtObservaciones;
        private Button btnAsignar;
        private Button btnRecordar;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Button btnReprogramar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private DataGridView dgvTurnos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLateral = new Panel();
            lblTurnoCanalValor = new Label();
            lblTurnoEstadoValor = new Label();
            lblTurnoFechaValor = new Label();
            lblTurnoPacienteValor = new Label();
            lblTurnoNumeroValor = new Label();
            lblTurnoCanal = new Label();
            lblTurnoEstado = new Label();
            lblTurnoFecha = new Label();
            lblTurnoPaciente = new Label();
            lblTurnoNumero = new Label();
            lblSeleccionTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            btnCerrar = new Button();
            pnlContenido = new Panel();
            gbListado = new Panel();
            dgvTurnos = new DataGridView();
            lblCantidadTurnos = new Label();
            lblListadoTitulo = new Label();
            pnlAccionesSeleccionado = new Panel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnRecordar = new Button();
            gbDatosTurno = new Panel();
            btnLimpiar = new Button();
            btnReprogramar = new Button();
            btnAsignar = new Button();
            lblAgendaDetalle = new Label();
            lblAgendaResumenTitulo = new Label();
            txtObservaciones = new TextBox();
            chkSobreturno = new CheckBox();
            cmbCanal = new ComboBox();
            dtpHoraTurno = new DateTimePicker();
            cmbAgenda = new ComboBox();
            cmbPaciente = new ComboBox();
            lblObservaciones = new Label();
            lblCanal = new Label();
            lblHoraTurno = new Label();
            lblAgenda = new Label();
            lblPaciente = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            pnlAccionesSeleccionado.SuspendLayout();
            gbDatosTurno.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();

            // pnlLateral
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(lblTurnoCanalValor);
            pnlLateral.Controls.Add(lblTurnoEstadoValor);
            pnlLateral.Controls.Add(lblTurnoFechaValor);
            pnlLateral.Controls.Add(lblTurnoPacienteValor);
            pnlLateral.Controls.Add(lblTurnoNumeroValor);
            pnlLateral.Controls.Add(lblTurnoCanal);
            pnlLateral.Controls.Add(lblTurnoEstado);
            pnlLateral.Controls.Add(lblTurnoFecha);
            pnlLateral.Controls.Add(lblTurnoPaciente);
            pnlLateral.Controls.Add(lblTurnoNumero);
            pnlLateral.Controls.Add(lblSeleccionTitulo);
            pnlLateral.Controls.Add(lblPanelTexto);
            pnlLateral.Controls.Add(lblPanelTitulo);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;

            // lblPanelTitulo
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(24, 32);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(135, 37);
            lblPanelTitulo.TabIndex = 1;
            lblPanelTitulo.Text = "🗓 Turnos";

            // lblPanelTexto
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(24, 85);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(232, 82);
            lblPanelTexto.TabIndex = 2;
            lblPanelTexto.Text = "Desde este módulo puede asignar, recordar, confirmar, reprogramar o cancelar turnos del circuito.";

            // lblSeleccionTitulo
            lblSeleccionTitulo.AutoSize = true;
            lblSeleccionTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblSeleccionTitulo.Location = new Point(24, 196);
            lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            lblSeleccionTitulo.Size = new Size(177, 21);
            lblSeleccionTitulo.TabIndex = 3;
            lblSeleccionTitulo.Text = "Turno seleccionado";

            // lblTurnoNumero
            lblTurnoNumero.AutoSize = true;
            lblTurnoNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoNumero.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoNumero.Location = new Point(30, 238);
            lblTurnoNumero.Name = "lblTurnoNumero";
            lblTurnoNumero.Size = new Size(71, 15);
            lblTurnoNumero.TabIndex = 4;
            lblTurnoNumero.Text = "Nro. turno";

            // lblTurnoNumeroValor
            lblTurnoNumeroValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoNumeroValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnoNumeroValor.Location = new Point(30, 256);
            lblTurnoNumeroValor.Name = "lblTurnoNumeroValor";
            lblTurnoNumeroValor.Size = new Size(226, 22);
            lblTurnoNumeroValor.TabIndex = 9;
            lblTurnoNumeroValor.Text = "Sin selección";

            // lblTurnoPaciente
            lblTurnoPaciente.AutoSize = true;
            lblTurnoPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoPaciente.Location = new Point(30, 292);
            lblTurnoPaciente.Name = "lblTurnoPaciente";
            lblTurnoPaciente.Size = new Size(51, 15);
            lblTurnoPaciente.TabIndex = 5;
            lblTurnoPaciente.Text = "Paciente";

            // lblTurnoPacienteValor
            lblTurnoPacienteValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurnoPacienteValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnoPacienteValor.Location = new Point(30, 310);
            lblTurnoPacienteValor.Name = "lblTurnoPacienteValor";
            lblTurnoPacienteValor.Size = new Size(226, 41);
            lblTurnoPacienteValor.TabIndex = 10;
            lblTurnoPacienteValor.Text = "-";

            // lblTurnoFecha
            lblTurnoFecha.AutoSize = true;
            lblTurnoFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoFecha.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoFecha.Location = new Point(30, 359);
            lblTurnoFecha.Name = "lblTurnoFecha";
            lblTurnoFecha.Size = new Size(90, 15);
            lblTurnoFecha.TabIndex = 6;
            lblTurnoFecha.Text = "Fecha y horario";

            // lblTurnoFechaValor
            lblTurnoFechaValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurnoFechaValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnoFechaValor.Location = new Point(30, 377);
            lblTurnoFechaValor.Name = "lblTurnoFechaValor";
            lblTurnoFechaValor.Size = new Size(226, 22);
            lblTurnoFechaValor.TabIndex = 11;
            lblTurnoFechaValor.Text = "-";

            // lblTurnoEstado
            lblTurnoEstado.AutoSize = true;
            lblTurnoEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoEstado.Location = new Point(30, 413);
            lblTurnoEstado.Name = "lblTurnoEstado";
            lblTurnoEstado.Size = new Size(42, 15);
            lblTurnoEstado.TabIndex = 7;
            lblTurnoEstado.Text = "Estado";

            // lblTurnoEstadoValor
            lblTurnoEstadoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoEstadoValor.Location = new Point(30, 431);
            lblTurnoEstadoValor.Name = "lblTurnoEstadoValor";
            lblTurnoEstadoValor.Size = new Size(226, 22);
            lblTurnoEstadoValor.TabIndex = 12;
            lblTurnoEstadoValor.Text = "-";

            // lblTurnoCanal
            lblTurnoCanal.AutoSize = true;
            lblTurnoCanal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoCanal.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoCanal.Location = new Point(30, 467);
            lblTurnoCanal.Name = "lblTurnoCanal";
            lblTurnoCanal.Size = new Size(101, 15);
            lblTurnoCanal.TabIndex = 8;
            lblTurnoCanal.Text = "Canal / condición";

            // lblTurnoCanalValor
            lblTurnoCanalValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurnoCanalValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnoCanalValor.Location = new Point(30, 485);
            lblTurnoCanalValor.Name = "lblTurnoCanalValor";
            lblTurnoCanalValor.Size = new Size(226, 45);
            lblTurnoCanalValor.TabIndex = 13;
            lblTurnoCanalValor.Text = "-";

            // btnCerrar
            btnCerrar.BackColor = Color.White;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(26, 82, 150);
            btnCerrar.Location = new Point(24, 612);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 42);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;

            // pnlContenido
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(gbListado);
            pnlContenido.Controls.Add(pnlAccionesSeleccionado);
            pnlContenido.Controls.Add(gbDatosTurno);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;

            // pnlEncabezado
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 135);
            pnlEncabezado.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de turnos";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 68);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(500, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registre nuevos turnos y gestione las acciones sobre los ya asignados.";

            // lblSeccion
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 102);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(220, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Agenda y seguimiento de citas";

            // gbDatosTurno
            gbDatosTurno.BackColor = Color.White;
            gbDatosTurno.BorderStyle = BorderStyle.FixedSingle;
            gbDatosTurno.Controls.Add(btnLimpiar);
            gbDatosTurno.Controls.Add(btnReprogramar);
            gbDatosTurno.Controls.Add(btnAsignar);
            gbDatosTurno.Controls.Add(lblAgendaDetalle);
            gbDatosTurno.Controls.Add(lblAgendaResumenTitulo);
            gbDatosTurno.Controls.Add(txtObservaciones);
            gbDatosTurno.Controls.Add(chkSobreturno);
            gbDatosTurno.Controls.Add(cmbCanal);
            gbDatosTurno.Controls.Add(dtpHoraTurno);
            gbDatosTurno.Controls.Add(cmbAgenda);
            gbDatosTurno.Controls.Add(cmbPaciente);
            gbDatosTurno.Controls.Add(lblObservaciones);
            gbDatosTurno.Controls.Add(lblCanal);
            gbDatosTurno.Controls.Add(lblHoraTurno);
            gbDatosTurno.Controls.Add(lblAgenda);
            gbDatosTurno.Controls.Add(lblPaciente);
            gbDatosTurno.Location = new Point(28, 150);
            gbDatosTurno.Name = "gbDatosTurno";
            gbDatosTurno.Size = new Size(550, 258);
            gbDatosTurno.TabIndex = 1;

            // lblPaciente
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblPaciente.Location = new Point(18, 16);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(51, 15);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Paciente";

            // cmbPaciente
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(150, 13);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(378, 23);
            cmbPaciente.TabIndex = 5;

            // lblAgenda
            lblAgenda.AutoSize = true;
            lblAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgenda.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgenda.Location = new Point(18, 48);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(46, 15);
            lblAgenda.TabIndex = 1;
            lblAgenda.Text = "Agenda";

            // cmbAgenda
            cmbAgenda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgenda.FormattingEnabled = true;
            cmbAgenda.Location = new Point(150, 45);
            cmbAgenda.Name = "cmbAgenda";
            cmbAgenda.Size = new Size(378, 23);
            cmbAgenda.DropDownWidth = 620;
            cmbAgenda.IntegralHeight = false;
            cmbAgenda.MaxDropDownItems = 8;
            cmbAgenda.TabIndex = 6;

            // lblHoraTurno
            lblHoraTurno.AutoSize = true;
            lblHoraTurno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraTurno.ForeColor = Color.FromArgb(26, 82, 150);
            lblHoraTurno.Location = new Point(18, 80);
            lblHoraTurno.Name = "lblHoraTurno";
            lblHoraTurno.Size = new Size(95, 15);
            lblHoraTurno.TabIndex = 2;
            lblHoraTurno.Text = "Hora del turno";

            // dtpHoraTurno
            dtpHoraTurno.CustomFormat = "HH:mm";
            dtpHoraTurno.Format = DateTimePickerFormat.Custom;
            dtpHoraTurno.Location = new Point(150, 77);
            dtpHoraTurno.Name = "dtpHoraTurno";
            dtpHoraTurno.ShowUpDown = true;
            dtpHoraTurno.Size = new Size(145, 23);
            dtpHoraTurno.TabIndex = 7;

            // lblCanal
            lblCanal.AutoSize = true;
            lblCanal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanal.ForeColor = Color.FromArgb(26, 82, 150);
            lblCanal.Location = new Point(315, 80);
            lblCanal.Name = "lblCanal";
            lblCanal.Size = new Size(113, 15);
            lblCanal.TabIndex = 3;
            lblCanal.Text = "Canal";

            // cmbCanal
            cmbCanal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanal.FormattingEnabled = true;
            cmbCanal.Location = new Point(383, 77);
            cmbCanal.Name = "cmbCanal";
            cmbCanal.Size = new Size(145, 23);
            cmbCanal.TabIndex = 8;

            // chkSobreturno
            chkSobreturno.AutoSize = true;
            chkSobreturno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkSobreturno.ForeColor = Color.FromArgb(42, 58, 92);
            chkSobreturno.Location = new Point(315, 110);
            chkSobreturno.Name = "chkSobreturno";
            chkSobreturno.Size = new Size(91, 19);
            chkSobreturno.TabIndex = 9;
            chkSobreturno.Text = "Sobreturno";
            chkSobreturno.UseVisualStyleBackColor = true;

            // lblAgendaResumenTitulo
            lblAgendaResumenTitulo.AutoSize = true;
            lblAgendaResumenTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaResumenTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaResumenTitulo.Location = new Point(18, 148);
            lblAgendaResumenTitulo.Name = "lblAgendaResumenTitulo";
            lblAgendaResumenTitulo.Size = new Size(103, 15);
            lblAgendaResumenTitulo.TabIndex = 11;
            lblAgendaResumenTitulo.Text = "Resumen agenda";

            // lblAgendaDetalle
            lblAgendaDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaDetalle.ForeColor = Color.FromArgb(42, 58, 92);
            lblAgendaDetalle.Location = new Point(150, 146);
            lblAgendaDetalle.Name = "lblAgendaDetalle";
            lblAgendaDetalle.Size = new Size(378, 48);
            lblAgendaDetalle.TabIndex = 12;
            lblAgendaDetalle.Text = "Sin agenda seleccionada";

            // lblObservaciones
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblObservaciones.ForeColor = Color.FromArgb(26, 82, 150);
            lblObservaciones.Location = new Point(18, 112);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(83, 15);
            lblObservaciones.TabIndex = 4;
            lblObservaciones.Text = "Observaciones";

            // txtObservaciones
            txtObservaciones.Location = new Point(150, 109);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(145, 33);
            txtObservaciones.TabIndex = 10;

            // btnAsignar
            btnAsignar.BackColor = Color.FromArgb(26, 82, 150);
            btnAsignar.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignar.ForeColor = Color.White;
            btnAsignar.Location = new Point(150, 211);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(118, 28);
            btnAsignar.TabIndex = 13;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;

            // btnReprogramar
            btnReprogramar.BackColor = Color.FromArgb(243, 239, 255);
            btnReprogramar.FlatAppearance.BorderColor = Color.FromArgb(213, 203, 245);
            btnReprogramar.FlatStyle = FlatStyle.Flat;
            btnReprogramar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnReprogramar.ForeColor = Color.FromArgb(106, 78, 181);
            btnReprogramar.Location = new Point(281, 211);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(118, 28);
            btnReprogramar.TabIndex = 14;
            btnReprogramar.Text = "Reprogramar";
            btnReprogramar.UseVisualStyleBackColor = false;
            btnReprogramar.Click += btnReprogramar_Click;

            // btnLimpiar
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(410, 211);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 28);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            // pnlAccionesSeleccionado
            pnlAccionesSeleccionado.BackColor = Color.White;
            pnlAccionesSeleccionado.BorderStyle = BorderStyle.FixedSingle;
            pnlAccionesSeleccionado.Controls.Add(btnCancelar);
            pnlAccionesSeleccionado.Controls.Add(btnConfirmar);
            pnlAccionesSeleccionado.Controls.Add(btnRecordar);
            pnlAccionesSeleccionado.Location = new Point(600, 150);
            pnlAccionesSeleccionado.Name = "pnlAccionesSeleccionado";
            pnlAccionesSeleccionado.Size = new Size(212, 258);
            pnlAccionesSeleccionado.TabIndex = 2;

            // btnRecordar
            btnRecordar.BackColor = Color.FromArgb(255, 250, 232);
            btnRecordar.FlatAppearance.BorderColor = Color.FromArgb(234, 223, 181);
            btnRecordar.FlatStyle = FlatStyle.Flat;
            btnRecordar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecordar.ForeColor = Color.FromArgb(147, 112, 31);
            btnRecordar.Location = new Point(18, 39);
            btnRecordar.Name = "btnRecordar";
            btnRecordar.Size = new Size(174, 42);
            btnRecordar.TabIndex = 0;
            btnRecordar.Text = "Enviar recordatorio";
            btnRecordar.UseVisualStyleBackColor = false;
            btnRecordar.Click += btnRecordar_Click;

            // btnConfirmar
            btnConfirmar.BackColor = Color.FromArgb(236, 248, 240);
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(194, 223, 203);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.FromArgb(34, 122, 83);
            btnConfirmar.Location = new Point(18, 94);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(174, 42);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;

            // btnCancelar
            btnCancelar.BackColor = Color.FromArgb(252, 241, 241);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(232, 201, 201);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(136, 58, 58);
            btnCancelar.Location = new Point(18, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(174, 42);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar turno";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;

            // gbListado
            gbListado.BackColor = Color.White;
            gbListado.BorderStyle = BorderStyle.FixedSingle;
            gbListado.Controls.Add(dgvTurnos);
            gbListado.Controls.Add(lblCantidadTurnos);
            gbListado.Controls.Add(lblListadoTitulo);
            gbListado.Location = new Point(28, 430);
            gbListado.Name = "gbListado";
            gbListado.Size = new Size(784, 216);
            gbListado.TabIndex = 3;

            // lblListadoTitulo
            lblListadoTitulo.AutoSize = true;
            lblListadoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblListadoTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblListadoTitulo.Location = new Point(16, 9);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(208, 21);
            lblListadoTitulo.TabIndex = 0;
            lblListadoTitulo.Text = "Turnos registrados en lista";

            // lblCantidadTurnos
            lblCantidadTurnos.AutoSize = true;
            lblCantidadTurnos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadTurnos.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadTurnos.Location = new Point(18, 32);
            lblCantidadTurnos.Name = "lblCantidadTurnos";
            lblCantidadTurnos.Size = new Size(163, 15);
            lblCantidadTurnos.TabIndex = 1;
            lblCantidadTurnos.Text = "Total de turnos registrados: 0";

            // dgvTurnos
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(18, 54);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.Size = new Size(746, 140);
            dgvTurnos.TabIndex = 2;
            dgvTurnos.CellClick += dgvTurnos_CellClick;

            // FrmTurnos
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTurnos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Turnos - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            gbListado.ResumeLayout(false);
            gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            pnlAccionesSeleccionado.ResumeLayout(false);
            gbDatosTurno.ResumeLayout(false);
            gbDatosTurno.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}