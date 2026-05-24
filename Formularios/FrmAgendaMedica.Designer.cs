namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmAgendaMedica
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel gbDatosAgenda;
        private Panel pnlProfesionalInfo;
        private Panel gbListado;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblSeleccionTitulo;
        private Label lblAgendaId;
        private Label lblAgendaProfesional;
        private Label lblAgendaEspecialidad;
        private Label lblAgendaConsultorio;
        private Label lblAgendaFecha;
        private Label lblAgendaEstado;
        private Label lblAgendaIdValor;
        private Label lblAgendaProfesionalValor;
        private Label lblAgendaEspecialidadValor;
        private Label lblAgendaConsultorioValor;
        private Label lblAgendaFechaValor;
        private Label lblAgendaEstadoValor;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblProfesional;
        private Label lblEspecialidad;
        private Label lblConsultorio;
        private Label lblFecha;
        private Label lblHoraInicio;
        private Label lblHoraFin;
        private Label lblEstado;
        private Label lblProfesionalInfoTitulo;
        private Label lblProfesionalDetalle;
        private Label lblListadoTitulo;
        private Label lblCantidadAgendas;
        private ComboBox cmbProfesional;
        private ComboBox cmbEspecialidad;
        private ComboBox cmbConsultorio;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private DataGridView dgvAgenda;

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
            lblAgendaEstadoValor = new Label();
            lblAgendaFechaValor = new Label();
            lblAgendaConsultorioValor = new Label();
            lblAgendaEspecialidadValor = new Label();
            lblAgendaProfesionalValor = new Label();
            lblAgendaIdValor = new Label();
            lblAgendaEstado = new Label();
            lblAgendaFecha = new Label();
            lblAgendaConsultorio = new Label();
            lblAgendaEspecialidad = new Label();
            lblAgendaProfesional = new Label();
            lblAgendaId = new Label();
            lblSeleccionTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            btnCerrar = new Button();
            pnlContenido = new Panel();
            gbListado = new Panel();
            dgvAgenda = new DataGridView();
            lblCantidadAgendas = new Label();
            lblListadoTitulo = new Label();
            pnlProfesionalInfo = new Panel();
            lblProfesionalDetalle = new Label();
            lblProfesionalInfoTitulo = new Label();
            gbDatosAgenda = new Panel();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            cmbEstado = new ComboBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            cmbConsultorio = new ComboBox();
            cmbEspecialidad = new ComboBox();
            cmbProfesional = new ComboBox();
            lblEstado = new Label();
            lblHoraFin = new Label();
            lblHoraInicio = new Label();
            lblFecha = new Label();
            lblConsultorio = new Label();
            lblEspecialidad = new Label();
            lblProfesional = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            pnlProfesionalInfo.SuspendLayout();
            gbDatosAgenda.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(lblAgendaEstadoValor);
            pnlLateral.Controls.Add(lblAgendaFechaValor);
            pnlLateral.Controls.Add(lblAgendaConsultorioValor);
            pnlLateral.Controls.Add(lblAgendaEspecialidadValor);
            pnlLateral.Controls.Add(lblAgendaProfesionalValor);
            pnlLateral.Controls.Add(lblAgendaIdValor);
            pnlLateral.Controls.Add(lblAgendaEstado);
            pnlLateral.Controls.Add(lblAgendaFecha);
            pnlLateral.Controls.Add(lblAgendaConsultorio);
            pnlLateral.Controls.Add(lblAgendaEspecialidad);
            pnlLateral.Controls.Add(lblAgendaProfesional);
            pnlLateral.Controls.Add(lblAgendaId);
            pnlLateral.Controls.Add(lblSeleccionTitulo);
            pnlLateral.Controls.Add(lblPanelTexto);
            pnlLateral.Controls.Add(lblPanelTitulo);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;
            // 
            // lblAgendaEstadoValor
            // 
            lblAgendaEstadoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaEstadoValor.Location = new Point(31, 528);
            lblAgendaEstadoValor.Name = "lblAgendaEstadoValor";
            lblAgendaEstadoValor.Size = new Size(216, 22);
            lblAgendaEstadoValor.TabIndex = 15;
            lblAgendaEstadoValor.Text = "-";
            // 
            // lblAgendaFechaValor
            // 
            lblAgendaFechaValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaFechaValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaFechaValor.Location = new Point(31, 475);
            lblAgendaFechaValor.Name = "lblAgendaFechaValor";
            lblAgendaFechaValor.Size = new Size(216, 22);
            lblAgendaFechaValor.TabIndex = 14;
            lblAgendaFechaValor.Text = "-";
            // 
            // lblAgendaConsultorioValor
            // 
            lblAgendaConsultorioValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaConsultorioValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaConsultorioValor.Location = new Point(31, 407);
            lblAgendaConsultorioValor.Name = "lblAgendaConsultorioValor";
            lblAgendaConsultorioValor.Size = new Size(216, 46);
            lblAgendaConsultorioValor.TabIndex = 13;
            lblAgendaConsultorioValor.Text = "-";
            // 
            // lblAgendaEspecialidadValor
            // 
            lblAgendaEspecialidadValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaEspecialidadValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaEspecialidadValor.Location = new Point(31, 354);
            lblAgendaEspecialidadValor.Name = "lblAgendaEspecialidadValor";
            lblAgendaEspecialidadValor.Size = new Size(216, 22);
            lblAgendaEspecialidadValor.TabIndex = 12;
            lblAgendaEspecialidadValor.Text = "-";
            // 
            // lblAgendaProfesionalValor
            // 
            lblAgendaProfesionalValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgendaProfesionalValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaProfesionalValor.Location = new Point(31, 301);
            lblAgendaProfesionalValor.Name = "lblAgendaProfesionalValor";
            lblAgendaProfesionalValor.Size = new Size(216, 35);
            lblAgendaProfesionalValor.TabIndex = 11;
            lblAgendaProfesionalValor.Text = "-";
            // 
            // lblAgendaIdValor
            // 
            lblAgendaIdValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaIdValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAgendaIdValor.Location = new Point(31, 248);
            lblAgendaIdValor.Name = "lblAgendaIdValor";
            lblAgendaIdValor.Size = new Size(216, 22);
            lblAgendaIdValor.TabIndex = 10;
            lblAgendaIdValor.Text = "Sin selección";
            // 
            // lblAgendaEstado
            // 
            lblAgendaEstado.AutoSize = true;
            lblAgendaEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaEstado.Location = new Point(31, 510);
            lblAgendaEstado.Name = "lblAgendaEstado";
            lblAgendaEstado.Size = new Size(43, 15);
            lblAgendaEstado.TabIndex = 9;
            lblAgendaEstado.Text = "Estado";
            // 
            // lblAgendaFecha
            // 
            lblAgendaFecha.AutoSize = true;
            lblAgendaFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaFecha.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaFecha.Location = new Point(31, 457);
            lblAgendaFecha.Name = "lblAgendaFecha";
            lblAgendaFecha.Size = new Size(91, 15);
            lblAgendaFecha.TabIndex = 8;
            lblAgendaFecha.Text = "Fecha y horario";
            // 
            // lblAgendaConsultorio
            // 
            lblAgendaConsultorio.AutoSize = true;
            lblAgendaConsultorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaConsultorio.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaConsultorio.Location = new Point(31, 389);
            lblAgendaConsultorio.Name = "lblAgendaConsultorio";
            lblAgendaConsultorio.Size = new Size(70, 15);
            lblAgendaConsultorio.TabIndex = 7;
            lblAgendaConsultorio.Text = "Consultorio";
            // 
            // lblAgendaEspecialidad
            // 
            lblAgendaEspecialidad.AutoSize = true;
            lblAgendaEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaEspecialidad.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaEspecialidad.Location = new Point(31, 336);
            lblAgendaEspecialidad.Name = "lblAgendaEspecialidad";
            lblAgendaEspecialidad.Size = new Size(73, 15);
            lblAgendaEspecialidad.TabIndex = 6;
            lblAgendaEspecialidad.Text = "Especialidad";
            // 
            // lblAgendaProfesional
            // 
            lblAgendaProfesional.AutoSize = true;
            lblAgendaProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaProfesional.Location = new Point(31, 283);
            lblAgendaProfesional.Name = "lblAgendaProfesional";
            lblAgendaProfesional.Size = new Size(69, 15);
            lblAgendaProfesional.TabIndex = 5;
            lblAgendaProfesional.Text = "Profesional";
            // 
            // lblAgendaId
            // 
            lblAgendaId.AutoSize = true;
            lblAgendaId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgendaId.ForeColor = Color.FromArgb(26, 82, 150);
            lblAgendaId.Location = new Point(31, 230);
            lblAgendaId.Name = "lblAgendaId";
            lblAgendaId.Size = new Size(49, 15);
            lblAgendaId.TabIndex = 4;
            lblAgendaId.Text = "Agenda";
            // 
            // lblSeleccionTitulo
            // 
            lblSeleccionTitulo.AutoSize = true;
            lblSeleccionTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblSeleccionTitulo.Location = new Point(25, 190);
            lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            lblSeleccionTitulo.Size = new Size(172, 21);
            lblSeleccionTitulo.TabIndex = 3;
            lblSeleccionTitulo.Text = "Agenda seleccionada";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(25, 91);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(225, 78);
            lblPanelTexto.TabIndex = 2;
            lblPanelTexto.Text = "Defina la disponibilidad de profesionales, especialidades, consultorios y franjas horarias.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(25, 38);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(159, 37);
            lblPanelTitulo.TabIndex = 1;
            lblPanelTitulo.Text = "📅 Agenda";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(26, 82, 150);
            btnCerrar.Location = new Point(24, 614);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(gbListado);
            pnlContenido.Controls.Add(pnlProfesionalInfo);
            pnlContenido.Controls.Add(gbDatosAgenda);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;
            // 
            // gbListado
            // 
            gbListado.BackColor = Color.White;
            gbListado.BorderStyle = BorderStyle.FixedSingle;
            gbListado.Controls.Add(dgvAgenda);
            gbListado.Controls.Add(lblCantidadAgendas);
            gbListado.Controls.Add(lblListadoTitulo);
            gbListado.Location = new Point(28, 408);
            gbListado.Name = "gbListado";
            gbListado.Size = new Size(784, 257);
            gbListado.TabIndex = 3;
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(18, 64);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.RowTemplate.Height = 25;
            dgvAgenda.Size = new Size(746, 184);
            dgvAgenda.TabIndex = 2;
            dgvAgenda.CellClick += dgvAgenda_CellClick;
            // 
            // lblCantidadAgendas
            // 
            lblCantidadAgendas.AutoSize = true;
            lblCantidadAgendas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadAgendas.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadAgendas.Location = new Point(18, 42);
            lblCantidadAgendas.Name = "lblCantidadAgendas";
            lblCantidadAgendas.Size = new Size(157, 15);
            lblCantidadAgendas.TabIndex = 1;
            lblCantidadAgendas.Text = "Total de agendas cargadas: 0";
            // 
            // lblListadoTitulo
            // 
            lblListadoTitulo.AutoSize = true;
            lblListadoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblListadoTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblListadoTitulo.Location = new Point(16, 20);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(215, 21);
            lblListadoTitulo.TabIndex = 0;
            lblListadoTitulo.Text = "Agendas médicas cargadas";
            // 
            // pnlProfesionalInfo
            // 
            pnlProfesionalInfo.BackColor = Color.FromArgb(238, 246, 255);
            pnlProfesionalInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlProfesionalInfo.Controls.Add(lblProfesionalDetalle);
            pnlProfesionalInfo.Controls.Add(lblProfesionalInfoTitulo);
            pnlProfesionalInfo.Location = new Point(555, 165);
            pnlProfesionalInfo.Name = "pnlProfesionalInfo";
            pnlProfesionalInfo.Size = new Size(257, 226);
            pnlProfesionalInfo.TabIndex = 2;
            // 
            // lblProfesionalDetalle
            // 
            lblProfesionalDetalle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesionalDetalle.ForeColor = Color.FromArgb(42, 58, 92);
            lblProfesionalDetalle.Location = new Point(18, 48);
            lblProfesionalDetalle.Name = "lblProfesionalDetalle";
            lblProfesionalDetalle.Size = new Size(218, 160);
            lblProfesionalDetalle.TabIndex = 1;
            lblProfesionalDetalle.Text = "Seleccione un profesional para ver su disponibilidad.";
            // 
            // lblProfesionalInfoTitulo
            // 
            lblProfesionalInfoTitulo.AutoSize = true;
            lblProfesionalInfoTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfesionalInfoTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblProfesionalInfoTitulo.Location = new Point(18, 18);
            lblProfesionalInfoTitulo.Name = "lblProfesionalInfoTitulo";
            lblProfesionalInfoTitulo.Size = new Size(158, 20);
            lblProfesionalInfoTitulo.TabIndex = 0;
            lblProfesionalInfoTitulo.Text = "Datos del profesional";
            // 
            // gbDatosAgenda
            // 
            gbDatosAgenda.BackColor = Color.White;
            gbDatosAgenda.BorderStyle = BorderStyle.FixedSingle;
            gbDatosAgenda.Controls.Add(btnLimpiar);
            gbDatosAgenda.Controls.Add(btnGuardar);
            gbDatosAgenda.Controls.Add(cmbEstado);
            gbDatosAgenda.Controls.Add(dtpHoraFin);
            gbDatosAgenda.Controls.Add(dtpHoraInicio);
            gbDatosAgenda.Controls.Add(dtpFecha);
            gbDatosAgenda.Controls.Add(cmbConsultorio);
            gbDatosAgenda.Controls.Add(cmbEspecialidad);
            gbDatosAgenda.Controls.Add(cmbProfesional);
            gbDatosAgenda.Controls.Add(lblEstado);
            gbDatosAgenda.Controls.Add(lblHoraFin);
            gbDatosAgenda.Controls.Add(lblHoraInicio);
            gbDatosAgenda.Controls.Add(lblFecha);
            gbDatosAgenda.Controls.Add(lblConsultorio);
            gbDatosAgenda.Controls.Add(lblEspecialidad);
            gbDatosAgenda.Controls.Add(lblProfesional);
            gbDatosAgenda.Location = new Point(28, 165);
            gbDatosAgenda.Name = "gbDatosAgenda";
            gbDatosAgenda.Size = new Size(500, 226);
            gbDatosAgenda.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(352, 184);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 32);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 82, 150);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(200, 184);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 32);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar agenda";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(200, 152);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(119, 23);
            cmbEstado.TabIndex = 13;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(390, 109);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(87, 23);
            dtpHoraFin.TabIndex = 12;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(200, 109);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(87, 23);
            dtpHoraInicio.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(200, 65);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(119, 23);
            dtpFecha.TabIndex = 10;
            // 
            // cmbConsultorio
            // 
            cmbConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsultorio.FormattingEnabled = true;
            cmbConsultorio.Location = new Point(200, 20);
            cmbConsultorio.Name = "cmbConsultorio";
            cmbConsultorio.Size = new Size(277, 23);
            cmbConsultorio.TabIndex = 9;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(20, 152);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(154, 23);
            cmbEspecialidad.TabIndex = 8;
            // 
            // cmbProfesional
            // 
            cmbProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfesional.FormattingEnabled = true;
            cmbProfesional.Location = new Point(20, 65);
            cmbProfesional.Name = "cmbProfesional";
            cmbProfesional.Size = new Size(154, 23);
            cmbProfesional.TabIndex = 7;
            cmbProfesional.SelectedIndexChanged += cmbProfesional_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstado.Location = new Point(200, 134);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(43, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraFin.ForeColor = Color.FromArgb(26, 82, 150);
            lblHoraFin.Location = new Point(390, 91);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(52, 15);
            lblHoraFin.TabIndex = 5;
            lblHoraFin.Text = "Hora fin";
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraInicio.ForeColor = Color.FromArgb(26, 82, 150);
            lblHoraInicio.Location = new Point(200, 91);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(66, 15);
            lblHoraInicio.TabIndex = 4;
            lblHoraInicio.Text = "Hora inicio";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(26, 82, 150);
            lblFecha.Location = new Point(200, 47);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(39, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha";
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConsultorio.ForeColor = Color.FromArgb(26, 82, 150);
            lblConsultorio.Location = new Point(200, 3);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(70, 15);
            lblConsultorio.TabIndex = 2;
            lblConsultorio.Text = "Consultorio";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEspecialidad.ForeColor = Color.FromArgb(26, 82, 150);
            lblEspecialidad.Location = new Point(20, 134);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(73, 15);
            lblEspecialidad.TabIndex = 1;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblProfesional.Location = new Point(20, 47);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(69, 15);
            lblProfesional.TabIndex = 0;
            lblProfesional.Text = "Profesional";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 140);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 106);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(194, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Disponibilidad para turnos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(457, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Cargue las franjas horarias disponibles para la asignación de turnos.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(356, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de agenda médica";
            // 
            // FrmAgendaMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAgendaMedica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agenda médica - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            gbListado.ResumeLayout(false);
            gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            pnlProfesionalInfo.ResumeLayout(false);
            pnlProfesionalInfo.PerformLayout();
            gbDatosAgenda.ResumeLayout(false);
            gbDatosAgenda.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}
