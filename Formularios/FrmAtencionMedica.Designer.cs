namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmAtencionMedica
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel pnlTurnos;
        private Panel pnlRegistro;
        private Panel pnlAcciones;

        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblResumenTitulo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblTurnosTitulo;
        private Label lblCantidadTurnos;
        private Label lblRegistroTitulo;

        private Label lblPaciente;
        private Label lblPacienteDato;
        private Label lblDocumento;
        private Label lblDocumentoDato;
        private Label lblProfesional;
        private Label lblProfesionalDato;
        private Label lblEspecialidad;
        private Label lblEspecialidadDato;
        private Label lblFechaHora;
        private Label lblFechaHoraDato;
        private Label lblEstadoTurno;
        private Label lblEstadoTurnoDato;
        private Label lblHistoriaClinica;
        private Label lblHistoriaClinicaDato;
        private Label lblAtencionesPrevias;
        private Label lblAtencionesPreviasDato;
        private Label lblEstadoAtencion;
        private Label lblEstadoAtencionDato;

        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Label lblIndicaciones;
        private TextBox txtIndicaciones;
        private Label lblObservaciones;
        private TextBox txtObservaciones;

        private CheckBox chkRequiereNuevoTurno;
        private CheckBox chkDerivacionAEstudio;

        private Button btnRegistrarAtencion;
        private Button btnCerrarConsulta;
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
            btnCerrar = new Button();
            lblEstadoAtencionDato = new Label();
            lblEstadoAtencion = new Label();
            lblAtencionesPreviasDato = new Label();
            lblAtencionesPrevias = new Label();
            lblHistoriaClinicaDato = new Label();
            lblHistoriaClinica = new Label();
            lblEstadoTurnoDato = new Label();
            lblEstadoTurno = new Label();
            lblFechaHoraDato = new Label();
            lblFechaHora = new Label();
            lblEspecialidadDato = new Label();
            lblEspecialidad = new Label();
            lblProfesionalDato = new Label();
            lblProfesional = new Label();
            lblDocumentoDato = new Label();
            lblDocumento = new Label();
            lblPacienteDato = new Label();
            lblPaciente = new Label();
            lblResumenTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            pnlContenido = new Panel();
            pnlRegistro = new Panel();
            pnlAcciones = new Panel();
            btnLimpiar = new Button();
            btnCerrarConsulta = new Button();
            btnRegistrarAtencion = new Button();
            chkDerivacionAEstudio = new CheckBox();
            chkRequiereNuevoTurno = new CheckBox();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            txtIndicaciones = new TextBox();
            lblIndicaciones = new Label();
            txtDiagnostico = new TextBox();
            lblDiagnostico = new Label();
            lblRegistroTitulo = new Label();
            pnlTurnos = new Panel();
            dgvTurnos = new DataGridView();
            lblCantidadTurnos = new Label();
            lblTurnosTitulo = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlRegistro.SuspendLayout();
            pnlAcciones.SuspendLayout();
            pnlTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Controls.Add(lblEstadoAtencionDato);
            pnlLateral.Controls.Add(lblEstadoAtencion);
            pnlLateral.Controls.Add(lblAtencionesPreviasDato);
            pnlLateral.Controls.Add(lblAtencionesPrevias);
            pnlLateral.Controls.Add(lblHistoriaClinicaDato);
            pnlLateral.Controls.Add(lblHistoriaClinica);
            pnlLateral.Controls.Add(lblEstadoTurnoDato);
            pnlLateral.Controls.Add(lblEstadoTurno);
            pnlLateral.Controls.Add(lblFechaHoraDato);
            pnlLateral.Controls.Add(lblFechaHora);
            pnlLateral.Controls.Add(lblEspecialidadDato);
            pnlLateral.Controls.Add(lblEspecialidad);
            pnlLateral.Controls.Add(lblProfesionalDato);
            pnlLateral.Controls.Add(lblProfesional);
            pnlLateral.Controls.Add(lblDocumentoDato);
            pnlLateral.Controls.Add(lblDocumento);
            pnlLateral.Controls.Add(lblPacienteDato);
            pnlLateral.Controls.Add(lblPaciente);
            pnlLateral.Controls.Add(lblResumenTitulo);
            pnlLateral.Controls.Add(lblPanelTexto);
            pnlLateral.Controls.Add(lblPanelTitulo);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(26, 82, 150);
            btnCerrar.Location = new Point(24, 617);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 38);
            btnCerrar.TabIndex = 21;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstadoAtencionDato
            // 
            lblEstadoAtencionDato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoAtencionDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstadoAtencionDato.Location = new Point(31, 570);
            lblEstadoAtencionDato.Name = "lblEstadoAtencionDato";
            lblEstadoAtencionDato.Size = new Size(222, 24);
            lblEstadoAtencionDato.TabIndex = 20;
            lblEstadoAtencionDato.Text = "-";
            // 
            // lblEstadoAtencion
            // 
            lblEstadoAtencion.AutoSize = true;
            lblEstadoAtencion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoAtencion.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstadoAtencion.Location = new Point(31, 552);
            lblEstadoAtencion.Name = "lblEstadoAtencion";
            lblEstadoAtencion.Size = new Size(94, 15);
            lblEstadoAtencion.TabIndex = 19;
            lblEstadoAtencion.Text = "Estado atención";
            // 
            // lblAtencionesPreviasDato
            // 
            lblAtencionesPreviasDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencionesPreviasDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblAtencionesPreviasDato.Location = new Point(31, 528);
            lblAtencionesPreviasDato.Name = "lblAtencionesPreviasDato";
            lblAtencionesPreviasDato.Size = new Size(222, 19);
            lblAtencionesPreviasDato.TabIndex = 18;
            lblAtencionesPreviasDato.Text = "-";
            // 
            // lblAtencionesPrevias
            // 
            lblAtencionesPrevias.AutoSize = true;
            lblAtencionesPrevias.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionesPrevias.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionesPrevias.Location = new Point(31, 510);
            lblAtencionesPrevias.Name = "lblAtencionesPrevias";
            lblAtencionesPrevias.Size = new Size(112, 15);
            lblAtencionesPrevias.TabIndex = 17;
            lblAtencionesPrevias.Text = "Atenciones previas";
            // 
            // lblHistoriaClinicaDato
            // 
            lblHistoriaClinicaDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistoriaClinicaDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblHistoriaClinicaDato.Location = new Point(31, 486);
            lblHistoriaClinicaDato.Name = "lblHistoriaClinicaDato";
            lblHistoriaClinicaDato.Size = new Size(222, 19);
            lblHistoriaClinicaDato.TabIndex = 16;
            lblHistoriaClinicaDato.Text = "-";
            // 
            // lblHistoriaClinica
            // 
            lblHistoriaClinica.AutoSize = true;
            lblHistoriaClinica.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistoriaClinica.ForeColor = Color.FromArgb(26, 82, 150);
            lblHistoriaClinica.Location = new Point(31, 468);
            lblHistoriaClinica.Name = "lblHistoriaClinica";
            lblHistoriaClinica.Size = new Size(87, 15);
            lblHistoriaClinica.TabIndex = 15;
            lblHistoriaClinica.Text = "Historia clínica";
            // 
            // lblEstadoTurnoDato
            // 
            lblEstadoTurnoDato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTurnoDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstadoTurnoDato.Location = new Point(31, 444);
            lblEstadoTurnoDato.Name = "lblEstadoTurnoDato";
            lblEstadoTurnoDato.Size = new Size(222, 19);
            lblEstadoTurnoDato.TabIndex = 14;
            lblEstadoTurnoDato.Text = "-";
            // 
            // lblEstadoTurno
            // 
            lblEstadoTurno.AutoSize = true;
            lblEstadoTurno.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTurno.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstadoTurno.Location = new Point(31, 426);
            lblEstadoTurno.Name = "lblEstadoTurno";
            lblEstadoTurno.Size = new Size(77, 15);
            lblEstadoTurno.TabIndex = 13;
            lblEstadoTurno.Text = "Estado turno";
            // 
            // lblFechaHoraDato
            // 
            lblFechaHoraDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHoraDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblFechaHoraDato.Location = new Point(31, 402);
            lblFechaHoraDato.Name = "lblFechaHoraDato";
            lblFechaHoraDato.Size = new Size(222, 19);
            lblFechaHoraDato.TabIndex = 12;
            lblFechaHoraDato.Text = "-";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaHora.ForeColor = Color.FromArgb(26, 82, 150);
            lblFechaHora.Location = new Point(31, 384);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(91, 15);
            lblFechaHora.TabIndex = 11;
            lblFechaHora.Text = "Fecha y horario";
            // 
            // lblEspecialidadDato
            // 
            lblEspecialidadDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialidadDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblEspecialidadDato.Location = new Point(31, 360);
            lblEspecialidadDato.Name = "lblEspecialidadDato";
            lblEspecialidadDato.Size = new Size(222, 19);
            lblEspecialidadDato.TabIndex = 10;
            lblEspecialidadDato.Text = "-";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblEspecialidad.ForeColor = Color.FromArgb(26, 82, 150);
            lblEspecialidad.Location = new Point(31, 342);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(73, 15);
            lblEspecialidad.TabIndex = 9;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblProfesionalDato
            // 
            lblProfesionalDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesionalDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblProfesionalDato.Location = new Point(31, 318);
            lblProfesionalDato.Name = "lblProfesionalDato";
            lblProfesionalDato.Size = new Size(222, 19);
            lblProfesionalDato.TabIndex = 8;
            lblProfesionalDato.Text = "-";
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblProfesional.Location = new Point(31, 300);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(69, 15);
            lblProfesional.TabIndex = 7;
            lblProfesional.Text = "Profesional";
            // 
            // lblDocumentoDato
            // 
            lblDocumentoDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumentoDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblDocumentoDato.Location = new Point(31, 276);
            lblDocumentoDato.Name = "lblDocumentoDato";
            lblDocumentoDato.Size = new Size(222, 19);
            lblDocumentoDato.TabIndex = 6;
            lblDocumentoDato.Text = "-";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.ForeColor = Color.FromArgb(26, 82, 150);
            lblDocumento.Location = new Point(31, 258);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento";
            // 
            // lblPacienteDato
            // 
            lblPacienteDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPacienteDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteDato.Location = new Point(31, 222);
            lblPacienteDato.Name = "lblPacienteDato";
            lblPacienteDato.Size = new Size(222, 32);
            lblPacienteDato.TabIndex = 4;
            lblPacienteDato.Text = "-";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblPaciente.Location = new Point(31, 204);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(55, 15);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "Paciente";
            // 
            // lblResumenTitulo
            // 
            lblResumenTitulo.AutoSize = true;
            lblResumenTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResumenTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblResumenTitulo.Location = new Point(24, 165);
            lblResumenTitulo.Name = "lblResumenTitulo";
            lblResumenTitulo.Size = new Size(164, 21);
            lblResumenTitulo.TabIndex = 2;
            lblResumenTitulo.Text = "Datos de la consulta";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(24, 85);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(232, 66);
            lblPanelTexto.TabIndex = 1;
            lblPanelTexto.Text = "Seleccione un turno habilitado por recepción para registrar la atención   médica y cerrar la consulta.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(23, 36);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(261, 36);
            lblPanelTitulo.TabIndex = 0;
            lblPanelTitulo.Text = "⚕ Atención médica";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(pnlRegistro);
            pnlContenido.Controls.Add(pnlTurnos);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;
            // 
            // pnlRegistro
            // 
            pnlRegistro.BackColor = Color.White;
            pnlRegistro.BorderStyle = BorderStyle.FixedSingle;
            pnlRegistro.Controls.Add(pnlAcciones);
            pnlRegistro.Controls.Add(chkDerivacionAEstudio);
            pnlRegistro.Controls.Add(chkRequiereNuevoTurno);
            pnlRegistro.Controls.Add(txtObservaciones);
            pnlRegistro.Controls.Add(lblObservaciones);
            pnlRegistro.Controls.Add(txtIndicaciones);
            pnlRegistro.Controls.Add(lblIndicaciones);
            pnlRegistro.Controls.Add(txtDiagnostico);
            pnlRegistro.Controls.Add(lblDiagnostico);
            pnlRegistro.Controls.Add(lblRegistroTitulo);
            pnlRegistro.Location = new Point(28, 386);
            pnlRegistro.Name = "pnlRegistro";
            pnlRegistro.Size = new Size(784, 262);
            pnlRegistro.TabIndex = 2;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.FromArgb(248, 251, 255);
            pnlAcciones.BorderStyle = BorderStyle.FixedSingle;
            pnlAcciones.Controls.Add(btnLimpiar);
            pnlAcciones.Controls.Add(btnCerrarConsulta);
            pnlAcciones.Controls.Add(btnRegistrarAtencion);
            pnlAcciones.Location = new Point(562, 47);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(200, 195);
            pnlAcciones.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(17, 131);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(164, 36);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrarConsulta
            // 
            btnCerrarConsulta.BackColor = Color.FromArgb(236, 248, 240);
            btnCerrarConsulta.FlatAppearance.BorderColor = Color.FromArgb(194, 223, 203);
            btnCerrarConsulta.FlatStyle = FlatStyle.Flat;
            btnCerrarConsulta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarConsulta.ForeColor = Color.FromArgb(34, 122, 83);
            btnCerrarConsulta.Location = new Point(17, 78);
            btnCerrarConsulta.Name = "btnCerrarConsulta";
            btnCerrarConsulta.Size = new Size(164, 36);
            btnCerrarConsulta.TabIndex = 1;
            btnCerrarConsulta.Text = "Cerrar consulta";
            btnCerrarConsulta.UseVisualStyleBackColor = false;
            btnCerrarConsulta.Click += btnCerrarConsulta_Click;
            // 
            // btnRegistrarAtencion
            // 
            btnRegistrarAtencion.BackColor = Color.FromArgb(26, 82, 150);
            btnRegistrarAtencion.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnRegistrarAtencion.FlatStyle = FlatStyle.Flat;
            btnRegistrarAtencion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarAtencion.ForeColor = Color.White;
            btnRegistrarAtencion.Location = new Point(17, 25);
            btnRegistrarAtencion.Name = "btnRegistrarAtencion";
            btnRegistrarAtencion.Size = new Size(164, 36);
            btnRegistrarAtencion.TabIndex = 0;
            btnRegistrarAtencion.Text = "Registrar atención";
            btnRegistrarAtencion.UseVisualStyleBackColor = false;
            btnRegistrarAtencion.Click += btnRegistrarAtencion_Click;
            // 
            // chkDerivacionAEstudio
            // 
            chkDerivacionAEstudio.AutoSize = true;
            chkDerivacionAEstudio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkDerivacionAEstudio.ForeColor = Color.FromArgb(42, 58, 92);
            chkDerivacionAEstudio.Location = new Point(224, 224);
            chkDerivacionAEstudio.Name = "chkDerivacionAEstudio";
            chkDerivacionAEstudio.Size = new Size(133, 19);
            chkDerivacionAEstudio.TabIndex = 8;
            chkDerivacionAEstudio.Text = "Derivación a estudio";
            chkDerivacionAEstudio.UseVisualStyleBackColor = true;
            // 
            // chkRequiereNuevoTurno
            // 
            chkRequiereNuevoTurno.AutoSize = true;
            chkRequiereNuevoTurno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkRequiereNuevoTurno.ForeColor = Color.FromArgb(42, 58, 92);
            chkRequiereNuevoTurno.Location = new Point(44, 224);
            chkRequiereNuevoTurno.Name = "chkRequiereNuevoTurno";
            chkRequiereNuevoTurno.Size = new Size(140, 19);
            chkRequiereNuevoTurno.TabIndex = 7;
            chkRequiereNuevoTurno.Text = "Requiere nuevo turno";
            chkRequiereNuevoTurno.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(158, 162);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(381, 47);
            txtObservaciones.TabIndex = 6;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblObservaciones.ForeColor = Color.FromArgb(26, 82, 150);
            lblObservaciones.Location = new Point(43, 165);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(88, 15);
            lblObservaciones.TabIndex = 5;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(158, 103);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(381, 47);
            txtIndicaciones.TabIndex = 4;
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIndicaciones.ForeColor = Color.FromArgb(26, 82, 150);
            lblIndicaciones.Location = new Point(43, 106);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(75, 15);
            lblIndicaciones.TabIndex = 3;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(158, 45);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(381, 47);
            txtDiagnostico.TabIndex = 2;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiagnostico.ForeColor = Color.FromArgb(26, 82, 150);
            lblDiagnostico.Location = new Point(43, 48);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(72, 15);
            lblDiagnostico.TabIndex = 1;
            lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblRegistroTitulo
            // 
            lblRegistroTitulo.AutoSize = true;
            lblRegistroTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblRegistroTitulo.Location = new Point(20, 13);
            lblRegistroTitulo.Name = "lblRegistroTitulo";
            lblRegistroTitulo.Size = new Size(227, 21);
            lblRegistroTitulo.TabIndex = 0;
            lblRegistroTitulo.Text = "Registro de atención médica";
            // 
            // pnlTurnos
            // 
            pnlTurnos.BackColor = Color.White;
            pnlTurnos.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnos.Controls.Add(dgvTurnos);
            pnlTurnos.Controls.Add(lblCantidadTurnos);
            pnlTurnos.Controls.Add(lblTurnosTitulo);
            pnlTurnos.Location = new Point(28, 142);
            pnlTurnos.Name = "pnlTurnos";
            pnlTurnos.Size = new Size(784, 218);
            pnlTurnos.TabIndex = 1;
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(18, 54);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.Size = new Size(746, 144);
            dgvTurnos.TabIndex = 2;
            dgvTurnos.CellClick += dgvTurnos_CellClick;
            // 
            // lblCantidadTurnos
            // 
            lblCantidadTurnos.AutoSize = true;
            lblCantidadTurnos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadTurnos.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadTurnos.Location = new Point(19, 31);
            lblCantidadTurnos.Name = "lblCantidadTurnos";
            lblCantidadTurnos.Size = new Size(191, 15);
            lblCantidadTurnos.TabIndex = 1;
            lblCantidadTurnos.Text = "Turnos habilitados para atención: 0";
            // 
            // lblTurnosTitulo
            // 
            lblTurnosTitulo.AutoSize = true;
            lblTurnosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnosTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnosTitulo.Location = new Point(18, 9);
            lblTurnosTitulo.Name = "lblTurnosTitulo";
            lblTurnosTitulo.Size = new Size(260, 21);
            lblTurnosTitulo.TabIndex = 0;
            lblTurnosTitulo.Text = "Turnos habilitados por recepción";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 125);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 93);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(212, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Consulta médica del paciente";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(501, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registre diagnóstico, indicaciones y cierre de consulta del circuito externo.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Atención médica";
            // 
            // FrmAtencionMedica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAtencionMedica";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Atención médica - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlRegistro.ResumeLayout(false);
            pnlRegistro.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            pnlTurnos.ResumeLayout(false);
            pnlTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}
