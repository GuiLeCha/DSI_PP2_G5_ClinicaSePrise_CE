namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string TipoDocumento { get; set; } = "DNI";
        public string NroDocumento { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Domicilio { get; set; } = "";
        public string Email { get; set; } = "";
        public int? IdObraSocialPrepaga { get; set; }
        public string NroAfiliado { get; set; } = "";
        public EstadoGeneral Estado { get; set; }

        public string NombreCompleto
        {
            get { return Apellido + ", " + Nombre; }
        }

        public Paciente()
        {
        }

        public Paciente(int idPaciente, string nombre, string apellido, string tipoDocumento,
            string nroDocumento, DateTime fechaNacimiento, string sexo, string telefono,
            string domicilio, string email, int? idObraSocialPrepaga, string nroAfiliado,
            EstadoGeneral estado)
        {
            IdPaciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NroDocumento = nroDocumento;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Telefono = telefono;
            Domicilio = domicilio;
            Email = email;
            IdObraSocialPrepaga = idObraSocialPrepaga;
            NroAfiliado = nroAfiliado;
            Estado = estado;
        }

        public override string ToString()
        {
            return NombreCompleto + " - DNI " + NroDocumento;
        }
    }
}