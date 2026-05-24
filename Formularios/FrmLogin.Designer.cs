namespace DSI_PP2_G5_ClinicaSePrise_CE.Formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlLateral;
        private Panel pnlFormulario;
        private Panel pnlCredenciales;
        private Label lblIcono;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblDescripcion;
        private Label lblModulo;
        private Label lblIngresoTitulo;
        private Label lblIngresoTexto;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblCredencialesTitulo;
        private Label lblCredencialesTexto;
        private Label lblAyuda;

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
            lblModulo = new Label();
            lblDescripcion = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            lblIcono = new Label();
            pnlFormulario = new Panel();
            lblAyuda = new Label();
            pnlCredenciales = new Panel();
            lblCredencialesTexto = new Label();
            lblCredencialesTitulo = new Label();
            btnSalir = new Button();
            btnIngresar = new Button();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            lblClave = new Label();
            lblUsuario = new Label();
            lblIngresoTexto = new Label();
            lblIngresoTitulo = new Label();
            pnlLateral.SuspendLayout();
            pnlFormulario.SuspendLayout();
            pnlCredenciales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(239, 246, 255);
            pnlLateral.Controls.Add(lblModulo);
            pnlLateral.Controls.Add(lblDescripcion);
            pnlLateral.Controls.Add(lblSubtitulo);
            pnlLateral.Controls.Add(lblTitulo);
            pnlLateral.Controls.Add(lblIcono);
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(330, 520);
            pnlLateral.TabIndex = 0;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblModulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblModulo.Location = new Point(35, 313);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(245, 20);
            lblModulo.TabIndex = 4;
            lblModulo.Text = "Circuito A - Consultorios Externos";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.FromArgb(42, 58, 92);
            lblDescripcion.Location = new Point(35, 353);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(250, 86);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Simulación funcional para la gestión de pacientes, agendas, turnos, recepción, atención médica e historial.";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(90, 103, 130);
            lblSubtitulo.Location = new Point(17, 262);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(299, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Ingreso al sistema del Grupo 5 - Comision B";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblTitulo.Location = new Point(35, 214);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(119, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SePrise";
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 58F, FontStyle.Bold, GraphicsUnit.Point);
            lblIcono.ForeColor = Color.FromArgb(26, 82, 150);
            lblIcono.Location = new Point(30, 94);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(112, 104);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "✚";
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.FromArgb(250, 252, 255);
            pnlFormulario.Controls.Add(lblAyuda);
            pnlFormulario.Controls.Add(pnlCredenciales);
            pnlFormulario.Controls.Add(btnSalir);
            pnlFormulario.Controls.Add(btnIngresar);
            pnlFormulario.Controls.Add(txtClave);
            pnlFormulario.Controls.Add(txtUsuario);
            pnlFormulario.Controls.Add(lblClave);
            pnlFormulario.Controls.Add(lblUsuario);
            pnlFormulario.Controls.Add(lblIngresoTexto);
            pnlFormulario.Controls.Add(lblIngresoTitulo);
            pnlFormulario.Location = new Point(330, 0);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(530, 520);
            pnlFormulario.TabIndex = 1;
            // 
            // lblAyuda
            // 
            lblAyuda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAyuda.ForeColor = Color.FromArgb(90, 103, 130);
            lblAyuda.Location = new Point(68, 423);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(394, 34);
            lblAyuda.TabIndex = 9;
            lblAyuda.Text = "Use uno de los usuarios disponibles para acceder al circuito según el rol correspondiente.";
            lblAyuda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCredenciales
            // 
            pnlCredenciales.BackColor = Color.White;
            pnlCredenciales.BorderStyle = BorderStyle.FixedSingle;
            pnlCredenciales.Controls.Add(lblCredencialesTexto);
            pnlCredenciales.Controls.Add(lblCredencialesTitulo);
            pnlCredenciales.Location = new Point(68, 14);
            pnlCredenciales.Name = "pnlCredenciales";
            pnlCredenciales.Size = new Size(394, 95);
            pnlCredenciales.TabIndex = 8;
            // 
            // lblCredencialesTexto
            // 
            lblCredencialesTexto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredencialesTexto.ForeColor = Color.FromArgb(42, 58, 92);
            lblCredencialesTexto.Location = new Point(18, 36);
            lblCredencialesTexto.Name = "lblCredencialesTexto";
            lblCredencialesTexto.Size = new Size(356, 42);
            lblCredencialesTexto.TabIndex = 1;
            lblCredencialesTexto.Text = "admin / admin\nrecepcion / 123\nmedico / 123";
            // 
            // lblCredencialesTitulo
            // 
            lblCredencialesTitulo.AutoSize = true;
            lblCredencialesTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCredencialesTitulo.ForeColor = Color.FromArgb(26, 82, 150);
            lblCredencialesTitulo.Location = new Point(18, 13);
            lblCredencialesTitulo.Name = "lblCredencialesTitulo";
            lblCredencialesTitulo.Size = new Size(183, 19);
            lblCredencialesTitulo.TabIndex = 0;
            lblCredencialesTitulo.Text = "Usuarios de demostración";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(188, 207, 230);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(26, 82, 150);
            btnSalir.Location = new Point(274, 371);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(138, 38);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(26, 82, 150);
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(26, 82, 150);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(118, 371);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(138, 38);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(118, 316);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(294, 25);
            txtClave.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(118, 250);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(294, 25);
            txtUsuario.TabIndex = 4;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblClave.ForeColor = Color.FromArgb(26, 82, 150);
            lblClave.Location = new Point(118, 294);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(84, 19);
            lblClave.TabIndex = 3;
            lblClave.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(26, 82, 150);
            lblUsuario.Location = new Point(118, 228);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 19);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblIngresoTexto
            // 
            lblIngresoTexto.AutoSize = true;
            lblIngresoTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresoTexto.ForeColor = Color.FromArgb(90, 103, 130);
            lblIngresoTexto.Location = new Point(118, 178);
            lblIngresoTexto.Name = "lblIngresoTexto";
            lblIngresoTexto.Size = new Size(266, 19);
            lblIngresoTexto.TabIndex = 1;
            lblIngresoTexto.Text = "Ingrese usuario y contraseña para acceder";
            // 
            // lblIngresoTitulo
            // 
            lblIngresoTitulo.AutoSize = true;
            lblIngresoTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresoTitulo.ForeColor = Color.FromArgb(20, 36, 70);
            lblIngresoTitulo.Location = new Point(112, 144);
            lblIngresoTitulo.Name = "lblIngresoTitulo";
            lblIngresoTitulo.Size = new Size(221, 32);
            lblIngresoTitulo.TabIndex = 0;
            lblIngresoTitulo.Text = "Ingreso al sistema";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 255);
            ClientSize = new Size(860, 520);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso - Clínica SePrise";
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            pnlCredenciales.ResumeLayout(false);
            pnlCredenciales.PerformLayout();
            ResumeLayout(false);
        }
    }
}
