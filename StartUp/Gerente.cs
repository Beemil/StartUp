

namespace StartUp
{
    public class Gerente
    {
        public double BonoAnual { get; set; }

        public override double CalcularSalarioAnual()
        {
            
            return SalarioBase * 12 + BonoAnual;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gerente: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Gerente: {Gerente}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            
        }
    }
}
