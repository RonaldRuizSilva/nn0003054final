
using n00033054app.BD;

namespace n00033054app.Repositorios
{
    public interface IIngresoRepositorio
    {

    }
    public class IngresoRepositorio: IIngresoRepositorio
    {
        private DbEntities context;

        public IngresoRepositorio (DbEntities context)
        {
            this.context = context;
        }
    }
}
