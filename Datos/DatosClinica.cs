using DSI_PP2_G5_ClinicaSePrise_CE.Entidades;

namespace DSI_PP2_G5_ClinicaSePrise_CE.Datos
{
    // Esta clase simula la base de datos del sistema.
    // Todos los datos se guardan en memoria mientras el programa está abierto.
    public static class DatosClinica
    {
        public static List<UsuarioSistema> Usuarios { get; set; } = new List<UsuarioSistema>();
        public static List<Paciente> Pacientes { get; set; } = new List<Paciente>();
        public static List<ObraSocialPrepaga> ObrasSocialesPrepagas { get; set; } = new List<ObraSocialPrepaga>();
        public static List<Especialidad> Especialidades { get; set; } = new List<Especialidad>();
        public static List<Profesional> Profesionales { get; set; } = new List<Profesional>();
        public static List<Consultorio> Consultorios { get; set; } = new List<Consultorio>();
        public static List<AgendaMedica> Agendas { get; set; } = new List<AgendaMedica>();
        public static List<TurnoConsultorio> Turnos { get; set; } = new List<TurnoConsultorio>();
        public static List<HistoriaClinica> HistoriasClinicas { get; set; } = new List<HistoriaClinica>();
        public static List<AtencionMedica> AtencionesMedicas { get; set; } = new List<AtencionMedica>();
        public static List<ComprobantePago> ComprobantesPago { get; set; } = new List<ComprobantePago>();
        public static List<Honorario> Honorarios { get; set; } = new List<Honorario>();
        public static List<LoteObraSocial> LotesObraSocial { get; set; } = new List<LoteObraSocial>();

        static DatosClinica()
        {
            CargarDatosIniciales();
        }

        private static void CargarDatosIniciales()
        {
            CargarUsuarios();
            CargarCoberturas();
            CargarEspecialidades();
            CargarProfesionales();
            CargarConsultorios();
            CargarAgendasIniciales();
            CargarPacientesIniciales();
        }

        private static void CargarUsuarios()
        {
            Usuarios.Add(new UsuarioSistema(1, "admin", "admin", "Administrador del sistema", "Administrador"));
            Usuarios.Add(new UsuarioSistema(2, "recepcion", "123", "Usuario de recepción", "Administrativo"));
            Usuarios.Add(new UsuarioSistema(3, "medico", "123", "Profesional médico", "Medico"));
            Usuarios.Add(new UsuarioSistema(4, "test", "test", "Usuario de prueba", "Test"));
        }

        private static void CargarCoberturas()
        {
            ObrasSocialesPrepagas.Add(new ObraSocialPrepaga(
                1,
                "Particular",
                TipoCobertura.Particular,
                true,
                false,
                "El paciente abona el 100% de la consulta.",
                EstadoGeneral.Activo));

            ObrasSocialesPrepagas.Add(new ObraSocialPrepaga(
                2,
                "OSDE",
                TipoCobertura.Prepaga,
                true,
                true,
                "Requiere autorización para algunas prestaciones.",
                EstadoGeneral.Activo));

            ObrasSocialesPrepagas.Add(new ObraSocialPrepaga(
                3,
                "Swiss Medical",
                TipoCobertura.Prepaga,
                true,
                true,
                "Cobertura con coseguro según plan.",
                EstadoGeneral.Activo));

            ObrasSocialesPrepagas.Add(new ObraSocialPrepaga(
                4,
                "PAMI",
                TipoCobertura.ObraSocial,
                true,
                true,
                "Requiere validación de afiliado.",
                EstadoGeneral.Activo));

            ObrasSocialesPrepagas.Add(new ObraSocialPrepaga(
                5,
                "IOMA",
                TipoCobertura.ObraSocial,
                true,
                true,
                "Requiere autorización administrativa.",
                EstadoGeneral.Activo));
        }

