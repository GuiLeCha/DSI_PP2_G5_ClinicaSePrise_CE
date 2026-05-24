namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class ObraSocialPrepaga
    {
        public int IdCobertura { get; set; }
        public string Nombre { get; set; } = "";
        public TipoCobertura Tipo { get; set; }
        public bool ConvenioVigente { get; set; }
        public bool RequiereAutorizacion { get; set; }
        public string CondicionesPago { get; set; } = "";
        public EstadoGeneral Estado { get; set; }

        public ObraSocialPrepaga()
        {
        }

        public ObraSocialPrepaga(int idCobertura, string nombre, TipoCobertura tipo,
            bool convenioVigente, bool requiereAutorizacion, string condicionesPago, EstadoGeneral estado)
        {
            IdCobertura = idCobertura;
            Nombre = nombre;
            Tipo = tipo;
            ConvenioVigente = convenioVigente;
            RequiereAutorizacion = requiereAutorizacion;
            CondicionesPago = condicionesPago;
            Estado = estado;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}