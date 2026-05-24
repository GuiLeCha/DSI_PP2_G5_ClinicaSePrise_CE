namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class Honorario
    {
        public int NroLiquidacion { get; set; }
        public int IdProfesional { get; set; }
        public string Periodo { get; set; } = "";
        public DateTime FechaGeneracion { get; set; }
        public int CantidadAtenciones { get; set; }
        public decimal MontoTotal { get; set; }
        public EstadoHonorario Estado { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Observaciones { get; set; } = "";

        public Honorario()
        {
        }

        public Honorario(int nroLiquidacion, int idProfesional, string periodo,
            DateTime fechaGeneracion, int cantidadAtenciones, decimal montoTotal,
            EstadoHonorario estado, DateTime? fechaPago, string observaciones)
        {
            NroLiquidacion = nroLiquidacion;
            IdProfesional = idProfesional;
            Periodo = periodo;
            FechaGeneracion = fechaGeneracion;
            CantidadAtenciones = cantidadAtenciones;
            MontoTotal = montoTotal;
            Estado = estado;
            FechaPago = fechaPago;
            Observaciones = observaciones;
        }
    }
}