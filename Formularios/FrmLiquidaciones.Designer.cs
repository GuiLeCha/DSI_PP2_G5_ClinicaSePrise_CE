namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmLiquidaciones
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel pnlInfoLateral;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblResumenTitulo;
        private Label lblPendientesTitulo;
        private Label lblComprobantesTitulo;
        private Label lblHonorariosTitulo;
        private Label lblLotesTitulo;
        private Label lblPendientesValor;
        private Label lblComprobantesValor;
        private Label lblHonorariosValor;
        private Label lblLotesValor;
        private Label lblInfoTitulo;
        private Label lblInfoTexto;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;

        private TabControl tabLiquidaciones;
        private TabPage tabComprobantes;
        private TabPage tabHonorarios;
        private TabPage tabObraSocial;

        private Panel gbComprobante;
        private Label lblComprobanteTitulo;
        private Label lblTurnoComprobante;
        private Label lblCantidadComprobantes;
        private ComboBox cmbTurnoComprobante;
        private Button btnGenerarComprobante;
        private DataGridView dgvComprobantes;

        private Panel gbHonorarios;
        private Label lblHonorariosPanelTitulo;
        private Label lblProfesional;
        private ComboBox cmbProfesional;
        private Label lblPeriodoHonorarios;
        private DateTimePicker dtpPeriodoHonorarios;
        private Label lblCantidadHonorarios;
        private Button btnLiquidarHonorarios;
        private DataGridView dgvHonorarios;

        private Panel gbObraSocial;
        private Label lblObraSocialPanelTitulo;
        private Label lblObraSocial;
        private ComboBox cmbObraSocial;
        private Label lblPeriodoObraSocial;
        private DateTimePicker dtpPeriodoObraSocial;
        private Label lblCantidadLotes;
        private Button btnPresentarObraSocial;
        private DataGridView dgvLotes;

        private Button btnActualizar;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLateral = new Panel();
            btnCerrar = new Button();
            pnlInfoLateral = new Panel();
            lblInfoTexto = new Label();
            lblInfoTitulo = new Label();
            lblLotesValor = new Label();
            lblHonorariosValor = new Label();
            lblComprobantesValor = new Label();
            lblPendientesValor = new Label();
            lblLotesTitulo = new Label();
            lblHonorariosTitulo = new Label();
            lblComprobantesTitulo = new Label();
            lblPendientesTitulo = new Label();
            lblResumenTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            pnlContenido = new Panel();
            btnActualizar = new Button();
            tabLiquidaciones = new TabControl();
            tabComprobantes = new TabPage();
            dgvComprobantes = new DataGridView();
            lblCantidadComprobantes = new Label();
            gbComprobante = new Panel();
            btnGenerarComprobante = new Button();
            cmbTurnoComprobante = new ComboBox();
            lblTurnoComprobante = new Label();
            lblComprobanteTitulo = new Label();
            tabHonorarios = new TabPage();
            dgvHonorarios = new DataGridView();
            lblCantidadHonorarios = new Label();
            gbHonorarios = new Panel();
            btnLiquidarHonorarios = new Button();
            dtpPeriodoHonorarios = new DateTimePicker();
            lblPeriodoHonorarios = new Label();
            cmbProfesional = new ComboBox();
            lblProfesional = new Label();
            lblHonorariosPanelTitulo = new Label();
            tabObraSocial = new TabPage();
            dgvLotes = new DataGridView();
            lblCantidadLotes = new Label();
            gbObraSocial = new Panel();
            btnPresentarObraSocial = new Button();
            dtpPeriodoObraSocial = new DateTimePicker();
            lblPeriodoObraSocial = new Label();
            cmbObraSocial = new ComboBox();
            lblObraSocial = new Label();
            lblObraSocialPanelTitulo = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlInfoLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            tabLiquidaciones.SuspendLayout();
            tabComprobantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).BeginInit();
            gbComprobante.SuspendLayout();
            tabHonorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHonorarios).BeginInit();
            gbHonorarios.SuspendLayout();
            tabObraSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).BeginInit();
            gbObraSocial.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Controls.Add(pnlInfoLateral);
            pnlLateral.Controls.Add(lblLotesValor);
            pnlLateral.Controls.Add(lblHonorariosValor);
            pnlLateral.Controls.Add(lblComprobantesValor);
            pnlLateral.Controls.Add(lblPendientesValor);
            pnlLateral.Controls.Add(lblLotesTitulo);
            pnlLateral.Controls.Add(lblHonorariosTitulo);
            pnlLateral.Controls.Add(lblComprobantesTitulo);
            pnlLateral.Controls.Add(lblPendientesTitulo);
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
            btnCerrar.Location = new Point(24, 610);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(232, 42);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Volver al menú";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlInfoLateral
            // 
            pnlInfoLateral.BackColor = Color.FromArgb(248, 251, 255);
            pnlInfoLateral.BorderStyle = BorderStyle.FixedSingle;
            pnlInfoLateral.Controls.Add(lblInfoTexto);
            pnlInfoLateral.Controls.Add(lblInfoTitulo);
            pnlInfoLateral.Location = new Point(24, 420);
            pnlInfoLateral.Name = "pnlInfoLateral";
            pnlInfoLateral.Size = new Size(232, 148);
            pnlInfoLateral.TabIndex = 11;
            // 
            // lblInfoTexto
            // 
            lblInfoTexto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblInfoTexto.Location = new Point(15, 45);
            lblInfoTexto.Name = "lblInfoTexto";
            lblInfoTexto.Size = new Size(199, 82);
            lblInfoTexto.TabIndex = 1;
            lblInfoTexto.Text = "Este módulo cierra el circuito: comprobantes, honorarios profesionales y presentación a obra social.";
            // 
            // lblInfoTitulo
            // 
            lblInfoTitulo.AutoSize = true;
            lblInfoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblInfoTitulo.Location = new Point(15, 15);
            lblInfoTitulo.Name = "lblInfoTitulo";
            lblInfoTitulo.Size = new Size(89, 19);
            lblInfoTitulo.TabIndex = 0;
            lblInfoTitulo.Text = "Información";
            // 
            // lblLotesValor
            // 
            lblLotesValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotesValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblLotesValor.Location = new Point(180, 352);
            lblLotesValor.Name = "lblLotesValor";
            lblLotesValor.Size = new Size(76, 31);
            lblLotesValor.TabIndex = 10;
            lblLotesValor.Text = "0";
            lblLotesValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHonorariosValor
            // 
            lblHonorariosValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHonorariosValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblHonorariosValor.Location = new Point(180, 307);
            lblHonorariosValor.Name = "lblHonorariosValor";
            lblHonorariosValor.Size = new Size(76, 31);
            lblHonorariosValor.TabIndex = 9;
            lblHonorariosValor.Text = "0";
            lblHonorariosValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblComprobantesValor
            // 
            lblComprobantesValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobantesValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblComprobantesValor.Location = new Point(180, 262);
            lblComprobantesValor.Name = "lblComprobantesValor";
            lblComprobantesValor.Size = new Size(76, 31);
            lblComprobantesValor.TabIndex = 8;
            lblComprobantesValor.Text = "0";
            lblComprobantesValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPendientesValor
            // 
            lblPendientesValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendientesValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblPendientesValor.Location = new Point(180, 217);
            lblPendientesValor.Name = "lblPendientesValor";
            lblPendientesValor.Size = new Size(76, 31);
            lblPendientesValor.TabIndex = 7;
            lblPendientesValor.Text = "0";
            lblPendientesValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLotesTitulo
            // 
            lblLotesTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotesTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblLotesTitulo.Location = new Point(28, 360);
            lblLotesTitulo.Name = "lblLotesTitulo";
            lblLotesTitulo.Size = new Size(135, 19);
            lblLotesTitulo.TabIndex = 6;
            lblLotesTitulo.Text = "Presentaciones";
            // 
            // lblHonorariosTitulo
            // 
            lblHonorariosTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblHonorariosTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblHonorariosTitulo.Location = new Point(28, 315);
            lblHonorariosTitulo.Name = "lblHonorariosTitulo";
            lblHonorariosTitulo.Size = new Size(135, 19);
            lblHonorariosTitulo.TabIndex = 5;
            lblHonorariosTitulo.Text = "Honorarios";
            // 
            // lblComprobantesTitulo
            // 
            lblComprobantesTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobantesTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblComprobantesTitulo.Location = new Point(28, 270);
            lblComprobantesTitulo.Name = "lblComprobantesTitulo";
            lblComprobantesTitulo.Size = new Size(135, 19);
            lblComprobantesTitulo.TabIndex = 4;
            lblComprobantesTitulo.Text = "Comprobantes";
            // 
            // lblPendientesTitulo
            // 
            lblPendientesTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblPendientesTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblPendientesTitulo.Location = new Point(28, 225);
            lblPendientesTitulo.Name = "lblPendientesTitulo";
            lblPendientesTitulo.Size = new Size(145, 19);
            lblPendientesTitulo.TabIndex = 3;
            lblPendientesTitulo.Text = "Pendientes";
            // 
            // lblResumenTitulo
            // 
            lblResumenTitulo.AutoSize = true;
            lblResumenTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResumenTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblResumenTitulo.Location = new Point(24, 180);
            lblResumenTitulo.Name = "lblResumenTitulo";
            lblResumenTitulo.Size = new Size(185, 21);
            lblResumenTitulo.TabIndex = 2;
            lblResumenTitulo.Text = "Resumen administrativo";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(24, 92);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(232, 72);
            lblPanelTexto.TabIndex = 1;
            lblPanelTexto.Text = "Gestione comprobantes, honorarios y presentaciones a financiadores del circuito de Consultorios Externos.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(24, 36);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(215, 37);
            lblPanelTitulo.TabIndex = 0;
            lblPanelTitulo.Text = "💲 Liquidaciones";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(btnActualizar);
            pnlContenido.Controls.Add(tabLiquidaciones);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.FromArgb(26, 82, 150);
            btnActualizar.Location = new Point(650, 611);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(162, 40);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar listados";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tabLiquidaciones
            // 
            tabLiquidaciones.Controls.Add(tabComprobantes);
            tabLiquidaciones.Controls.Add(tabHonorarios);
            tabLiquidaciones.Controls.Add(tabObraSocial);
            tabLiquidaciones.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            tabLiquidaciones.Location = new Point(28, 145);
            tabLiquidaciones.Name = "tabLiquidaciones";
            tabLiquidaciones.SelectedIndex = 0;
            tabLiquidaciones.Size = new Size(784, 448);
            tabLiquidaciones.TabIndex = 1;
            // 
            // tabComprobantes
            // 
            tabComprobantes.BackColor = Color.FromArgb(250, 252, 255);
            tabComprobantes.Controls.Add(dgvComprobantes);
            tabComprobantes.Controls.Add(lblCantidadComprobantes);
            tabComprobantes.Controls.Add(gbComprobante);
            tabComprobantes.Location = new Point(4, 26);
            tabComprobantes.Name = "tabComprobantes";
            tabComprobantes.Padding = new Padding(3);
            tabComprobantes.Size = new Size(776, 418);
            tabComprobantes.TabIndex = 0;
            tabComprobantes.Text = "Comprobantes";
            // 
            // dgvComprobantes
            // 
            dgvComprobantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComprobantes.Location = new Point(17, 146);
            dgvComprobantes.Name = "dgvComprobantes";
            dgvComprobantes.RowTemplate.Height = 25;
            dgvComprobantes.Size = new Size(742, 252);
            dgvComprobantes.TabIndex = 2;
            // 
            // lblCantidadComprobantes
            // 
            lblCantidadComprobantes.AutoSize = true;
            lblCantidadComprobantes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadComprobantes.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadComprobantes.Location = new Point(18, 122);
            lblCantidadComprobantes.Name = "lblCantidadComprobantes";
            lblCantidadComprobantes.Size = new Size(142, 15);
            lblCantidadComprobantes.TabIndex = 1;
            lblCantidadComprobantes.Text = "Comprobantes emitidos: 0";
            // 
            // gbComprobante
            // 
            gbComprobante.BackColor = Color.White;
            gbComprobante.BorderStyle = BorderStyle.FixedSingle;
            gbComprobante.Controls.Add(btnGenerarComprobante);
            gbComprobante.Controls.Add(cmbTurnoComprobante);
            gbComprobante.Controls.Add(lblTurnoComprobante);
            gbComprobante.Controls.Add(lblComprobanteTitulo);
            gbComprobante.Location = new Point(17, 15);
            gbComprobante.Name = "gbComprobante";
            gbComprobante.Size = new Size(742, 95);
            gbComprobante.TabIndex = 0;
            // 
            // btnGenerarComprobante
            // 
            btnGenerarComprobante.BackColor = Color.FromArgb(26, 82, 150);
            btnGenerarComprobante.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnGenerarComprobante.FlatStyle = FlatStyle.Flat;
            btnGenerarComprobante.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarComprobante.ForeColor = Color.White;
            btnGenerarComprobante.Location = new Point(545, 41);
            btnGenerarComprobante.Name = "btnGenerarComprobante";
            btnGenerarComprobante.Size = new Size(174, 34);
            btnGenerarComprobante.TabIndex = 3;
            btnGenerarComprobante.Text = "Generar comprobante";
            btnGenerarComprobante.UseVisualStyleBackColor = false;
            btnGenerarComprobante.Click += btnGenerarComprobante_Click;
            // 
            // cmbTurnoComprobante
            // 
            cmbTurnoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurnoComprobante.FormattingEnabled = true;
            cmbTurnoComprobante.Location = new Point(136, 47);
            cmbTurnoComprobante.Name = "cmbTurnoComprobante";
            cmbTurnoComprobante.Size = new Size(388, 25);
            cmbTurnoComprobante.TabIndex = 2;
            // 
            // lblTurnoComprobante
            // 
            lblTurnoComprobante.AutoSize = true;
            lblTurnoComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnoComprobante.ForeColor = Color.FromArgb(26, 82, 150);
            lblTurnoComprobante.Location = new Point(17, 51);
            lblTurnoComprobante.Name = "lblTurnoComprobante";
            lblTurnoComprobante.Size = new Size(96, 15);
            lblTurnoComprobante.TabIndex = 1;
            lblTurnoComprobante.Text = "Turno atendido";
            // 
            // lblComprobanteTitulo
            // 
            lblComprobanteTitulo.AutoSize = true;
            lblComprobanteTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblComprobanteTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblComprobanteTitulo.Location = new Point(16, 14);
            lblComprobanteTitulo.Name = "lblComprobanteTitulo";
            lblComprobanteTitulo.Size = new Size(221, 20);
            lblComprobanteTitulo.TabIndex = 0;
            lblComprobanteTitulo.Text = "Generar comprobante de pago";
            // 
            // tabHonorarios
            // 
            tabHonorarios.BackColor = Color.FromArgb(250, 252, 255);
            tabHonorarios.Controls.Add(dgvHonorarios);
            tabHonorarios.Controls.Add(lblCantidadHonorarios);
            tabHonorarios.Controls.Add(gbHonorarios);
            tabHonorarios.Location = new Point(4, 26);
            tabHonorarios.Name = "tabHonorarios";
            tabHonorarios.Padding = new Padding(3);
            tabHonorarios.Size = new Size(776, 418);
            tabHonorarios.TabIndex = 1;
            tabHonorarios.Text = "Honorarios";
            // 
            // dgvHonorarios
            // 
            dgvHonorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHonorarios.Location = new Point(17, 146);
            dgvHonorarios.Name = "dgvHonorarios";
            dgvHonorarios.RowTemplate.Height = 25;
            dgvHonorarios.Size = new Size(742, 252);
            dgvHonorarios.TabIndex = 2;
            // 
            // lblCantidadHonorarios
            // 
            lblCantidadHonorarios.AutoSize = true;
            lblCantidadHonorarios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadHonorarios.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadHonorarios.Location = new Point(18, 122);
            lblCantidadHonorarios.Name = "lblCantidadHonorarios";
            lblCantidadHonorarios.Size = new Size(154, 15);
            lblCantidadHonorarios.TabIndex = 1;
            lblCantidadHonorarios.Text = "Liquidaciones generadas: 0";
            // 
            // gbHonorarios
            // 
            gbHonorarios.BackColor = Color.White;
            gbHonorarios.BorderStyle = BorderStyle.FixedSingle;
            gbHonorarios.Controls.Add(btnLiquidarHonorarios);
            gbHonorarios.Controls.Add(dtpPeriodoHonorarios);
            gbHonorarios.Controls.Add(lblPeriodoHonorarios);
            gbHonorarios.Controls.Add(cmbProfesional);
            gbHonorarios.Controls.Add(lblProfesional);
            gbHonorarios.Controls.Add(lblHonorariosPanelTitulo);
            gbHonorarios.Location = new Point(17, 15);
            gbHonorarios.Name = "gbHonorarios";
            gbHonorarios.Size = new Size(742, 95);
            gbHonorarios.TabIndex = 0;
            // 
            // btnLiquidarHonorarios
            // 
            btnLiquidarHonorarios.BackColor = Color.FromArgb(26, 82, 150);
            btnLiquidarHonorarios.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnLiquidarHonorarios.FlatStyle = FlatStyle.Flat;
            btnLiquidarHonorarios.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLiquidarHonorarios.ForeColor = Color.White;
            btnLiquidarHonorarios.Location = new Point(545, 41);
            btnLiquidarHonorarios.Name = "btnLiquidarHonorarios";
            btnLiquidarHonorarios.Size = new Size(174, 34);
            btnLiquidarHonorarios.TabIndex = 5;
            btnLiquidarHonorarios.Text = "Liquidar honorarios";
            btnLiquidarHonorarios.UseVisualStyleBackColor = false;
            btnLiquidarHonorarios.Click += btnLiquidarHonorarios_Click;
            // 
            // dtpPeriodoHonorarios
            // 
            dtpPeriodoHonorarios.Location = new Point(425, 47);
            dtpPeriodoHonorarios.Name = "dtpPeriodoHonorarios";
            dtpPeriodoHonorarios.Size = new Size(98, 24);
            dtpPeriodoHonorarios.TabIndex = 4;
            // 
            // lblPeriodoHonorarios
            // 
            lblPeriodoHonorarios.AutoSize = true;
            lblPeriodoHonorarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeriodoHonorarios.ForeColor = Color.FromArgb(26, 82, 150);
            lblPeriodoHonorarios.Location = new Point(360, 51);
            lblPeriodoHonorarios.Name = "lblPeriodoHonorarios";
            lblPeriodoHonorarios.Size = new Size(49, 15);
            lblPeriodoHonorarios.TabIndex = 3;
            lblPeriodoHonorarios.Text = "Período";
            // 
            // cmbProfesional
            // 
            cmbProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfesional.FormattingEnabled = true;
            cmbProfesional.Location = new Point(106, 47);
            cmbProfesional.Name = "cmbProfesional";
            cmbProfesional.Size = new Size(230, 25);
            cmbProfesional.TabIndex = 2;
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblProfesional.Location = new Point(17, 51);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(69, 15);
            lblProfesional.TabIndex = 1;
            lblProfesional.Text = "Profesional";
            // 
            // lblHonorariosPanelTitulo
            // 
            lblHonorariosPanelTitulo.AutoSize = true;
            lblHonorariosPanelTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblHonorariosPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblHonorariosPanelTitulo.Location = new Point(16, 14);
            lblHonorariosPanelTitulo.Name = "lblHonorariosPanelTitulo";
            lblHonorariosPanelTitulo.Size = new Size(256, 20);
            lblHonorariosPanelTitulo.TabIndex = 0;
            lblHonorariosPanelTitulo.Text = "Liquidar honorarios profesionales";
            // 
            // tabObraSocial
            // 
            tabObraSocial.BackColor = Color.FromArgb(250, 252, 255);
            tabObraSocial.Controls.Add(dgvLotes);
            tabObraSocial.Controls.Add(lblCantidadLotes);
            tabObraSocial.Controls.Add(gbObraSocial);
            tabObraSocial.Location = new Point(4, 26);
            tabObraSocial.Name = "tabObraSocial";
            tabObraSocial.Size = new Size(776, 418);
            tabObraSocial.TabIndex = 2;
            tabObraSocial.Text = "Obra social";
            // 
            // dgvLotes
            // 
            dgvLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotes.Location = new Point(17, 146);
            dgvLotes.Name = "dgvLotes";
            dgvLotes.RowTemplate.Height = 25;
            dgvLotes.Size = new Size(742, 252);
            dgvLotes.TabIndex = 2;
            // 
            // lblCantidadLotes
            // 
            lblCantidadLotes.AutoSize = true;
            lblCantidadLotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadLotes.ForeColor = Color.FromArgb(90, 103, 130);
            lblCantidadLotes.Location = new Point(18, 122);
            lblCantidadLotes.Name = "lblCantidadLotes";
            lblCantidadLotes.Size = new Size(158, 15);
            lblCantidadLotes.TabIndex = 1;
            lblCantidadLotes.Text = "Presentaciones realizadas: 0";
            // 
            // gbObraSocial
            // 
            gbObraSocial.BackColor = Color.White;
            gbObraSocial.BorderStyle = BorderStyle.FixedSingle;
            gbObraSocial.Controls.Add(btnPresentarObraSocial);
            gbObraSocial.Controls.Add(dtpPeriodoObraSocial);
            gbObraSocial.Controls.Add(lblPeriodoObraSocial);
            gbObraSocial.Controls.Add(cmbObraSocial);
            gbObraSocial.Controls.Add(lblObraSocial);
            gbObraSocial.Controls.Add(lblObraSocialPanelTitulo);
            gbObraSocial.Location = new Point(17, 15);
            gbObraSocial.Name = "gbObraSocial";
            gbObraSocial.Size = new Size(742, 95);
            gbObraSocial.TabIndex = 0;
            // 
            // btnPresentarObraSocial
            // 
            btnPresentarObraSocial.BackColor = Color.FromArgb(26, 82, 150);
            btnPresentarObraSocial.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnPresentarObraSocial.FlatStyle = FlatStyle.Flat;
            btnPresentarObraSocial.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnPresentarObraSocial.ForeColor = Color.White;
            btnPresentarObraSocial.Location = new Point(545, 41);
            btnPresentarObraSocial.Name = "btnPresentarObraSocial";
            btnPresentarObraSocial.Size = new Size(174, 34);
            btnPresentarObraSocial.TabIndex = 5;
            btnPresentarObraSocial.Text = "Presentar a obra social";
            btnPresentarObraSocial.UseVisualStyleBackColor = false;
            btnPresentarObraSocial.Click += btnPresentarObraSocial_Click;
            // 
            // dtpPeriodoObraSocial
            // 
            dtpPeriodoObraSocial.Location = new Point(425, 47);
            dtpPeriodoObraSocial.Name = "dtpPeriodoObraSocial";
            dtpPeriodoObraSocial.Size = new Size(98, 24);
            dtpPeriodoObraSocial.TabIndex = 4;
            // 
            // lblPeriodoObraSocial
            // 
            lblPeriodoObraSocial.AutoSize = true;
            lblPeriodoObraSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeriodoObraSocial.ForeColor = Color.FromArgb(26, 82, 150);
            lblPeriodoObraSocial.Location = new Point(360, 51);
            lblPeriodoObraSocial.Name = "lblPeriodoObraSocial";
            lblPeriodoObraSocial.Size = new Size(49, 15);
            lblPeriodoObraSocial.TabIndex = 3;
            lblPeriodoObraSocial.Text = "Período";
            // 
            // cmbObraSocial
            // 
            cmbObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObraSocial.FormattingEnabled = true;
            cmbObraSocial.Location = new Point(106, 47);
            cmbObraSocial.Name = "cmbObraSocial";
            cmbObraSocial.Size = new Size(230, 25);
            cmbObraSocial.TabIndex = 2;
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocial.ForeColor = Color.FromArgb(26, 82, 150);
            lblObraSocial.Location = new Point(17, 51);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(73, 15);
            lblObraSocial.TabIndex = 1;
            lblObraSocial.Text = "Financiador";
            // 
            // lblObraSocialPanelTitulo
            // 
            lblObraSocialPanelTitulo.AutoSize = true;
            lblObraSocialPanelTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocialPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblObraSocialPanelTitulo.Location = new Point(16, 14);
            lblObraSocialPanelTitulo.Name = "lblObraSocialPanelTitulo";
            lblObraSocialPanelTitulo.Size = new Size(263, 20);
            lblObraSocialPanelTitulo.TabIndex = 0;
            lblObraSocialPanelTitulo.Text = "Presentar liquidación a financiador";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 130);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 97);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(209, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Cierre administrativo del circuito";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(596, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Genere comprobantes, liquide honorarios y presente prestaciones a obras sociales.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(393, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Liquidaciones y facturación";
            // 
            // FrmLiquidaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLiquidaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Liquidaciones - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlInfoLateral.ResumeLayout(false);
            pnlInfoLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            tabLiquidaciones.ResumeLayout(false);
            tabComprobantes.ResumeLayout(false);
            tabComprobantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).EndInit();
            gbComprobante.ResumeLayout(false);
            gbComprobante.PerformLayout();
            tabHonorarios.ResumeLayout(false);
            tabHonorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHonorarios).EndInit();
            gbHonorarios.ResumeLayout(false);
            gbHonorarios.PerformLayout();
            tabObraSocial.ResumeLayout(false);
            tabObraSocial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).EndInit();
            gbObraSocial.ResumeLayout(false);
            gbObraSocial.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}