        private static void CargarEspecialidades()
        {
            Especialidades.Add(new Especialidad(
                1,
                "Clínica Médica",
                "Atención médica general para pacientes adultos.",
                15,
                10000m));

            Especialidades.Add(new Especialidad(
                2,
                "Cardiología",
                "Atención de enfermedades cardiovasculares.",
                20,
                15000m));

            Especialidades.Add(new Especialidad(
                3,
                "Pediatría",
                "Atención médica de niños y adolescentes.",
                15,
                10000m));

            Especialidades.Add(new Especialidad(
                4,
                "Fisio-kinesiología",
                "Prácticas de rehabilitación y kinesiología.",
                25,
                12000m));

            Especialidades.Add(new Especialidad(
                5,
                "Salud Mental",
                "Atención psicológica y acompañamiento en salud mental.",
                30,
                14000m));
        }

        private static void CargarProfesionales()
        {
            Profesionales.Add(new Profesional(
                1,
                "Cecilia",
                "Grierson",
                "1122334455",
                "cecilia.grierson@seprise.com",
                "MN 12345",
                1,
                "Lunes a Viernes de 08:00 a 12:00",
                16,
                15,
                EstadoGeneral.Activo));

            Profesionales.Add(new Profesional(
                2,
                "René",
                "Favaloro",
                "1133445566",
                "rene.favaloro@seprise.com",
                "MN 23456",
                2,
                "Lunes, Miércoles y Viernes de 09:00 a 13:00",
                12,
                20,
                EstadoGeneral.Activo));

            Profesionales.Add(new Profesional(
                3,
                "Florencio",
                "Escardó",
                "1144556677",
                "florencio.escardo@seprise.com",
                "MN 34567",
                3,
                "Martes y Jueves de 14:00 a 18:00",
                14,
                15,
                EstadoGeneral.Activo));

            Profesionales.Add(new Profesional(
                4,
                "Elizabeth",
                "Kenny",
                "1155667788",
                "elizabeth.kenny@seprise.com",
                "MN 45678",
                4,
                "Lunes a Viernes de 08:00 a 12:00",
                10,
                25,
                EstadoGeneral.Activo));

            Profesionales.Add(new Profesional(
                5,
                "Sigmund",
                "Freud",
                "1166778899",
                "sigmund.freud@seprise.com",
                "MN 56789",
                5,
                "Lunes a Viernes de 08:00 a 12:00",
                8,
                30,
                EstadoGeneral.Activo));
        }

        private static void CargarConsultorios()
        {
            Consultorios.Add(new Consultorio(
                1,
                "101",
                "Planta Baja",
                1,
                "Camilla, escritorio, tensiómetro",
                EstadoConsultorio.Disponible));

            Consultorios.Add(new Consultorio(
                2,
                "202",
                "Primer Piso",
                2,
                "Camilla, electrocardiógrafo, escritorio",
                EstadoConsultorio.Disponible));

            Consultorios.Add(new Consultorio(
                3,
                "103",
                "Planta Baja",
                3,
                "Camilla pediátrica, balanza, escritorio",
                EstadoConsultorio.Disponible));

            Consultorios.Add(new Consultorio(
                4,
                "204",
                "Primer Piso",
                4,
                "Camilla, colchoneta, elementos de rehabilitación",
                EstadoConsultorio.Disponible));

            Consultorios.Add(new Consultorio(
                5,
                "203",
                "Primer Piso",
                5,
                "Escritorio, sillones, ambiente de entrevista",
                EstadoConsultorio.Disponible));
        }

