

using n00033054app.BD;

namespace n00033054app.Repositorios
{
    public interface IGastoRepositorio
    {

    }
    public class GastoRepositorio : IGastoRepositorio
    {
        private readonly DbEntities context;

        public GastoRepositorio(DbEntities context)
        {
            this.context = context;
        }
    }
}
