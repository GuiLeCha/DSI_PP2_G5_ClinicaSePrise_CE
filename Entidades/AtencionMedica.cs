namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class AtencionMedica
    {
        public int NroAtencion { get; set; }
        public int IdHistoriaClinica { get; set; }
        public int NroTurno { get; set; }
        public int IdPaciente { get; set; }
        public int IdProfesional { get; set; }
        public DateTime FechaAtencion { get; set; }
        public string Diagnostico { get; set; } = "";
        public string Indicaciones { get; set; } = "";
        public bool RequiereNuevoTurno { get; set; }
        public bool DerivacionAEstudio { get; set; }
        public string ObservacionesClinicas { get; set; } = "";
        public bool Cerrada { get; set; }

        public AtencionMedica()
        {
        }

        public AtencionMedica(int nroAtencion, int idHistoriaClinica, int nroTurno,
            int idPaciente, int idProfesional, DateTime fechaAtencion, string diagnostico,
            string indicaciones, bool requiereNuevoTurno, bool derivacionAEstudio,
            string observacionesClinicas, bool cerrada)
        {
            NroAtencion = nroAtencion;
            IdHistoriaClinica = idHistoriaClinica;
            NroTurno = nroTurno;
            IdPaciente = idPaciente;
            IdProfesional = idProfesional;
            FechaAtencion = fechaAtencion;
            Diagnostico = diagnostico;
            Indicaciones = indicaciones;
            RequiereNuevoTurno = requiereNuevoTurno;
            DerivacionAEstudio = derivacionAEstudio;
            ObservacionesClinicas = observacionesClinicas;
            Cerrada = cerrada;
        }
    }
}