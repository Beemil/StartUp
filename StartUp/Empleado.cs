

namespace StartUp
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public double SalarioBase { get; set; }

        public Empleado() { }

        public Empleado(string nombre, int id, double salarioBase)
        {
            Nombre = nombre;
            ID = id;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalarioAnual();
        public abstract void MostrarInformacion();

    }
}
