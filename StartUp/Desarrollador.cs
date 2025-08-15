

namespace StartUp
{
    public class Desarrollador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        public Desarrollador() { }  
        public Desarrollador(string nombre, int id, double salarioBase, string lenguajePrincipal)
            : base(nombre, id, salarioBase)
        {
            LenguajePrincipal = lenguajePrincipal;
        }

        public override double CalcularSalarioAnual()
        {
            return SalarioBase * 12; 
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Desarrollador: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            Console.WriteLine();
        }
    }
}
