

namespace StartUp
{
    public class Gerente : Empleado
    {
        public Gerente() { }
        public Gerente(string nombre, int id, double salarioBase, double bonoAnual)
            : base(nombre, id, salarioBase)
        {
            BonoAnual = bonoAnual;
        }
        public double BonoAnual { get; set; }

        public override double CalcularSalarioAnual()
        {
            
            return SalarioBase * 12 + BonoAnual;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine();
            Console.WriteLine("Información del Gerente:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Cargo: Gerente");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            Console.WriteLine();
        }
    }
}
