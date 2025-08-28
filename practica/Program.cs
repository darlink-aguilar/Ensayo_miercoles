// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var estudiante1 = new Estudiantes();
estudiante1.Id = 1;
estudiante1.Nombre = "Darlink";
estudiante1.Actividad = true;
estudiante1.Estatura = 1.52m;
estudiante1.Nacimiento = DateTime.Now;
estudiante1.Promedio = 4.5m;

Console.WriteLine(estudiante1.Id);
Console.WriteLine(estudiante1.Nombre);

public class Personas
{
    public int Id;
    public string? Nombre;
    public bool Actividad;
    public decimal Estatura;
    public DateTime Nacimiento;
}

public class Estudiantes : Personas
{
    public decimal Promedio;
}
