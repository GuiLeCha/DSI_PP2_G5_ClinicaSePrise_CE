namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public int DuracionDefaultTurno { get; set; }
        public decimal CostoParticular { get; set; }

        public Especialidad()
        {
        }

        public Especialidad(int idEspecialidad, string nombre, string descripcion,
            int duracionDefaultTurno, decimal costoParticular)
        {
            IdEspecialidad = idEspecialidad;
            Nombre = nombre;
            Descripcion = descripcion;
            DuracionDefaultTurno = duracionDefaultTurno;
            CostoParticular = costoParticular;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}