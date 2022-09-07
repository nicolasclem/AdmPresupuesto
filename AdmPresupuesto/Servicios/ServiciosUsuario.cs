namespace AdmPresupuesto.Servicios
{
    public interface IServiciosUsuarios
    {
        int ObtenerUsuarioId();
    }
    public class ServiciosUsuario : IServiciosUsuarios
    {
        public int ObtenerUsuarioId()
        {
            return 1;
        }
    }
}
