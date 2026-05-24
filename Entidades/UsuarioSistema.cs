namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    // Representa a un usuario que puede ingresar al sistema.
    public class UsuarioSistema
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = "";
        public string Clave { get; set; } = "";
        public string NombreCompleto { get; set; } = "";
        public string Rol { get; set; } = "";

        public UsuarioSistema()
        {
        }

        public UsuarioSistema(int id, string usuario, string clave, string nombreCompleto, string rol)
        {
            Id = id;
            Usuario = usuario;
            Clave = clave;
            NombreCompleto = nombreCompleto;
            Rol = rol;
        }

        public override string ToString()
        {
            return $"{NombreCompleto} - {Rol}";
        }
    }
}