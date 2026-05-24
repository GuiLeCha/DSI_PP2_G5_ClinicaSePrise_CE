namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class Profesional
    {
        public int IdProfesional { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Matricula { get; set; } = "";
        public int IdEspecialidad { get; set; }
        public string DisponibilidadHoraria { get; set; } = "";
        public int Cupo { get; set; }
        public int DuracionMinimaTurno { get; set; }
        public EstadoGeneral Estado { get; set; }

        public string NombreCompleto
        {
            get { return Apellido + ", " + Nombre; }
        }

        public Profesional()
        {
        }

        public Profesional(int idProfesional, string nombre, string apellido, string telefono,
            string email, string matricula, int idEspecialidad, string disponibilidadHoraria,
            int cupo, int duracionMinimaTurno, EstadoGeneral estado)
        {
            IdProfesional = idProfesional;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Matricula = matricula;
            IdEspecialidad = idEspecialidad;
            DisponibilidadHoraria = disponibilidadHoraria;
            Cupo = cupo;
            DuracionMinimaTurno = duracionMinimaTurno;
            Estado = estado;
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}