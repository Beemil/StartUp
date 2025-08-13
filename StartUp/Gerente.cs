

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

            Console.WriteLine($"Gerente: {Gerente}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            
        }
    }
}
