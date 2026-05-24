namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmPacientes
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel gbDatosPaciente;
        private Panel pnlAcciones;
        private Panel gbListado;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblSeleccionTitulo;
        private Label lblPacienteNombre;
        private Label lblPacienteDocumento;
        private Label lblPacienteTelefono;
        private Label lblPacienteCobertura;
        private Label lblPacienteEstado;
        private Label lblPacienteNombreValor;
        private Label lblPacienteDocumentoValor;
        private Label lblPacienteTelefonoValor;
        private Label lblPacienteCoberturaValor;
        private Label lblPacienteEstadoValor;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblDatosTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipoDocumento;
        private Label lblNroDocumento;
        private Label lblFechaNacimiento;
        private Label lblSexo;
        private Label lblTelefono;
        private Label lblDomicilio;
        private Label lblEmail;
        private Label lblCobertura;
        private Label lblNroAfiliado;
        private Label lblAccionesTitulo;
        private Label lblAccionesTexto;
        private Label lblListadoTitulo;
        private Label lblCantidadPacientes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cmbTipoDocumento;
        private TextBox txtNroDocumento;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbSexo;
        private TextBox txtTelefono;
        private TextBox txtDomicilio;
        private TextBox txtEmail;
        private ComboBox cmbCobertura;
        private TextBox txtNroAfiliado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private DataGridView dgvPacientes;

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
            lblPacienteEstadoValor = new Label();
            lblPacienteCoberturaValor = new Label();
            lblPacienteTelefonoValor = new Label();
            lblPacienteDocumentoValor = new Label();
            lblPacienteNombreValor = new Label();
            lblPacienteEstado = new Label();
            lblPacienteCobertura = new Label();
            lblPacienteTelefono = new Label();
            lblPacienteDocumento = new Label();
            lblPacienteNombre = new Label();
            lblSeleccionTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            btnCerrar = new Button();
            pnlContenido = new Panel();
            gbListado = new Panel();
            dgvPacientes = new DataGridView();
            lblCantidadPacientes = new Label();
            lblListadoTitulo = new Label();
            pnlAcciones = new Panel();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            lblAccionesTexto = new Label();
            lblAccionesTitulo = new Label();
            gbDatosPaciente = new Panel();
            lblDatosTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipoDocumento = new Label();
            lblNroDocumento = new Label();
            lblFechaNacimiento = new Label();
            lblSexo = new Label();
            lblTelefono = new Label();
            lblDomicilio = new Label();
            lblEmail = new Label();
            lblCobertura = new Label();
            lblNroAfiliado = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cmbTipoDocumento = new ComboBox();
            txtNroDocumento = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbSexo = new ComboBox();
            txtTelefono = new TextBox();
            txtDomicilio = new TextBox();
            txtEmail = new TextBox();
            cmbCobertura = new ComboBox();
            txtNroAfiliado = new TextBox();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            pnlAcciones.SuspendLayout();
            gbDatosPaciente.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(lblPacienteEstadoValor);
            pnlLateral.Controls.Add(lblPacienteCoberturaValor);
            pnlLateral.Controls.Add(lblPacienteTelefonoValor);
            pnlLateral.Controls.Add(lblPacienteDocumentoValor);
            pnlLateral.Controls.Add(lblPacienteNombreValor);
            pnlLateral.Controls.Add(lblPacienteEstado);
            pnlLateral.Controls.Add(lblPacienteCobertura);
            pnlLateral.Controls.Add(lblPacienteTelefono);
            pnlLateral.Controls.Add(lblPacienteDocumento);
            pnlLateral.Controls.Add(lblPacienteNombre);
            pnlLateral.Controls.Add(lblSeleccionTitulo);
            pnlLateral.Controls.Add(lblPanelTexto);
            pnlLateral.Controls.Add(lblPanelTitulo);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;
            // 
            // lblPacienteEstadoValor
            // 
            lblPacienteEstadoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteEstadoValor.Location = new Point(32, 494);
            lblPacienteEstadoValor.Name = "lblPacienteEstadoValor";
            lblPacienteEstadoValor.Size = new Size(215, 22);
            lblPacienteEstadoValor.TabIndex = 13;
            lblPacienteEstadoValor.Text = "-";
            // 
            // lblPacienteCoberturaValor
            // 
            lblPacienteCoberturaValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPacienteCoberturaValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteCoberturaValor.Location = new Point(32, 435);
            lblPacienteCoberturaValor.Name = "lblPacienteCoberturaValor";
            lblPacienteCoberturaValor.Size = new Size(215, 40);
            lblPacienteCoberturaValor.TabIndex = 12;
            lblPacienteCoberturaValor.Text = "-";
            // 
            // lblPacienteTelefonoValor
            // 
            lblPacienteTelefonoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPacienteTelefonoValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteTelefonoValor.Location = new Point(32, 381);
            lblPacienteTelefonoValor.Name = "lblPacienteTelefonoValor";
            lblPacienteTelefonoValor.Size = new Size(215, 22);
            lblPacienteTelefonoValor.TabIndex = 11;
            lblPacienteTelefonoValor.Text = "-";
            // 
            // lblPacienteDocumentoValor
            // 
            lblPacienteDocumentoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPacienteDocumentoValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteDocumentoValor.Location = new Point(32, 327);
            lblPacienteDocumentoValor.Name = "lblPacienteDocumentoValor";
            lblPacienteDocumentoValor.Size = new Size(215, 22);
            lblPacienteDocumentoValor.TabIndex = 10;
            lblPacienteDocumentoValor.Text = "-";
            // 
            // lblPacienteNombreValor
            // 
            lblPacienteNombreValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteNombreValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblPacienteNombreValor.Location = new Point(32, 267);
            lblPacienteNombreValor.Name = "lblPacienteNombreValor";
            lblPacienteNombreValor.Size = new Size(215, 42);
            lblPacienteNombreValor.TabIndex = 9;
            lblPacienteNombreValor.Text = "Sin selección";
            // 
            // lblPacienteEstado
            // 
            lblPacienteEstado.AutoSize = true;
            lblPacienteEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteEstado.Location = new Point(32, 476);
            lblPacienteEstado.Name = "lblPacienteEstado";
            lblPacienteEstado.Size = new Size(44, 15);
            lblPacienteEstado.TabIndex = 8;
            lblPacienteEstado.Text = "Estado";
            // 
            // lblPacienteCobertura
            // 
            lblPacienteCobertura.AutoSize = true;
            lblPacienteCobertura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteCobertura.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteCobertura.Location = new Point(32, 417);
            lblPacienteCobertura.Name = "lblPacienteCobertura";
            lblPacienteCobertura.Size = new Size(64, 15);
            lblPacienteCobertura.TabIndex = 7;
            lblPacienteCobertura.Text = "Cobertura";
            // 
            // lblPacienteTelefono
            // 
            lblPacienteTelefono.AutoSize = true;
            lblPacienteTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteTelefono.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteTelefono.Location = new Point(32, 363);
            lblPacienteTelefono.Name = "lblPacienteTelefono";
            lblPacienteTelefono.Size = new Size(56, 15);
            lblPacienteTelefono.TabIndex = 6;
            lblPacienteTelefono.Text = "Teléfono";
            // 
            // lblPacienteDocumento
            // 
            lblPacienteDocumento.AutoSize = true;
            lblPacienteDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteDocumento.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteDocumento.Location = new Point(32, 309);
            lblPacienteDocumento.Name = "lblPacienteDocumento";
            lblPacienteDocumento.Size = new Size(73, 15);
            lblPacienteDocumento.TabIndex = 5;
            lblPacienteDocumento.Text = "Documento";
            // 
            // lblPacienteNombre
            // 
            lblPacienteNombre.AutoSize = true;
            lblPacienteNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteNombre.ForeColor = Color.FromArgb(26, 82, 150);
            lblPacienteNombre.Location = new Point(32, 249);
            lblPacienteNombre.Name = "lblPacienteNombre";
            lblPacienteNombre.Size = new Size(110, 15);
            lblPacienteNombre.TabIndex = 4;
            lblPacienteNombre.Text = "Nombre completo";
            // 
            // lblSeleccionTitulo
            // 
            lblSeleccionTitulo.AutoSize = true;
            lblSeleccionTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblSeleccionTitulo.Location = new Point(28, 206);
            lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            lblSeleccionTitulo.Size = new Size(185, 21);
            lblSeleccionTitulo.TabIndex = 3;
            lblSeleccionTitulo.Text = "Paciente seleccionado";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(28, 92);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(220, 85);
            lblPanelTexto.TabIndex = 2;
            lblPanelTexto.Text = "Desde este módulo se registran los datos personales, de contacto y cobertura del paciente.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(28, 37);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(170, 37);
            lblPanelTitulo.TabIndex = 1;
            lblPanelTitulo.Text = "👥 Pacientes";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(26, 82, 150);
            btnCerrar.Location = new Point(24, 610);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 42);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(gbListado);
            pnlContenido.Controls.Add(pnlAcciones);
            pnlContenido.Controls.Add(gbDatosPaciente);
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
            gbListado.Controls.Add(dgvPacientes);
            gbListado.Controls.Add(lblCantidadPacientes);
            gbListado.Controls.Add(lblListadoTitulo);
            gbListado.Location = new Point(28, 455);
            gbListado.Name = "gbListado";
            gbListado.Size = new Size(784, 190);
            gbListado.TabIndex = 3;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(18, 53);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowTemplate.Height = 25;
            dgvPacientes.Size = new Size(746, 115);
            dgvPacientes.TabIndex = 2;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // lblCantidadPacientes
            // 
            lblCantidadPacientes.AutoSize = true;
            lblCantidadPacientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadPacientes.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadPacientes.Location = new Point(18, 31);
            lblCantidadPacientes.Name = "lblCantidadPacientes";
            lblCantidadPacientes.Size = new Size(129, 15);
            lblCantidadPacientes.TabIndex = 1;
            lblCantidadPacientes.Text = "Pacientes registrados: 0";
            // 
            // lblListadoTitulo
            // 
            lblListadoTitulo.AutoSize = true;
            lblListadoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblListadoTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblListadoTitulo.Location = new Point(16, 9);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(188, 21);
            lblListadoTitulo.TabIndex = 0;
            lblListadoTitulo.Text = "Pacientes registrados";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.White;
            pnlAcciones.BorderStyle = BorderStyle.FixedSingle;
            pnlAcciones.Controls.Add(btnLimpiar);
            pnlAcciones.Controls.Add(btnGuardar);
            pnlAcciones.Controls.Add(lblAccionesTexto);
            pnlAcciones.Controls.Add(lblAccionesTitulo);
            pnlAcciones.Location = new Point(595, 165);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(217, 270);
            pnlAcciones.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(21, 181);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(174, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar datos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 82, 150);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(21, 124);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar paciente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblAccionesTexto
            // 
            lblAccionesTexto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccionesTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblAccionesTexto.Location = new Point(21, 47);
            lblAccionesTexto.Name = "lblAccionesTexto";
            lblAccionesTexto.Size = new Size(174, 62);
            lblAccionesTexto.TabIndex = 1;
            lblAccionesTexto.Text = "Complete los datos obligatorios antes de registrar el paciente.";
            // 
            // lblAccionesTitulo
            // 
            lblAccionesTitulo.AutoSize = true;
            lblAccionesTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccionesTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblAccionesTitulo.Location = new Point(21, 17);
            lblAccionesTitulo.Name = "lblAccionesTitulo";
            lblAccionesTitulo.Size = new Size(78, 21);
            lblAccionesTitulo.TabIndex = 0;
            lblAccionesTitulo.Text = "Acciones";
            // 
            // gbDatosPaciente
            // 
            gbDatosPaciente.BackColor = Color.White;
            gbDatosPaciente.BorderStyle = BorderStyle.FixedSingle;
            gbDatosPaciente.Controls.Add(lblDatosTitulo);
            gbDatosPaciente.Controls.Add(lblNombre);
            gbDatosPaciente.Controls.Add(lblApellido);
            gbDatosPaciente.Controls.Add(lblTipoDocumento);
            gbDatosPaciente.Controls.Add(lblNroDocumento);
            gbDatosPaciente.Controls.Add(lblFechaNacimiento);
            gbDatosPaciente.Controls.Add(lblSexo);
            gbDatosPaciente.Controls.Add(lblTelefono);
            gbDatosPaciente.Controls.Add(lblDomicilio);
            gbDatosPaciente.Controls.Add(lblEmail);
            gbDatosPaciente.Controls.Add(lblCobertura);
            gbDatosPaciente.Controls.Add(lblNroAfiliado);
            gbDatosPaciente.Controls.Add(txtNombre);
            gbDatosPaciente.Controls.Add(txtApellido);
            gbDatosPaciente.Controls.Add(cmbTipoDocumento);
            gbDatosPaciente.Controls.Add(txtNroDocumento);
            gbDatosPaciente.Controls.Add(dtpFechaNacimiento);
            gbDatosPaciente.Controls.Add(cmbSexo);
            gbDatosPaciente.Controls.Add(txtTelefono);
            gbDatosPaciente.Controls.Add(txtDomicilio);
            gbDatosPaciente.Controls.Add(txtEmail);
            gbDatosPaciente.Controls.Add(cmbCobertura);
            gbDatosPaciente.Controls.Add(txtNroAfiliado);
            gbDatosPaciente.Location = new Point(28, 165);
            gbDatosPaciente.Name = "gbDatosPaciente";
            gbDatosPaciente.Size = new Size(548, 270);
            gbDatosPaciente.TabIndex = 1;
            // 
            // lblDatosTitulo
            // 
            lblDatosTitulo.AutoSize = true;
            lblDatosTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblDatosTitulo.Location = new Point(18, 12);
            lblDatosTitulo.Name = "lblDatosTitulo";
            lblDatosTitulo.Size = new Size(158, 21);
            lblDatosTitulo.TabIndex = 0;
            lblDatosTitulo.Text = "Datos del paciente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(26, 82, 150);
            lblNombre.Location = new Point(18, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.FromArgb(26, 82, 150);
            lblApellido.Location = new Point(279, 49);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDocumento.ForeColor = Color.FromArgb(26, 82, 150);
            lblTipoDocumento.Location = new Point(18, 94);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(99, 15);
            lblTipoDocumento.TabIndex = 5;
            lblTipoDocumento.Text = "Tipo documento";
            // 
            // lblNroDocumento
            // 
            lblNroDocumento.AutoSize = true;
            lblNroDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroDocumento.ForeColor = Color.FromArgb(26, 82, 150);
            lblNroDocumento.Location = new Point(279, 94);
            lblNroDocumento.Name = "lblNroDocumento";
            lblNroDocumento.Size = new Size(101, 15);
            lblNroDocumento.TabIndex = 7;
            lblNroDocumento.Text = "Nro. documento";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.ForeColor = Color.FromArgb(26, 82, 150);
            lblFechaNacimiento.Location = new Point(18, 139);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(121, 15);
            lblFechaNacimiento.TabIndex = 9;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSexo.ForeColor = Color.FromArgb(26, 82, 150);
            lblSexo.Location = new Point(279, 139);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(33, 15);
            lblSexo.TabIndex = 11;
            lblSexo.Text = "Sexo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.FromArgb(26, 82, 150);
            lblTelefono.Location = new Point(18, 184);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomicilio.ForeColor = Color.FromArgb(26, 82, 150);
            lblDomicilio.Location = new Point(279, 184);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(63, 15);
            lblDomicilio.TabIndex = 15;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(26, 82, 150);
            lblEmail.Location = new Point(18, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // lblCobertura
            // 
            lblCobertura.AutoSize = true;
            lblCobertura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCobertura.ForeColor = Color.FromArgb(26, 82, 150);
            lblCobertura.Location = new Point(18, 244);
            lblCobertura.Name = "lblCobertura";
            lblCobertura.Size = new Size(64, 15);
            lblCobertura.TabIndex = 19;
            lblCobertura.Text = "Cobertura";
            // 
            // lblNroAfiliado
            // 
            lblNroAfiliado.AutoSize = true;
            lblNroAfiliado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroAfiliado.ForeColor = Color.FromArgb(26, 82, 150);
            lblNroAfiliado.Location = new Point(279, 244);
            lblNroAfiliado.Name = "lblNroAfiliado";
            lblNroAfiliado.Size = new Size(77, 15);
            lblNroAfiliado.TabIndex = 21;
            lblNroAfiliado.Text = "Nro. afiliado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(386, 46);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 23);
            txtApellido.TabIndex = 4;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(121, 91);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(140, 23);
            cmbTipoDocumento.TabIndex = 6;
            // 
            // txtNroDocumento
            // 
            txtNroDocumento.Location = new Point(386, 91);
            txtNroDocumento.Name = "txtNroDocumento";
            txtNroDocumento.Size = new Size(140, 23);
            txtNroDocumento.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(145, 136);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(116, 23);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(386, 136);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(140, 23);
            cmbSexo.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(121, 181);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(140, 23);
            txtTelefono.TabIndex = 14;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(356, 181);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(170, 23);
            txtDomicilio.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(405, 23);
            txtEmail.TabIndex = 18;
            // 
            // cmbCobertura
            // 
            cmbCobertura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCobertura.FormattingEnabled = true;
            cmbCobertura.Location = new Point(121, 241);
            cmbCobertura.Name = "cmbCobertura";
            cmbCobertura.Size = new Size(140, 23);
            cmbCobertura.TabIndex = 20;
            cmbCobertura.SelectedIndexChanged += cmbCobertura_SelectedIndexChanged;
            // 
            // txtNroAfiliado
            // 
            txtNroAfiliado.Location = new Point(386, 241);
            txtNroAfiliado.Name = "txtNroAfiliado";
            txtNroAfiliado.Size = new Size(140, 23);
            txtNroAfiliado.TabIndex = 22;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.FromArgb(250, 252, 255);
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
            lblSeccion.Size = new Size(225, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Alta y consulta de pacientes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(466, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registre pacientes y consulte sus datos principales de cobertura.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de pacientes";
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPacientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pacientes - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            gbListado.ResumeLayout(false);
            gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            gbDatosPaciente.ResumeLayout(false);
            gbDatosPaciente.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}