        private static void CargarAgendasIniciales()
        {
            DateTime manana = DateTime.Today.AddDays(1);
            DateTime pasadoManana = DateTime.Today.AddDays(2);

            Agendas.Add(new AgendaMedica(
                1,
                1,
                1,
                1,
                manana,
                new TimeSpan(8, 0, 0),
                new TimeSpan(12, 0, 0),
                EstadoAgenda.Disponible));

            Agendas.Add(new AgendaMedica(
                2,
                2,
                2,
                2,
                manana,
                new TimeSpan(9, 0, 0),
                new TimeSpan(13, 0, 0),
                EstadoAgenda.Disponible));

            Agendas.Add(new AgendaMedica(
                3,
                3,
                3,
                3,
                pasadoManana,
                new TimeSpan(14, 0, 0),
                new TimeSpan(18, 0, 0),
                EstadoAgenda.Disponible));

            Agendas.Add(new AgendaMedica(
                4,
                4,
                4,
                4,
                manana,
                new TimeSpan(8, 0, 0),
                new TimeSpan(12, 0, 0),
                EstadoAgenda.Disponible));

            Agendas.Add(new AgendaMedica(
                5,
                5,
                5,
                5,
                manana,
                new TimeSpan(8, 0, 0),
                new TimeSpan(12, 0, 0),
                EstadoAgenda.Disponible));
        }

        private static void CargarPacientesIniciales()
        {
            Pacientes.Add(new Paciente(
                1,
                "Fernando Ezequiel",
                "Baca",
                "DNI",
                "30111222",
                new DateTime(1990, 5, 12),
                "Masculino",
                "1122334455",
                "Av. San Juan 1250, CABA",
                "fernando.baca@mail.com",
                1,
                "PART-1001",
                EstadoGeneral.Activo));

            Pacientes.Add(new Paciente(
                2,
                "Eric",
                "Bermudez",
                "PAS",
                "31222333",
                new DateTime(1991, 8, 23),
                "Masculino",
                "1133445566",
                "Av. Independencia 1800, CABA",
                "eric.bermudez@mail.com",
                2,
                "OSDE-1002",
                EstadoGeneral.Activo));

            Pacientes.Add(new Paciente(
                3,
                "Mariana",
                "Borda",
                "LC",
                "32333444",
                new DateTime(1989, 11, 7),
                "Femenino",
                "1144556677",
                "Av. Belgrano 950, CABA",
                "mariana.borda@mail.com",
                3,
                "SWISS-1003",
                EstadoGeneral.Activo));

            Pacientes.Add(new Paciente(
                4,
                "Guillermo",
                "Chacon",
                "LE",
                "33444555",
                new DateTime(1988, 3, 18),
                "No Informa",
                "1155667788",
                "Av. Corrientes 3200, CABA",
                "guillermo.chacon@mail.com",
                4,
                "PAMI-1004",
                EstadoGeneral.Activo));

            Pacientes.Add(new Paciente(
                5,
                "Julia",
                "Piassentini",
                "DNI",
                "34555666",
                new DateTime(1992, 9, 30),
                "Femenino",
                "1166778899",
                "Av. Rivadavia 4100, CABA",
                "julia.piassentini@mail.com",
                5,
                "IOMA-1005",
                EstadoGeneral.Activo));
        }

        public static UsuarioSistema? ValidarUsuario(string usuario, string clave)
        {
            return Usuarios.FirstOrDefault(u =>
                u.Usuario.ToLower() == usuario.ToLower()
                && u.Clave == clave);
        }

        public static Paciente? BuscarPacientePorId(int idPaciente)
        {
            return Pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
        }

        public static Paciente? BuscarPacientePorDocumento(string nroDocumento)
        {
            return Pacientes.FirstOrDefault(p => p.NroDocumento == nroDocumento);
        }

        public static Profesional? BuscarProfesionalPorId(int idProfesional)
        {
            return Profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
        }

        public static Especialidad? BuscarEspecialidadPorId(int idEspecialidad)
        {
            return Especialidades.FirstOrDefault(e => e.IdEspecialidad == idEspecialidad);
        }

        public static Consultorio? BuscarConsultorioPorId(int idConsultorio)
        {
            return Consultorios.FirstOrDefault(c => c.IdConsultorio == idConsultorio);
        }

        public static ObraSocialPrepaga? BuscarCoberturaPorId(int? idCobertura)
        {
            if (idCobertura == null)
            {
                return null;
            }

            return ObrasSocialesPrepagas.FirstOrDefault(o => o.IdCobertura == idCobertura.Value);
        }

