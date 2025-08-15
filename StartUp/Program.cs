using StartUp;

Gerente gerente = new Gerente();
gerente.Nombre = "Cristian Almendarez";
gerente.ID = 1;
gerente.SalarioBase = 22000;
gerente.BonoAnual = 5000;
gerente.MostrarInformacion();


Desarrollador desarrollador = new Desarrollador();
desarrollador.Nombre = "Valeska Ventura";
desarrollador.ID = 2;
desarrollador.SalarioBase = 18000;
desarrollador.LenguajePrincipal = "C#";
desarrollador.MostrarInformacion();

Contador contador = new Contador();
contador.Nombre = "Mercedes Urbina";
contador.ID = 3;
contador.SalarioBase = 25000;
contador.HorasExtras = 10;
contador.PagoPorHoraExtra = 25;
contador.MostrarInformacion();








