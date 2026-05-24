namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public int IdPaciente { get; set; }
        public string AntecedentesPersonales { get; set; } = "";
        public string AntecedentesFamiliares { get; set; } = "";
        public DateTime FechaApertura { get; set; }
        public EstadoHistoriaClinica Estado { get; set; }

        public HistoriaClinica()
        {
        }

        public HistoriaClinica(int idHistoriaClinica, int idPaciente,
            string antecedentesPersonales, string antecedentesFamiliares,
            DateTime fechaApertura, EstadoHistoriaClinica estado)
        {
            IdHistoriaClinica = idHistoriaClinica;
            IdPaciente = idPaciente;
            AntecedentesPersonales = antecedentesPersonales;
            AntecedentesFamiliares = antecedentesFamiliares;
            FechaApertura = fechaApertura;
            Estado = estado;
        }
    }
}