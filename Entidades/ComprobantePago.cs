namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class ComprobantePago
    {
        public int NroComprobante { get; set; }
        public int NroTurno { get; set; }
        public int IdPaciente { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Concepto { get; set; } = "";
        public string TipoPago { get; set; } = "";
        public decimal Monto { get; set; }
        public EstadoComprobante Estado { get; set; }

        public ComprobantePago()
        {
        }

        public ComprobantePago(int nroComprobante, int nroTurno, int idPaciente,
            DateTime fechaEmision, string concepto, string tipoPago, decimal monto,
            EstadoComprobante estado)
        {
            NroComprobante = nroComprobante;
            NroTurno = nroTurno;
            IdPaciente = idPaciente;
            FechaEmision = fechaEmision;
            Concepto = concepto;
            TipoPago = tipoPago;
            Monto = monto;
            Estado = estado;
        }
    }
}