

namespace StartUp
{
    public class Desarrollador
    {
        public string LenguajePrincipal { get; set; }

        public override double CalcularSalarioAnual()
        {
            return SalarioBase * 12; 
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Desarrollador: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
        }
    }
}
