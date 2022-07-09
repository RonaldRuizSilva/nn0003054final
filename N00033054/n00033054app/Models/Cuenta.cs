namespace n00033054app.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String categoria { get; set; }
        public decimal saldoini { get; set; }
        public char moneda { get; set; }

        public List<Gasto> gastos { get; set; }

        public List<Ingreso> ingresos { get; set; }

    }
}
