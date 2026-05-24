namespace DSI_PP2_G5_ClinicaSePrise_CE.Entidades
{
    public enum TipoCobertura
    {
        Particular,
        ObraSocial,
        Prepaga
    }

    public enum EstadoGeneral
    {
        Activo,
        Inactivo
    }

    public enum EstadoConsultorio
    {
        Disponible,
        Ocupado,
        EnMantenimiento
    }

    public enum EstadoAgenda
    {
        Disponible,
        Asignada,
        Bloqueada
    }

    public enum TipoCanalTurno
    {
        Presencial,
        Telefonico
    }

    public enum EstadoTurno
    {
        Reservado,
        Recordado,
        Confirmado,
        Cancelado,
        Reprogramado,
        Presente,
        EnAtencion,
        Atendido,
        Facturado,
        Liquidado,
        PresentadoObraSocial,
        Vencido
    }

    public enum EstadoHistoriaClinica
    {
        Activa,
        Inactiva
    }

    public enum EstadoComprobante
    {
        Emitido,
        Anulado
    }

    public enum EstadoHonorario
    {
        Pendiente,
        Liquidado,
        Presentado,
        Pagado,
        Rechazado,
        PagoParcial
    }

    public enum EstadoLoteObraSocial
    {
        Generado,
        Presentado,
        Aceptado,
        Rechazado
    }
}