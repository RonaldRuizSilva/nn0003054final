
using n00033054app.BD;
using n00033054app.Models;

namespace n00033054app.Repositorios
{
    public interface ICuentaRepositorio
    {
        public List<Cuenta> listaCuentas();
        public void crear(Cuenta cuenta);
    }
    public class CuentaRepositorio : ICuentaRepositorio
    {
        private readonly DbEntities context;

        public CuentaRepositorio(DbEntities context)
        {
            this.context = context;
        }
        public List<Cuenta> listaCuentas()
        {
            var model = context.Cuentas.ToList();
            return model;
        }
        public void crear(Cuenta cuenta)
        {
            context.Cuentas.Add(cuenta);
            context.SaveChanges();
        }
    }
}
