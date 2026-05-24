namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmRecepcion
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel pnlTurnos;
        private Panel pnlDetalle;
        private Panel pnlCobertura;
        private Panel pnlAcciones;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblSeleccionTitulo;

        private Label lblPaciente;
        private Label lblPacienteDato;
        private Label lblDocumento;
        private Label lblDocumentoDato;
        private Label lblTelefono;
        private Label lblTelefonoDato;
        private Label lblProfesional;
        private Label lblProfesionalDato;
        private Label lblEspecialidad;
        private Label lblEspecialidadDato;
        private Label lblFechaHora;
        private Label lblFechaHoraDato;
        private Label lblEstado;
        private Label lblEstadoDato;

        private Label lblTurnosTitulo;
        private Label lblCantidadTurnos;
        private Label lblDetalleTitulo;
        private Label lblCoberturaTitulo;
        private Label lblAccionesTitulo;

        private Label lblCobertura;
        private Label lblCoberturaDato;
        private Label lblConvenio;
        private Label lblConvenioDato;
        private Label lblRequiereAutorizacion;
        private Label lblRequiereAutorizacionDato;

        private CheckBox chkAutorizacionAprobada;
        private Label lblObservaciones;
        private TextBox txtObservaciones;
        private Label lblResultadoVerificacion;

        private DataGridView dgvTurnos;

        private Button btnVerificarCobertura;
        private Button btnRegistrarLlegada;
        private Button btnHabilitarAtencion;
        private Button btnLimpiar;
        private Button btnCerrar;

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
            lblEstadoDato = new Label();
            lblEstado = new Label();
            lblFechaHoraDato = new Label();
            lblFechaHora = new Label();
            lblEspecialidadDato = new Label();
            lblEspecialidad = new Label();
            lblProfesionalDato = new Label();
            lblProfesional = new Label();
            lblTelefonoDato = new Label();
            lblTelefono = new Label();
            lblDocumentoDato = new Label();
            lblDocumento = new Label();
            lblPacienteDato = new Label();
            lblPaciente = new Label();
            lblSeleccionTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            pnlContenido = new Panel();
            pnlAcciones = new Panel();
            btnLimpiar = new Button();
            btnHabilitarAtencion = new Button();
            btnRegistrarLlegada = new Button();
            btnVerificarCobertura = new Button();
            lblAccionesTitulo = new Label();
            pnlCobertura = new Panel();
            lblResultadoVerificacion = new Label();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            chkAutorizacionAprobada = new CheckBox();
            lblRequiereAutorizacionDato = new Label();
            lblRequiereAutorizacion = new Label();
            lblConvenioDato = new Label();
            lblConvenio = new Label();
            lblCoberturaDato = new Label();
            lblCobertura = new Label();
            lblCoberturaTitulo = new Label();
            pnlDetalle = new Panel();
            lblDetalleTitulo = new Label();
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
            pnlAcciones.SuspendLayout();
            pnlCobertura.SuspendLayout();
            pnlDetalle.SuspendLayout();
            pnlTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Controls.Add(lblEstadoDato);
            pnlLateral.Controls.Add(lblEstado);
            pnlLateral.Controls.Add(lblFechaHoraDato);
            pnlLateral.Controls.Add(lblFechaHora);
            pnlLateral.Controls.Add(lblEspecialidadDato);
            pnlLateral.Controls.Add(lblEspecialidad);
            pnlLateral.Controls.Add(lblProfesionalDato);
            pnlLateral.Controls.Add(lblProfesional);
            pnlLateral.Controls.Add(lblTelefonoDato);
            pnlLateral.Controls.Add(lblTelefono);
            pnlLateral.Controls.Add(lblDocumentoDato);
            pnlLateral.Controls.Add(lblDocumento);
            pnlLateral.Controls.Add(lblPacienteDato);
            pnlLateral.Controls.Add(lblPaciente);
            pnlLateral.Controls.Add(lblSeleccionTitulo);
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
            btnCerrar.Location = new Point(24, 618);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 38);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstadoDato.Location = new Point(24, 558);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(232, 24);
            lblEstadoDato.TabIndex = 16;
            lblEstadoDato.Text = "-";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblEstado.Location = new Point(24, 540);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado";
            // 
            // lblFechaHoraDato
            // 
            lblFechaHoraDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHoraDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblFechaHoraDato.Location = new Point(24, 505);
            lblFechaHoraDato.Name = "lblFechaHoraDato";
            lblFechaHoraDato.Size = new Size(232, 24);
            lblFechaHoraDato.TabIndex = 14;
            lblFechaHoraDato.Text = "-";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaHora.ForeColor = Color.FromArgb(26, 82, 150);
            lblFechaHora.Location = new Point(24, 487);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(91, 15);
            lblFechaHora.TabIndex = 13;
            lblFechaHora.Text = "Fecha y horario";
            // 
            // lblEspecialidadDato
            // 
            lblEspecialidadDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialidadDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblEspecialidadDato.Location = new Point(24, 453);
            lblEspecialidadDato.Name = "lblEspecialidadDato";
            lblEspecialidadDato.Size = new Size(232, 25);
            lblEspecialidadDato.TabIndex = 12;
            lblEspecialidadDato.Text = "-";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEspecialidad.ForeColor = Color.FromArgb(26, 82, 150);
            lblEspecialidad.Location = new Point(24, 435);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(74, 15);
            lblEspecialidad.TabIndex = 11;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblProfesionalDato
            // 
            lblProfesionalDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesionalDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblProfesionalDato.Location = new Point(24, 400);
            lblProfesionalDato.Name = "lblProfesionalDato";
            lblProfesionalDato.Size = new Size(232, 25);
            lblProfesionalDato.TabIndex = 10;
            lblProfesionalDato.Text = "-";
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblProfesional.Location = new Point(24, 382);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(68, 15);
            lblProfesional.TabIndex = 9;
            lblProfesional.Text = "Profesional";
            // 
            // lblTelefonoDato
            // 
            lblTelefonoDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefonoDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblTelefonoDato.Location = new Point(24, 348);
            lblTelefonoDato.Name = "lblTelefonoDato";
            lblTelefonoDato.Size = new Size(232, 25);
            lblTelefonoDato.TabIndex = 8;
            lblTelefonoDato.Text = "-";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.FromArgb(26, 82, 150);
            lblTelefono.Location = new Point(24, 330);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDocumentoDato
            // 
            lblDocumentoDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumentoDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblDocumentoDato.Location = new Point(24, 294);
            lblDocumentoDato.Name = "lblDocumentoDato";
            lblDocumentoDato.Size = new Size(232, 25);
            lblDocumentoDato.TabIndex = 6;
            lblDocumentoDato.Text = "-";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.ForeColor = Color.FromArgb(26, 82, 150);
            lblDocumento.Location = new Point(24, 276);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento";
            // 
            // lblPacienteDato
            // 
            lblPacienteDato.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteDato.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteDato.Location = new Point(24, 232);
            lblPacienteDato.Name = "lblPacienteDato";
            lblPacienteDato.Size = new Size(232, 35);
            lblPacienteDato.TabIndex = 4;
            lblPacienteDato.Text = "-";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblPaciente.Location = new Point(24, 214);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(51, 15);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "Paciente";
            // 
            // lblSeleccionTitulo
            // 
            lblSeleccionTitulo.AutoSize = true;
            lblSeleccionTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblSeleccionTitulo.Location = new Point(24, 174);
            lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            lblSeleccionTitulo.Size = new Size(178, 21);
            lblSeleccionTitulo.TabIndex = 2;
            lblSeleccionTitulo.Text = "Turno seleccionado";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(24, 86);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(232, 74);
            lblPanelTexto.TabIndex = 1;
            lblPanelTexto.Text = "Verifique la cobertura, registre la llegada del paciente y habilite la atención médica.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(24, 35);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(174, 37);
            lblPanelTitulo.TabIndex = 0;
            lblPanelTitulo.Text = "☑ Recepción";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(pnlAcciones);
            pnlContenido.Controls.Add(pnlCobertura);
            pnlContenido.Controls.Add(pnlDetalle);
            pnlContenido.Controls.Add(pnlTurnos);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.White;
            pnlAcciones.BorderStyle = BorderStyle.FixedSingle;
            pnlAcciones.Controls.Add(btnLimpiar);
            pnlAcciones.Controls.Add(btnHabilitarAtencion);
            pnlAcciones.Controls.Add(btnRegistrarLlegada);
            pnlAcciones.Controls.Add(btnVerificarCobertura);
            pnlAcciones.Controls.Add(lblAccionesTitulo);
            pnlAcciones.Location = new Point(586, 392);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(228, 228);
            pnlAcciones.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(20, 174);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(186, 34);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar selección";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnHabilitarAtencion
            // 
            btnHabilitarAtencion.BackColor = Color.FromArgb(243, 239, 255);
            btnHabilitarAtencion.FlatAppearance.BorderColor = Color.FromArgb(213, 203, 245);
            btnHabilitarAtencion.FlatStyle = FlatStyle.Flat;
            btnHabilitarAtencion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnHabilitarAtencion.ForeColor = Color.FromArgb(106, 78, 181);
            btnHabilitarAtencion.Location = new Point(20, 132);
            btnHabilitarAtencion.Name = "btnHabilitarAtencion";
            btnHabilitarAtencion.Size = new Size(186, 34);
            btnHabilitarAtencion.TabIndex = 3;
            btnHabilitarAtencion.Text = "Habilitar atención";
            btnHabilitarAtencion.UseVisualStyleBackColor = false;
            btnHabilitarAtencion.Click += btnHabilitarAtencion_Click;
            // 
            // btnRegistrarLlegada
            // 
            btnRegistrarLlegada.BackColor = Color.FromArgb(236, 248, 240);
            btnRegistrarLlegada.FlatAppearance.BorderColor = Color.FromArgb(194, 223, 203);
            btnRegistrarLlegada.FlatStyle = FlatStyle.Flat;
            btnRegistrarLlegada.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarLlegada.ForeColor = Color.FromArgb(34, 122, 83);
            btnRegistrarLlegada.Location = new Point(20, 90);
            btnRegistrarLlegada.Name = "btnRegistrarLlegada";
            btnRegistrarLlegada.Size = new Size(186, 34);
            btnRegistrarLlegada.TabIndex = 2;
            btnRegistrarLlegada.Text = "Registrar llegada";
            btnRegistrarLlegada.UseVisualStyleBackColor = false;
            btnRegistrarLlegada.Click += btnRegistrarLlegada_Click;
            // 
            // btnVerificarCobertura
            // 
            btnVerificarCobertura.BackColor = Color.FromArgb(26, 82, 150);
            btnVerificarCobertura.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnVerificarCobertura.FlatStyle = FlatStyle.Flat;
            btnVerificarCobertura.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificarCobertura.ForeColor = Color.White;
            btnVerificarCobertura.Location = new Point(20, 48);
            btnVerificarCobertura.Name = "btnVerificarCobertura";
            btnVerificarCobertura.Size = new Size(186, 34);
            btnVerificarCobertura.TabIndex = 1;
            btnVerificarCobertura.Text = "Verificar cobertura";
            btnVerificarCobertura.UseVisualStyleBackColor = false;
            btnVerificarCobertura.Click += btnVerificarCobertura_Click;
            // 
            // lblAccionesTitulo
            // 
            lblAccionesTitulo.AutoSize = true;
            lblAccionesTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccionesTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblAccionesTitulo.Location = new Point(18, 15);
            lblAccionesTitulo.Name = "lblAccionesTitulo";
            lblAccionesTitulo.Size = new Size(129, 20);
            lblAccionesTitulo.TabIndex = 0;
            lblAccionesTitulo.Text = "Acciones rápidas";
            // 
            // pnlCobertura
            // 
            pnlCobertura.BackColor = Color.White;
            pnlCobertura.BorderStyle = BorderStyle.FixedSingle;
            pnlCobertura.Controls.Add(lblResultadoVerificacion);
            pnlCobertura.Controls.Add(txtObservaciones);
            pnlCobertura.Controls.Add(lblObservaciones);
            pnlCobertura.Controls.Add(chkAutorizacionAprobada);
            pnlCobertura.Controls.Add(lblRequiereAutorizacionDato);
            pnlCobertura.Controls.Add(lblRequiereAutorizacion);
            pnlCobertura.Controls.Add(lblConvenioDato);
            pnlCobertura.Controls.Add(lblConvenio);
            pnlCobertura.Controls.Add(lblCoberturaDato);
            pnlCobertura.Controls.Add(lblCobertura);
            pnlCobertura.Controls.Add(lblCoberturaTitulo);
            pnlCobertura.Location = new Point(26, 392);
            pnlCobertura.Name = "pnlCobertura";
            pnlCobertura.Size = new Size(542, 228);
            pnlCobertura.TabIndex = 3;
            // 
            // lblResultadoVerificacion
            // 
            lblResultadoVerificacion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblResultadoVerificacion.ForeColor = Color.FromArgb(90, 103, 130);
            lblResultadoVerificacion.Location = new Point(18, 190);
            lblResultadoVerificacion.Name = "lblResultadoVerificacion";
            lblResultadoVerificacion.Size = new Size(500, 24);
            lblResultadoVerificacion.TabIndex = 10;
            lblResultadoVerificacion.Text = "Seleccione un turno para verificar cobertura.";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(309, 92);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(209, 74);
            txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblObservaciones.ForeColor = Color.FromArgb(26, 82, 150);
            lblObservaciones.Location = new Point(309, 72);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(83, 15);
            lblObservaciones.TabIndex = 8;
            lblObservaciones.Text = "Observaciones";
            // 
            // chkAutorizacionAprobada
            // 
            chkAutorizacionAprobada.AutoSize = true;
            chkAutorizacionAprobada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkAutorizacionAprobada.ForeColor = Color.FromArgb(42, 58, 92);
            chkAutorizacionAprobada.Location = new Point(309, 38);
            chkAutorizacionAprobada.Name = "chkAutorizacionAprobada";
            chkAutorizacionAprobada.Size = new Size(147, 19);
            chkAutorizacionAprobada.TabIndex = 7;
            chkAutorizacionAprobada.Text = "Autorización aprobada";
            chkAutorizacionAprobada.UseVisualStyleBackColor = true;
            // 
            // lblRequiereAutorizacionDato
            // 
            lblRequiereAutorizacionDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequiereAutorizacionDato.ForeColor = Color.FromArgb(42, 58, 92);
            lblRequiereAutorizacionDato.Location = new Point(18, 152);
            lblRequiereAutorizacionDato.Name = "lblRequiereAutorizacionDato";
            lblRequiereAutorizacionDato.Size = new Size(260, 24);
            lblRequiereAutorizacionDato.TabIndex = 6;
            lblRequiereAutorizacionDato.Text = "-";
            // 
            // lblRequiereAutorizacion
            // 
            lblRequiereAutorizacion.AutoSize = true;
            lblRequiereAutorizacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRequiereAutorizacion.ForeColor = Color.FromArgb(26, 82, 150);
            lblRequiereAutorizacion.Location = new Point(18, 134);
            lblRequiereAutorizacion.Name = "lblRequiereAutorizacion";
            lblRequiereAutorizacion.Size = new Size(128, 15);
            lblRequiereAutorizacion.TabIndex = 5;
            lblRequiereAutorizacion.Text = "Requiere autorización";
            // 
            // lblConvenioDato
            // 
            lblConvenioDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblConvenioDato.ForeColor = Color.FromArgb(42, 58, 92);
            lblConvenioDato.Location = new Point(18, 103);
            lblConvenioDato.Name = "lblConvenioDato";
            lblConvenioDato.Size = new Size(260, 24);
            lblConvenioDato.TabIndex = 4;
            lblConvenioDato.Text = "-";
            // 
            // lblConvenio
            // 
            lblConvenio.AutoSize = true;
            lblConvenio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConvenio.ForeColor = Color.FromArgb(26, 82, 150);
            lblConvenio.Location = new Point(18, 85);
            lblConvenio.Name = "lblConvenio";
            lblConvenio.Size = new Size(58, 15);
            lblConvenio.TabIndex = 3;
            lblConvenio.Text = "Convenio";
            // 
            // lblCoberturaDato
            // 
            lblCoberturaDato.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoberturaDato.ForeColor = Color.FromArgb(42, 58, 92);
            lblCoberturaDato.Location = new Point(18, 54);
            lblCoberturaDato.Name = "lblCoberturaDato";
            lblCoberturaDato.Size = new Size(260, 24);
            lblCoberturaDato.TabIndex = 2;
            lblCoberturaDato.Text = "-";
            // 
            // lblCobertura
            // 
            lblCobertura.AutoSize = true;
            lblCobertura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCobertura.ForeColor = Color.FromArgb(26, 82, 150);
            lblCobertura.Location = new Point(18, 36);
            lblCobertura.Name = "lblCobertura";
            lblCobertura.Size = new Size(62, 15);
            lblCobertura.TabIndex = 1;
            lblCobertura.Text = "Cobertura";
            // 
            // lblCoberturaTitulo
            // 
            lblCoberturaTitulo.AutoSize = true;
            lblCoberturaTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCoberturaTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblCoberturaTitulo.Location = new Point(16, 10);
            lblCoberturaTitulo.Name = "lblCoberturaTitulo";
            lblCoberturaTitulo.Size = new Size(226, 20);
            lblCoberturaTitulo.TabIndex = 0;
            lblCoberturaTitulo.Text = "Cobertura y autorización";
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.White;
            pnlDetalle.BorderStyle = BorderStyle.FixedSingle;
            pnlDetalle.Controls.Add(lblDetalleTitulo);
            pnlDetalle.Location = new Point(26, 316);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(788, 54);
            pnlDetalle.TabIndex = 2;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetalleTitulo.ForeColor = Color.FromArgb(42, 58, 92);
            lblDetalleTitulo.Location = new Point(18, 15);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(747, 24);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Seleccione un turno de la lista. Los datos principales del paciente se muestran en el panel izquierdo.";
            // 
            // pnlTurnos
            // 
            pnlTurnos.BackColor = Color.White;
            pnlTurnos.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnos.Controls.Add(dgvTurnos);
            pnlTurnos.Controls.Add(lblCantidadTurnos);
            pnlTurnos.Controls.Add(lblTurnosTitulo);
            pnlTurnos.Location = new Point(26, 145);
            pnlTurnos.Name = "pnlTurnos";
            pnlTurnos.Size = new Size(788, 150);
            pnlTurnos.TabIndex = 1;
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(18, 51);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.Size = new Size(750, 78);
            dgvTurnos.TabIndex = 2;
            dgvTurnos.CellClick += dgvTurnos_CellClick;
            // 
            // lblCantidadTurnos
            // 
            lblCantidadTurnos.AutoSize = true;
            lblCantidadTurnos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadTurnos.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadTurnos.Location = new Point(18, 30);
            lblCantidadTurnos.Name = "lblCantidadTurnos";
            lblCantidadTurnos.Size = new Size(190, 15);
            lblCantidadTurnos.TabIndex = 1;
            lblCantidadTurnos.Text = "Turnos pendientes de recepción: 0";
            // 
            // lblTurnosTitulo
            // 
            lblTurnosTitulo.AutoSize = true;
            lblTurnosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnosTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTurnosTitulo.Location = new Point(16, 8);
            lblTurnosTitulo.Name = "lblTurnosTitulo";
            lblTurnosTitulo.Size = new Size(241, 21);
            lblTurnosTitulo.TabIndex = 0;
            lblTurnosTitulo.Text = "Turnos pendientes de recepción";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(250, 252, 255);
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
            lblSeccion.Location = new Point(31, 92);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(287, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Admisión del paciente al consultorio";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(566, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Verifique la cobertura y registre la llegada antes de habilitar la atención médica.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(351, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recepción de consultorios";
            // 
            // FrmRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRecepcion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recepción - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            pnlCobertura.ResumeLayout(false);
            pnlCobertura.PerformLayout();
            pnlDetalle.ResumeLayout(false);
            pnlTurnos.ResumeLayout(false);
            pnlTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}