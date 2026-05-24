namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class TurnoConsultorio
    {
        public int NroTurno { get; set; }
        public int IdPaciente { get; set; }
        public int IdProfesional { get; set; }
        public int IdEspecialidad { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime FechaTurno { get; set; }
        public TimeSpan HoraTurno { get; set; }
        public TipoCanalTurno CanalSolicitud { get; set; }
        public bool EsSobreturno { get; set; }
        public EstadoTurno Estado { get; set; }
        public bool RecordatorioEnviado { get; set; }
        public bool CoberturaVerificada { get; set; }
        public bool AutorizacionAprobada { get; set; }
        public decimal MontoCoseguro { get; set; }
        public decimal MontoParticular { get; set; }
        public string Observaciones { get; set; } = "";

        public TurnoConsultorio()
        {
        }

        public TurnoConsultorio(int nroTurno, int idPaciente, int idProfesional,
            int idEspecialidad, int idConsultorio, DateTime fechaTurno, TimeSpan horaTurno,
            TipoCanalTurno canalSolicitud, bool esSobreturno, EstadoTurno estado)
        {
            NroTurno = nroTurno;
            IdPaciente = idPaciente;
            IdProfesional = idProfesional;
            IdEspecialidad = idEspecialidad;
            IdConsultorio = idConsultorio;
            FechaTurno = fechaTurno;
            HoraTurno = horaTurno;
            CanalSolicitud = canalSolicitud;
            EsSobreturno = esSobreturno;
            Estado = estado;
            RecordatorioEnviado = false;
            CoberturaVerificada = false;
            AutorizacionAprobada = false;
            MontoCoseguro = 0;
            MontoParticular = 0;
        }
    }
}