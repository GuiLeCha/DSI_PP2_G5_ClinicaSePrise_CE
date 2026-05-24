namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class AgendaMedica
    {
        public int IdAgenda { get; set; }
        public int IdProfesional { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public EstadoAgenda Estado { get; set; }

        public AgendaMedica()
        {
        }

        public AgendaMedica(int idAgenda, int idProfesional, int idEspecialidad,
            int idConsultorio, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin,
            EstadoAgenda estado)
        {
            IdAgenda = idAgenda;
            IdProfesional = idProfesional;
            IdEspecialidad = idEspecialidad;
            IdConsultorio = idConsultorio;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Estado = estado;
        }
    }
}