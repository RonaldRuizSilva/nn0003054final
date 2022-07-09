namespace n00033054app.Models
{
    public class Ingreso
    {
        public int id { get; set; }
        public int cuentaid { get; set; }
        public string descripcion { get; set; }
        public float monto { get; set; }
        public Cuenta cuenta { get; set; }

    }
}
