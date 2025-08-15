

namespace StartUp
{
    public class Contador : Empleado
    {
        public int HorasExtras { get; set; }
        public double PagoPorHoraExtra { get; set; }  

        public Contador() { }
        public Contador(string nombre, int id, double salarioBase, int horasExtras, double pagoPorHoraExtra)
            : base(nombre, id, salarioBase)
        {
            HorasExtras = horasExtras;
            PagoPorHoraExtra = pagoPorHoraExtra;
        }

        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + (HorasExtras * PagoPorHoraExtra);
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Contador: {Nombre}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Horas Extras: {HorasExtras}");
            Console.WriteLine($"Pago por Hora Extra: {PagoPorHoraExtra}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual()}");
            Console.WriteLine();
        }
    }
}