        public static TurnoConsultorio? BuscarTurnoPorNumero(int nroTurno)
        {
            return Turnos.FirstOrDefault(t => t.NroTurno == nroTurno);
        }


        public static AtencionMedica? BuscarAtencionPorTurno(int nroTurno)
        {
            return AtencionesMedicas.FirstOrDefault(a => a.NroTurno == nroTurno);
        }

        public static List<AtencionMedica> BuscarAtencionesPorPaciente(int idPaciente)
        {
            return AtencionesMedicas
                .Where(a => a.IdPaciente == idPaciente)
                .OrderByDescending(a => a.FechaAtencion)
                .ToList();
        }

        public static HistoriaClinica? BuscarHistoriaClinicaPorPaciente(int idPaciente)
        {
            return HistoriasClinicas.FirstOrDefault(h => h.IdPaciente == idPaciente);
        }

        public static HistoriaClinica CrearHistoriaClinicaSiNoExiste(int idPaciente)
        {
            HistoriaClinica? historia = BuscarHistoriaClinicaPorPaciente(idPaciente);

            if (historia != null)
            {
                return historia;
            }

            historia = new HistoriaClinica(
                ObtenerProximoIdHistoriaClinica(),
                idPaciente,
                "",
                "",
                DateTime.Today,
                EstadoHistoriaClinica.Activa);

            HistoriasClinicas.Add(historia);

            return historia;
        }

        public static bool ExistePacienteConDocumento(string nroDocumento)
        {
            return Pacientes.Any(p => p.NroDocumento == nroDocumento);
        }

        public static AgendaMedica? BuscarAgendaPorId(int idAgenda)
        {
            return Agendas.FirstOrDefault(a => a.IdAgenda == idAgenda);
        }

        public static bool ExisteTurnoEnHorario(int idProfesional, DateTime fecha, TimeSpan hora)
        {
            return ExisteTurnoEnHorario(idProfesional, fecha, hora, 0);
        }

        public static bool ExisteTurnoEnHorario(int idProfesional, DateTime fecha, TimeSpan hora, int nroTurnoExcluir)
        {
            return Turnos.Any(t =>
                t.NroTurno != nroTurnoExcluir
                && t.IdProfesional == idProfesional
                && t.FechaTurno.Date == fecha.Date
                && t.HoraTurno == hora
                && t.Estado != EstadoTurno.Cancelado
                && t.Estado != EstadoTurno.Vencido);
        }

        public static int ObtenerDuracionTurnoPorEspecialidad(int idEspecialidad)
        {
            Especialidad? especialidad = BuscarEspecialidadPorId(idEspecialidad);

            if (especialidad == null || especialidad.DuracionDefaultTurno <= 0)
            {
                return 15;
            }

            return especialidad.DuracionDefaultTurno;
        }

        // Controla que el nuevo turno no se pise con otro turno del mismo profesional,
        // tomando como referencia la duración mínima definida para cada especialidad.
        public static bool ExisteTurnoSuperpuesto(int idProfesional, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int nroTurnoExcluir)
        {
            return Turnos.Any(t =>
            {
                if (t.NroTurno == nroTurnoExcluir ||
                    t.IdProfesional != idProfesional ||
                    t.FechaTurno.Date != fecha.Date ||
                    t.Estado == EstadoTurno.Cancelado ||
                    t.Estado == EstadoTurno.Vencido)
                {
                    return false;
                }

                TimeSpan horaInicioExistente = t.HoraTurno;
                TimeSpan horaFinExistente = t.HoraTurno.Add(TimeSpan.FromMinutes(
                    ObtenerDuracionTurnoPorEspecialidad(t.IdEspecialidad)));

                return horaInicio < horaFinExistente && horaFin > horaInicioExistente;
            });
        }

