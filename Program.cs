using DSI_PP2_G5_ClinicaSePrise_CE.Formularios;

namespace DSI_PP2_G5_ClinicaSePrise_CE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configuración inicial de Windows Forms en .NET 6.
            ApplicationConfiguration.Initialize();

            // Inicia el sistema mostrando el login.
            Application.Run(new FrmLogin());
        }
    }
}