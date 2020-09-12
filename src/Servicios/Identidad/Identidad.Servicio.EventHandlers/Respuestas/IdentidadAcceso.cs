namespace Identidad.Servicio.EventHandlers.Respuestas
{
    public class IdentidadAcceso
    {
        public bool EsError { get; set; }
        public string Token { get; set; }

        public IdentidadAcceso() 
        {
            EsError = true;
        }
    }
}
