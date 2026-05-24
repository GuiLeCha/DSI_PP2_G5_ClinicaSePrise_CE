namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class Consultorio
    {
        public int IdConsultorio { get; set; }
        public string Numero { get; set; } = "";
        public string PisoSector { get; set; } = "";
        public int IdEspecialidad { get; set; }
        public string Equipamiento { get; set; } = "";
        public EstadoConsultorio Estado { get; set; }

        public Consultorio()
        {
        }

        public Consultorio(int idConsultorio, string numero, string pisoSector,
            int idEspecialidad, string equipamiento, EstadoConsultorio estado)
        {
            IdConsultorio = idConsultorio;
            Numero = numero;
            PisoSector = pisoSector;
            IdEspecialidad = idEspecialidad;
            Equipamiento = equipamiento;
            Estado = estado;
        }

        public override string ToString()
        {
            return "Consultorio " + Numero + " - " + PisoSector;
        }
    }
}