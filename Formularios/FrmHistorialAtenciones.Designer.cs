namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmHistorialAtenciones
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlEncabezado;
        private Panel gbBusqueda;
        private Panel gbListado;
        private Panel gbDetalle;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;
        private Label lblPanelTitulo;
        private Label lblPanelTexto;
        private Label lblSeleccionTitulo;
        private Label lblAtencionNumero;
        private Label lblAtencionPaciente;
        private Label lblAtencionFecha;
        private Label lblAtencionProfesional;
        private Label lblAtencionEstado;
        private Label lblAtencionNumeroValor;
        private Label lblAtencionPacienteValor;
        private Label lblAtencionFechaValor;
        private Label lblAtencionProfesionalValor;
        private Label lblAtencionEstadoValor;
        private Label lblPaciente;
        private Label lblCantidad;
        private Label lblCantidadDato;
        private Label lblListadoTitulo;
        private Label lblDetalleTitulo;
        private ComboBox cmbPaciente;
        private Button btnBuscar;
        private DataGridView dgvHistorial;
        private TextBox txtDetalleAtencion;
        private Button btnLimpiar;
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
            lblAtencionEstadoValor = new Label();
            lblAtencionProfesionalValor = new Label();
            lblAtencionFechaValor = new Label();
            lblAtencionPacienteValor = new Label();
            lblAtencionNumeroValor = new Label();
            lblAtencionEstado = new Label();
            lblAtencionProfesional = new Label();
            lblAtencionFecha = new Label();
            lblAtencionPaciente = new Label();
            lblAtencionNumero = new Label();
            lblSeleccionTitulo = new Label();
            lblPanelTexto = new Label();
            lblPanelTitulo = new Label();
            btnCerrar = new Button();
            pnlContenido = new Panel();
            gbDetalle = new Panel();
            btnLimpiar = new Button();
            txtDetalleAtencion = new TextBox();
            lblDetalleTitulo = new Label();
            gbListado = new Panel();
            dgvHistorial = new DataGridView();
            lblListadoTitulo = new Label();
            gbBusqueda = new Panel();
            lblCantidadDato = new Label();
            lblCantidad = new Label();
            btnBuscar = new Button();
            cmbPaciente = new ComboBox();
            lblPaciente = new Label();
            pnlEncabezado = new Panel();
            lblSeccion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlContenido.SuspendLayout();
            gbDetalle.SuspendLayout();
            gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            gbBusqueda.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(lblAtencionEstadoValor);
            pnlLateral.Controls.Add(lblAtencionProfesionalValor);
            pnlLateral.Controls.Add(lblAtencionFechaValor);
            pnlLateral.Controls.Add(lblAtencionPacienteValor);
            pnlLateral.Controls.Add(lblAtencionNumeroValor);
            pnlLateral.Controls.Add(lblAtencionEstado);
            pnlLateral.Controls.Add(lblAtencionProfesional);
            pnlLateral.Controls.Add(lblAtencionFecha);
            pnlLateral.Controls.Add(lblAtencionPaciente);
            pnlLateral.Controls.Add(lblAtencionNumero);
            pnlLateral.Controls.Add(lblSeleccionTitulo);
            pnlLateral.Controls.Add(lblPanelTexto);
            pnlLateral.Controls.Add(lblPanelTitulo);
            pnlLateral.Controls.Add(btnCerrar);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(280, 680);
            pnlLateral.TabIndex = 0;
            // 
            // lblAtencionEstadoValor
            // 
            lblAtencionEstadoValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionEstadoValor.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionEstadoValor.Location = new Point(32, 498);
            lblAtencionEstadoValor.Name = "lblAtencionEstadoValor";
            lblAtencionEstadoValor.Size = new Size(213, 22);
            lblAtencionEstadoValor.TabIndex = 13;
            lblAtencionEstadoValor.Text = "-";
            // 
            // lblAtencionProfesionalValor
            // 
            lblAtencionProfesionalValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencionProfesionalValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAtencionProfesionalValor.Location = new Point(32, 436);
            lblAtencionProfesionalValor.Name = "lblAtencionProfesionalValor";
            lblAtencionProfesionalValor.Size = new Size(213, 42);
            lblAtencionProfesionalValor.TabIndex = 12;
            lblAtencionProfesionalValor.Text = "-";
            // 
            // lblAtencionFechaValor
            // 
            lblAtencionFechaValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencionFechaValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAtencionFechaValor.Location = new Point(32, 381);
            lblAtencionFechaValor.Name = "lblAtencionFechaValor";
            lblAtencionFechaValor.Size = new Size(213, 22);
            lblAtencionFechaValor.TabIndex = 11;
            lblAtencionFechaValor.Text = "-";
            // 
            // lblAtencionPacienteValor
            // 
            lblAtencionPacienteValor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencionPacienteValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAtencionPacienteValor.Location = new Point(32, 318);
            lblAtencionPacienteValor.Name = "lblAtencionPacienteValor";
            lblAtencionPacienteValor.Size = new Size(213, 42);
            lblAtencionPacienteValor.TabIndex = 10;
            lblAtencionPacienteValor.Text = "-";
            // 
            // lblAtencionNumeroValor
            // 
            lblAtencionNumeroValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionNumeroValor.ForeColor = Color.FromArgb(20, 36, 70);
            lblAtencionNumeroValor.Location = new Point(32, 263);
            lblAtencionNumeroValor.Name = "lblAtencionNumeroValor";
            lblAtencionNumeroValor.Size = new Size(213, 22);
            lblAtencionNumeroValor.TabIndex = 9;
            lblAtencionNumeroValor.Text = "Sin selección";
            // 
            // lblAtencionEstado
            // 
            lblAtencionEstado.AutoSize = true;
            lblAtencionEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionEstado.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionEstado.Location = new Point(32, 480);
            lblAtencionEstado.Name = "lblAtencionEstado";
            lblAtencionEstado.Size = new Size(42, 15);
            lblAtencionEstado.TabIndex = 8;
            lblAtencionEstado.Text = "Estado";
            // 
            // lblAtencionProfesional
            // 
            lblAtencionProfesional.AutoSize = true;
            lblAtencionProfesional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionProfesional.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionProfesional.Location = new Point(32, 418);
            lblAtencionProfesional.Name = "lblAtencionProfesional";
            lblAtencionProfesional.Size = new Size(68, 15);
            lblAtencionProfesional.TabIndex = 7;
            lblAtencionProfesional.Text = "Profesional";
            // 
            // lblAtencionFecha
            // 
            lblAtencionFecha.AutoSize = true;
            lblAtencionFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionFecha.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionFecha.Location = new Point(32, 363);
            lblAtencionFecha.Name = "lblAtencionFecha";
            lblAtencionFecha.Size = new Size(97, 15);
            lblAtencionFecha.TabIndex = 6;
            lblAtencionFecha.Text = "Fecha de atención";
            // 
            // lblAtencionPaciente
            // 
            lblAtencionPaciente.AutoSize = true;
            lblAtencionPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionPaciente.Location = new Point(32, 300);
            lblAtencionPaciente.Name = "lblAtencionPaciente";
            lblAtencionPaciente.Size = new Size(51, 15);
            lblAtencionPaciente.TabIndex = 5;
            lblAtencionPaciente.Text = "Paciente";
            // 
            // lblAtencionNumero
            // 
            lblAtencionNumero.AutoSize = true;
            lblAtencionNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencionNumero.ForeColor = Color.FromArgb(26, 82, 150);
            lblAtencionNumero.Location = new Point(32, 245);
            lblAtencionNumero.Name = "lblAtencionNumero";
            lblAtencionNumero.Size = new Size(87, 15);
            lblAtencionNumero.TabIndex = 4;
            lblAtencionNumero.Text = "Nro. atención";
            // 
            // lblSeleccionTitulo
            // 
            lblSeleccionTitulo.AutoSize = true;
            lblSeleccionTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblSeleccionTitulo.Location = new Point(28, 204);
            lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            lblSeleccionTitulo.Size = new Size(178, 21);
            lblSeleccionTitulo.TabIndex = 3;
            lblSeleccionTitulo.Text = "Atención seleccionada";
            // 
            // lblPanelTexto
            // 
            lblPanelTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPanelTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblPanelTexto.Location = new Point(28, 92);
            lblPanelTexto.Name = "lblPanelTexto";
            lblPanelTexto.Size = new Size(218, 86);
            lblPanelTexto.TabIndex = 2;
            lblPanelTexto.Text = "Desde este módulo se consulta el historial de atenciones médicas registradas para cada paciente.";
            // 
            // lblPanelTitulo
            // 
            lblPanelTitulo.AutoSize = true;
            lblPanelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanelTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblPanelTitulo.Location = new Point(26, 37);
            lblPanelTitulo.Name = "lblPanelTitulo";
            lblPanelTitulo.Size = new Size(151, 37);
            lblPanelTitulo.TabIndex = 1;
            lblPanelTitulo.Text = "📁 Historial";
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
            pnlContenido.Controls.Add(gbDetalle);
            pnlContenido.Controls.Add(gbListado);
            pnlContenido.Controls.Add(gbBusqueda);
            pnlContenido.Controls.Add(pnlEncabezado);
            pnlContenido.Location = new Point(280, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(840, 680);
            pnlContenido.TabIndex = 1;
            // 
            // gbDetalle
            // 
            gbDetalle.BackColor = Color.White;
            gbDetalle.BorderStyle = BorderStyle.FixedSingle;
            gbDetalle.Controls.Add(btnLimpiar);
            gbDetalle.Controls.Add(txtDetalleAtencion);
            gbDetalle.Controls.Add(lblDetalleTitulo);
            gbDetalle.Location = new Point(28, 460);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(784, 188);
            gbDetalle.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 82, 150);
            btnLimpiar.Location = new Point(623, 16);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 30);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar detalle";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtDetalleAtencion
            // 
            txtDetalleAtencion.BackColor = Color.FromArgb(248, 251, 255);
            txtDetalleAtencion.BorderStyle = BorderStyle.FixedSingle;
            txtDetalleAtencion.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetalleAtencion.ForeColor = Color.FromArgb(42, 58, 92);
            txtDetalleAtencion.Location = new Point(18, 52);
            txtDetalleAtencion.Multiline = true;
            txtDetalleAtencion.Name = "txtDetalleAtencion";
            txtDetalleAtencion.ReadOnly = true;
            txtDetalleAtencion.ScrollBars = ScrollBars.Vertical;
            txtDetalleAtencion.Size = new Size(743, 115);
            txtDetalleAtencion.TabIndex = 1;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.AutoSize = true;
            lblDetalleTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalleTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblDetalleTitulo.Location = new Point(16, 17);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(207, 21);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Detalle de atención médica";
            // 
            // gbListado
            // 
            gbListado.BackColor = Color.White;
            gbListado.BorderStyle = BorderStyle.FixedSingle;
            gbListado.Controls.Add(dgvHistorial);
            gbListado.Controls.Add(lblListadoTitulo);
            gbListado.Location = new Point(28, 253);
            gbListado.Name = "gbListado";
            gbListado.Size = new Size(784, 190);
            gbListado.TabIndex = 2;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(18, 48);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(743, 122);
            dgvHistorial.TabIndex = 1;
            dgvHistorial.CellClick += dgvHistorial_CellClick;
            // 
            // lblListadoTitulo
            // 
            lblListadoTitulo.AutoSize = true;
            lblListadoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblListadoTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblListadoTitulo.Location = new Point(16, 14);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(197, 21);
            lblListadoTitulo.TabIndex = 0;
            lblListadoTitulo.Text = "Atenciones del paciente";
            // 
            // gbBusqueda
            // 
            gbBusqueda.BackColor = Color.White;
            gbBusqueda.BorderStyle = BorderStyle.FixedSingle;
            gbBusqueda.Controls.Add(lblCantidadDato);
            gbBusqueda.Controls.Add(lblCantidad);
            gbBusqueda.Controls.Add(btnBuscar);
            gbBusqueda.Controls.Add(cmbPaciente);
            gbBusqueda.Controls.Add(lblPaciente);
            gbBusqueda.Location = new Point(28, 154);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(784, 78);
            gbBusqueda.TabIndex = 1;
            // 
            // lblCantidadDato
            // 
            lblCantidadDato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadDato.ForeColor = Color.FromArgb(26, 82, 150);
            lblCantidadDato.Location = new Point(705, 29);
            lblCantidadDato.Name = "lblCantidadDato";
            lblCantidadDato.Size = new Size(46, 23);
            lblCantidadDato.TabIndex = 4;
            lblCantidadDato.Text = "0";
            lblCantidadDato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.FromArgb(26, 82, 150);
            lblCantidad.Location = new Point(555, 32);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(141, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Atenciones registradas:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(26, 82, 150);
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(390, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(142, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar historial";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbPaciente
            // 
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(97, 27);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(270, 23);
            cmbPaciente.TabIndex = 1;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaciente.ForeColor = Color.FromArgb(26, 82, 150);
            lblPaciente.Location = new Point(18, 31);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(51, 15);
            lblPaciente.TabIndex = 0;
            lblPaciente.Text = "Paciente";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Controls.Add(lblSeccion);
            pnlEncabezado.Controls.Add(lblSubtitulo);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(840, 132);
            pnlEncabezado.TabIndex = 0;
            // 
            // lblSeccion
            // 
            lblSeccion.AutoSize = true;
            lblSeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeccion.ForeColor = Color.FromArgb(26, 82, 150);
            lblSeccion.Location = new Point(31, 101);
            lblSeccion.Name = "lblSeccion";
            lblSeccion.Size = new Size(241, 20);
            lblSeccion.TabIndex = 2;
            lblSeccion.Text = "Consulta posterior a la atención";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(31, 69);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(480, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione un paciente y consulte sus atenciones médicas registradas.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(28, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de atenciones";
            // 
            // FrmHistorialAtenciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(1120, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmHistorialAtenciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historial de atenciones - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlContenido.ResumeLayout(false);
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            gbListado.ResumeLayout(false);
            gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            ResumeLayout(false);
        }
    }
}
