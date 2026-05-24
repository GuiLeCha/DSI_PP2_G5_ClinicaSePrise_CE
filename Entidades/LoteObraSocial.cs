namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class LoteObraSocial
    {
        public int NroLote { get; set; }
        public int IdObraSocialPrepaga { get; set; }
        public string Periodo { get; set; } = "";
        public DateTime FechaPresentacion { get; set; }
        public int CantidadPrestaciones { get; set; }
        public decimal MontoTotal { get; set; }
        public EstadoLoteObraSocial Estado { get; set; }
        public string Observaciones { get; set; } = "";

        public LoteObraSocial()
        {
        }

        public LoteObraSocial(int nroLote, int idObraSocialPrepaga, string periodo,
            DateTime fechaPresentacion, int cantidadPrestaciones, decimal montoTotal,
            EstadoLoteObraSocial estado, string observaciones)
        {
            NroLote = nroLote;
            IdObraSocialPrepaga = idObraSocialPrepaga;
            Periodo = periodo;
            FechaPresentacion = fechaPresentacion;
            CantidadPrestaciones = cantidadPrestaciones;
            MontoTotal = montoTotal;
            Estado = estado;
            Observaciones = observaciones;
        }
    }
}