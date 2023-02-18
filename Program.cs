class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi Segundo Programa");
        Console.ReadKey();

        Console.Write("\nIngrese su Nombre: ");
            string Nombre = Console.ReadLine();

        Console.Write("Ingrese su Edad: ");
            string Edad = Console.ReadLine();

        Console.Write("Ingrese su Carrera: ");
            string Carrera = Console.ReadLine();

        Console.Write("Ingrese su Carné: ");
            string Carné = Console.ReadLine();

        Console.Write("\nSoy " + Nombre);
        Console.Write(",tengo " + Edad);
        Console.Write(" años y estudio la carrera de " + Carrera);
        Console.Write(". Mi número de carné es; " + Carné);
        Console.ReadKey();

    }
}