        // Regla de negocio: se permite como máximo un sobreturno por hora
        // para el mismo profesional y fecha.
        public static bool ExisteSobreturnoEnMismaHora(int idProfesional, DateTime fecha, TimeSpan hora, int nroTurnoExcluir)
        {
            return Turnos.Any(t =>
                t.NroTurno != nroTurnoExcluir
                && t.IdProfesional == idProfesional
                && t.FechaTurno.Date == fecha.Date
                && t.EsSobreturno
                && t.HoraTurno.Hours == hora.Hours
                && t.Estado != EstadoTurno.Cancelado
                && t.Estado != EstadoTurno.Vencido);
        }

        public static int ObtenerProximoIdPaciente()
        {
            if (Pacientes.Count == 0)
            {
                return 1;
            }

            return Pacientes.Max(p => p.IdPaciente) + 1;
        }

        public static int ObtenerProximoIdAgenda()
        {
            if (Agendas.Count == 0)
            {
                return 1;
            }

            return Agendas.Max(a => a.IdAgenda) + 1;
        }

        public static bool ExisteSuperposicionAgenda(int idProfesional, int idConsultorio, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            return Agendas.Any(a =>
                a.Fecha.Date == fecha.Date
                &&
                (
                    a.IdProfesional == idProfesional ||
                    a.IdConsultorio == idConsultorio
                )
                &&
                horaInicio < a.HoraFin
                &&
                horaFin > a.HoraInicio);
        }

        public static int ObtenerProximoNroTurno()
        {
            if (Turnos.Count == 0)
            {
                return 1;
            }

            return Turnos.Max(t => t.NroTurno) + 1;
        }

        public static int ObtenerProximoIdHistoriaClinica()
        {
            if (HistoriasClinicas.Count == 0)
            {
                return 1;
            }

            return HistoriasClinicas.Max(h => h.IdHistoriaClinica) + 1;
        }

        public static int ObtenerProximoNroAtencion()
        {
            if (AtencionesMedicas.Count == 0)
            {
                return 1;
            }

            return AtencionesMedicas.Max(a => a.NroAtencion) + 1;
        }

        public static int ObtenerProximoNroComprobante()
        {
            if (ComprobantesPago.Count == 0)
            {
                return 1;
            }

            return ComprobantesPago.Max(c => c.NroComprobante) + 1;
        }

        public static int ObtenerProximoNroLiquidacion()
        {
            if (Honorarios.Count == 0)
            {
                return 1;
            }

            return Honorarios.Max(h => h.NroLiquidacion) + 1;
        }

        public static int ObtenerProximoNroLote()
        {
            if (LotesObraSocial.Count == 0)
            {
                return 1;
            }

            return LotesObraSocial.Max(l => l.NroLote) + 1;
        }

        public static string ObtenerNombrePaciente(int idPaciente)
        {
            Paciente? paciente = BuscarPacientePorId(idPaciente);

            if (paciente == null)
            {
                return "Paciente no encontrado";
            }

            return paciente.NombreCompleto;
        }

        public static string ObtenerNombreProfesional(int idProfesional)
        {
            Profesional? profesional = BuscarProfesionalPorId(idProfesional);

            if (profesional == null)
            {
                return "Profesional no encontrado";
            }

            return profesional.NombreCompleto;
        }

        public static string ObtenerNombreEspecialidad(int idEspecialidad)
        {
            Especialidad? especialidad = BuscarEspecialidadPorId(idEspecialidad);

            if (especialidad == null)
            {
                return "Especialidad no encontrada";
            }

            return especialidad.Nombre;
        }

        public static string ObtenerNombreConsultorio(int idConsultorio)
        {
            Consultorio? consultorio = BuscarConsultorioPorId(idConsultorio);

            if (consultorio == null)
            {
                return "Consultorio no encontrado";
            }

            return consultorio.ToString();
        }

        public static string ObtenerNombreCobertura(int? idCobertura)
        {
            ObraSocialPrepaga? cobertura = BuscarCoberturaPorId(idCobertura);

            if (cobertura == null)
            {
                return "Sin cobertura";
            }

            return cobertura.Nombre;
        }
    }
}