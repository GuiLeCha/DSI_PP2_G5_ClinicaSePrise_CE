namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlUsuario;
        private Panel pnlFechaHora;
        private Panel pnlInfo;
        private Panel pnlEncabezado;
        private Panel pnlPie;
        private TableLayoutPanel tlpModulos;
        private Label lblLogoIcono;
        private Label lblLogoClinica;
        private Label lblLogoSubtitulo;
        private Label lblUsuarioTitulo;
        private Label lblUsuarioActual;
        private Label lblRolActual;
        private Label lblFechaTitulo;
        private Label lblFechaActual;
        private Label lblHoraActual;
        private Label lblInfoTitulo;
        private Label lblInfoTexto;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblAccesosTitulo;
        private Label lblAccesosTexto;
        private Button btnPacientes;
        private Button btnAgenda;
        private Button btnTurnos;
        private Button btnRecepcion;
        private Button btnAtencion;
        private Button btnHistorial;
        private Button btnLiquidaciones;
        private Button btnSalir;

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
            btnSalir = new Button();
            pnlInfo = new Panel();
            lblInfoTexto = new Label();
            lblInfoTitulo = new Label();
            pnlFechaHora = new Panel();
            lblHoraActual = new Label();
            lblFechaActual = new Label();
            lblFechaTitulo = new Label();
            pnlUsuario = new Panel();
            lblRolActual = new Label();
            lblUsuarioActual = new Label();
            lblUsuarioTitulo = new Label();
            lblLogoSubtitulo = new Label();
            lblLogoClinica = new Label();
            lblLogoIcono = new Label();
            pnlContenido = new Panel();
            tlpModulos = new TableLayoutPanel();
            btnPacientes = new Button();
            btnAgenda = new Button();
            btnTurnos = new Button();
            btnRecepcion = new Button();
            btnAtencion = new Button();
            btnHistorial = new Button();
            btnLiquidaciones = new Button();
            pnlPie = new Panel();
            lblAccesosTexto = new Label();
            lblAccesosTitulo = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlFechaHora.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlContenido.SuspendLayout();
            tlpModulos.SuspendLayout();
            pnlPie.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();

            // pnlLateral
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(btnSalir);
            pnlLateral.Controls.Add(pnlInfo);
            pnlLateral.Controls.Add(pnlFechaHora);
            pnlLateral.Controls.Add(pnlUsuario);
            pnlLateral.Controls.Add(lblLogoSubtitulo);
            pnlLateral.Controls.Add(lblLogoClinica);
            pnlLateral.Controls.Add(lblLogoIcono);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;

            // btnSalir
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(26, 82, 150);
            btnSalir.Location = new Point(24, 610);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(232, 42);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cerrar sesión";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // pnlInfo
            pnlInfo.BackColor = Color.FromArgb(248, 251, 255);
            pnlInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlInfo.Controls.Add(lblInfoTexto);
            pnlInfo.Controls.Add(lblInfoTitulo);
            pnlInfo.Location = new Point(24, 392);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(232, 164);
            pnlInfo.TabIndex = 8;

            // lblInfoTexto
            lblInfoTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblInfoTexto.Location = new Point(18, 50);
            lblInfoTexto.Name = "lblInfoTexto";
            lblInfoTexto.Size = new Size(195, 92);
            lblInfoTexto.TabIndex = 1;
            lblInfoTexto.Text = "Seleccione un módulo para continuar con el circuito de Consultorios Externos.";

            // lblInfoTitulo
            lblInfoTitulo.AutoSize = true;
            lblInfoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblInfoTitulo.Location = new Point(18, 18);
            lblInfoTitulo.Name = "lblInfoTitulo";
            lblInfoTitulo.Size = new Size(89, 19);
            lblInfoTitulo.TabIndex = 0;
            lblInfoTitulo.Text = "Información";

            // pnlFechaHora
            pnlFechaHora.BackColor = Color.FromArgb(248, 251, 255);
            pnlFechaHora.BorderStyle = BorderStyle.FixedSingle;
            pnlFechaHora.Controls.Add(lblHoraActual);
            pnlFechaHora.Controls.Add(lblFechaActual);
            pnlFechaHora.Controls.Add(lblFechaTitulo);
            pnlFechaHora.Location = new Point(24, 250);
            pnlFechaHora.Name = "pnlFechaHora";
            pnlFechaHora.Size = new Size(232, 112);
            pnlFechaHora.TabIndex = 7;

            // lblHoraActual
            lblHoraActual.AutoSize = true;
            lblHoraActual.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraActual.ForeColor = Color.FromArgb(20, 36, 70);
            lblHoraActual.Location = new Point(17, 60);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(77, 32);
            lblHoraActual.TabIndex = 2;
            lblHoraActual.Text = "00:00";

            // lblFechaActual
            lblFechaActual.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaActual.ForeColor = Color.FromArgb(42, 58, 92);
            lblFechaActual.Location = new Point(18, 34);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(195, 18);
            lblFechaActual.TabIndex = 1;
            lblFechaActual.Text = "lunes, 01 de enero de 2026";

            // lblFechaTitulo
            lblFechaTitulo.AutoSize = true;
            lblFechaTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblFechaTitulo.Location = new Point(18, 12);
            lblFechaTitulo.Name = "lblFechaTitulo";
            lblFechaTitulo.Size = new Size(107, 19);
            lblFechaTitulo.TabIndex = 0;
            lblFechaTitulo.Text = "Fecha y horario";

            // pnlUsuario
            pnlUsuario.BackColor = Color.FromArgb(248, 251, 255);
            pnlUsuario.BorderStyle = BorderStyle.FixedSingle;
            pnlUsuario.Controls.Add(lblRolActual);
            pnlUsuario.Controls.Add(lblUsuarioActual);
            pnlUsuario.Controls.Add(lblUsuarioTitulo);
            pnlUsuario.Location = new Point(24, 126);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(232, 94);
            pnlUsuario.TabIndex = 6;

            // lblRolActual
            lblRolActual.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblRolActual.ForeColor = Color.FromArgb(26, 82, 150);
            lblRolActual.Location = new Point(18, 62);
            lblRolActual.Name = "lblRolActual";
            lblRolActual.Size = new Size(195, 18);
            lblRolActual.TabIndex = 2;
            lblRolActual.Text = "Rol:";

            // lblUsuarioActual
            lblUsuarioActual.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioActual.ForeColor = Color.FromArgb(20, 36, 70);
            lblUsuarioActual.Location = new Point(18, 39);
            lblUsuarioActual.Name = "lblUsuarioActual";
            lblUsuarioActual.Size = new Size(195, 19);
            lblUsuarioActual.TabIndex = 1;
            lblUsuarioActual.Text = "Usuario";

            // lblUsuarioTitulo
            lblUsuarioTitulo.AutoSize = true;
            lblUsuarioTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblUsuarioTitulo.Location = new Point(18, 14);
            lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            lblUsuarioTitulo.Size = new Size(105, 19);
            lblUsuarioTitulo.TabIndex = 0;
            lblUsuarioTitulo.Text = "Usuario actual";

            // lblLogoSubtitulo
            lblLogoSubtitulo.AutoSize = true;
            lblLogoSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogoSubtitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblLogoSubtitulo.Location = new Point(104, 83);
            lblLogoSubtitulo.Name = "lblLogoSubtitulo";
            lblLogoSubtitulo.Size = new Size(124, 15);
            lblLogoSubtitulo.TabIndex = 2;
            lblLogoSubtitulo.Text = "Consultorios Externos";

            // lblLogoClinica
            lblLogoClinica.AutoSize = true;
            lblLogoClinica.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogoClinica.ForeColor = Color.FromArgb(20, 36, 70);
            lblLogoClinica.Location = new Point(99, 47);
            lblLogoClinica.Name = "lblLogoClinica";
            lblLogoClinica.Size = new Size(104, 32);
            lblLogoClinica.TabIndex = 1;
            lblLogoClinica.Text = "SePrise";

            // lblLogoIcono
            lblLogoIcono.AutoSize = true;
            lblLogoIcono.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogoIcono.ForeColor = Color.FromArgb(26, 82, 150);
            lblLogoIcono.Location = new Point(35, 31);
            lblLogoIcono.Name = "lblLogoIcono";
            lblLogoIcono.Size = new Size(64, 62);
            lblLogoIcono.TabIndex = 0;
            lblLogoIcono.Text = "✚";

            // pnlContenido
            pnlContenido.BackColor = Color.FromArgb(250, 252, 255);
            pnlContenido.Controls.Add(tlpModulos);
            pnlContenido.Controls.Add(pnlPie);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;

            // tlpModulos
            tlpModulos.ColumnCount = 4;
            tlpModulos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpModulos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpModulos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpModulos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpModulos.Controls.Add(btnPacientes, 0, 0);
            tlpModulos.Controls.Add(btnAgenda, 1, 0);
            tlpModulos.Controls.Add(btnTurnos, 2, 0);
            tlpModulos.Controls.Add(btnRecepcion, 3, 0);
            tlpModulos.Controls.Add(btnAtencion, 0, 1);
            tlpModulos.Controls.Add(btnHistorial, 1, 1);
            tlpModulos.Controls.Add(btnLiquidaciones, 2, 1);
            tlpModulos.Location = new Point(28, 167);
            tlpModulos.Name = "tlpModulos";
            tlpModulos.RowCount = 2;
            tlpModulos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpModulos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpModulos.Size = new Size(784, 365);
            tlpModulos.TabIndex = 1;

            // btnPacientes
            btnPacientes.BackColor = Color.White;
            btnPacientes.Dock = DockStyle.Fill;
            btnPacientes.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnPacientes.ForeColor = Color.FromArgb(20, 36, 70);
            btnPacientes.Location = new Point(9, 9);
            btnPacientes.Margin = new Padding(9);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(178, 164);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "👥\r\nPacientes\r\n\r\nDatos personales y de contacto";
            btnPacientes.TextAlign = ContentAlignment.MiddleCenter;
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;

            // btnAgenda
            btnAgenda.BackColor = Color.White;
            btnAgenda.Dock = DockStyle.Fill;
            btnAgenda.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgenda.ForeColor = Color.FromArgb(20, 36, 70);
            btnAgenda.Location = new Point(205, 9);
            btnAgenda.Margin = new Padding(9);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(178, 164);
            btnAgenda.TabIndex = 1;
            btnAgenda.Text = "📅\r\nAgenda médica\r\n\r\nProfesionales, días y horarios";
            btnAgenda.TextAlign = ContentAlignment.MiddleCenter;
            btnAgenda.UseVisualStyleBackColor = false;
            btnAgenda.Click += btnAgenda_Click;

            // btnTurnos
            btnTurnos.BackColor = Color.White;
            btnTurnos.Dock = DockStyle.Fill;
            btnTurnos.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnTurnos.ForeColor = Color.FromArgb(20, 36, 70);
            btnTurnos.Location = new Point(401, 9);
            btnTurnos.Margin = new Padding(9);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(178, 164);
            btnTurnos.TabIndex = 2;
            btnTurnos.Text = "🎫\r\nTurnos\r\n\r\nAsignar, confirmar y reprogramar";
            btnTurnos.TextAlign = ContentAlignment.MiddleCenter;
            btnTurnos.UseVisualStyleBackColor = false;
            btnTurnos.Click += btnTurnos_Click;

            // btnRecepcion
            btnRecepcion.BackColor = Color.White;
            btnRecepcion.Dock = DockStyle.Fill;
            btnRecepcion.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnRecepcion.FlatStyle = FlatStyle.Flat;
            btnRecepcion.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecepcion.ForeColor = Color.FromArgb(20, 36, 70);
            btnRecepcion.Location = new Point(597, 9);
            btnRecepcion.Margin = new Padding(9);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(178, 164);
            btnRecepcion.TabIndex = 3;
            btnRecepcion.Text = "🖥\r\nRecepción\r\n\r\nLlegada, cobertura y admisión";
            btnRecepcion.TextAlign = ContentAlignment.MiddleCenter;
            btnRecepcion.UseVisualStyleBackColor = false;
            btnRecepcion.Click += btnRecepcion_Click;

            // btnAtencion
            btnAtencion.BackColor = Color.White;
            btnAtencion.Dock = DockStyle.Fill;
            btnAtencion.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtencion.ForeColor = Color.FromArgb(20, 36, 70);
            btnAtencion.Location = new Point(9, 191);
            btnAtencion.Margin = new Padding(9);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(178, 165);
            btnAtencion.TabIndex = 4;
            btnAtencion.Text = "⚕\r\nAtención médica\r\n\r\nRegistrar consulta e indicaciones";
            btnAtencion.TextAlign = ContentAlignment.MiddleCenter;
            btnAtencion.UseVisualStyleBackColor = false;
            btnAtencion.Click += btnAtencion_Click;

            // btnHistorial
            btnHistorial.BackColor = Color.White;
            btnHistorial.Dock = DockStyle.Fill;
            btnHistorial.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.FromArgb(20, 36, 70);
            btnHistorial.Location = new Point(205, 191);
            btnHistorial.Margin = new Padding(9);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(178, 165);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "📁\r\nHistorial\r\n\r\nConsultar atenciones realizadas";
            btnHistorial.TextAlign = ContentAlignment.MiddleCenter;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;

            // btnLiquidaciones
            btnLiquidaciones.BackColor = Color.White;
            btnLiquidaciones.Dock = DockStyle.Fill;
            btnLiquidaciones.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLiquidaciones.FlatStyle = FlatStyle.Flat;
            btnLiquidaciones.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLiquidaciones.ForeColor = Color.FromArgb(20, 36, 70);
            btnLiquidaciones.Location = new Point(401, 191);
            btnLiquidaciones.Margin = new Padding(9);
            btnLiquidaciones.Name = "btnLiquidaciones";
            btnLiquidaciones.Size = new Size(178, 165);
            btnLiquidaciones.TabIndex = 6;
            btnLiquidaciones.Text = "💲\r\nLiquidaciones\r\n\r\nComprobantes y honorarios";
            btnLiquidaciones.TextAlign = ContentAlignment.MiddleCenter;
            btnLiquidaciones.UseVisualStyleBackColor = false;
            btnLiquidaciones.Click += btnLiquidaciones_Click;

            // pnlPie
            pnlPie.BackColor = Color.FromArgb(238, 246, 255);
            pnlPie.BorderStyle = BorderStyle.FixedSingle;
            pnlPie.Controls.Add(lblAccesosTexto);
            pnlPie.Controls.Add(lblAccesosTitulo);
            pnlPie.Location = new Point(28, 565);
            pnlPie.Name = "pnlPie";
            pnlPie.Size = new Size(784, 78);
            pnlPie.TabIndex = 2;

            // lblAccesosTexto
            lblAccesosTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccesosTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblAccesosTexto.Location = new Point(23, 41);
            lblAccesosTexto.Name = "lblAccesosTexto";
            lblAccesosTexto.Size = new Size(725, 22);
            lblAccesosTexto.TabIndex = 1;
            lblAccesosTexto.Text = "Los módulos disponibles se habilitan según el rol del usuario.";

            // lblAccesosTitulo
            lblAccesosTitulo.AutoSize = true;
            lblAccesosTitulo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccesosTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblAccesosTitulo.Location = new Point(23, 17);
            lblAccesosTitulo.Name = "lblAccesosTitulo";
            lblAccesosTitulo.Size = new Size(197, 19);
            lblAccesosTitulo.TabIndex = 0;
            lblAccesosTitulo.Text = "Accesos habilitados por rol";

            // pnlEncabezado
            pnlEncabezado.BackColor = Color.FromArgb(250, 252, 255);
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 140);
            pnlEncabezado.TabIndex = 0;

            // lblSeccion
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 106);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(237, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Circuito principal de atención";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(344, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione el módulo al que desea acceder.";

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(536, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clínica SePrise - Consultorios Externos";

            // FrmMenuPrincipal
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clínica SePrise - Consultorios Externos";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlFechaHora.ResumeLayout(false);
            pnlFechaHora.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlContenido.ResumeLayout(false);
            tlpModulos.ResumeLayout(false);
            pnlPie.ResumeLayout(false);
            pnlPie.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}