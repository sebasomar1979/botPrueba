using System;
using System.Collections.Generic;
using System.Data.SqlClient;


public class Estudiante
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public int nota { get; set; }
    // Ingreso de datos de estudiantes
}
public class Profesor
{
    public string Id { get; set; }
    public int Matricula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Materia { get; set; }

    // Ingreso de datos de profesores
}
class Program
{
    static List<Estudiante> listaEstudiantes = new List<Estudiante>();

    static List<Profesor> listaProfesores = new List<Profesor>();

    static void Main(string[] args)
    {
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Agregar Estudiante");
        Console.WriteLine("2. Agregar Profesor");
        Console.WriteLine("3. Mostrar Estudiantes");
        Console.WriteLine("4. Mostrar Profesor");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarEstudiante();
                break;
            case "2":
                AgregarProfesor();
                break;
            case "3":
                MostrarEstudiantes();
                break;
            case "4":
                MostrarProfresor();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }

        MostrarMenu(); // Vuelve a mostrar el menú después de realizar una opción
    }

    static void AgregarEstudiante()
    {
        Console.Write("Ingrese nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el apellido del estudiante: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese la edad del estudiante: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la nota del estudiante: ");
        int nota = int.Parse(Console.ReadLine());


        /* Estudiante nuevoEstudiante = new Estudiante { Nombre = nombre, Apellido = apellido, Edad = edad, nota = nota};
         listaEstudiantes.Add(nuevoEstudiante);*/



        Console.WriteLine("Estudiante agregado con éxito.");
    }
    static void AgregarProfesor()
    {
        Console.Write("Ingrese matricula del profesor: ");
        int matricula = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del profesor: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el apellido del profesor: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese la materia del profesor: ");
        string materia = Console.ReadLine();




        Profesor nuevoProfesor = new Profesor { Matricula = matricula, Nombre = nombre, Apellido = apellido, Materia = materia };
        listaProfesores.Add(nuevoProfesor);

        Console.WriteLine("Profesor agregado con éxito.");
    }

    static void MostrarEstudiantes()
    {
        Console.WriteLine("Lista de Estudiantes:");

        foreach (var estudiante in listaEstudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Apellido:{estudiante.Apellido} ,Edad: {estudiante.Edad}, Nota: {estudiante.nota}");
        }
    }
    static void MostrarProfresor()
    {
        Console.WriteLine("Lista de Profesores:");

        foreach (var profesor in listaProfesores)
        {
            Console.WriteLine($"Matricula: {profesor.Matricula}, Nombre:{profesor.Nombre} ,Apellido: {profesor.Apellido}, Materia: {profesor.Materia}");
        }
    }

}